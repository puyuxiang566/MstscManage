using System;
using System.Drawing;
using System.Windows.Forms;
using AxMSTSCLib;

namespace MstscManage
{
	public class ControlToImage
	{
		public static Image GetControlScreenshot(Control control)
		{
			Bitmap bitmap = null;
			bool flag = control == null || control.Handle == IntPtr.Zero;
			Image result;
			if (flag)
			{
				result = bitmap;
			}
			else
			{
				bool flag2 = control.Width < 1 || control.Height < 1;
				if (flag2)
				{
					result = bitmap;
				}
				else
				{
					bool flag3 = bitmap != null;
					if (flag3)
					{
						bitmap.Dispose();
					}
					bitmap = new Bitmap(control.Width, control.Height);
					Graphics destGraphics = Graphics.FromImage(bitmap);
					int printFlags = 6;
					IntPtr param = new IntPtr(printFlags);
					IntPtr hdc = destGraphics.GetHdc();
					APIs.SendMessage(control.Handle, 791, hdc, param);
					destGraphics.ReleaseHdc(hdc);
					destGraphics.Dispose();
					result = bitmap;
				}
			}
			return result;
		}

		public static Image CaptureControlImage(ref AxMsRdpClient7NotSafeForScripting ctrl)
		{
			Image ret = null;
			Bitmap bmp = new Bitmap(ctrl.Width, ctrl.Height);
			IntPtr p_hWnd = ctrl.Handle;
			IntPtr hWnd = APIs.FindWindowEx(p_hWnd, IntPtr.Zero, "UIMainClass", IntPtr.Zero);
			bool flag = hWnd != IntPtr.Zero;
			if (flag)
			{
				hWnd = APIs.FindWindowEx(hWnd, IntPtr.Zero, "UIContainerClass", IntPtr.Zero);
				bool flag2 = hWnd != IntPtr.Zero;
				if (flag2)
				{
					hWnd = APIs.FindWindowEx(hWnd, IntPtr.Zero, "OPWindowClass", "Output Painter Window");
					bool flag3 = hWnd != IntPtr.Zero;
					if (flag3)
					{
						Graphics gBmp = Graphics.FromImage(bmp);
						IntPtr dcBmp = gBmp.GetHdc();
						IntPtr param = new IntPtr(22);
						APIs.SendMessage(ctrl.Handle, 791, dcBmp, param);
						gBmp.ReleaseHdc(dcBmp);
						ret = bmp;
					}
				}
			}
			return ret;
		}
	}
}
