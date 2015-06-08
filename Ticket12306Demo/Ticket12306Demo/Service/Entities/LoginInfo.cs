using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service.Entities
{
	/// <summary>
	/// 12306登录信息
	/// </summary>
	class LoginInfo
	{

		/// <summary>
		/// 获得或设置当前的显示名
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// 登录用户名
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// 登录密码
		/// </summary>
		public string Password { get; set; }
	}
}
