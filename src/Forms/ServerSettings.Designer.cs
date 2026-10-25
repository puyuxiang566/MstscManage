namespace MstscManage
{
	public partial class ServerSettings : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.ServerSettings));
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnRandom = new global::System.Windows.Forms.Button();
			this.GroupingComboBox = new global::System.Windows.Forms.ComboBox();
			this.txDescription = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.textOrder = new global::System.Windows.Forms.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.txPassword = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txUsername = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txComputer = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txServername = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.tbColor = new global::System.Windows.Forms.ComboBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.txHeight = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txWidth = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.tbDeskSize = new global::System.Windows.Forms.TrackBar();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbDeskSize).BeginInit();
			base.SuspendLayout();
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new global::System.Drawing.Point(6, 76);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(337, 326);
			this.tabControl1.TabIndex = 1;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(329, 300);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "基本";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.groupBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox1.Controls.Add(this.btnRandom);
			this.groupBox1.Controls.Add(this.GroupingComboBox);
			this.groupBox1.Controls.Add(this.txDescription);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.textOrder);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txPassword);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txUsername);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txComputer);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txServername);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(318, 288);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "登陆配置";
			this.btnRandom.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.btnRandom.Location = new global::System.Drawing.Point(102, 132);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new global::System.Drawing.Size(194, 23);
			this.btnRandom.TabIndex = 11;
			this.btnRandom.Text = "生成随机密码";
			this.btnRandom.UseVisualStyleBackColor = true;
			this.btnRandom.Click += new global::System.EventHandler(this.btnRandom_Click);
			this.GroupingComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GroupingComboBox.FormattingEnabled = true;
			this.GroupingComboBox.Location = new global::System.Drawing.Point(102, 251);
			this.GroupingComboBox.Name = "GroupingComboBox";
			this.GroupingComboBox.Size = new global::System.Drawing.Size(194, 21);
			this.GroupingComboBox.TabIndex = 6;
			this.txDescription.Location = new global::System.Drawing.Point(102, 165);
			this.txDescription.Multiline = true;
			this.txDescription.Name = "txDescription";
			this.txDescription.Size = new global::System.Drawing.Size(194, 50);
			this.txDescription.TabIndex = 5;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(63, 168);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(33, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "描述";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(63, 254);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(33, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "分组";
			this.textOrder.Location = new global::System.Drawing.Point(102, 223);
			this.textOrder.Name = "textOrder";
			this.textOrder.Size = new global::System.Drawing.Size(194, 22);
			this.textOrder.TabIndex = 3;
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(63, 227);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(33, 13);
			this.label13.TabIndex = 1;
			this.label13.Text = "排序";
			this.txPassword.Location = new global::System.Drawing.Point(102, 102);
			this.txPassword.Name = "txPassword";
			this.txPassword.Size = new global::System.Drawing.Size(194, 22);
			this.txPassword.TabIndex = 3;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(63, 106);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(33, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "密码";
			this.txUsername.Location = new global::System.Drawing.Point(102, 74);
			this.txUsername.Name = "txUsername";
			this.txUsername.Size = new global::System.Drawing.Size(194, 22);
			this.txUsername.TabIndex = 2;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(50, 78);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(46, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "用户名";
			this.txComputer.Location = new global::System.Drawing.Point(102, 46);
			this.txComputer.Name = "txComputer";
			this.txComputer.Size = new global::System.Drawing.Size(194, 22);
			this.txComputer.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(63, 49);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(33, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "主机";
			this.txServername.Location = new global::System.Drawing.Point(102, 18);
			this.txServername.Name = "txServername";
			this.txServername.Size = new global::System.Drawing.Size(194, 22);
			this.txServername.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(24, 21);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(72, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "服务器名称";
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(329, 300);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "显示";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.groupBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox3.Controls.Add(this.tbColor);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Location = new global::System.Drawing.Point(10, 134);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(316, 54);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "色彩";
			this.tbColor.FormattingEnabled = true;
			this.tbColor.Location = new global::System.Drawing.Point(177, 15);
			this.tbColor.Name = "tbColor";
			this.tbColor.Size = new global::System.Drawing.Size(127, 21);
			this.tbColor.TabIndex = 13;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(6, 18);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(163, 13);
			this.label11.TabIndex = 2;
			this.label11.Text = "选择远程绘画的颜色深度：";
			this.groupBox2.Controls.Add(this.txHeight);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txWidth);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.tbDeskSize);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(317, 122);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "桌面大小";
			this.txHeight.Location = new global::System.Drawing.Point(252, 87);
			this.txHeight.Name = "txHeight";
			this.txHeight.Size = new global::System.Drawing.Size(50, 22);
			this.txHeight.TabIndex = 9;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(226, 91);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(20, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "高";
			this.txWidth.Location = new global::System.Drawing.Point(170, 87);
			this.txWidth.Name = "txWidth";
			this.txWidth.Size = new global::System.Drawing.Size(50, 22);
			this.txWidth.TabIndex = 8;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(144, 91);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(20, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "宽";
			this.tbDeskSize.LargeChange = 1;
			this.tbDeskSize.Location = new global::System.Drawing.Point(9, 34);
			this.tbDeskSize.Maximum = 13;
			this.tbDeskSize.Minimum = 1;
			this.tbDeskSize.Name = "tbDeskSize";
			this.tbDeskSize.Size = new global::System.Drawing.Size(299, 45);
			this.tbDeskSize.TabIndex = 6;
			this.tbDeskSize.Value = 4;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(6, 90);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(150, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "输入一个自定义的大小：";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(6, 18);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(306, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "选择远程桌面的大小。将拖动到最右边来使用全屏。";
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(268, 426);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "关闭";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.Location = new global::System.Drawing.Point(187, 427);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "color_full_48.ico");
			this.imageList1.Images.SetKeyName(1, "color_16_48.ico");
			this.imageList1.Images.SetKeyName(2, "color_8_48.ico");
			this.panel1.BackgroundImage = global::MstscManage.Properties.Resources.远程桌面背景图;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(352, 70);
			this.panel1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(352, 456);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ServerSettings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "连接设置";
			base.Load += new global::System.EventHandler(this.ServerSettings_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tbDeskSize).EndInit();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.TabControl tabControl1;

		private global::System.Windows.Forms.TabPage tabPage1;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.TabPage tabPage2;

		private global::System.Windows.Forms.TextBox txPassword;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.TextBox txUsername;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.TextBox txComputer;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.TextBox txServername;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox txDescription;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.Button btnCancel;

		private global::System.Windows.Forms.Button btnSave;

		private global::System.Windows.Forms.GroupBox groupBox2;

		private global::System.Windows.Forms.Label label7;

		private global::System.Windows.Forms.TrackBar tbDeskSize;

		private global::System.Windows.Forms.Label label8;

		private global::System.Windows.Forms.TextBox txHeight;

		private global::System.Windows.Forms.Label label10;

		private global::System.Windows.Forms.TextBox txWidth;

		private global::System.Windows.Forms.Label label9;

		private global::System.Windows.Forms.GroupBox groupBox3;

		private global::System.Windows.Forms.ImageList imageList1;

		private global::System.Windows.Forms.Label label11;

		private global::System.Windows.Forms.Label label12;

		private global::System.Windows.Forms.ComboBox GroupingComboBox;

		private global::System.Windows.Forms.ComboBox tbColor;

		private global::System.Windows.Forms.TextBox textOrder;

		private global::System.Windows.Forms.Label label13;

		private global::System.Windows.Forms.Button btnRandom;
	}
}
