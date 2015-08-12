using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket12306Demo.UI.Dialogs
{
	using System.Windows.Forms;
	using Ticket12306Demo.Service;

	/// <summary>
	/// 抽象窗口基类
	/// </summary>
	class FormBase : Form
	{
		/// <summary>
		/// 获得当前的上下文
		/// </summary>
		public ServiceContext ServiceContext { get; private set; }

		protected FormBase(ServiceContext serviceContext)
		{
			ServiceContext = serviceContext;
		}

		/// <summary>
		/// 无效构造函数
		/// </summary>
		public FormBase()
		{
			
		}
	}
}
