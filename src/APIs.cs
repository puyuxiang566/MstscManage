using System;
using System.Runtime.InteropServices;

namespace MstscManage
{
	public class APIs
	{
		[DllImport("USER32.DLL")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

		[DllImport("user32.dll")]
		public static extern int GetWindowRect(IntPtr hwnd, out APIs.RECT rc);

		[DllImport("user32.dll")]
		private static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		public static void ShowInactiveTopmost(IntPtr FormHandle)
		{
			APIs.ShowWindow(FormHandle, 4);
		}

		public const int WM_PRINT = 791;

		public const int WM_PRINTCLIENT = 792;

		public const int PRF_CHECKVISIBLE = 1;

		public const int PRF_NONCLIENT = 2;

		public const int PRF_CLIENT = 4;

		public const int PRF_ERASEBKGND = 8;

		public const int PRF_CHILDREN = 16;

		public const int PRF_OWNED = 32;

		public const int SW_SHOWNOACTIVATE = 4;

		public const int HWND_TOPMOST = -1;

		public const uint SWP_NOACTIVATE = 16U;

		public struct RECT
		{
			public int Left;

			public int Top;

			public int Right;

			public int Bottom;
		}
	}
}
