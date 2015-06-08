using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket12306Demo.UI.Dialogs
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Load += MainForm_Load;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			InitQueryParamEdit();
		}

		#region 查询参数编辑

		/// <summary>
		/// 初始化查询参数编辑
		/// </summary>
		void InitQueryParamEdit()
		{
			dtDate.MinDate = DateTime.Now.Date;
			dtDate.MaxDate = DateTime.Now.Date.AddDays(59);
			dtDate.Value = DateTime.Now.AddDays(1);
		}

		#endregion
	}
}
