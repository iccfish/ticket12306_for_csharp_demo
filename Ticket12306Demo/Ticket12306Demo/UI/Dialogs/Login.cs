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
	using Ticket12306Demo.Service;

	partial class Login : Form
	{
		ServiceContext _context;

		public Login(ServiceContext context)
		{
			_context = context;
			InitializeComponent();
		}

		private async void btnOk_Click(object sender, EventArgs e)
		{
			var username = txtUserName.Text;
			var password = txtPassword.Text;

			if (username.IsNullOrEmpty() || password.IsNullOrEmpty())
			{
				MessageBox.Show("输入用户名和密码哦！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var vcdlg = new RequireVcDlg(_context, VerifyCodeType.Login);
			if (vcdlg.ShowDialog(this) != DialogResult.OK)
				return;

			var result = await _context.Session.LoginAsync(username, password, vcdlg.Points);
			if (result == null)
			{
				Close();
				return;
			}
			MessageBox.Show("登录失败：" + result.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
}
