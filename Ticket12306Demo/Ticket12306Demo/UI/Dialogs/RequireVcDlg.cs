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

	partial class RequireVcDlg : FormBase
	{

		/// <summary>
		/// 获得验证码类型
		/// </summary>
		public VerifyCodeType RandType { get; private set; }

		/// <summary>
		/// 获得输入的坐标位置
		/// </summary>
		public List<Point> Points { get; private set; }

		public RequireVcDlg(ServiceContext context, VerifyCodeType randType) : base(context)
		{
			RandType = randType;

			InitializeComponent();
		}

		void RequireVcDlg_Load(object sender, EventArgs e)
		{
			LoadVerifyCode();

			btnRefresh.Click += (x1, x2) => LoadVerifyCode();
			pbVc.MouseClick += PbVc_MouseClick;
			btnOK.Click += BtnOK_Click;
		}

		private async void BtnOK_Click(object sender, EventArgs e)
		{
			btnRefresh.Enabled = false;
			btnOK.Enabled = false;
			stStatus.Text = "正在校验验证码...";

			var checkResult = await ServiceContext.VerifyCodeService.CheckVerifyCode(RandType, Points.ToArray());
			if (!checkResult)
			{
				//校验失败
				stStatus.Text = "验证码校验失败！请重试。";
				await Task.Delay(2000);	//延迟两秒
				LoadVerifyCode();
				return;
			}

			//成功！
			stStatus.Text = "校验成功！";
			DialogResult = DialogResult.OK;
			Close();
		}

		private void PbVc_MouseClick(object sender, MouseEventArgs e)
		{
			//如果验证码没有成功加载，则视为点击刷新
			if (pbVc.Image == null)
			{
				LoadVerifyCode();
				return;
			}

			//添加mark
			var point = e.Location + new Size(0, -30);
			if (point.X == 0 || point.Y == 0)
				return; //非法坐标

			(Points ?? (Points = new List<Point>())).Add(point);

			//添加marker
			var marker = new PictureBox()
			{
				Location = e.Location + new Size(-16, -16),
				Image = Properties.Resources.vc_marker,
				SizeMode = PictureBoxSizeMode.AutoSize,
				Tag = point
			};
			imgContainer.Controls.Add(marker);
			marker.BringToFront();

			//添加marker移除事件
			marker.Click += (x, y) =>
			{
				Points.Remove((Point)(x as PictureBox).Tag);
				imgContainer.Controls.Remove(x as PictureBox);
				btnOK.Enabled = Points.Count > 0;
			};

			btnOK.Enabled = true;
		}

		/// <summary>
		/// 加载验证码
		/// </summary>
		async void LoadVerifyCode()
		{
			stStatus.Text = "正在加载验证码...";

			//清空之前的图片和状态
			Points = null;
			imgContainer.Controls.Cast<Control>().Where(s => s != pbVc).ToArray().ForEach(s => imgContainer.Controls.Remove(s));
			imgContainer.Enabled = false;
			btnOK.Enabled = false;
			btnRefresh.Enabled = false;

			//加载
			var img = await ServiceContext.VerifyCodeService.LoadVerifyCodeImage(RandType);
			if (img == null)
			{
				stStatus.Text = "验证码加载失败, 点击重新加载...";
			}
			else
			{
				pbVc.Image = img;
				stStatus.Text = "验证码加载成功";
			}
			btnRefresh.Enabled = true;
			imgContainer.Enabled = true;
		}
	}
}
