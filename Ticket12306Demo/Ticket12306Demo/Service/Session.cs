namespace Ticket12306Demo.Service
{
	using System;

	using Entities;

	using Ticket12306Demo.Network;

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

		/// <summary>
		/// 获得当前的登录信息
		/// </summary>
		public LoginInfo LoginInfo { get; private set; }

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
	}
}
