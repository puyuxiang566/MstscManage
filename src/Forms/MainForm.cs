using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using MstscManage.Database;
using MstscManage.Helper;
using MstscManage.Properties;
using NPinyin;

namespace MstscManage
{
	public partial class MainForm : Form
	{
		[DllImport("shell32.dll")]
		public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

		public MainForm()
		{
			this.InitializeComponent();
			this.HostDal.EnsureDatabaseExists();
			this.InitializeControlEvents();
		}

		public void InitializeControlEvents()
		{
			string[] GroupingItem = Config.GetConfig().GroupingItem.Split(new char[]
			{
				','
			});
			ComboBox.ObjectCollection items = this.GroupingComboBox.Items;
			object[] items2 = GroupingItem;
			items.AddRange(items2);
			string selectGrouping = Config.GetConfig().SelectGrouping;
			if (this.GroupingComboBox.Items.Contains(selectGrouping))
			{
				this.GroupingComboBox.SelectedItem = selectGrouping;
			}
			else if (this.GroupingComboBox.Items.Count > 0)
			{
				this.GroupingComboBox.SelectedIndex = 0;
			}
			base.Shown += this.RemoteDesktopClient_Shown;
			this.HostDataGridView.CellDoubleClick += this.HostDataGridView_CellContentDoubleClick;
			this.HostDataGridView.SelectionChanged += this.HostDataGridView_SelectionChanged;
		}

		private void RemoteDesktopClient_Shown(object sender, EventArgs e)
		{
			this.HostDal.EnsureDatabaseExists();
			this.BintServerLists();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			ServerSettings ssw = new ServerSettings(ref this.HostInformation);
			ssw.ShowDialog();
		}

