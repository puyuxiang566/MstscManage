using System;
using System.Runtime.InteropServices;

namespace MstscManage
{
	internal class NativeMethods
	{
		[DllImport("user32")]
		public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

		[DllImport("user32")]
		public static extern int RegisterWindowMessage(string message);

		public const int HWND_BROADCAST = 65535;

		public static readonly int WM_SHOWME = NativeMethods.RegisterWindowMessage("WM_SHOWME");
	}
}
