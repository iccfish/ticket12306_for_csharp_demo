using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.Service
{
	/// <summary>
	/// 数据服务
	/// </summary>
	class DataService : ServiceBase
	{
		public DataService(ServiceContext context) : base(context)
		{
		}

		/// <summary>
		/// 最大售票天数
		/// </summary>
		public int MaxSellDays { get { return 59; } }

		/// <summary>
		/// 默认的买票日期选择
		/// </summary>
		public int DefaultDayOffset { get { return 1; } }
	}
}
