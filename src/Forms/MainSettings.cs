using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MstscManage.Properties;

namespace MstscManage
{
	public partial class MainSettings : Form
	{
		public MainSettings()
		{
			this.InitializeComponent();
		}

		private void ServerSettings_Load(object sender, EventArgs e)
		{
			Config CurrConfig = Config.GetConfig();
			DriveInfo[] allDirves = DriveInfo.GetDrives();
			foreach (DriveInfo item in allDirves)
			{
				this.DiskListBox.Items.Add(item.Name);
			}
			this.MstscType.SelectedItem = CurrConfig.MstscType;
			string[] SelectDiskList = CurrConfig.SelectDiskList.Split(new char[]
			{
				';'
			});
			for (int i = 0; i < this.DiskListBox.Items.Count; i++)
			{
				string Value = this.DiskListBox.Items[i].ToString();
				bool flag = SelectDiskList.Contains(Value);
				if (flag)
				{
					this.DiskListBox.SetItemChecked(i, true);
				}
			}
			this.textPwd.Text = CurrConfig.LoginPwd;
			this.checkPwdBox.Checked = !CurrConfig.LoginPwd.IsNullOrEmpty();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = this.checkPwdBox.Checked && this.textPwd.Text.IsNullOrEmpty();
			if (flag)
			{
				MessageBox.Show("请输入登录密码！");
			}
			else
			{
				string SelectDiskList = "";
				for (int i = 0; i < this.DiskListBox.Items.Count; i++)
				{
					bool itemChecked = this.DiskListBox.GetItemChecked(i);
					if (itemChecked)
					{
						SelectDiskList = SelectDiskList + this.DiskListBox.Items[i].ToString() + ";";
					}
				}
				Config.UpdateConfig(this.MstscType.SelectedItem.ToString(), this.MstscParameter.Text, SelectDiskList, this.textPwd.Text);
				base.Close();
			}
		}

		private Rectangle GetClientWindowSize()
		{
			int DesktopWidth = Screen.PrimaryScreen.Bounds.Height;
			int DesktopHeight = Screen.PrimaryScreen.Bounds.Width;
			return new Rectangle(0, 0, DesktopWidth, DesktopHeight);
		}

		private void checkPwdBox_CheckedChanged(object sender, EventArgs e)
		{
			this.textPwd.ReadOnly = !this.checkPwdBox.Checked;
			bool flag = !this.checkPwdBox.Checked;
			if (flag)
			{
				this.textPwd.Text = "";
			}
		}
	}
}
