namespace MstscManage
{
	public partial class ClientMain : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			try
			{
				base.Dispose(disposing);
			}
			catch (global::System.Exception)
			{
			}
		}

		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.ClientMain));
			this.toolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new global::System.Windows.Forms.ToolStripDropDownButton();
			this.btnSndKey_TaskManager = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.btnConnect = new global::System.Windows.Forms.ToolStripButton();
			this.btnDisconnect = new global::System.Windows.Forms.ToolStripButton();
			this.btnReconnect = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.btnFullscreen = new global::System.Windows.Forms.ToolStripButton();
			this.btnFitToScreen = new global::System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.lblStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.rdpClient = new global::AxMSTSCLib.AxMsRdpClient7NotSafeForScripting();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.rdpClient).BeginInit();
			base.SuspendLayout();
			this.toolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripDropDownButton1,
				this.toolStripSeparator2,
				this.btnConnect,
				this.btnDisconnect,
				this.btnReconnect,
				this.toolStripSeparator1,
				this.btnFullscreen,
				this.btnFitToScreen
			});
			this.toolStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new global::System.Drawing.Size(619, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStripDropDownButton1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.btnSndKey_TaskManager
			});
			this.toolStripDropDownButton1.Image = global::MstscManage.Properties.Resources.快捷键;
			this.toolStripDropDownButton1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new global::System.Drawing.Size(85, 22);
			this.toolStripDropDownButton1.Text = "发送按键";
			this.btnSndKey_TaskManager.Name = "btnSndKey_TaskManager";
			this.btnSndKey_TaskManager.Size = new global::System.Drawing.Size(180, 22);
			this.btnSndKey_TaskManager.Text = "CLTR+ALT+DEL";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.btnConnect.Image = global::MstscManage.Properties.Resources.连接;
			this.btnConnect.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new global::System.Drawing.Size(52, 22);
			this.btnConnect.Text = "连接";
			this.btnConnect.ToolTipText = "Connect to server";
			this.btnDisconnect.Image = global::MstscManage.Properties.Resources.断开连接;
			this.btnDisconnect.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new global::System.Drawing.Size(52, 22);
			this.btnDisconnect.Text = "断开";
			this.btnDisconnect.ToolTipText = "Disconnect to server";
			this.btnReconnect.Image = global::MstscManage.Properties.Resources.刷新;
			this.btnReconnect.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.btnReconnect.Name = "btnReconnect";
			this.btnReconnect.Size = new global::System.Drawing.Size(76, 22);
			this.btnReconnect.Text = "重新连接";
			this.btnReconnect.ToolTipText = "Restart the connection";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.btnFullscreen.Image = global::MstscManage.Properties.Resources.全屏;
			this.btnFullscreen.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.btnFullscreen.Name = "btnFullscreen";
			this.btnFullscreen.Size = new global::System.Drawing.Size(100, 22);
			this.btnFullscreen.Text = "进入全屏模式";
			this.btnFitToScreen.Image = global::MstscManage.Properties.Resources.自适应窗口;
			this.btnFitToScreen.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.btnFitToScreen.Name = "btnFitToScreen";
			this.btnFitToScreen.Size = new global::System.Drawing.Size(148, 22);
			this.btnFitToScreen.Text = "自适应当前窗口分辨率";
			this.btnFitToScreen.ToolTipText = "自适应当前窗口分辨率";
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.lblStatus
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 368);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new global::System.Drawing.Size(619, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(39, 17);
			this.lblStatus.Text = "共0项";
			this.panel2.Controls.Add(this.rdpClient);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(0, 25);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(619, 343);
			this.panel2.TabIndex = 4;
			this.rdpClient.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.rdpClient.Enabled = true;
			this.rdpClient.Location = new global::System.Drawing.Point(0, 0);
			this.rdpClient.Name = "rdpClient";
			this.rdpClient.OcxState = (global::System.Windows.Forms.AxHost.State)resources.GetObject("rdpClient.OcxState");
			this.rdpClient.Size = new global::System.Drawing.Size(619, 343);
			this.rdpClient.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(619, 390);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.toolStrip1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "ClientMain";
			base.Tag = "远程桌面 - {0}@{1}[{2}]";
			this.Text = "远程桌面";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.rdpClient).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		public global::System.Windows.Forms.ToolStrip toolStrip1;

		private global::System.Windows.Forms.ToolStripButton btnDisconnect;

		private global::System.Windows.Forms.ToolStripButton btnReconnect;

		private global::System.Windows.Forms.StatusStrip statusStrip1;

		private global::System.Windows.Forms.ToolStripStatusLabel lblStatus;

		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private global::System.Windows.Forms.ToolStripButton btnConnect;

		private global::System.Windows.Forms.ToolStripButton btnFullscreen;

		private global::System.Windows.Forms.ToolStripButton btnFitToScreen;

		private global::System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;

		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private global::System.Windows.Forms.ToolStripMenuItem btnSndKey_TaskManager;

		private global::System.Windows.Forms.Panel panel2;

		public global::AxMSTSCLib.AxMsRdpClient7NotSafeForScripting rdpClient;
	}
}
