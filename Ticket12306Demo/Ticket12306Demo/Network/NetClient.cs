using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Network
{
	using FSLib.Network.Http;

	/// <summary>
	/// 基于FSLIB.NETWORK的网络层扩展，进一步抽象以便于后期提供功能
	/// </summary>
	class NetClient : HttpClient
	{
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public NetClient()
		{
			
		}
	}
}
