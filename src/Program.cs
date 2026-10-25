using System;
using System.Threading;
using System.Windows.Forms;

namespace MstscManage
{
	internal static class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			bool flag = Program.mutex.WaitOne(TimeSpan.Zero, true);
			if (flag)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
				Program.mutex.ReleaseMutex();
			}
			else
			{
				NativeMethods.PostMessage((IntPtr)65535, NativeMethods.WM_SHOWME, IntPtr.Zero, IntPtr.Zero);
			}
		}

		private static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
	}
}
