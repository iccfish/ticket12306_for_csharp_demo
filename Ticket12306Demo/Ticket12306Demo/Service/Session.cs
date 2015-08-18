namespace Ticket12306Demo.Service
{
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Threading.Tasks;
	using Entities;
	using FSLib.Network.Http;
	using Ticket12306Demo.Network;
	using Ticket12306Demo.Service.Entities.Web;

	/// <summary>
	/// 表示当前的12306登录会话，以及一些必须的状态信息。
	/// </summary>
	class Session
	{
		bool _isLogined;

		public Session()
		{
			NetClient = new NetClient();
		}

		/// <summary>
		/// 获得当前使用的网络对象，每个网络对象都是会话关联的。
		/// </summary>
		public NetClient NetClient { get; private set; }

		LoginInfo _loginInfo;

		/// <summary>
		/// 获得当前的登录信息
		/// </summary>
		public LoginInfo LoginInfo
		{
			get { return _loginInfo; }
			private set { _loginInfo = value; }
		}

		/// <summary>
		/// 获得当前是否已经登录
		/// </summary>
		public bool IsLogined
		{
			get { return _isLogined; }
			private set
			{
				if (_isLogined == value)
					return;

				_isLogined = value;
				OnIsLoginedChanged();
			}
		}

		/// <summary>
		/// 登录状态发生变化
		/// </summary>
		public event EventHandler IsLoginedChanged;

		/// <summary>
		/// 引发 <see cref="IsLoginedChanged" /> 事件
		/// </summary>
		protected virtual void OnIsLoginedChanged()
		{
			var handler = IsLoginedChanged;
			if (handler != null)
				handler(this, EventArgs.Empty);
		}

		/// <summary>
		/// 注销登录
		/// </summary>
		public void Logout()
		{
			LoginInfo = null;
			NetClient=new NetClient();
			IsLogined = false;
		}

		/// <summary>
		/// 登录。如果返回异常则说明登录失败
		/// </summary>
		/// <param name="verifyPoints"></param>
		/// <returns></returns>
		public async Task<Exception> LoginAsync(string username, string password, List<Point> verifyPoints)
		{
			IsLogined = false;
			LoginInfo = new LoginInfo()
			{
				UserName = username,
				Password = password
			};
			var loginData = new Dictionary<string, string>()
			{
				["loginUserDTO.user_name"] = LoginInfo.UserName,
				["userDTO.password"] = LoginInfo.Password,
				["randCode"] = verifyPoints.Select(s => s.X + "," + s.Y).JoinAsString(",")
			};
			var loginCheck = NetClient.Create<WebResponseResult<LoginAsyncResult>>(
											 HttpMethod.Post,
											"https://kyfw.12306.cn/otn/login/loginAysnSuggest",
											"https://kyfw.12306.cn/otn/login/init",
											loginData
				);
			await loginCheck.SendTask();
			if (!loginCheck.IsValid())
			{
				return loginCheck.Exception ?? new Exception("未能提交请求");
			}

			if (!loginCheck.Result.Data.IsSuceess)
			{
				return new Exception(loginCheck.Result.GetErrorMessage());
			}

			//登录成功
			var postLogin = NetClient.Create<string>(
													 HttpMethod.Post,
													"https://kyfw.12306.cn/otn/login/userLogin",
													"https://kyfw.12306.cn/otn/login/init"
				);
			await postLogin.SendTask(); //这里的返回值我们不care ....

			//登录好了。等等。。我们好像想拿到显示的中文名？
			//所以多加一个请求吧。
			var realNameCtx = NetClient.Create<string>(
													 HttpMethod.Get,
													"https://kyfw.12306.cn/otn/index/initMy12306",
													"https://kyfw.12306.cn/otn/login/init"
				);
			await realNameCtx.SendTask();

			if (realNameCtx.IsValid())
			{
				//匹配出名字信息
				var realMatch = Regex.Match(realNameCtx.Result, @"user_name\s*=\s*['""]([^'""]+)['""]", RegexOptions.Singleline);
				if (realMatch.Success)
				{
					LoginInfo.DisplayName = realMatch.GetGroupValue(1).DecodeFromJsExpression();
				}
			}
			//这里失败了我们就随便起个名字，嗯。
			if (LoginInfo.DisplayName.IsNullOrEmpty())
				LoginInfo.DisplayName = "路人甲";



			IsLogined = true;

			return null;
		}
	}
}
