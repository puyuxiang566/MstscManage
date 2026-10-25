using System;
using System.Windows.Forms;

namespace MstscManage
{
	public partial class BatchGroupingForm : Form
	{
		public string SelectedGrouping
		{
			get
			{
				if (this.GroupingComboBox.SelectedItem != null)
				{
					return this.GroupingComboBox.SelectedItem.ToString();
				}
				return string.Empty;
			}
		}

		public BatchGroupingForm()
		{
			this.InitializeComponent();
			this.LoadGroupingList();
		}

		private void LoadGroupingList()
		{
			string[] GroupingItem = Config.GetConfig().GroupingItem.Split(new char[] { ',' });
			this.GroupingComboBox.Items.Clear();
			foreach (string item in GroupingItem)
			{
				string trimmed = item.Trim();
				if (!string.IsNullOrEmpty(trimmed))
				{
					this.GroupingComboBox.Items.Add(trimmed);
				}
			}
			if (this.GroupingComboBox.Items.Count > 0)
			{
				this.GroupingComboBox.SelectedIndex = 0;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (this.GroupingComboBox.SelectedItem == null)
			{
				MessageBox.Show("请选择一个分组！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}
	}
}
