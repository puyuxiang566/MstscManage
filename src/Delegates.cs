using System;
using System.Windows.Forms;
using AxMSTSCLib;
using MstscManage.Helper;

namespace MstscManage
{
	/// <summary>
	/// 应用服务器设置到客户端窗体时使用的委托。
	/// </summary>
	public delegate void ApplySettings(object sender, HostServers sd);

	/// <summary>
	/// 关闭客户端窗体时使用的委托。
	/// </summary>
	public delegate void CloseTistWindow();

	/// <summary>
	/// 远程会话连接成功时使用的委托。
	/// </summary>
	public delegate void Connected(object sender, EventArgs e, int ListIndex);

	/// <summary>
	/// 远程会话正在连接时使用的委托。
	/// </summary>
	public delegate void Connecting(object sender, EventArgs e, int ListIndex);

	/// <summary>
	/// 远程会话断开连接时使用的委托。
	/// </summary>
	public delegate void Disconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e, int ListIndex);

	/// <summary>
	/// 远程会话登录完成时使用的委托。
	/// </summary>
	public delegate void LoginComplete(object sender, EventArgs e, int ListIndex);

	/// <summary>
	/// 客户端窗体被激活时使用的委托。
	/// </summary>
	public delegate void OnFormActivated(object sender, EventArgs e, int ListIndex, IntPtr Handle);

	/// <summary>
	/// 客户端窗体关闭过程中使用的委托。
	/// </summary>
	public delegate void OnFormClosing(object sender, FormClosingEventArgs e, int ListIndex, IntPtr Handle);

	/// <summary>
	/// 客户端窗体首次显示时使用的委托。
	/// </summary>
	public delegate void OnFormShown(object sender, EventArgs e, int ListIndex, IntPtr Handle);

	/// <summary>
	/// 服务器设置发生变更时使用的委托。
	/// </summary>
	public delegate void ServerSettingsChanged(object sender, HostServers sd, int ListIndex);

	/// <summary>
	/// 刷新主界面状态时使用的委托。
	/// </summary>
	public delegate void UpdateState();
}
