using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MstscManage
{
	public partial class RemarksSettings : Form
	{
		public RemarksSettings()
		{
			this.InitializeComponent();
		}

		private void ServerSettings_Load(object sender, EventArgs e)
		{
			bool flag = !File.Exists(this.FilePath);
			if (flag)
			{
				File.WriteAllText(this.FilePath, "", Encoding.UTF8);
			}
			this.RemarksText.Text = File.ReadAllText(this.FilePath, Encoding.UTF8);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			File.WriteAllText(this.FilePath, this.RemarksText.Text, Encoding.UTF8);
		}

		private string FilePath = "Remarks.txt";
	}
}
