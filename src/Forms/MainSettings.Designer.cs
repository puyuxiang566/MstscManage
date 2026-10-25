namespace MstscManage
{
	public partial class MainSettings : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.MainSettings));
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.MstscType = new global::System.Windows.Forms.ComboBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.MstscParameter = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.DiskListBox = new global::System.Windows.Forms.CheckedListBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.checkPwdBox = new global::System.Windows.Forms.CheckBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.textPwd = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(240, 301);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "关闭";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.Location = new global::System.Drawing.Point(134, 301);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(100, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "color_full_48.ico");
			this.imageList1.Images.SetKeyName(1, "color_16_48.ico");
			this.imageList1.Images.SetKeyName(2, "color_8_48.ico");
			this.MstscType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MstscType.FormattingEnabled = true;
			this.MstscType.Items.AddRange(new object[]
			{
				"Rdp模式",
				"原生远程桌面",
				"内置远程桌面"
			});
			this.MstscType.Location = new global::System.Drawing.Point(133, 86);
			this.MstscType.Name = "MstscType";
			this.MstscType.Size = new global::System.Drawing.Size(181, 21);
			this.MstscType.TabIndex = 24;
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(29, 89);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(98, 13);
			this.label12.TabIndex = 15;
			this.label12.Text = "远程桌面方式：";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(29, 132);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(98, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "远程桌面参数：";
			this.MstscParameter.Location = new global::System.Drawing.Point(133, 128);
			this.MstscParameter.Name = "MstscParameter";
			this.MstscParameter.Size = new global::System.Drawing.Size(181, 22);
			this.MstscParameter.TabIndex = 26;
			this.MstscParameter.Text = " /admin";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(133, 110);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(171, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Rdp模式不需要手动输入密码";
			this.DiskListBox.FormattingEnabled = true;
			this.DiskListBox.Location = new global::System.Drawing.Point(133, 187);
			this.DiskListBox.Name = "DiskListBox";
			this.DiskListBox.Size = new global::System.Drawing.Size(181, 106);
			this.DiskListBox.TabIndex = 27;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(55, 191);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(72, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "共享磁盘：";
			this.checkPwdBox.AutoSize = true;
			this.checkPwdBox.Location = new global::System.Drawing.Point(133, 159);
			this.checkPwdBox.Name = "checkPwdBox";
			this.checkPwdBox.Size = new global::System.Drawing.Size(52, 17);
			this.checkPwdBox.TabIndex = 28;
			this.checkPwdBox.Text = "验证";
			this.checkPwdBox.UseVisualStyleBackColor = true;
			this.checkPwdBox.CheckedChanged += new global::System.EventHandler(this.checkPwdBox_CheckedChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(16, 159);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(111, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "打开后密码验证：";
			this.panel1.BackgroundImage = global::MstscManage.Properties.Resources.远程桌面设置背景图;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(339, 70);
			this.panel1.TabIndex = 0;
			this.textPwd.Location = new global::System.Drawing.Point(191, 155);
			this.textPwd.Name = "textPwd";
			this.textPwd.PasswordChar = '*';
			this.textPwd.Size = new global::System.Drawing.Size(123, 22);
			this.textPwd.TabIndex = 26;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(339, 336);
			base.Controls.Add(this.checkPwdBox);
			base.Controls.Add(this.DiskListBox);
			base.Controls.Add(this.textPwd);
			base.Controls.Add(this.MstscParameter);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.MstscType);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainSettings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "连接设置";
			base.Load += new global::System.EventHandler(this.ServerSettings_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Panel panel1;

		private global::System.Windows.Forms.Button btnCancel;

		private global::System.Windows.Forms.Button btnSave;

		private global::System.Windows.Forms.ImageList imageList1;

		private global::System.Windows.Forms.ComboBox MstscType;

		private global::System.Windows.Forms.Label label12;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox MstscParameter;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.CheckedListBox DiskListBox;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.CheckBox checkPwdBox;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.TextBox textPwd;
	}
}
