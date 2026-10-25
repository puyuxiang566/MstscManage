namespace MstscManage
{
	public partial class LoginForm : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.LoginForm));
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnLogIn = new global::System.Windows.Forms.Button();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.Pwd_Text = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(260, 119);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(151, 68);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "关闭";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnLogIn.Location = new global::System.Drawing.Point(17, 119);
			this.btnLogIn.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new global::System.Drawing.Size(227, 65);
			this.btnLogIn.TabIndex = 11;
			this.btnLogIn.Text = "登录";
			this.btnLogIn.UseVisualStyleBackColor = true;
			this.btnLogIn.Click += new global::System.EventHandler(this.btnLogIn_Click);
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "color_full_48.ico");
			this.imageList1.Images.SetKeyName(1, "color_16_48.ico");
			this.imageList1.Images.SetKeyName(2, "color_8_48.ico");
			this.Pwd_Text.Location = new global::System.Drawing.Point(17, 61);
			this.Pwd_Text.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
			this.Pwd_Text.Name = "Pwd_Text";
			this.Pwd_Text.PasswordChar = '*';
			this.Pwd_Text.Size = new global::System.Drawing.Size(394, 43);
			this.Pwd_Text.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(185, 37);
			this.label1.TabIndex = 27;
			this.label1.Text = "请输入密码：";
			base.AcceptButton = this.btnLogIn;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(15f, 37f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(422, 201);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnLogIn);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.Pwd_Text);
			this.Font = new global::System.Drawing.Font("Segoe UI", 20f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(8, 9, 8, 9);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoginForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "主机状态检测";
			base.Load += new global::System.EventHandler(this.LoginForm_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Button btnCancel;

		private global::System.Windows.Forms.Button btnLogIn;

		private global::System.Windows.Forms.ImageList imageList1;

		private global::System.Windows.Forms.TextBox Pwd_Text;

		private global::System.Windows.Forms.Label label1;
	}
}
