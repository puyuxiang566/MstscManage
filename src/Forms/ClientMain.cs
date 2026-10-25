using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AxMSTSCLib;
using MSTSCLib;
using MstscManage.Helper;
using MstscManage.Properties;

namespace MstscManage
{
	public partial class ClientMain : Form
	{
		public event Connected Connected;

		public event Connecting Connecting;

		public event LoginComplete LoginComplete;

		public event Disconnected Disconnected;

		public new event OnFormClosing OnFormClosing;

		public event OnFormActivated OnFormActivated;

		public event OnFormShown OnFormShown;

		public ClientMain(HostServers sd)
		{
			this.InitializeComponent();
			this.InitializeControl(sd);
			this.InitializeControlEvents();
		}

		public void InitializeControl(HostServers sd)
		{
			this.rdpClient.DisconnectedText = "连接中，请稍后...";
			this._sd = sd;
			bool flag = sd.Server.IndexOf(":") != -1;
			if (flag)
			{
				string[] ServerItem = sd.Server.Split(new char[]
				{
					':'
				});
				this.rdpClient.Server = ServerItem[0];
				this.rdpClient.AdvancedSettings2.RDPPort = ServerItem[1].ToInt32(0, NumberStyles.Any, null);
			}
			else
			{
				this.rdpClient.Server = sd.Server;
			}
			this.rdpClient.UserName = sd.Username;
			// 先启用 CredSSP/NLA，再设置密码 — 确保密码通过 CredSSP 通道传递
			this.rdpClient.AdvancedSettings8.EnableCredSspSupport = true;
			this.rdpClient.AdvancedSettings8.AuthenticationLevel = 2U;
			this.rdpClient.AdvancedSettings2.ClearTextPassword = sd.Password;
			this.rdpClient.ColorDepth = sd.ColorDepth;
			this.rdpClient.DesktopWidth = sd.DesktopWidth;
			this.rdpClient.DesktopHeight = sd.DesktopHeight;
			this.rdpClient.FullScreen = sd.Fullscreen;
			base.Width = sd.DesktopWidth + 30;
			base.Height = sd.DesktopHeight + 100;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.rdpClient.AdvancedSettings2.allowBackgroundInput = -1;
			bool flag2 = sd.Port != 0;
			if (flag2)
			{
				this.rdpClient.AdvancedSettings2.RDPPort = sd.Port;
			}
			this.btnConnect.Enabled = false;
		}

		public void InitializeControlEvents()
		{
			base.Shown += this.RdpClientWindow_Shown;
			base.FormClosing += this.RdpClientWindow_FormClosing;
			base.Activated += this.RdpClientWindow_Activated;
			this.btnDisconnect.Click += this.ToolbarButtons_Click;
			this.btnConnect.Click += this.ToolbarButtons_Click;
			this.btnReconnect.Click += this.ToolbarButtons_Click;
			this.btnFullscreen.Click += this.ToolbarButtons_Click;
			this.btnFitToScreen.Click += this.ToolbarButtons_Click;
			this.rdpClient.OnConnecting += this.rdpClient_OnConnecting;
			this.rdpClient.OnConnected += this.rdpClient_OnConnected;
			this.rdpClient.OnLoginComplete += this.rdpClient_OnLoginComplete;
			this.rdpClient.OnDisconnected += this.rdpClient_OnDisconnected;
			this.rdpClient.OnAuthenticationWarningDisplayed += this.rdpClient_OnAuthenticationWarningDisplayed;
			this.btnSndKey_TaskManager.Click += this.SendKeys_Button_Click;
			this.imsRdpClientNonScriptable5_0 = (IMsRdpClientNonScriptable5)this.rdpClient.GetOcx();
			// 通过 DLR dynamic 设置 NonScriptable 接口上的 NLA 凭据属性:
			//   PromptForCredentials=false → 阻止弹出"你的凭据不工作"对话框
			//   Password → 直接传给 CredSSP 层，与 ClearTextPassword 走不同通道
			try
			{
				dynamic ns = this.rdpClient.GetOcx();
				ns.PromptForCredentials = false;
				ns.Password = this._sd.Password;
			}
			catch
			{
				// 低版本 RDP 控件可能不支持这些属性
			}
			List<string> SelectDiskList = Config.GetConfig().SelectDiskList.Split(new char[]
			{
				';'
			}).ToList<string>();
			int DriveCount = (int)((ulong)this.imsRdpClientNonScriptable5_0.DriveCollection.DriveCount - 1UL);
			for (int i = 0; i <= DriveCount; i++)
			{
				IMsRdpDrive drive = this.imsRdpClientNonScriptable5_0.DriveCollection.get_DriveByIndex((uint)i);
				string Name = drive.Name.Trim(new char[1]);
				drive.RedirectionState = SelectDiskList.Contains(Name);
			}
		}

