using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MstscManage.Database;
using MstscManage.Helper;

namespace MstscManage
{
	public partial class ExportFile : Form
	{
		public ExportFile()
		{
			this.InitializeComponent();
			this.InitializeControls();
		}

		public ExportFile(BindingCollection<HostServers> HostInformation)
		{
			this.InitializeComponent();
			this.InitializeControls(HostInformation);
		}

		public void InitializeControls()
		{
		}

		public void InitializeControls(BindingCollection<HostServers> HostInformation)
		{
			foreach (HostServers item in HostInformation)
			{
				ListViewItem Listitem = new ListViewItem(item.ServerName);
				Listitem.SubItems.Add("OK");
				Listitem.ImageIndex = 0;
				Listitem.Tag = item;
				this.lvRDPFiles.Items.Add(Listitem);
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog SelectFolder = new FolderBrowserDialog();
			SelectFolder.ShowDialog();
			bool flag = SelectFolder.SelectedPath != string.Empty;
			if (flag)
			{
				foreach (object obj in this.lvRDPFiles.Items)
				{
					ListViewItem thisItem = (ListViewItem)obj;
					bool @checked = thisItem.Checked;
					if (@checked)
					{
						thisItem.SubItems[1].Text = "导入...";
						HostServers Item = (HostServers)thisItem.Tag;
						bool flag2 = ExportFile.ExportRdp(Item, SelectFolder.SelectedPath, 1);
						if (flag2)
						{
							thisItem.SubItems[1].Text = "Done!";
						}
						else
						{
							thisItem.SubItems[1].Text = "Error";
						}
					}
				}
			}
			Process.Start(SelectFolder.SelectedPath);
			base.Close();
		}

		public static bool ExportRdp(HostServers Item, string SelectedPath, int ModelType = 1)
		{
			RDPFile rdp = new RDPFile();
			rdp.ScreenMode = 2;
			rdp.SessionBPP = (RDPFile.SessionBPPs)Item.ColorDepth;
			rdp.WinPosStr = new RDPFile.WindowsPosition
			{
				Rect = default(RDPFile.RECT),
				WinState = RDPFile.WindowState.MAXMIZE
			};
			rdp.FullAddress = Item.Server;
			rdp.Compression = 1;
			rdp.KeyboardHook = RDPFile.KeyboardHooks.ON_THE_REMOTE_COMPUTER;
			rdp.AudioMode = RDPFile.AudioModes.BRING_TO_THIS_COMPUTER;
			rdp.RedirectDrives = 0;
			rdp.RedirectPrinters = 0;
			rdp.RedirectComPorts = 0;
			rdp.RedirectSmartCards = 0;
			rdp.DisplayConnectionBar = 1;
			rdp.AutoReconnectionEnabled = 1;
			rdp.Username = Item.Username;
			rdp.Domain = string.Empty;
			rdp.AlternateShell = string.Empty;
			rdp.ShellWorkingDirectory = string.Empty;
			rdp.Password = ((Item.Password == string.Empty) ? string.Empty : DataProtectionForRDPWrapper.Encrypt(Item.Password));
			rdp.DisableWallpaper = 1;
			rdp.DisableFullWindowDrag = 1;
			rdp.DisableMenuAnims = 1;
			rdp.DisableThemes = 1;
			rdp.DisableCursorSettings = 1;
			rdp.BitmapCachePersistEnable = 1;
			bool result;
			try
			{
				string[] ServerItem = Item.Server.Split(new char[]
				{
					'.'
				});
				string ServerName = ServerItem[ServerItem.Length - 1].Replace(":", "，");
				string FilePath = Path.Combine(SelectedPath, Item.ServerName + "-" + ServerName + ".rdp");
				rdp.Save(FilePath);
				bool flag = ModelType == 2;
				if (flag)
				{
					Process.Start(FilePath);
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
	}
}
