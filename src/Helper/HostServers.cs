using System;

namespace MstscManage.Helper
{
	public class HostServers
	{
		public int Id { get; set; }

		public int SortNumber { get; set; }

		public string ServerName { get; set; }

		public string Server { get; set; }

		public int Port { get; set; }

		public string Username { get; set; }

		public string Password
		{
			get
			{
				bool flag = this._password != string.Empty;
				if (flag)
				{
				}
				return this._password;
			}
			set
			{
				bool flag = value != string.Empty;
				if (flag)
				{
				}
				this._password = value;
			}
		}

		public int ColorDepth { get; set; }

		public int DesktopWidth { get; set; }

		public int DesktopHeight { get; set; }

		public bool Fullscreen { get; set; }

		public string Description { get; set; }

		public string Grouping { get; internal set; }

		public string RemoteType { get; internal set; }

		private string _password = "";
	}
}
