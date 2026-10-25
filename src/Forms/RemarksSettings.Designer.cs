namespace MstscManage
{
	public partial class RemarksSettings : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.RemarksSettings));
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.RemarksText = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "color_full_48.ico");
			this.imageList1.Images.SetKeyName(1, "color_16_48.ico");
			this.imageList1.Images.SetKeyName(2, "color_8_48.ico");
			this.RemarksText.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.RemarksText.Font = new global::System.Drawing.Font("Segoe UI", 15f);
			this.RemarksText.Location = new global::System.Drawing.Point(0, 0);
			this.RemarksText.Multiline = true;
			this.RemarksText.Name = "RemarksText";
			this.RemarksText.Size = new global::System.Drawing.Size(543, 486);
			this.RemarksText.TabIndex = 27;
			this.RemarksText.TextChanged += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(543, 486);
			base.Controls.Add(this.RemarksText);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "RemarksSettings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "备忘录";
			base.Load += new global::System.EventHandler(this.ServerSettings_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.ImageList imageList1;

		private global::System.Windows.Forms.TextBox RemarksText;
	}
}
