namespace Ticket12306Demo.UI.Dialogs
{
	partial class RequireVcDlg
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
			this.imgContainer = new System.Windows.Forms.Panel();
			this.pbVc = new System.Windows.Forms.PictureBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.stStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.imgContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbVc)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imgContainer
			// 
			this.imgContainer.Controls.Add(this.pbVc);
			this.imgContainer.Location = new System.Drawing.Point(12, 12);
			this.imgContainer.Name = "imgContainer";
			this.imgContainer.Size = new System.Drawing.Size(293, 190);
			this.imgContainer.TabIndex = 0;
			// 
			// pbVc
			// 
			this.pbVc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbVc.Location = new System.Drawing.Point(0, 0);
			this.pbVc.Name = "pbVc";
			this.pbVc.Size = new System.Drawing.Size(293, 190);
			this.pbVc.TabIndex = 0;
			this.pbVc.TabStop = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 258);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(316, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// stStatus
			// 
			this.stStatus.Name = "stStatus";
			this.stStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(203, 208);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(101, 41);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 213);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(68, 31);
			this.btnRefresh.TabIndex = 3;
			this.btnRefresh.Text = "刷新(&R)";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// RequireVcDlg
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 280);
			this.Controls.Add(this.imgContainer);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RequireVcDlg";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "请输入验证码";
			this.Load += new System.EventHandler(this.RequireVcDlg_Load);
			this.imgContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbVc)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel imgContainer;
		private System.Windows.Forms.PictureBox pbVc;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel stStatus;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnRefresh;
	}
}