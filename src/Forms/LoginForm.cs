using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MstscManage
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			this.InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			bool flag = this.CurrConfig.LoginPwd == this.Pwd_Text.Text;
			if (flag)
			{
				base.Close();
			}
			else
			{
				MessageBox.Show("密码错误，请重新输入！");
			}
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
		}

		private Config CurrConfig = Config.GetConfig();
	}
}
