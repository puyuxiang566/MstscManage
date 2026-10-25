namespace MstscManage
{
	public partial class ClientStateDetection : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.ClientStateDetection));
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnState = new global::System.Windows.Forms.Button();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.Port_Text = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.Select_Radio = new global::System.Windows.Forms.RadioButton();
			this.All_Radio = new global::System.Windows.Forms.RadioButton();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(196, 114);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "关闭";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnState.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnState.Location = new global::System.Drawing.Point(115, 115);
			this.btnState.Name = "btnState";
			this.btnState.Size = new global::System.Drawing.Size(75, 23);
			this.btnState.TabIndex = 11;
			this.btnState.Text = "开始检测";
			this.btnState.UseVisualStyleBackColor = true;
			this.btnState.Click += new global::System.EventHandler(this.btnState_Click);
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "color_full_48.ico");
			this.imageList1.Images.SetKeyName(1, "color_16_48.ico");
			this.imageList1.Images.SetKeyName(2, "color_8_48.ico");
			this.Port_Text.Location = new global::System.Drawing.Point(85, 46);
			this.Port_Text.Name = "Port_Text";
			this.Port_Text.Size = new global::System.Drawing.Size(160, 22);
			this.Port_Text.TabIndex = 26;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(20, 49);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(59, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "检测端口";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(46, 22);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(33, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "密码";
			this.Select_Radio.AutoSize = true;
			this.Select_Radio.Checked = true;
			this.Select_Radio.Location = new global::System.Drawing.Point(85, 20);
			this.Select_Radio.Name = "Select_Radio";
			this.Select_Radio.Size = new global::System.Drawing.Size(77, 17);
			this.Select_Radio.TabIndex = 30;
			this.Select_Radio.TabStop = true;
			this.Select_Radio.Text = "选中主机";
			this.Select_Radio.UseVisualStyleBackColor = true;
			this.All_Radio.AutoSize = true;
			this.All_Radio.Location = new global::System.Drawing.Point(168, 20);
			this.All_Radio.Name = "All_Radio";
			this.All_Radio.Size = new global::System.Drawing.Size(77, 17);
			this.All_Radio.TabIndex = 31;
			this.All_Radio.TabStop = true;
			this.All_Radio.Text = "全部主机";
			this.All_Radio.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.All_Radio);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.Select_Radio);
			this.groupBox1.Controls.Add(this.Port_Text);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(259, 99);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "检测设置";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(82, 75);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(140, 13);
			this.label1.TabIndex = 32;
			this.label1.Text = "端口号多个使用,分割。";
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 143);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new global::System.Drawing.Size(282, 22);
			this.statusStrip1.TabIndex = 33;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(56, 17);
			this.toolStripStatusLabel1.Text = "等待检测";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(282, 165);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.btnState);
			base.Controls.Add(this.btnCancel);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ClientStateDetection";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "主机状态检测";
			base.Load += new global::System.EventHandler(this.ServerSettings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Button btnCancel;

		private global::System.Windows.Forms.Button btnState;

		private global::System.Windows.Forms.ImageList imageList1;

		private global::System.Windows.Forms.TextBox Port_Text;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.RadioButton Select_Radio;

		private global::System.Windows.Forms.RadioButton All_Radio;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.StatusStrip statusStrip1;

		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		private global::System.Windows.Forms.Label label1;
	}
}
