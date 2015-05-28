namespace Ticket12306Demo.Service
{
	using Ticket12306Demo.Network;

	/// <summary>
	/// 表示当前的12306登录会话，以及一些必须的状态信息。
	/// </summary>
	class Session
	{
		public Session()
		{
			NetClient = new NetClient();
		}

		/// <summary>
		/// 获得当前使用的网络对象，每个网络对象都是会话关联的。
		/// </summary>
		public NetClient NetClient { get; private set; }

		/// <summary>
		/// 获得当前是否已经登录
		/// </summary>
		public bool IsLogined { get; private set; }
	}
}
