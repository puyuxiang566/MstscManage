namespace MstscManage
{
	public partial class BatchGroupingForm
	{
		private global::System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.labelMessage = new global::System.Windows.Forms.Label();
			this.GroupingComboBox = new global::System.Windows.Forms.ComboBox();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.labelMessage.AutoSize = true;
			this.labelMessage.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.labelMessage.Location = new global::System.Drawing.Point(26, 26);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new global::System.Drawing.Size(139, 21);
			this.labelMessage.TabIndex = 0;
			this.labelMessage.Text = "请选择目标分组：";
			this.GroupingComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GroupingComboBox.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.GroupingComboBox.FormattingEnabled = true;
			this.GroupingComboBox.Location = new global::System.Drawing.Point(26, 56);
			this.GroupingComboBox.Name = "GroupingComboBox";
			this.GroupingComboBox.Size = new global::System.Drawing.Size(306, 29);
			this.GroupingComboBox.TabIndex = 1;
			this.btnOK.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.btnOK.Location = new global::System.Drawing.Point(176, 100);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(75, 30);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "确定";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.btnCancel.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.btnCancel.Location = new global::System.Drawing.Point(257, 100);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 30);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			base.AcceptButton = this.btnOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(358, 148);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.GroupingComboBox);
			base.Controls.Add(this.labelMessage);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BatchGroupingForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "批量修改分组";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.Windows.Forms.Label labelMessage;
		private global::System.Windows.Forms.ComboBox GroupingComboBox;
		private global::System.Windows.Forms.Button btnOK;
		private global::System.Windows.Forms.Button btnCancel;
	}
}