		public void BintServerLists()
		{
			this.HostInformation.Clear();
			string GroupingValue = "全部主机";
			if (this.GroupingComboBox.SelectedItem != null)
			{
				GroupingValue = this.GroupingComboBox.SelectedItem.ToString();
			}
			string keyword = this.Search_Text.Text.Trim();
			bool isAsciiSearch = !string.IsNullOrEmpty(keyword) && keyword.All(c => c <= 0x7f);
			List<HostServers> HostList = this.HostDal.ReadAllHost(GroupingValue, "");
			foreach (HostServers item in HostList)
			{
				if (string.IsNullOrEmpty(keyword))
				{
					this.HostInformation.Add(item);
				}
				else if (item.ServerName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
					item.Server.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					this.HostInformation.Add(item);
				}
				else if (isAsciiSearch && item.ServerName.Any(c => c >= 0x4e00 && c <= 0x9fff))
				{
					try
					{
						if (Pinyin.GetInitials(item.ServerName).IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
							Pinyin.GetPinyin(item.ServerName).Replace(" ", "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
						{
							this.HostInformation.Add(item);
						}
					}
					catch
					{
					}
				}
			}
			this.TextStatus.Text = string.Format("共{0}项", this.HostInformation.Count.ToString());
			this.HostDataGridView.DataSource = this.HostInformation;
			this.HostDataGridView.ContextMenuStrip = this.lvServerListContextMenu;
			this.HostDataGridView.Sort(this.HostDataGridView.Columns[1], ListSortDirection.Ascending);
		}

		public void StatClientSelect()
		{
			string MstscType = Config.GetConfig().MstscType;
			for (int i = 0; i < this.SelectHost.Count; i++)
			{
				HostServers item = this.SelectHost[i];
				bool flag = MstscType == "原生远程桌面";
				if (flag)
				{
					this.StatClientByWindow(item);
				}
				else
				{
					bool flag2 = MstscType == "Rdp模式";
					if (flag2)
					{
						string TempDir = "Temp";
						bool flag3 = !Directory.Exists(TempDir);
						if (flag3)
						{
							Directory.CreateDirectory(TempDir);
						}
						ExportFile.ExportRdp(item, TempDir, 2);
					}
					else
					{
						this.StatClient(item);
					}
				}
			}
		}

		public void StatClient(HostServers sd)
		{
			string formTitle = string.Format("远程桌面客户端 - {0}@{1}[{2}]", sd.Username, sd.ServerName, sd.Server);
			ClientMain clientWin = new ClientMain(sd);
			clientWin.Text = formTitle;
			clientWin.Visible = true;
			clientWin.Show();
			Task.Run(() =>
			{
				try
				{
					clientWin.Invoke(new Action(() =>
					{
						if (clientWin != null && !clientWin.IsDisposed)
						{
							clientWin.Focus();
						}
					}));
				}
				catch
				{
				}
			});
		}

		public void StatClientByWindow(HostServers sd)
		{
			string MstscParameter = Config.GetConfig().MstscParameter;
			this.StartProcess("mstsc", string.Format("/v:{0} {1}", sd.Server, MstscParameter));
		}

		// 用 tvnviewer（TightVNC）发起 VNC 远程连接，tvnviewer.exe 需放在本程序同目录下；不携带密码，由 tvnviewer 自行提示输入
		public void StatClientByTvnViewer(HostServers sd)
		{
			string HostAndPort = sd.Server;
			bool flag = sd.Port > 0 && sd.Port != 3389;
			if (flag)
			{
				HostAndPort = HostAndPort + ":" + sd.Port;
			}
			this.StartProcess(Application.StartupPath + "\\tvnviewer.exe", string.Format("-host={0}", HostAndPort));
		}

		public bool StartProcess(string filename, string arguments = "")
		{
			try
			{
				Process myprocess = new Process();
				ProcessStartInfo startInfo = new ProcessStartInfo(filename, arguments);
				myprocess.StartInfo = startInfo;
				myprocess.StartInfo.UseShellExecute = false;
				myprocess.Start();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("启动应用程序时出错！原因：" + ex.Message);
			}
			return false;
		}

		public void DeleteSelectHost()
		{
			bool flag = this.SelectHost.Count > 0;
			if (flag)
			{
				DialogResult dr = MessageBox.Show("是否删除选中的 " + this.SelectHost.Count.ToString() + " 个主机！", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				bool flag2 = dr == DialogResult.Yes;
				if (flag2)
				{
					for (int i = this.SelectHost.Count - 1; i >= 0; i--)
					{
						HostServers Item = this.SelectHost[i];
						this.HostDal.DeleteHost(Item.Id);
						this.HostInformation.Remove(Item);
					}
				}
			}
		}

		private void ShowMe()
		{
			bool flag = base.WindowState == FormWindowState.Minimized;
			if (flag)
			{
				base.WindowState = FormWindowState.Normal;
			}
			bool top = base.TopMost;
			base.TopMost = true;
			base.TopMost = top;
		}

		private void HostDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			this.SelectHost.Clear();
			DataGridViewSelectedRowCollection Rows = this.HostDataGridView.SelectedRows;
			foreach (object obj in Rows)
			{
				DataGridViewRow item = (DataGridViewRow)obj;
				int CurrId = item.Cells[0].Value.ToString().ToInt32(0, NumberStyles.Any, null);
				HostServers CurrHost = (from a in this.HostInformation
				where a.Id == CurrId
				select a).ToList<HostServers>()[0];
				this.SelectHost.Add(CurrHost);
			}
		}

		private void HostDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.StatClientSelect();
		}

		private void lvServerListsContextMenu_EditClientSettings_Click(object sender, EventArgs e)
		{
			bool flag = this.SelectHost.Count > 0;
			if (flag)
			{
				HostServers CurrItem = this.SelectHost[0];
				ServerSettings ssw = new ServerSettings(ref CurrItem);
				ssw.ShowDialog();
			}
		}

		private void lvServerListsContextMenu_DeleteClient_Click(object sender, EventArgs e)
		{
			this.DeleteSelectHost();
		}

		private void lvServerListsContextMenu_NewClient_Click(object sender, EventArgs e)
		{
			this.ShowNewForm(sender, e);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			bool flag = !this.CurrConfig.LoginPwd.IsNullOrEmpty();
			if (flag)
			{
				base.Hide();
				new LoginForm().ShowDialog();
				base.Show();
			}
		}

		private void MoveUp_Button_Click(object sender, EventArgs e)
		{
			bool flag = this.SelectHost.Count > 0;
			if (flag)
			{
				bool flag2 = this.SelectHost.Count == 1;
				if (flag2)
				{
					foreach (HostServers item in this.SelectHost)
					{
						item.SortNumber = this.HostDal.GetUpSortNumber(item.Id);
						this.HostDal.Update(item);
					}
					this.HostDataGridView.Sort(this.HostDataGridView.Columns[1], ListSortDirection.Ascending);
					this.HostDataGridView.ClearSelection();
				}
				else
				{
					MessageBox.Show("此功能仅支持选中单条！");
				}
			}
		}

		private void MoveDown_Button_Click(object sender, EventArgs e)
		{
			bool flag = this.SelectHost.Count > 0;
			if (flag)
			{
				bool flag2 = this.SelectHost.Count == 1;
				if (flag2)
				{
					foreach (HostServers item in this.SelectHost)
					{
						item.SortNumber = this.HostDal.GetDownSortNumber(item.Id);
						this.HostDal.Update(item);
					}
					this.HostDataGridView.Sort(this.HostDataGridView.Columns[1], ListSortDirection.Ascending);
					this.HostDataGridView.ClearSelection();
				}
				else
				{
					MessageBox.Show("此功能仅支持选中单条！");
				}
			}
		}

		private void DeleteClient_Button_Click(object sender, EventArgs e)
		{
			this.DeleteSelectHost();
		}

		private void Menu_Link_Click(object sender, EventArgs e)
		{
			this.StatClientSelect();
		}

		// 右键菜单：用 tvnviewer 连接选中主机（tvnviewer.exe 放在本程序同目录下）
		private void Menu_TvnViewerConnect_Click(object sender, EventArgs e)
		{
			bool flag = this.SelectHost.Count > 0;
			if (flag)
			{
				string TvnViewerPath = Application.StartupPath + "\\tvnviewer.exe";
				bool flag2 = !File.Exists(TvnViewerPath);
				if (flag2)
				{
					MessageBox.Show("未找到 tvnviewer.exe，请将其放到本程序所在目录：\r\n" + Application.StartupPath, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					foreach (HostServers item in this.SelectHost)
					{
						this.StatClientByTvnViewer(item);
					}
					this.SetState("已启动 tvnviewer 连接");
				}
			}
		}

		private void Button_Link_Click(object sender, EventArgs e)
		{
			this.StatClientSelect();
		}

		private void StateDetection_Button_Click(object sender, EventArgs e)
		{
			ClientStateDetection StateDetection = new ClientStateDetection(ref this.HostInformation, ref this.SelectHost);
			StateDetection.OnUpdateState += this.StateDetection_OnUpdateState;
			StateDetection.ShowDialog();
		}

		private void StateDetection_OnUpdateState()
		{
			try
			{
				base.Invoke(new EventHandler(delegate(object sender, EventArgs e)
				{
					this.HostDataGridView.Refresh();
				}));
			}
			catch (Exception)
			{
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			MainSettings Settings = new MainSettings();
			Settings.ShowDialog();
		}

		private void ExportRDP_Button_Click(object sender, EventArgs e)
		{
			ExportFile File = new ExportFile(this.SelectHost);
			File.ShowDialog();
		}

		private void CopyPwd_MenuItem_Click(object sender, EventArgs e)
		{
			foreach (HostServers item in this.SelectHost)
			{
				Clipboard.SetDataObject(item.Password);
			}
			this.SetState("复制成功");
		}

		private void CopyUserName_MenuItem_Click(object sender, EventArgs e)
		{
			foreach (HostServers item in this.SelectHost)
			{
				Clipboard.SetDataObject(item.Username);
			}
			this.SetState("复制成功");
		}

		private void CopyServer_MenuItem_Click(object sender, EventArgs e)
		{
			foreach (HostServers item in this.SelectHost)
			{
				Clipboard.SetDataObject(item.Server);
			}
			this.SetState("复制成功");
		}

		private void Copy_MenuItem_Click(object sender, EventArgs e)
		{
			foreach (HostServers Item in this.SelectHost)
			{
				HostServers hostServers = Item;
				hostServers.ServerName += "_复制";
				this.HostDal.Save(Item);
			}
			this.BintServerLists();
			this.SetState("复制成功");
		}

		private void SetState(string Text)
		{
			this.OperationStateLabel.Text = Text;
			this.DeleteStateTime.Start();
		}

		private void DeleteStateTime_Tick(object sender, EventArgs e)
		{
			this.OperationStateLabel.Text = "";
		}

		private void RemarksButton_Click(object sender, EventArgs e)
		{
			RemarksSettings Remarks = new RemarksSettings();
			Remarks.ShowDialog();
		}

		private void GroupingComboBox_TextChanged(object sender, EventArgs e)
		{
			this.Search_Text.Text = "";
			this.BintServerLists();
		}

		private void Search_Button_Click(object sender, EventArgs e)
		{
			this.BintServerLists();
		}

		private void Menu_BatchGrouping_Click(object sender, EventArgs e)
		{
			if (this.SelectHost.Count == 0)
			{
				MessageBox.Show("请先选择需要修改分组的主机！\r\n提示：按住 Ctrl 或 Shift 键可多选。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			using (BatchGroupingForm batchForm = new BatchGroupingForm())
			{
				if (batchForm.ShowDialog() == DialogResult.OK)
				{
					string selectedGroup = batchForm.SelectedGrouping;
					foreach (HostServers host in this.SelectHost)
					{
						host.Grouping = selectedGroup;
						this.HostDal.Update(host);
					}
					this.BintServerLists();
					this.SetState(string.Format("已将 {0} 台主机分组修改为: {1}", this.SelectHost.Count, selectedGroup));
				}
			}
		}

		private HostServersDal HostDal = new HostServersDal();

		private BindingCollection<HostServers> HostInformation = new BindingCollection<HostServers>();

		private BindingCollection<HostServers> SelectHost = new BindingCollection<HostServers>();

		private Config CurrConfig = Config.GetConfig();
	}
}
