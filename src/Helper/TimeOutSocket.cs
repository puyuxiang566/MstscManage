using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MstscManage.Helper
{
	internal class TimeOutSocket
	{
		public static TcpClient TryConnect(IPEndPoint remoteEndPoint, int timeoutMiliSecond)
		{
			TimeOutSocket.TimeoutObject.Reset();
			TimeOutSocket.socketexception = null;
			string serverip = Convert.ToString(remoteEndPoint.Address);
			int serverport = remoteEndPoint.Port;
			TcpClient tcpclient = new TcpClient();
			tcpclient.BeginConnect(serverip, serverport, new AsyncCallback(TimeOutSocket.CallBackMethod), tcpclient);
			bool flag = TimeOutSocket.TimeoutObject.WaitOne(timeoutMiliSecond, false);
			if (flag)
			{
				bool isConnectionSuccessful = TimeOutSocket.IsConnectionSuccessful;
				TcpClient result;
				if (isConnectionSuccessful)
				{
					result = tcpclient;
				}
				else
				{
					result = null;
				}
				return result;
			}
			tcpclient.Close();
			throw new TimeoutException("TimeOut Exception");
		}

		private static void CallBackMethod(IAsyncResult asyncresult)
		{
			try
			{
				TimeOutSocket.IsConnectionSuccessful = false;
				TcpClient tcpclient = asyncresult.AsyncState as TcpClient;
				bool flag = tcpclient.Client != null;
				if (flag)
				{
					tcpclient.EndConnect(asyncresult);
					TimeOutSocket.IsConnectionSuccessful = true;
				}
			}
			catch (Exception ex)
			{
				TimeOutSocket.IsConnectionSuccessful = false;
				TimeOutSocket.socketexception = ex;
			}
			finally
			{
				TimeOutSocket.TimeoutObject.Set();
			}
		}

		private static bool IsConnectionSuccessful = false;

		private static Exception socketexception;

		private static ManualResetEvent TimeoutObject = new ManualResetEvent(false);
	}
}
