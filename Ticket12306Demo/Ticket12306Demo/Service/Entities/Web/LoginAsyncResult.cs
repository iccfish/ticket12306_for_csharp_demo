using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service.Entities.Web
{
	class LoginAsyncResult
	{
		public string LoginCheck { get; set; }
		public string OtherMsg { get; set; }

		/// <summary>
		/// 获得登录是否成功
		/// </summary>
		public bool IsSuceess {get { return LoginCheck == "Y"; } }
	}
}
