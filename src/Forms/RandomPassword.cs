using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MstscManage
{
	public partial class RandomPassword : Form
	{
		public RandomPassword()
		{
			this.InitializeComponent();
			int Count = this.PasswordCountTxt.Text.ToInt32(0, NumberStyles.Any, null);
			this.PasswordTxt.Text = this.GetRandomPassword(Count);
		}

		private int getNewSeed()
		{
			byte[] rndBytes = new byte[4];
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			rng.GetBytes(rndBytes);
			return BitConverter.ToInt32(rndBytes, 0);
		}

		private string GetRandomPassword(int PwdLength)
		{
			string chars = "abcdefghijklmnpqrstuvwxyz";
			string chars2 = "ABCDEFGHIJKLMNOPQSTUVWXYZ";
			string chars3 = ".~*[]()!@#$%^&*";
			string chars4 = "0123456789";
			string chars5 = "";
			bool @checked = this.PasswordCheck1.Checked;
			if (@checked)
			{
				chars5 += chars;
			}
			bool checked2 = this.PasswordCheck2.Checked;
			if (checked2)
			{
				chars5 += chars2;
			}
			bool checked3 = this.PasswordCheck3.Checked;
			if (checked3)
			{
				chars5 += chars3;
			}
			bool checked4 = this.PasswordCheck4.Checked;
			if (checked4)
			{
				chars5 += chars4;
			}
			Random randrom = new Random(this.getNewSeed());
			string str = "";
			for (int i = 0; i < PwdLength; i++)
			{
				str += chars5[randrom.Next(chars5.Length)].ToString();
			}
			return str;
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			bool flag = this.PasswordCheck1.Checked || this.PasswordCheck2.Checked || this.PasswordCheck3.Checked || this.PasswordCheck4.Checked;
			if (flag)
			{
				int Count = this.PasswordCountTxt.Text.ToInt32(0, NumberStyles.Any, null);
				this.PasswordTxt.Text = this.GetRandomPassword(Count);
			}
			else
			{
				MessageBox.Show("请选择一个密码类别！");
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			bool flag = this.PasswordTxt.Text.IsNullOrEmpty();
			if (flag)
			{
				MessageBox.Show("请点击生成随机密码！");
			}
			else
			{
				base.Close();
			}
		}
	}
}
