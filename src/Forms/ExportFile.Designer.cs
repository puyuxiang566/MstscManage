namespace MstscManage
{
	public partial class ExportFile : global::System.Windows.Forms.Form
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
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MstscManage.ExportFile));
			this.lvRDPFiles = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.btnClose = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.lvRDPFiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lvRDPFiles.CheckBoxes = true;
			this.lvRDPFiles.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2
			});
			this.lvRDPFiles.FullRowSelect = true;
			this.lvRDPFiles.HideSelection = false;
			this.lvRDPFiles.Location = new global::System.Drawing.Point(6, 12);
			this.lvRDPFiles.Name = "lvRDPFiles";
			this.lvRDPFiles.Size = new global::System.Drawing.Size(392, 387);
			this.lvRDPFiles.TabIndex = 1;
			this.lvRDPFiles.UseCompatibleStateImageBehavior = false;
			this.lvRDPFiles.View = global::System.Windows.Forms.View.Details;
			this.columnHeader1.Text = "主机名称";
			this.columnHeader1.Width = 320;
			this.columnHeader2.Text = "状态";
			this.columnHeader2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader2.Width = 50;
			this.btnStart.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnStart.Location = new global::System.Drawing.Point(242, 405);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new global::System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "导出";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.btnClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new global::System.Drawing.Point(323, 405);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			base.AcceptButton = this.btnStart;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnClose;
			base.ClientSize = new global::System.Drawing.Size(404, 435);
			base.Controls.Add(this.btnClose);
			base.Controls.Add(this.btnStart);
			base.Controls.Add(this.lvRDPFiles);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ExportFile";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "导出RDP连接文件";
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.ListView lvRDPFiles;

		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		private global::System.Windows.Forms.Button btnStart;

		private global::System.Windows.Forms.Button btnClose;
	}
}
