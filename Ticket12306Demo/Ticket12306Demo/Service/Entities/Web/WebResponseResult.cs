using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service.Entities.Web
{
	using Newtonsoft.Json;

	/// <summary>
	/// 服务器数据响应基类
	/// </summary>
	/// <typeparam name="T"></typeparam>
	class WebResponseResult<T>
	{
		/// <summary>
		/// 状态
		/// </summary>
		public bool Status { get; private set; }

		/// <summary>
		/// 数据
		/// </summary>
		public T Data { get; private set; }

		/// <summary>
		/// 响应的错误信息
		/// </summary>
		public string[] Messages { get; private set; }

		/// <summary>
		/// 获得响应的错误信息
		/// </summary>
		/// <returns></returns>
		public string GetErrorMessage()
		{
			return Messages == null || Messages.Length == 0 ? "" : Messages.JoinAsString("; ");
		}
	}
}
