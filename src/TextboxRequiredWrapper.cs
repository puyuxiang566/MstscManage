using System;
using System.Drawing;
using System.Windows.Forms;

namespace MstscManage
{
	public class TextboxRequiredWrapper
	{
		public void AddRange(Control[] textbox)
		{
			this._textbox = textbox;
			foreach (Control ctrl in this._textbox)
			{
				bool flag = ctrl.Text == string.Empty;
				if (flag)
				{
					ctrl.Text = this.reqFieldMessage;
					ctrl.Font = new Font("Segoe UI", 8.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
				}
				ctrl.LostFocus += this.ctrl_LostFocus;
				ctrl.GotFocus += this.ctrl_GotFocus;
				ctrl.TextChanged += this.ctrl_TextChanged;
			}
		}

		private void ctrl_TextChanged(object sender, EventArgs e)
		{
			Control ctrl = (Control)sender;
			bool flag = ctrl.Text != this.reqFieldMessage;
			if (flag)
			{
				ctrl.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}

		private void ctrl_LostFocus(object sender, EventArgs e)
		{
			Control ctrl = (Control)sender;
			bool flag = ctrl.Text == string.Empty;
			if (flag)
			{
				ctrl.Font = new Font("Segoe UI", 8.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
				ctrl.Text = this.reqFieldMessage;
			}
		}

		private void ctrl_GotFocus(object sender, EventArgs e)
		{
			Control ctrl = (Control)sender;
			bool flag = ctrl.Text == this.reqFieldMessage;
			if (flag)
			{
				ctrl.Text = string.Empty;
			}
		}

		public bool isAllFieldSet()
		{
			bool ret = true;
			foreach (Control ctrl in this._textbox)
			{
				bool flag = ctrl.Text == this.reqFieldMessage;
				if (flag)
				{
					ret = false;
					break;
				}
			}
			return ret;
		}

		private Control[] _textbox;

		private string reqFieldMessage = "必填字段";
	}
}
