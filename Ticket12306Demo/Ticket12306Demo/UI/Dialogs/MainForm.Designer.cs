namespace Ticket12306Demo.UI.Dialogs
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ts = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.panelQueryParam = new System.Windows.Forms.Panel();
			this.st = new System.Windows.Forms.StatusStrip();
			this.stProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbFrom = new System.Windows.Forms.ComboBox();
			this.cbTo = new System.Windows.Forms.ComboBox();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.ckStudent = new System.Windows.Forms.CheckBox();
			this.dgvTickets = new System.Windows.Forms.DataGridView();
			this.stStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnQueryTicket = new System.Windows.Forms.Button();
			this.tsLogin = new System.Windows.Forms.ToolStripButton();
			this.tsLogout = new System.Windows.Forms.ToolStripButton();
			this.tsExit = new System.Windows.Forms.ToolStripButton();
			this.colTrainNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFromStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFromTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colToStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colToTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colElapsedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeatP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeatM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeatO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeat6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeat4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeat3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeat0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSeatOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBook = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ts.SuspendLayout();
			this.panelQueryParam.SuspendLayout();
			this.st.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
			this.SuspendLayout();
			// 
			// ts
			// 
			this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLogin,
            this.tsLogout,
            this.toolStripSeparator1,
            this.tsExit});
			this.ts.Location = new System.Drawing.Point(0, 0);
			this.ts.Name = "ts";
			this.ts.Size = new System.Drawing.Size(1161, 25);
			this.ts.TabIndex = 0;
			this.ts.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// panelQueryParam
			// 
			this.panelQueryParam.Controls.Add(this.btnQueryTicket);
			this.panelQueryParam.Controls.Add(this.ckStudent);
			this.panelQueryParam.Controls.Add(this.dtDate);
			this.panelQueryParam.Controls.Add(this.cbTo);
			this.panelQueryParam.Controls.Add(this.cbFrom);
			this.panelQueryParam.Controls.Add(this.label3);
			this.panelQueryParam.Controls.Add(this.label2);
			this.panelQueryParam.Controls.Add(this.label1);
			this.panelQueryParam.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelQueryParam.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.panelQueryParam.Location = new System.Drawing.Point(0, 25);
			this.panelQueryParam.Name = "panelQueryParam";
			this.panelQueryParam.Size = new System.Drawing.Size(1161, 46);
			this.panelQueryParam.TabIndex = 1;
			// 
			// st
			// 
			this.st.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stStatus,
            this.stProgress,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
			this.st.Location = new System.Drawing.Point(0, 629);
			this.st.Name = "st";
			this.st.Size = new System.Drawing.Size(1161, 22);
			this.st.TabIndex = 2;
			this.st.Text = "statusStrip1";
			// 
			// stProgress
			// 
			this.stProgress.Name = "stProgress";
			this.stProgress.Size = new System.Drawing.Size(200, 16);
			this.stProgress.Visible = false;
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(618, 17);
			this.toolStripStatusLabel2.Spring = true;
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Image = global::Ticket12306Demo.Properties.Resources.globe_16;
			this.toolStripStatusLabel4.IsLink = true;
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(72, 17);
			this.toolStripStatusLabel4.Tag = "http://blog.fishlee.net/";
			this.toolStripStatusLabel4.Text = "鱼的博客";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Image = global::Ticket12306Demo.Properties.Resources.globe_16;
			this.toolStripStatusLabel5.IsLink = true;
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(84, 17);
			this.toolStripStatusLabel5.Tag = "http://www.fishlee.net/";
			this.toolStripStatusLabel5.Text = "鱼的后花园";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "发站";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(236, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "到站";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(460, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "日期";
			// 
			// cbFrom
			// 
			this.cbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbFrom.FormattingEnabled = true;
			this.cbFrom.Location = new System.Drawing.Point(50, 12);
			this.cbFrom.Name = "cbFrom";
			this.cbFrom.Size = new System.Drawing.Size(180, 25);
			this.cbFrom.TabIndex = 0;
			// 
			// cbTo
			// 
			this.cbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbTo.FormattingEnabled = true;
			this.cbTo.Location = new System.Drawing.Point(274, 12);
			this.cbTo.Name = "cbTo";
			this.cbTo.Size = new System.Drawing.Size(180, 25);
			this.cbTo.TabIndex = 1;
			// 
			// dtDate
			// 
			this.dtDate.Location = new System.Drawing.Point(507, 12);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(131, 23);
			this.dtDate.TabIndex = 2;
			// 
			// ckStudent
			// 
			this.ckStudent.AutoSize = true;
			this.ckStudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ckStudent.Location = new System.Drawing.Point(644, 13);
			this.ckStudent.Name = "ckStudent";
			this.ckStudent.Size = new System.Drawing.Size(63, 21);
			this.ckStudent.TabIndex = 3;
			this.ckStudent.Text = "学生票";
			this.ckStudent.UseVisualStyleBackColor = true;
			// 
			// dgvTickets
			// 
			this.dgvTickets.AllowUserToAddRows = false;
			this.dgvTickets.AllowUserToDeleteRows = false;
			this.dgvTickets.AllowUserToOrderColumns = true;
			this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrainNo,
            this.colFromStation,
            this.colFromTime,
            this.colToStation,
            this.colToTime,
            this.colElapsedTime,
            this.colSeatP,
            this.colSeatM,
            this.colSeatO,
            this.colSeat6,
            this.colSeat4,
            this.colSeat3,
            this.colSeat2,
            this.colSeat1,
            this.colSeat0,
            this.colSeatOther,
            this.colBook});
			this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTickets.Location = new System.Drawing.Point(0, 71);
			this.dgvTickets.Name = "dgvTickets";
			this.dgvTickets.RowHeadersVisible = false;
			this.dgvTickets.RowTemplate.Height = 23;
			this.dgvTickets.Size = new System.Drawing.Size(1161, 558);
			this.dgvTickets.TabIndex = 2;
			// 
			// stStatus
			// 
			this.stStatus.AutoSize = false;
			this.stStatus.Image = global::Ticket12306Demo.Properties.Resources.info_16;
			this.stStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.stStatus.Name = "stStatus";
			this.stStatus.Size = new System.Drawing.Size(300, 17);
			this.stStatus.Text = "就绪";
			this.stStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Image = global::Ticket12306Demo.Properties.Resources.globe_16;
			this.toolStripStatusLabel3.IsLink = true;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(72, 17);
			this.toolStripStatusLabel3.Tag = "https://github.com/iccfish/ticket12306_for_csharp_demo";
			this.toolStripStatusLabel3.Text = "开源主页";
			// 
			// btnQueryTicket
			// 
			this.btnQueryTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnQueryTicket.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnQueryTicket.Image = global::Ticket12306Demo.Properties.Resources.search_16;
			this.btnQueryTicket.Location = new System.Drawing.Point(1054, 6);
			this.btnQueryTicket.Name = "btnQueryTicket";
			this.btnQueryTicket.Size = new System.Drawing.Size(95, 34);
			this.btnQueryTicket.TabIndex = 4;
			this.btnQueryTicket.Text = "查询余票";
			this.btnQueryTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnQueryTicket.UseVisualStyleBackColor = true;
			// 
			// tsLogin
			// 
			this.tsLogin.Image = global::Ticket12306Demo.Properties.Resources.user_16;
			this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsLogin.Name = "tsLogin";
			this.tsLogin.Size = new System.Drawing.Size(64, 22);
			this.tsLogin.Text = "登录(&I)";
			// 
			// tsLogout
			// 
			this.tsLogout.Enabled = false;
			this.tsLogout.Image = global::Ticket12306Demo.Properties.Resources.left_16;
			this.tsLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsLogout.Name = "tsLogout";
			this.tsLogout.Size = new System.Drawing.Size(66, 22);
			this.tsLogout.Text = "注销(&L)";
			// 
			// tsExit
			// 
			this.tsExit.Image = global::Ticket12306Demo.Properties.Resources.block_16;
			this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsExit.Name = "tsExit";
			this.tsExit.Size = new System.Drawing.Size(68, 22);
			this.tsExit.Text = "退出(&X)";
			// 
			// colTrainNo
			// 
			this.colTrainNo.Frozen = true;
			this.colTrainNo.HeaderText = "车次";
			this.colTrainNo.Name = "colTrainNo";
			this.colTrainNo.ReadOnly = true;
			this.colTrainNo.Width = 80;
			// 
			// colFromStation
			// 
			this.colFromStation.Frozen = true;
			this.colFromStation.HeaderText = "发站";
			this.colFromStation.Name = "colFromStation";
			this.colFromStation.ReadOnly = true;
			this.colFromStation.Width = 80;
			// 
			// colFromTime
			// 
			this.colFromTime.Frozen = true;
			this.colFromTime.HeaderText = "发时";
			this.colFromTime.Name = "colFromTime";
			this.colFromTime.ReadOnly = true;
			this.colFromTime.Width = 60;
			// 
			// colToStation
			// 
			this.colToStation.Frozen = true;
			this.colToStation.HeaderText = "到站";
			this.colToStation.Name = "colToStation";
			this.colToStation.ReadOnly = true;
			this.colToStation.Width = 80;
			// 
			// colToTime
			// 
			this.colToTime.Frozen = true;
			this.colToTime.HeaderText = "到时";
			this.colToTime.Name = "colToTime";
			this.colToTime.ReadOnly = true;
			this.colToTime.Width = 60;
			// 
			// colElapsedTime
			// 
			this.colElapsedTime.HeaderText = "历时";
			this.colElapsedTime.Name = "colElapsedTime";
			this.colElapsedTime.ReadOnly = true;
			this.colElapsedTime.Width = 70;
			// 
			// colSeatP
			// 
			this.colSeatP.HeaderText = "特等座";
			this.colSeatP.Name = "colSeatP";
			this.colSeatP.ReadOnly = true;
			this.colSeatP.Width = 70;
			// 
			// colSeatM
			// 
			this.colSeatM.HeaderText = "一等座";
			this.colSeatM.Name = "colSeatM";
			this.colSeatM.ReadOnly = true;
			this.colSeatM.Width = 70;
			// 
			// colSeatO
			// 
			this.colSeatO.HeaderText = "二等座";
			this.colSeatO.Name = "colSeatO";
			this.colSeatO.ReadOnly = true;
			this.colSeatO.Width = 70;
			// 
			// colSeat6
			// 
			this.colSeat6.HeaderText = "高级软卧";
			this.colSeat6.Name = "colSeat6";
			this.colSeat6.ReadOnly = true;
			this.colSeat6.Width = 80;
			// 
			// colSeat4
			// 
			this.colSeat4.HeaderText = "软卧";
			this.colSeat4.Name = "colSeat4";
			this.colSeat4.ReadOnly = true;
			this.colSeat4.Width = 60;
			// 
			// colSeat3
			// 
			this.colSeat3.HeaderText = "硬卧";
			this.colSeat3.Name = "colSeat3";
			this.colSeat3.ReadOnly = true;
			this.colSeat3.Width = 60;
			// 
			// colSeat2
			// 
			this.colSeat2.HeaderText = "软座";
			this.colSeat2.Name = "colSeat2";
			this.colSeat2.ReadOnly = true;
			this.colSeat2.Width = 60;
			// 
			// colSeat1
			// 
			this.colSeat1.HeaderText = "硬座";
			this.colSeat1.Name = "colSeat1";
			this.colSeat1.ReadOnly = true;
			this.colSeat1.Width = 60;
			// 
			// colSeat0
			// 
			this.colSeat0.HeaderText = "无座";
			this.colSeat0.Name = "colSeat0";
			this.colSeat0.ReadOnly = true;
			this.colSeat0.Width = 60;
			// 
			// colSeatOther
			// 
			this.colSeatOther.HeaderText = "其它";
			this.colSeatOther.Name = "colSeatOther";
			this.colSeatOther.ReadOnly = true;
			this.colSeatOther.Width = 60;
			// 
			// colBook
			// 
			this.colBook.HeaderText = "预定";
			this.colBook.Name = "colBook";
			this.colBook.ReadOnly = true;
			this.colBook.Width = 60;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1161, 651);
			this.Controls.Add(this.dgvTickets);
			this.Controls.Add(this.st);
			this.Controls.Add(this.panelQueryParam);
			this.Controls.Add(this.ts);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "12306噜啦啦";
			this.ts.ResumeLayout(false);
			this.ts.PerformLayout();
			this.panelQueryParam.ResumeLayout(false);
			this.panelQueryParam.PerformLayout();
			this.st.ResumeLayout(false);
			this.st.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip ts;
		private System.Windows.Forms.ToolStripButton tsLogin;
		private System.Windows.Forms.ToolStripButton tsLogout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsExit;
		private System.Windows.Forms.Panel panelQueryParam;
		private System.Windows.Forms.Button btnQueryTicket;
		private System.Windows.Forms.CheckBox ckStudent;
		private System.Windows.Forms.DateTimePicker dtDate;
		private System.Windows.Forms.ComboBox cbTo;
		private System.Windows.Forms.ComboBox cbFrom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip st;
		private System.Windows.Forms.ToolStripStatusLabel stStatus;
		private System.Windows.Forms.ToolStripProgressBar stProgress;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.DataGridView dgvTickets;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTrainNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFromStation;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFromTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn colToStation;
		private System.Windows.Forms.DataGridViewTextBoxColumn colToTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn colElapsedTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeatP;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeatM;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeatO;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeat6;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeat4;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeat3;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeat2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeat1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeat0;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSeatOther;
		private System.Windows.Forms.DataGridViewButtonColumn colBook;
	}
}