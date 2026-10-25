using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using MstscManage.Database;
using MstscManage.Helper;

namespace MstscManage
{
	public partial class ClientStateDetection : Form
	{
		public event UpdateState OnUpdateState;

		public event CloseTistWindow OnCloseTistWindow;

		public ClientStateDetection(ref BindingCollection<HostServers> hostInformation, ref BindingCollection<HostServers> selectHost)
		{
			this.InitializeComponent();
			this.HostInformation = hostInformation;
			this.SelectHost = selectHost;
			Control.CheckForIllegalCrossThreadCalls = false;
			this.OnCloseTistWindow += this.ClientStateDetection_OnCloseTistWindow;
			this.Port_Text.Text = Config.GetConfig().CheckPort;
		}

		private void ClientStateDetection_OnCloseTistWindow()
		{
			base.Close();
		}

		private void ServerSettings_Load(object sender, EventArgs e)
		{
		}

		private void btnState_Click(object sender, EventArgs e)
		{
			this.PortList = this.Port_Text.Text.Split(new char[]
			{
				','
			});
			this.btnState.Enabled = false;
			Thread thread = new Thread(new ThreadStart(this.PortScan));
			thread.Start();
			CloseTistWindow onCloseTistWindow = this.OnCloseTistWindow;
			if (onCloseTistWindow != null)
			{
				onCloseTistWindow();
			}
			Config.UpdateCheckPort(this.Port_Text.Text);
		}

		private void PortScan()
		{
			bool @checked = this.All_Radio.Checked;
			if (@checked)
			{
				this.PortScanItem(ref this.HostInformation);
			}
			else
			{
				this.PortScanItem(ref this.SelectHost);
			}
		}

		private void PortScanItem(ref BindingCollection<HostServers> HostList)
		{
			foreach (HostServers item in HostList)
			{
				string Description = "主机离线";
				foreach (string Port in this.PortList)
				{
					bool Result = this.CheckPort(item.Server, Port.ToInt32(0, NumberStyles.Any, null));
					bool flag = Result && Description == "主机离线";
					if (flag)
					{
						Description = "在线";
						break;
					}
				}
				item.Description = Description;
				UpdateState onUpdateState = this.OnUpdateState;
				if (onUpdateState != null)
				{
					onUpdateState();
				}
				Thread.Sleep(100);
			}
		}

		public bool CheckPort(string Ip, int Port)
		{
			TcpClient tcpClient = new TcpClient();
			bool result;
			try
			{
				IPEndPoint IpModel = new IPEndPoint(IPAddress.Parse(Ip), Port);
				tcpClient = TimeOutSocket.TryConnect(IpModel, 500);
				result = (tcpClient != null);
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		private HostServersDal HostDal = new HostServersDal();

		private BindingCollection<HostServers> HostInformation;

		private BindingCollection<HostServers> SelectHost;

		private string[] PortList = null;
	}
}
