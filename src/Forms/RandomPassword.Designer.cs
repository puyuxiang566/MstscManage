namespace MstscManage
{
	public partial class RandomPassword : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.RandomPassword));
			this.btnOK = new global::System.Windows.Forms.Button();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.PasswordCheck4 = new global::System.Windows.Forms.CheckBox();
			this.PasswordCheck3 = new global::System.Windows.Forms.CheckBox();
			this.PasswordCheck2 = new global::System.Windows.Forms.CheckBox();
			this.PasswordCheck1 = new global::System.Windows.Forms.CheckBox();
			this.PasswordTxt = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.PasswordCountTxt = new global::System.Windows.Forms.TextBox();
			this.btnRandom = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.btnOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnOK.Location = new global::System.Drawing.Point(250, 203);
			this.btnOK.Margin = new global::System.Windows.Forms.Padding(4);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(119, 28);
			this.btnOK.TabIndex = 12;
			this.btnOK.Text = "确定录入密码";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "color_full_48.ico");
			this.imageList1.Images.SetKeyName(1, "color_16_48.ico");
			this.imageList1.Images.SetKeyName(2, "color_8_48.ico");
			this.PasswordCheck4.AutoSize = true;
			this.PasswordCheck4.Checked = true;
			this.PasswordCheck4.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.PasswordCheck4.Location = new global::System.Drawing.Point(112, 173);
			this.PasswordCheck4.Margin = new global::System.Windows.Forms.Padding(4);
			this.PasswordCheck4.Name = "PasswordCheck4";
			this.PasswordCheck4.Size = new global::System.Drawing.Size(59, 20);
			this.PasswordCheck4.TabIndex = 15;
			this.PasswordCheck4.Text = "数字";
			this.PasswordCheck4.UseVisualStyleBackColor = true;
			this.PasswordCheck3.AutoSize = true;
			this.PasswordCheck3.Checked = true;
			this.PasswordCheck3.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.PasswordCheck3.Location = new global::System.Drawing.Point(112, 145);
			this.PasswordCheck3.Margin = new global::System.Windows.Forms.Padding(4);
			this.PasswordCheck3.Name = "PasswordCheck3";
			this.PasswordCheck3.Size = new global::System.Drawing.Size(91, 20);
			this.PasswordCheck3.TabIndex = 16;
			this.PasswordCheck3.Text = "特殊字符";
			this.PasswordCheck3.UseVisualStyleBackColor = true;
			this.PasswordCheck2.AutoSize = true;
			this.PasswordCheck2.Checked = true;
			this.PasswordCheck2.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.PasswordCheck2.Location = new global::System.Drawing.Point(112, 117);
			this.PasswordCheck2.Margin = new global::System.Windows.Forms.Padding(4);
			this.PasswordCheck2.Name = "PasswordCheck2";
			this.PasswordCheck2.Size = new global::System.Drawing.Size(91, 20);
			this.PasswordCheck2.TabIndex = 17;
			this.PasswordCheck2.Text = "大写字母";
			this.PasswordCheck2.UseVisualStyleBackColor = true;
			this.PasswordCheck1.AutoSize = true;
			this.PasswordCheck1.Checked = true;
			this.PasswordCheck1.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.PasswordCheck1.Location = new global::System.Drawing.Point(112, 89);
			this.PasswordCheck1.Margin = new global::System.Windows.Forms.Padding(4);
			this.PasswordCheck1.Name = "PasswordCheck1";
			this.PasswordCheck1.Size = new global::System.Drawing.Size(91, 20);
			this.PasswordCheck1.TabIndex = 18;
			this.PasswordCheck1.Text = "小写字母";
			this.PasswordCheck1.UseVisualStyleBackColor = true;
			this.PasswordTxt.Location = new global::System.Drawing.Point(112, 15);
			this.PasswordTxt.Margin = new global::System.Windows.Forms.Padding(4);
			this.PasswordTxt.Name = "PasswordTxt";
			this.PasswordTxt.Size = new global::System.Drawing.Size(257, 26);
			this.PasswordTxt.TabIndex = 13;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(16, 18);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(88, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "随机密码：";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(16, 56);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(88, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "密码长度：";
			this.PasswordCountTxt.Location = new global::System.Drawing.Point(112, 54);
			this.PasswordCountTxt.Margin = new global::System.Windows.Forms.Padding(4);
			this.PasswordCountTxt.Name = "PasswordCountTxt";
			this.PasswordCountTxt.Size = new global::System.Drawing.Size(81, 26);
			this.PasswordCountTxt.TabIndex = 13;
			this.PasswordCountTxt.Text = "20";
			this.btnRandom.Location = new global::System.Drawing.Point(112, 203);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new global::System.Drawing.Size(113, 28);
			this.btnRandom.TabIndex = 20;
			this.btnRandom.Text = "随机生成密码";
			this.btnRandom.UseVisualStyleBackColor = true;
			this.btnRandom.Click += new global::System.EventHandler(this.btnRandom_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(397, 244);
			base.Controls.Add(this.btnRandom);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.PasswordCheck4);
			base.Controls.Add(this.PasswordCheck3);
			base.Controls.Add(this.PasswordCheck2);
			base.Controls.Add(this.PasswordCheck1);
			base.Controls.Add(this.PasswordCountTxt);
			base.Controls.Add(this.PasswordTxt);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnOK);
			this.Font = new global::System.Drawing.Font("宋体", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RandomPassword";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "生成随机密码";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Button btnOK;

		private global::System.Windows.Forms.ImageList imageList1;

		private global::System.Windows.Forms.CheckBox PasswordCheck4;

		private global::System.Windows.Forms.CheckBox PasswordCheck3;

		private global::System.Windows.Forms.CheckBox PasswordCheck2;

		private global::System.Windows.Forms.CheckBox PasswordCheck1;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.TextBox PasswordCountTxt;

		public global::System.Windows.Forms.TextBox PasswordTxt;

		private global::System.Windows.Forms.Button btnRandom;
	}
}
