using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service.Entities.Web
{
	/// <summary>
	/// 验证码校验结果
	/// </summary>
	class VerifyCodeCheckResult
	{
		public int Result { get; set; }

		public string Msg { get; set; }
	}
}