		private void SendKeys_Button_Click(object sender, EventArgs e)
		{
			this.rdpClient.Focus();
			bool flag = sender == this.btnSndKey_TaskManager;
			if (flag)
			{
				SendKeys.Send("(^%{END})");
			}
		}

		private Rectangle ssw_GetClientWindowSize()
		{
			return this.rdpClient.RectangleToScreen(this.rdpClient.ClientRectangle);
		}

		private void ssw_ApplySettings(object sender, HostServers sd)
		{
			this._sd = sd;
			MessageBox.Show("即将重新连接。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.Reconnect(true, false, false);
		}

		private void rdpClient_OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
		{
			string reasonText = GetDisconnectReasonText(e.discReason);
			this.Status("已断开连接 " + this._sd.Server + "  [失败原因:" + reasonText + "]");
			this.btnConnect.Enabled = true;
			this.btnDisconnect.Enabled = false;
			bool flag = this.Disconnected != null;
			if (flag)
			{
				this.Disconnected(this, e, this._listIndex);
			}
		}

		private void rdpClient_OnAuthenticationWarningDisplayed(object sender, EventArgs e)
		{
			// NLA 凭据失败时弹出"你的凭据不工作"对话框时触发
			this.Status("认证警告: 远程主机要求 NLA 身份验证，请检查用户名/密码是否正确");
		}

		private void rdpClient_OnLoginComplete(object sender, EventArgs e)
		{
			this.Status("登陆使用" + this._sd.Username + " 用户账户");
			bool flag = this.LoginComplete != null;
			if (flag)
			{
				this.LoginComplete(this, e, this._listIndex);
			}
		}

		private void rdpClient_OnConnected(object sender, EventArgs e)
		{
			this.Status("连接到 " + this._sd.Server);
			Debug.WriteLine("连接 " + this.rdpClient.Connected.ToString());
			bool flag = this.Connected != null;
			if (flag)
			{
				this.Connected(this, e, this._listIndex);
			}
		}

		private void rdpClient_OnConnecting(object sender, EventArgs e)
		{
			this.Status("连接到 " + this._sd.Server);
			this.btnConnect.Enabled = false;
			this.btnDisconnect.Enabled = true;
			Debug.WriteLine("连接 " + this.rdpClient.Connected.ToString());
			bool flag = this.Connecting != null;
			if (flag)
			{
				this.Connecting(this, e, this._listIndex);
			}
		}

		private void ToolbarButtons_Click(object sender, EventArgs e)
		{
			bool flag = sender == this.btnDisconnect;
			if (flag)
			{
				this.Disconnect();
			}
			else
			{
				bool flag2 = sender == this.btnConnect;
				if (flag2)
				{
					this.Connect();
				}
				else
				{
					bool flag3 = sender == this.btnReconnect;
					if (flag3)
					{
						this.Reconnect(false, this._isFitToWindow, false);
					}
					else
					{
						bool flag4 = sender == this.btnFullscreen;
						if (flag4)
						{
							DialogResult dr = MessageBox.Show("即将进入全屏模式\r\n注意：此项操作需要重新连接远程主机。", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							bool flag5 = dr == DialogResult.Yes;
							if (flag5)
							{
								this.Reconnect(false, false, true);
							}
							else
							{
								this.rdpClient.FullScreen = true;
							}
						}
						else
						{
							bool flag6 = sender == this.btnFitToScreen;
							if (flag6)
							{
								DialogResult dr2 = MessageBox.Show("即将自动适应当前窗口分辨率\r\n注意：此项操作需要重新连接远程主机。", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								bool flag7 = dr2 == DialogResult.Yes;
								if (flag7)
								{
									this.Reconnect(true, true, false);
								}
							}
						}
					}
				}
			}
		}

		private void RdpClientWindow_Shown(object sender, EventArgs e)
		{
			bool flag = this.OnFormShown != null;
			if (flag)
			{
				this.OnFormShown(this, e, this._listIndex, base.Handle);
			}
			this.Connect();
		}

		private void RdpClientWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dr = MessageBox.Show("确实要关闭此窗口吗？", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
			bool flag = dr == DialogResult.Yes;
			if (flag)
			{
				this.Disconnect();
				this.rdpClient.Dispose();
				bool flag2 = this.OnFormClosing != null;
				if (flag2)
				{
					this.OnFormClosing(this, e, this._listIndex, base.Handle);
				}
			}
			else
			{
				e.Cancel = true;
			}
		}

		private void RdpClientWindow_Activated(object sender, EventArgs e)
		{
			bool flag = this.OnFormActivated != null;
			if (flag)
			{
				this.OnFormActivated(this, e, this._listIndex, base.Handle);
			}
		}

		public void Connect()
		{
			this.Status("启动中...");
			this.rdpClient.Connect();
		}

		public void Disconnect()
		{
			this.Status("断开中...");
			this.rdpClient.DisconnectedText = "已断开";
			bool flag = this.rdpClient.Connected != 0;
			if (flag)
			{
				this.rdpClient.Disconnect();
			}
		}

		public void Reconnect(bool hasChanges, bool isFitToWindow, bool isFullscreen)
		{
			this.Disconnect();
			this.Status("正在等待服务器断开连接...");
			while (this.rdpClient.Connected != 0)
			{
				Thread.Sleep(1000);
				Application.DoEvents();
			}
			this.Status("重新连接中 ...");
			if (hasChanges)
			{
				this.rdpClient.Server = this._sd.Server;
				this.rdpClient.UserName = this._sd.Username;
				this.rdpClient.AdvancedSettings2.ClearTextPassword = this._sd.Password;
				this.rdpClient.ColorDepth = this._sd.ColorDepth;
				this._isFitToWindow = isFitToWindow;
				if (isFitToWindow)
				{
					this.rdpClient.DesktopWidth = this.rdpClient.Width;
					this.rdpClient.DesktopHeight = this.rdpClient.Height;
				}
				else
				{
					this.rdpClient.DesktopWidth = this._sd.DesktopWidth;
					this.rdpClient.DesktopHeight = this._sd.DesktopHeight;
				}
				this.rdpClient.FullScreen = this._sd.Fullscreen;
			}
			if (isFullscreen)
			{
				this.rdpClient.DesktopWidth = Screen.PrimaryScreen.Bounds.Width;
				this.rdpClient.DesktopHeight = Screen.PrimaryScreen.Bounds.Height;
				this.rdpClient.FullScreen = true;
			}
			this.Connect();
		}

		public Image GetCurrentScreen()
		{
			return ControlToImage.CaptureControlImage(ref this.rdpClient);
		}

		private void Status(string stat)
		{
			this.lblStatus.Text = stat;
		}

		/// <summary>
		/// 将 RDP 断开原因码翻译为中文说明（依据微软官方 IMsTscAxEvents::OnDisconnected 文档）
		/// </summary>
		private string GetDisconnectReasonText(int discReason)
		{
			switch (discReason)
			{
				case 0: return "无信息";
				case 1: return "本地断开（非错误）";
				case 2: return "远程用户断开（非错误）";
				case 3: return "服务器断开（非错误）";
				case 260: return "DNS 名称解析失败";
				case 262: return "内存不足";
				case 264: return "连接超时";
				case 516: return "连接失败（无法建立连接，请检查主机是否在线、3389端口是否开放、防火墙是否放行）";
				case 518: return "内存不足";
				case 520: return "找不到主机（主机名/IP 无法解析）";
				case 772: return "网络发送失败";
				case 774: return "内存不足";
				case 776: return "IP 地址无效";
				case 1028: return "网络接收失败";
				case 1030: return "安全数据无效";
				case 1032: return "内部错误";
				case 1286: return "加密方法无效";
				case 1288: return "DNS 解析失败";
				case 1540: return "主机名解析失败 (gethostbyname)";
				case 1542: return "服务器安全数据无效";
				case 1544: return "内部定时器错误";
				case 1796: return "超时";
				case 1798: return "服务器证书解包失败";
				case 2052: return "IP 地址错误";
				case 2055: return "登录失败（用户名或密码错误）";
				case 2056: return "许可证协商失败";
				case 2308: return "套接字被关闭";
				case 2310: return "内部安全错误";
				case 2312: return "许可证超时";
				case 2566: return "内部安全错误";
				case 2822: return "加密错误";
				case 2823: return "账户已被禁用";
				case 3078: return "解密错误";
				case 3079: return "账户受限（无法登录）";
				case 3080: return "解压错误";
				case 3335: return "账户已被锁定";
				case 3591: return "账户已过期";
				case 5639: return "凭据委派策略不允许（无法向目标服务器委派凭据）";
				case 6151: return "无认证机构（域名错误、域不可达或信任关系失败）";
				case 6919: return "服务器证书已过期";
				case 8455: return "服务器认证策略不允许使用已保存的凭据连接，必须输入新凭据";
				default: return string.Format("原因码 {0} (0x{0:X})", discReason);
			}
		}

		public HostServers _sd;

		private int _listIndex = 0;

		private bool _isFitToWindow = false;

		private IMsRdpClientNonScriptable5 imsRdpClientNonScriptable5_0;
	}
}
