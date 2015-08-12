namespace Ticket12306Demo.UI.Dialogs
{
	using System;
	using System.Windows.Forms;
	using Ticket12306Demo.Service;

	/// <summary>
	/// 抽象用户控件基类
	/// </summary>
	abstract class UserControlBase : UserControl
	{
		/// <summary>
		/// 获得当前的上下文
		/// </summary>
		public ServiceContext ServiceContext { get; private set; }

		protected UserControlBase(ServiceContext serviceContext)
		{
			ServiceContext = serviceContext;
		}
	}
}