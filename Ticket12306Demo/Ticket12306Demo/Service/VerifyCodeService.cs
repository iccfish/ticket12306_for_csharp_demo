using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service
{
	using System.Drawing;
	using FSLib.Network.Http;
	using Ticket12306Demo.Service.Entities.Web;

	/// <summary>
	/// 验证码服务
	/// </summary>
	class VerifyCodeService : ServiceBase
	{
		public VerifyCodeService(ServiceContext context) : base(context)
		{
		}

		/// <summary>
		/// 加载验证码
		/// </summary>
		/// <param name="type">验证码类型</param>
		/// <returns></returns>
		public async Task<Image> LoadVerifyCodeImage(VerifyCodeType type)
		{
			var module = "login";
			var randType = "sjrand";

			//为了准确起见，我们使用真正的引用页
			var urlRefer = "https://kyfw.12306.cn/otn/login/init";

			if (type == VerifyCodeType.SubmitOrder)
			{
				module = "passenger";
				randType = "randp";
				urlRefer = "https://kyfw.12306.cn/otn/confirmPassenger/initDc";
			}


			var ctx = Session.NetClient.Create<Image>(HttpMethod.Get,
													string.Format("https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module={0}&rand={1}&{2}", module, randType, new Random().NextDouble().ToString()),
													urlRefer
				);
			await ctx.SendTask();

			return ctx.Result;
		}

		/// <summary>
		/// 校验验证码
		/// </summary>
		/// <param name="type">验证码类型</param>
		/// <param name="points">验证码点位置</param>
		/// <returns></returns>

		public async Task<bool> CheckVerifyCode(VerifyCodeType type, params Point[] points)
		{
			var randType = "sjrand";

			//为了准确起见，我们使用真正的引用页
			var urlRefer = "https://kyfw.12306.cn/otn/login/init";

			if (type == VerifyCodeType.SubmitOrder)
			{
				randType = "randp";
				urlRefer = "https://kyfw.12306.cn/otn/confirmPassenger/initDc";
			}

			var ctx = Session.NetClient.Create<WebResponseResult<VerifyCodeCheckResult>>(
																							HttpMethod.Post,
																						"https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn",
																						urlRefer,
																						new
																						{
																							randCode = points.Select(s => s.X + "," + s.Y).JoinAsString(","),
																							rand = randType
																						}
				);

			await ctx.SendTask();

			return ctx.IsValid() && ctx.Result.Data.Result == 1;
		}

	}

	/// <summary>
	/// 验证码类型
	/// </summary>
	enum VerifyCodeType
	{
		/// <summary>
		/// 登录验证码
		/// </summary>
		Login = 0,
		/// <summary>
		/// 提交订单验证码
		/// </summary>
		SubmitOrder = 1
	}
}
