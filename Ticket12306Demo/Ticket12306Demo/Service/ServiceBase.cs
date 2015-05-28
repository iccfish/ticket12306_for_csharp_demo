using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service
{
	using Ticket12306Demo.Network;

	/// <summary>
	/// 通用的服务基类，提供一些额外的基础服务
	/// </summary>
	abstract class ServiceBase
	{
		protected ServiceBase(ServiceContext context)
		{
			ServiceContext = context;
		}

		/// <summary>
		/// 获得当前的服务上下文
		/// </summary>
		public ServiceContext ServiceContext { get; private set; }

		/// <summary>
		/// 获得当前关联的12306会话
		/// </summary>
		public Session Session { get { return ServiceContext.Session; } }

		/// <summary>
		/// 获得当前关联的网络访问对象
		/// </summary>
		public NetClient NetClient
		{
			get { return Session.NetClient; }
		}

		/// <summary>
		/// 获得当前是否已经登录
		/// </summary>
		public bool IsLogined { get { return Session.IsLogined; } }
	}
}
