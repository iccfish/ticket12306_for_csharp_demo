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
	using System.Diagnostics;
	using System.Text.RegularExpressions;
	using Ticket12306Demo.Service;
	using Ticket12306Demo.Service.Entities;

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			dgvTickets.AutoGenerateColumns = false;
			Load += MainForm_Load;
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			await InitServiceContext();
			InitToolbar();
			InitStatusBar();
			InitQueryParamEdit();
			InitTicketGrid();

			var result = new RequireVcDlg(_context, VerifyCodeType.Login).ShowDialog();
			MessageBox.Show(result.ToString());
		}

		#region 状态栏和工具栏事件

		void InitToolbar()
		{
			tsExit.Click += (s, e) => Close();
			tsLogin.Enabled = !(tsLogout.Enabled = _context.Session.IsLogined);
			//捕捉登录状态变化事件，在登录状态发生变化的时候重设登录状态
			_context.Session.IsLoginedChanged += (s, e) =>
			{
				tsLogin.Enabled = !(tsLogout.Enabled = _context.Session.IsLogined);
				tsLogin.Text = _context.Session.IsLogined ? string.Format("已登录为【{0} ({1})】", _context.Session.LoginInfo.DisplayName, _context.Session.LoginInfo.UserName) : "登录(&I)";
			};
			btnQueryTicket.Click += (s, e) => QueryTicket();
		}

		/// <summary>
		/// 初始化状态栏
		/// </summary>
		void InitStatusBar()
		{
			//绑定链接处理
			foreach (var label in st.Items.OfType<ToolStripStatusLabel>().Where(s => s.IsLink && s.Tag != null))
			{
				label.Click += (s, e) =>
				{
					try
					{
						Process.Start((s as ToolStripStatusLabel).Tag.ToString());
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, "错误：无法打开网址，错误信息：" + ex.Message + "。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				};
			}
		}

		/// <summary>
		/// 表示开始一个操作
		/// </summary>
		/// <param name="opName">当前操作的名称</param>
		/// <param name="maxItemsCount">当前操作如果需要显示进度，那么提供任务总数；不提供则为跑马灯等待</param>
		/// <param name="disableForm">是否禁用当前窗口的操作</param>
		void BeginOperation(string opName, int maxItemsCount = 100, bool disableForm = false)
		{
			stStatus.Text = opName.DefaultForEmpty("正在操作，请稍等...");
			stProgress.Visible = true;
			stProgress.Maximum = maxItemsCount > 0 ? maxItemsCount : 100;
			stProgress.Style = maxItemsCount > 0 ? ProgressBarStyle.Blocks : ProgressBarStyle.Marquee;
			if (disableForm)
			{
				btnQueryTicket.Enabled = false;
			}
		}

		/// <summary>
		/// 操作结束
		/// </summary>
		void EndOperation()
		{
			stStatus.Text = "就绪.";
			stProgress.Visible = false;
			btnQueryTicket.Enabled = true;
		}

		#endregion

		#region 查询参数编辑

		/// <summary>
		/// 初始化查询参数编辑
		/// </summary>
		void InitQueryParamEdit()
		{
			dtDate.MinDate = DateTime.Now.Date;
			//dtDate.MaxDate = DateTime.Now.Date.AddDays(59);
			//dtDate.Value = DateTime.Now.AddDays(1);
			dtDate.MaxDate = DateTime.Now.Date.AddDays(_context.DataService.MaxSellDays);
			dtDate.Value = DateTime.Now.Date.AddDays(_context.DataService.DefaultDayOffset);

			var allstationText = _context.StationDataService.AllStations.Select(s => (object)(s.FirstLetter.PadRight(5, ' ') + s.Name + "\t" + s.Code)).ToArray();
			cbFrom.Items.AddRange(allstationText);
			cbTo.Items.AddRange(allstationText);
		}

		#endregion

		#region 服务接入

		ServiceContext _context;

		/// <summary>
		/// 初始化服务状态
		/// </summary>
		async Task InitServiceContext()
		{
			_context = new ServiceContext();
			BeginOperation("正在初始化站点数据...", 0, true);
			await _context.StationDataService.LoadStationDatasAsync();
			EndOperation();
		}

		#endregion

		#region 查票


		void InitTicketGrid()
		{
			dgvTickets.CellFormatting += DgvTickets_CellFormatting;
		}

		private void DgvTickets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (_result == null)
				return;


			var index = e.ColumnIndex;
			var data = _result[e.RowIndex];
			if (index == 1)
			{
				//发站
				if (data.IsFirstStation)
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			else if (index == 3)
			{
				//到站
				if (data.IsLastStation)
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			else if (index >= 6 && index <= 16)
			{
				var text = e.Value.ToString();
				if (text == "" || text == "无" || text == "--" || text == "*")
				{
					e.CellStyle.ForeColor = Color.Gray;
				}
				else if (text == "有" || char.IsDigit(text[0]))
				{
					e.CellStyle.ForeColor = Color.Blue;
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
		}


		/// <summary>
		/// 从选择的字符串获得电报码
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		bool GetTeleCode(string str, out string name, out string code)
		{
			name = code = null;

			if (str.IsNullOrEmpty()) return false;

			var args = Regex.Split(str, @"\s+");
			if (args.Length != 3)
				return false;

			name = args[1];
			code = args[2];
			return true;
		}

		TicketQueryResult _result;

		/// <summary>
		/// 查票
		/// </summary>
		/// <returns></returns>
		async Task QueryTicket()
		{
			string fromCode, fromName, toCode, toName;
			var date = dtDate.Value;

			if (!GetTeleCode(cbFrom.Text, out fromName, out fromCode) || !GetTeleCode(cbTo.Text, out toName, out toCode))
			{
				MessageBox.Show(this, "哎呀，没有选择车站，逗我呢 o(╯□╰)o", "哎呀", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			_result = null;
			Exception exception = null;

			BeginOperation("正在查询...", 0);
			btnQueryTicket.Enabled = false;
			try
			{
				_result = await _context.TicketQueryService.QueryTicket(date, fromName, fromCode, toName, toCode, ckStudent.Checked);
			}
			catch (Exception ex)
			{
				exception = ex;
			}
			finally
			{
				EndOperation();
			}

			if (_result != null)
			{
				stStatus.Text = string.Format("查询到 {0} 趟车次。", _result.Count);

				//绑定数据
				bs.DataSource = _result;
			}
			else
			{
				bs.DataSource = null;
				stStatus.Text = "查询出错，错误信息：" + exception.Message;
			}
		}

		#endregion

		private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
