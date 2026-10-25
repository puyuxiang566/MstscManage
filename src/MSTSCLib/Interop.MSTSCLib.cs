using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Threading;


namespace MSTSCLib
{

[ComImport]
[Guid("336D5562-EFA8-482E-8CB3-C5C0FC7A7DB6")]
[InterfaceType(2)]
[TypeLibType(4096)]
public interface IMsTscAxEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1)]
	void OnConnecting();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(2)]
	void OnConnected();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(3)]
	void OnLoginComplete();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(4)]
	void OnDisconnected([In] int discReason);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(5)]
	void OnEnterFullScreenMode();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(6)]
	void OnLeaveFullScreenMode();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(7)]
	void OnChannelReceivedData([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string data);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(8)]
	void OnRequestGoFullScreen();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(9)]
	void OnRequestLeaveFullScreen();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(10)]
	void OnFatalError([In] int errorCode);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(11)]
	void OnWarning([In] int warningCode);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(12)]
	void OnRemoteDesktopSizeChange([In] int width, [In] int height);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(13)]
	void OnIdleTimeoutNotification();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(14)]
	void OnRequestContainerMinimize();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(15)]
	bool OnConfirmClose();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(16)]
	bool OnReceivedTSPublicKey([In][MarshalAs(UnmanagedType.BStr)] string publicKey);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(17)]
	[return: ComAliasName("MSTSCLib.AutoReconnectContinueState")]
	AutoReconnectContinueState OnAutoReconnecting([In] int disconnectReason, [In] int attemptCount);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(18)]
	void OnAuthenticationWarningDisplayed();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(19)]
	void OnAuthenticationWarningDismissed();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(20)]
	void OnRemoteProgramResult([In][MarshalAs(UnmanagedType.BStr)] string bstrRemoteProgram, [In][ComAliasName("MSTSCLib.RemoteProgramResult")] RemoteProgramResult lError, [In] bool vbIsExecutable);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(21)]
	void OnRemoteProgramDisplayed([In] bool vbDisplayed, [In] uint uDisplayInformation);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(29)]
	void OnRemoteWindowDisplayed([In] bool vbDisplayed, [In][ComAliasName("MSTSCLib.wireHWND")] ref _RemotableHandle hwnd, [In][ComAliasName("MSTSCLib.RemoteWindowDisplayedAttribute")] RemoteWindowDisplayedAttribute windowAttribute);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(22)]
	void OnLogonError([In] int lError);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(23)]
	void OnFocusReleased([In] int iDirection);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(24)]
	void OnUserNameAcquired([In][MarshalAs(UnmanagedType.BStr)] string bstrUserName);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(26)]
	void OnMouseInputModeChanged([In] bool fMouseModeRelative);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(28)]
	void OnServiceMessageReceived([In][MarshalAs(UnmanagedType.BStr)] string serviceMessage);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	void OnConnectionBarPullDown();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(32)]
	void OnNetworkStatusChanged([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	void OnDevicesButtonPressed();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	void OnAutoReconnected();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	void OnAutoReconnecting2([In] int disconnectReason, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
}
public enum AutoReconnectContinueState
{
	autoReconnectContinueAutomatic,
	autoReconnectContinueStop,
	autoReconnectContinueManual
}
public enum __MIDL___MIDL_itf_mstsax_0000_0043_0001
{
	autoReconnectContinueAutomatic,
	autoReconnectContinueStop,
	autoReconnectContinueManual
}
public enum RemoteProgramResult
{
	remoteAppResultOk,
	remoteAppResultLocked,
	remoteAppResultProtocolError,
	remoteAppResultNotInWhitelist,
	remoteAppResultNetworkPathDenied,
	remoteAppResultFileNotFound,
	remoteAppResultFailure,
	remoteAppResultHookNotLoaded
}
public enum __MIDL___MIDL_itf_mstsax_0000_0057_0001
{
	remoteAppResultOk,
	remoteAppResultLocked,
	remoteAppResultProtocolError,
	remoteAppResultNotInWhitelist,
	remoteAppResultNetworkPathDenied,
	remoteAppResultFileNotFound,
	remoteAppResultFailure,
	remoteAppResultHookNotLoaded
}
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct _RemotableHandle
{
	public int fContext;

	public __MIDL_IWinTypes_0009 u;
}
[StructLayout(LayoutKind.Explicit, Pack = 4)]
public struct __MIDL_IWinTypes_0009
{
	[FieldOffset(0)]
	public int hInproc;

	[FieldOffset(0)]
	public int hRemote;
}
public enum RemoteWindowDisplayedAttribute
{
	remoteAppWindowNone,
	remoteAppWindowDisplayed,
	remoteAppShellIconDisplayed
}
public enum __MIDL___MIDL_itf_mstsax_0000_0057_0002
{
	remoteAppWindowNone,
	remoteAppWindowDisplayed,
	remoteAppShellIconDisplayed
}
[ComImport]
[TypeLibType(34)]
[Guid("A41A4187-5A86-4E26-B40A-856F9035D9CB")]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[ClassInterface(ClassInterfaceType.None)]
public class MsTscAxNotSafeForScriptingClass
{
}
[TypeLibType(16)]
[ComVisible(false)]
public interface IMsTscAxEvents_Event
{
	event IMsTscAxEvents_OnConnectingEventHandler OnConnecting;

	event IMsTscAxEvents_OnConnectedEventHandler OnConnected;

	event IMsTscAxEvents_OnLoginCompleteEventHandler OnLoginComplete;

	event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	event IMsTscAxEvents_OnEnterFullScreenModeEventHandler OnEnterFullScreenMode;

	event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler OnLeaveFullScreenMode;

	event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	event IMsTscAxEvents_OnRequestGoFullScreenEventHandler OnRequestGoFullScreen;

	event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler OnRequestLeaveFullScreen;

	event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler OnIdleTimeoutNotification;

	event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler OnRequestContainerMinimize;

	event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler OnAuthenticationWarningDisplayed;

	event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler OnAuthenticationWarningDismissed;

	event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	event IMsTscAxEvents_OnConnectionBarPullDownEventHandler OnConnectionBarPullDown;

	event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	event IMsTscAxEvents_OnDevicesButtonPressedEventHandler OnDevicesButtonPressed;

	event IMsTscAxEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

	event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;
}
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnConnectingEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnConnectedEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnLoginCompleteEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnDisconnectedEventHandler([In] int discReason);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnEnterFullScreenModeEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnLeaveFullScreenModeEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnChannelReceivedDataEventHandler([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string data);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnRequestGoFullScreenEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnFatalErrorEventHandler([In] int errorCode);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnWarningEventHandler([In] int warningCode);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler([In] int width, [In] int height);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnRequestContainerMinimizeEventHandler();
[ComVisible(false)]
public delegate bool IMsTscAxEvents_OnConfirmCloseEventHandler();
[ComVisible(false)]
public delegate bool IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler([In][MarshalAs(UnmanagedType.BStr)] string publicKey);
[ComVisible(false)]
[return: ComAliasName("MSTSCLib.AutoReconnectContinueState")]
public delegate AutoReconnectContinueState IMsTscAxEvents_OnAutoReconnectingEventHandler([In] int disconnectReason, [In] int attemptCount);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnRemoteProgramResultEventHandler([In][MarshalAs(UnmanagedType.BStr)] string bstrRemoteProgram, [In][ComAliasName("MSTSCLib.RemoteProgramResult")] RemoteProgramResult lError, [In] bool vbIsExecutable);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler([In] bool vbDisplayed, [In] uint uDisplayInformation);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler([In] bool vbDisplayed, [In][ComAliasName("MSTSCLib.wireHWND")] ref _RemotableHandle hwnd, [In][ComAliasName("MSTSCLib.RemoteWindowDisplayedAttribute")] RemoteWindowDisplayedAttribute windowAttribute);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnLogonErrorEventHandler([In] int lError);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnFocusReleasedEventHandler([In] int iDirection);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnUserNameAcquiredEventHandler([In][MarshalAs(UnmanagedType.BStr)] string bstrUserName);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnMouseInputModeChangedEventHandler([In] bool fMouseModeRelative);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnServiceMessageReceivedEventHandler([In][MarshalAs(UnmanagedType.BStr)] string serviceMessage);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnConnectionBarPullDownEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnNetworkStatusChangedEventHandler([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnDevicesButtonPressedEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnAutoReconnectedEventHandler();
[ComVisible(false)]
public delegate void IMsTscAxEvents_OnAutoReconnecting2EventHandler([In] int disconnectReason, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
[ComImport]
[Guid("8C11EFAE-92C3-11D1-BC1E-00C04FA31489")]
[CoClass(typeof(MsTscAxNotSafeForScriptingClass))]
public interface MsTscAxNotSafeForScripting : IMsTscAx
{
}
[ComImport]
[TypeLibType(4160)]
[Guid("92B4A539-7115-4B7C-A5A9-E5D9EFC2780A")]
public interface IMsRdpClient : IMsTscAx
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	[DispId(103)]
	ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	ControlCloseStatus RequestClose();
}
[ComImport]
[TypeLibType(4160)]
[Guid("8C11EFAE-92C3-11D1-BC1E-00C04FA31489")]
public interface IMsTscAx : IMsTscAx_Redist
{
	[DispId(1)]
	string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);
}
[ComImport]
[Guid("327BB5CD-834E-4400-AEF2-B30E15E5D682")]
[TypeLibType(4160)]
public interface IMsTscAx_Redist
{
}
[ComImport]
[TypeLibType(4160)]
[Guid("C9D65442-A0F9-45B2-8F73-D61D2DB8CBB6")]
public interface IMsTscSecuredSettings
{
	[DispId(1)]
	string StartProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	string WorkDir
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	int FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		get;
	}
}
[ComImport]
[TypeLibType(4160)]
[Guid("809945CC-4B3B-4A92-A6B0-DBF9B5F2EF2D")]
public interface IMsTscAdvancedSettings
{
	[DispId(121)]
	int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}
}
[ComImport]
[Guid("209D0EB9-6254-47B1-9033-A98DAE55BB27")]
[TypeLibType(4176)]
public interface IMsTscDebug
{
	[DispId(200)]
	int HatchBitmapPDU
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(201)]
	int HatchSSBOrder
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		get;
	}

	[DispId(202)]
	int HatchMembltOrder
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		get;
	}

	[DispId(203)]
	int HatchIndexPDU
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		get;
	}

	[DispId(204)]
	int LabelMemblt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	int BitmapCacheMonitor
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(206)]
	int MallocFailuresPercent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
	}

	[DispId(207)]
	int MallocHugeFailuresPercent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
	}

	[DispId(208)]
	int NetThroughput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(208)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(208)]
		get;
	}

	[DispId(209)]
	string CLXCmdLine
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(209)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(209)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(210)]
	string CLXDll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	int RemoteProgramsHatchVisibleRegion
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	int RemoteProgramsHatchVisibleNoDataRegion
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	int RemoteProgramsHatchNonVisibleRegion
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(214)]
	int RemoteProgramsHatchWindow
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(214)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(214)]
		get;
	}

	[DispId(215)]
	int RemoteProgramsStayConnectOnBadCaps
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}

	[DispId(216)]
	uint ControlType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(217)]
	bool DecodeGfx
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		[param: In]
		set;
	}
}
[ComImport]
[TypeLibType(4160)]
[ComConversionLoss]
[Guid("3C65B4AB-12B3-465B-ACD4-B8DAD3BFF9E2")]
public interface IMsRdpClientAdvancedSettings : IMsTscAdvancedSettings
{
	[DispId(121)]
	new int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	new int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	new int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	new string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	new string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	new string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	new int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	new int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	new int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}

	[DispId(101)]
	int SmoothScroll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		get;
	}

	[DispId(102)]
	int AcceleratorPassthrough
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	int ShadowBitmap
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	[DispId(104)]
	int TransportType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[DispId(105)]
	int SasSequence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		get;
	}

	[DispId(106)]
	int EncryptionEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	int DedicatedTerminal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	int RDPPort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[DispId(109)]
	int EnableMouse
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		get;
	}

	[DispId(110)]
	int DisableCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		get;
	}

	[DispId(111)]
	int EnableWindowsKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		get;
	}

	[DispId(112)]
	int DoubleClickDetect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[DispId(113)]
	int MaximizeShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		get;
	}

	[DispId(114)]
	int HotKeyFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	int HotKeyCtrlEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	int HotKeyAltEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[DispId(117)]
	int HotKeyAltTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		get;
	}

	[DispId(118)]
	int HotKeyAltShiftTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[DispId(119)]
	int HotKeyAltSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		get;
	}

	[DispId(120)]
	int HotKeyCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		get;
	}

	[DispId(123)]
	int orderDrawThreshold
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
	}

	[DispId(124)]
	int BitmapCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
	}

	[DispId(125)]
	int BitmapVirtualCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
	}

	[DispId(175)]
	int ScaleBitmapCachesByBPP
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
	}

	[DispId(126)]
	int NumBitmapCaches
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
	}

	[DispId(127)]
	int CachePersistenceActive
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
	}

	[DispId(138)]
	string PersistCacheDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(156)]
	int brushSupportLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	int minInputSendInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	int InputEventsAtOnce
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[DispId(159)]
	int maxEventCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		get;
	}

	[DispId(160)]
	int keepAliveInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		get;
	}

	[DispId(163)]
	int shutdownTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		get;
	}

	[DispId(164)]
	int overallConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[DispId(165)]
	int singleConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		get;
	}

	[DispId(166)]
	int KeyboardType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		get;
	}

	[DispId(167)]
	int KeyboardSubType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		get;
	}

	[DispId(168)]
	int KeyboardFunctionKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		get;
	}

	[DispId(169)]
	int WinceFixedPalette
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		get;
	}

	[DispId(178)]
	bool ConnectToServerConsole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
	}

	[DispId(182)]
	int BitmapPersistence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
	}

	[DispId(183)]
	int MinutesToIdleTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
	}

	[DispId(184)]
	bool SmartSizing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[DispId(185)]
	string RdpdrLocalPrintingDocName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(201)]
	string RdpdrClipCleanTempDirString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(202)]
	string RdpdrClipPasteInfoString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(186)]
	string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(187)]
	bool DisplayConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		get;
	}

	[DispId(188)]
	bool PinConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		get;
	}

	[DispId(189)]
	bool GrabFocusOnConnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		get;
	}

	[DispId(190)]
	string LoadBalanceInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(191)]
	bool RedirectDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		get;
	}

	[DispId(192)]
	bool RedirectPrinters
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		get;
	}

	[DispId(193)]
	bool RedirectPorts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		get;
	}

	[DispId(194)]
	bool RedirectSmartCards
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		get;
	}

	[DispId(195)]
	int BitmapVirtualCache16BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		get;
	}

	[DispId(196)]
	int BitmapVirtualCache24BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		get;
	}

	[DispId(200)]
	int PerformanceFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(203)]
	IntPtr ConnectWithEndpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(204)]
	bool NotifyTSPublicKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}
}
[ComImport]
[Guid("605BEFCF-39C1-45CC-A811-068FB7BE346D")]
[TypeLibType(4160)]
public interface IMsRdpClientSecuredSettings : IMsTscSecuredSettings
{
	[DispId(1)]
	new string StartProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string WorkDir
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new int FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		get;
	}

	[DispId(4)]
	int KeyboardHookMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		get;
	}

	[DispId(5)]
	int AudioRedirectionMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		get;
	}
}
public enum ExtendedDisconnectReasonCode
{
	exDiscReasonNoInfo = 0,
	exDiscReasonAPIInitiatedDisconnect = 1,
	exDiscReasonAPIInitiatedLogoff = 2,
	exDiscReasonServerIdleTimeout = 3,
	exDiscReasonServerLogonTimeout = 4,
	exDiscReasonReplacedByOtherConnection = 5,
	exDiscReasonOutOfMemory = 6,
	exDiscReasonServerDeniedConnection = 7,
	exDiscReasonServerDeniedConnectionFips = 8,
	exDiscReasonServerInsufficientPrivileges = 9,
	exDiscReasonServerFreshCredsRequired = 10,
	exDiscReasonRpcInitiatedDisconnectByUser = 11,
	exDiscReasonLogoffByUser = 12,
	exDiscReasonLicenseInternal = 256,
	exDiscReasonLicenseNoLicenseServer = 257,
	exDiscReasonLicenseNoLicense = 258,
	exDiscReasonLicenseErrClientMsg = 259,
	exDiscReasonLicenseHwidDoesntMatchLicense = 260,
	exDiscReasonLicenseErrClientLicense = 261,
	exDiscReasonLicenseCantFinishProtocol = 262,
	exDiscReasonLicenseClientEndedProtocol = 263,
	exDiscReasonLicenseErrClientEncryption = 264,
	exDiscReasonLicenseCantUpgradeLicense = 265,
	exDiscReasonLicenseNoRemoteConnections = 266,
	exDiscReasonLicenseCreatingLicStoreAccDenied = 267,
	exDiscReasonRdpEncInvalidCredentials = 768,
	exDiscReasonProtocolRangeStart = 4096,
	exDiscReasonProtocolRangeEnd = 32767
}
public enum __MIDL___MIDL_itf_mstsax_0000_0000_0001
{
	exDiscReasonNoInfo = 0,
	exDiscReasonAPIInitiatedDisconnect = 1,
	exDiscReasonAPIInitiatedLogoff = 2,
	exDiscReasonServerIdleTimeout = 3,
	exDiscReasonServerLogonTimeout = 4,
	exDiscReasonReplacedByOtherConnection = 5,
	exDiscReasonOutOfMemory = 6,
	exDiscReasonServerDeniedConnection = 7,
	exDiscReasonServerDeniedConnectionFips = 8,
	exDiscReasonServerInsufficientPrivileges = 9,
	exDiscReasonServerFreshCredsRequired = 10,
	exDiscReasonRpcInitiatedDisconnectByUser = 11,
	exDiscReasonLogoffByUser = 12,
	exDiscReasonLicenseInternal = 256,
	exDiscReasonLicenseNoLicenseServer = 257,
	exDiscReasonLicenseNoLicense = 258,
	exDiscReasonLicenseErrClientMsg = 259,
	exDiscReasonLicenseHwidDoesntMatchLicense = 260,
	exDiscReasonLicenseErrClientLicense = 261,
	exDiscReasonLicenseCantFinishProtocol = 262,
	exDiscReasonLicenseClientEndedProtocol = 263,
	exDiscReasonLicenseErrClientEncryption = 264,
	exDiscReasonLicenseCantUpgradeLicense = 265,
	exDiscReasonLicenseNoRemoteConnections = 266,
	exDiscReasonLicenseCreatingLicStoreAccDenied = 267,
	exDiscReasonRdpEncInvalidCredentials = 768,
	exDiscReasonProtocolRangeStart = 4096,
	exDiscReasonProtocolRangeEnd = 32767
}
public enum ControlCloseStatus
{
	controlCloseCanProceed,
	controlCloseWaitForEvents
}
public enum __MIDL_IMsRdpClient_0001
{
	controlCloseCanProceed,
	controlCloseWaitForEvents
}
[ComImport]
[Guid("C1E6743A-41C1-4A74-832A-0DD06C1C7A0E")]
[InterfaceType(1)]
public interface IMsTscNonScriptable
{
	[DispId(1)]
	string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	string PortablePassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	string PortableSalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	string BinaryPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	string BinarySalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void ResetPassword();
}
[ComImport]
[InterfaceType(1)]
[Guid("2F079C4C-87B2-4AFD-97AB-20CDB43038AE")]
public interface IMsRdpClientNonScriptable : IMsTscNonScriptable
{
	[DispId(1)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	new string PortablePassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string PortableSalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string BinaryPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string BinarySalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void ResetPassword();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void NotifyRedirectDeviceChange([In][ComAliasName("MSTSCLib.UINT_PTR")] uint wParam, [In][ComAliasName("MSTSCLib.LONG_PTR")] int lParam);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);
}
[ComImport]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[Guid("1FB464C8-09BB-4017-A2F5-EB742F04392F")]
public class MsTscAxClass
{
}
[ComImport]
[Guid("8C11EFAE-92C3-11D1-BC1E-00C04FA31489")]
[CoClass(typeof(MsTscAxClass))]
public interface MsTscAx : IMsTscAx
{
}
[ComImport]
[TypeLibType(34)]
[Guid("7CACBD7B-0D99-468F-AC33-22E495C0AFE5")]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
public class MsRdpClientNotSafeForScriptingClass
{
}
[ComImport]
[Guid("92B4A539-7115-4B7C-A5A9-E5D9EFC2780A")]
[CoClass(typeof(MsRdpClientNotSafeForScriptingClass))]
public interface MsRdpClientNotSafeForScripting : IMsRdpClient
{
}
[ComImport]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[Guid("791FA017-2DE3-492E-ACC5-53C67A2B94D0")]
[ClassInterface(ClassInterfaceType.None)]
public class MsRdpClientClass
{
}
[ComImport]
[CoClass(typeof(MsRdpClientClass))]
[Guid("92B4A539-7115-4B7C-A5A9-E5D9EFC2780A")]
public interface MsRdpClient : IMsRdpClient
{
}
[ComImport]
[Guid("3523C2FB-4031-44E4-9A3B-F1E94986EE7F")]
[TypeLibType(34)]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
public class MsRdpClient2NotSafeForScriptingClass
{
}
[ComImport]
[CoClass(typeof(MsRdpClient2NotSafeForScriptingClass))]
[Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
public interface MsRdpClient2NotSafeForScripting : IMsRdpClient2
{
}
[ComImport]
[Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
[TypeLibType(4160)]
public interface IMsRdpClient2 : IMsRdpClient
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(64)]
		[DispId(99)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(103)]
	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
[ComImport]
[Guid("9AC42117-2B76-4320-AA44-0E616AB8437B")]
[TypeLibType(4160)]
public interface IMsRdpClientAdvancedSettings2 : IMsRdpClientAdvancedSettings
{
	[DispId(121)]
	new int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	new int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	new int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	new string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	new string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	new string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	new int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	new int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	new int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}

	[DispId(101)]
	new int SmoothScroll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		get;
	}

	[DispId(102)]
	new int AcceleratorPassthrough
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	new int ShadowBitmap
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	[DispId(104)]
	new int TransportType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[DispId(105)]
	new int SasSequence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		get;
	}

	[DispId(106)]
	new int EncryptionEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	new int DedicatedTerminal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	new int RDPPort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[DispId(109)]
	new int EnableMouse
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		get;
	}

	[DispId(110)]
	new int DisableCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		get;
	}

	[DispId(111)]
	new int EnableWindowsKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		get;
	}

	[DispId(112)]
	new int DoubleClickDetect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[DispId(113)]
	new int MaximizeShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		get;
	}

	[DispId(114)]
	new int HotKeyFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	new int HotKeyCtrlEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	new int HotKeyAltEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[DispId(117)]
	new int HotKeyAltTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		get;
	}

	[DispId(118)]
	new int HotKeyAltShiftTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[DispId(119)]
	new int HotKeyAltSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		get;
	}

	[DispId(120)]
	new int HotKeyCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		get;
	}

	[DispId(123)]
	new int orderDrawThreshold
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
	}

	[DispId(124)]
	new int BitmapCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
	}

	[DispId(125)]
	new int BitmapVirtualCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
	}

	[DispId(175)]
	new int ScaleBitmapCachesByBPP
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
	}

	[DispId(126)]
	new int NumBitmapCaches
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
	}

	[DispId(127)]
	new int CachePersistenceActive
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
	}

	[DispId(138)]
	new string PersistCacheDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(156)]
	new int brushSupportLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	new int minInputSendInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	new int InputEventsAtOnce
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[DispId(159)]
	new int maxEventCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		get;
	}

	[DispId(160)]
	new int keepAliveInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		get;
	}

	[DispId(163)]
	new int shutdownTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		get;
	}

	[DispId(164)]
	new int overallConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[DispId(165)]
	new int singleConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		get;
	}

	[DispId(166)]
	new int KeyboardType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		get;
	}

	[DispId(167)]
	new int KeyboardSubType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		get;
	}

	[DispId(168)]
	new int KeyboardFunctionKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		get;
	}

	[DispId(169)]
	new int WinceFixedPalette
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		get;
	}

	[DispId(178)]
	new bool ConnectToServerConsole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
	}

	[DispId(182)]
	new int BitmapPersistence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
	}

	[DispId(183)]
	new int MinutesToIdleTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
	}

	[DispId(184)]
	new bool SmartSizing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[DispId(185)]
	new string RdpdrLocalPrintingDocName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(201)]
	new string RdpdrClipCleanTempDirString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(202)]
	new string RdpdrClipPasteInfoString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(186)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(187)]
	new bool DisplayConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		get;
	}

	[DispId(188)]
	new bool PinConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		get;
	}

	[DispId(189)]
	new bool GrabFocusOnConnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		get;
	}

	[DispId(190)]
	new string LoadBalanceInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(191)]
	new bool RedirectDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		get;
	}

	[DispId(192)]
	new bool RedirectPrinters
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		get;
	}

	[DispId(193)]
	new bool RedirectPorts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		get;
	}

	[DispId(194)]
	new bool RedirectSmartCards
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		get;
	}

	[DispId(195)]
	new int BitmapVirtualCache16BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		get;
	}

	[DispId(196)]
	new int BitmapVirtualCache24BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		get;
	}

	[DispId(200)]
	new int PerformanceFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(203)]
	new IntPtr ConnectWithEndpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(204)]
	new bool NotifyTSPublicKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	bool CanAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(206)]
	bool EnableAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
	}

	[DispId(207)]
	int MaxReconnectAttempts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
	}
}
[ComImport]
[TypeLibType(34)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[Guid("9059F30F-4EB1-4BD2-9FDC-36F43A218F4A")]
[ClassInterface(ClassInterfaceType.None)]
public class MsRdpClient2Class
{
}
[ComImport]
[CoClass(typeof(MsRdpClient2Class))]
[Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
public interface MsRdpClient2 : IMsRdpClient2
{
}
[ComImport]
[TypeLibType(34)]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[Guid("971127BB-259F-48C2-BD75-5F97A3331551")]
public class MsRdpClient2aClass
{
}
[ComImport]
[Guid("E7E17DC4-3B71-4BA7-A8E6-281FFADCA28F")]
[CoClass(typeof(MsRdpClient2aClass))]
public interface MsRdpClient2a : IMsRdpClient2
{
}
[ComImport]
[Guid("ACE575FD-1FCF-4074-9401-EBAB990FA9DE")]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(34)]
public class MsRdpClient3NotSafeForScriptingClass
{
}
[ComImport]
[CoClass(typeof(MsRdpClient3NotSafeForScriptingClass))]
[Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
public interface MsRdpClient3NotSafeForScripting : IMsRdpClient3
{
}
[ComImport]
[TypeLibType(4160)]
[Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
public interface IMsRdpClient3 : IMsRdpClient2
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	[DispId(103)]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	new IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	new string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(300)]
	IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
[ComImport]
[Guid("19CD856B-C542-4C53-ACEE-F127E3BE1A59")]
[TypeLibType(4160)]
public interface IMsRdpClientAdvancedSettings3 : IMsRdpClientAdvancedSettings2
{
	[DispId(121)]
	new int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	new int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	new int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	new string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	new string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	new string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	new int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	new int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	new int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}

	[DispId(101)]
	new int SmoothScroll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		get;
	}

	[DispId(102)]
	new int AcceleratorPassthrough
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	new int ShadowBitmap
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	[DispId(104)]
	new int TransportType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[DispId(105)]
	new int SasSequence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		get;
	}

	[DispId(106)]
	new int EncryptionEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	new int DedicatedTerminal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	new int RDPPort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[DispId(109)]
	new int EnableMouse
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		get;
	}

	[DispId(110)]
	new int DisableCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		get;
	}

	[DispId(111)]
	new int EnableWindowsKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		get;
	}

	[DispId(112)]
	new int DoubleClickDetect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[DispId(113)]
	new int MaximizeShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		get;
	}

	[DispId(114)]
	new int HotKeyFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	new int HotKeyCtrlEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	new int HotKeyAltEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[DispId(117)]
	new int HotKeyAltTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		get;
	}

	[DispId(118)]
	new int HotKeyAltShiftTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[DispId(119)]
	new int HotKeyAltSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		get;
	}

	[DispId(120)]
	new int HotKeyCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		get;
	}

	[DispId(123)]
	new int orderDrawThreshold
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
	}

	[DispId(124)]
	new int BitmapCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
	}

	[DispId(125)]
	new int BitmapVirtualCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
	}

	[DispId(175)]
	new int ScaleBitmapCachesByBPP
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
	}

	[DispId(126)]
	new int NumBitmapCaches
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
	}

	[DispId(127)]
	new int CachePersistenceActive
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
	}

	[DispId(138)]
	new string PersistCacheDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(156)]
	new int brushSupportLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	new int minInputSendInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	new int InputEventsAtOnce
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[DispId(159)]
	new int maxEventCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		get;
	}

	[DispId(160)]
	new int keepAliveInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		get;
	}

	[DispId(163)]
	new int shutdownTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		get;
	}

	[DispId(164)]
	new int overallConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[DispId(165)]
	new int singleConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		get;
	}

	[DispId(166)]
	new int KeyboardType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		get;
	}

	[DispId(167)]
	new int KeyboardSubType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		get;
	}

	[DispId(168)]
	new int KeyboardFunctionKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		get;
	}

	[DispId(169)]
	new int WinceFixedPalette
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		get;
	}

	[DispId(178)]
	new bool ConnectToServerConsole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
	}

	[DispId(182)]
	new int BitmapPersistence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
	}

	[DispId(183)]
	new int MinutesToIdleTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
	}

	[DispId(184)]
	new bool SmartSizing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[DispId(185)]
	new string RdpdrLocalPrintingDocName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(201)]
	new string RdpdrClipCleanTempDirString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(202)]
	new string RdpdrClipPasteInfoString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(186)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(187)]
	new bool DisplayConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		get;
	}

	[DispId(188)]
	new bool PinConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		get;
	}

	[DispId(189)]
	new bool GrabFocusOnConnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		get;
	}

	[DispId(190)]
	new string LoadBalanceInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(191)]
	new bool RedirectDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		get;
	}

	[DispId(192)]
	new bool RedirectPrinters
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		get;
	}

	[DispId(193)]
	new bool RedirectPorts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		get;
	}

	[DispId(194)]
	new bool RedirectSmartCards
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		get;
	}

	[DispId(195)]
	new int BitmapVirtualCache16BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		get;
	}

	[DispId(196)]
	new int BitmapVirtualCache24BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		get;
	}

	[DispId(200)]
	new int PerformanceFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(203)]
	new IntPtr ConnectWithEndpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(204)]
	new bool NotifyTSPublicKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	new bool CanAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(206)]
	new bool EnableAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
	}

	[DispId(207)]
	new int MaxReconnectAttempts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
	}

	[DispId(210)]
	bool ConnectionBarShowMinimizeButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		get;
	}

	[DispId(211)]
	bool ConnectionBarShowRestoreButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}
}
[ComImport]
[Guid("7584C670-2274-4EFB-B00B-D6AABA6D3850")]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(34)]
public class MsRdpClient3Class
{
}
[ComImport]
[CoClass(typeof(MsRdpClient3Class))]
[Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
public interface MsRdpClient3 : IMsRdpClient3
{
}
[ComImport]
[Guid("6A6F4B83-45C5-4CA9-BDD9-0D81C12295E4")]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(34)]
public class MsRdpClient3aClass
{
}
[ComImport]
[CoClass(typeof(MsRdpClient3aClass))]
[Guid("91B7CBC5-A72E-4FA0-9300-D647D7E897FF")]
public interface MsRdpClient3a : IMsRdpClient3
{
}
[ComImport]
[Guid("6AE29350-321B-42BE-BBE5-12FB5270C0DE")]
[TypeLibType(34)]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
public class MsRdpClient4NotSafeForScriptingClass
{
}
[ComImport]
[Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
[CoClass(typeof(MsRdpClient4NotSafeForScriptingClass))]
public interface MsRdpClient4NotSafeForScripting : IMsRdpClient4
{
}
[ComImport]
[Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
[TypeLibType(4160)]
public interface IMsRdpClient4 : IMsRdpClient3
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(64)]
		[DispId(99)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(103)]
	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	new IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	new string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(300)]
	new IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(400)]
	IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
[ComImport]
[TypeLibType(4160)]
[Guid("FBA7F64E-7345-4405-AE50-FA4A763DC0DE")]
public interface IMsRdpClientAdvancedSettings4 : IMsRdpClientAdvancedSettings3
{
	[DispId(121)]
	new int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	new int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	new int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	new string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	new string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	new string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	new int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	new int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	new int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}

	[DispId(101)]
	new int SmoothScroll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		get;
	}

	[DispId(102)]
	new int AcceleratorPassthrough
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	new int ShadowBitmap
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	[DispId(104)]
	new int TransportType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[DispId(105)]
	new int SasSequence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		get;
	}

	[DispId(106)]
	new int EncryptionEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	new int DedicatedTerminal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	new int RDPPort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[DispId(109)]
	new int EnableMouse
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		get;
	}

	[DispId(110)]
	new int DisableCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		get;
	}

	[DispId(111)]
	new int EnableWindowsKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		get;
	}

	[DispId(112)]
	new int DoubleClickDetect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[DispId(113)]
	new int MaximizeShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		get;
	}

	[DispId(114)]
	new int HotKeyFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	new int HotKeyCtrlEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	new int HotKeyAltEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[DispId(117)]
	new int HotKeyAltTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		get;
	}

	[DispId(118)]
	new int HotKeyAltShiftTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[DispId(119)]
	new int HotKeyAltSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		get;
	}

	[DispId(120)]
	new int HotKeyCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		get;
	}

	[DispId(123)]
	new int orderDrawThreshold
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
	}

	[DispId(124)]
	new int BitmapCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
	}

	[DispId(125)]
	new int BitmapVirtualCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
	}

	[DispId(175)]
	new int ScaleBitmapCachesByBPP
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
	}

	[DispId(126)]
	new int NumBitmapCaches
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
	}

	[DispId(127)]
	new int CachePersistenceActive
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
	}

	[DispId(138)]
	new string PersistCacheDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(156)]
	new int brushSupportLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	new int minInputSendInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	new int InputEventsAtOnce
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[DispId(159)]
	new int maxEventCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		get;
	}

	[DispId(160)]
	new int keepAliveInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		get;
	}

	[DispId(163)]
	new int shutdownTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		get;
	}

	[DispId(164)]
	new int overallConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[DispId(165)]
	new int singleConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		get;
	}

	[DispId(166)]
	new int KeyboardType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		get;
	}

	[DispId(167)]
	new int KeyboardSubType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		get;
	}

	[DispId(168)]
	new int KeyboardFunctionKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		get;
	}

	[DispId(169)]
	new int WinceFixedPalette
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		get;
	}

	[DispId(178)]
	new bool ConnectToServerConsole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
	}

	[DispId(182)]
	new int BitmapPersistence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
	}

	[DispId(183)]
	new int MinutesToIdleTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
	}

	[DispId(184)]
	new bool SmartSizing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[DispId(185)]
	new string RdpdrLocalPrintingDocName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(201)]
	new string RdpdrClipCleanTempDirString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(202)]
	new string RdpdrClipPasteInfoString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(186)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(187)]
	new bool DisplayConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		get;
	}

	[DispId(188)]
	new bool PinConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		get;
	}

	[DispId(189)]
	new bool GrabFocusOnConnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		get;
	}

	[DispId(190)]
	new string LoadBalanceInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(191)]
	new bool RedirectDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		get;
	}

	[DispId(192)]
	new bool RedirectPrinters
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		get;
	}

	[DispId(193)]
	new bool RedirectPorts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		get;
	}

	[DispId(194)]
	new bool RedirectSmartCards
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		get;
	}

	[DispId(195)]
	new int BitmapVirtualCache16BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		get;
	}

	[DispId(196)]
	new int BitmapVirtualCache24BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		get;
	}

	[DispId(200)]
	new int PerformanceFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(203)]
	new IntPtr ConnectWithEndpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(204)]
	new bool NotifyTSPublicKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	new bool CanAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(206)]
	new bool EnableAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
	}

	[DispId(207)]
	new int MaxReconnectAttempts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
	}

	[DispId(210)]
	new bool ConnectionBarShowMinimizeButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		get;
	}

	[DispId(211)]
	new bool ConnectionBarShowRestoreButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	uint AuthenticationLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}
}
[ComImport]
[Guid("17A5E535-4072-4FA4-AF32-C8D0D47345E9")]
[InterfaceType(1)]
[ComConversionLoss]
public interface IMsRdpClientNonScriptable2 : IMsRdpClientNonScriptable
{
	[DispId(1)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	new string PortablePassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string PortableSalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string BinaryPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string BinarySalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void ResetPassword();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void NotifyRedirectDeviceChange([In][ComAliasName("MSTSCLib.UINT_PTR")] uint wParam, [In][ComAliasName("MSTSCLib.LONG_PTR")] int lParam);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

	[ComAliasName("MSTSCLib.wireHWND")]
	[DispId(13)]
	IntPtr UIParentWindowHandle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: ComAliasName("MSTSCLib.wireHWND")]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: ComAliasName("MSTSCLib.wireHWND")]
		get;
	}
}
[ComImport]
[ClassInterface(ClassInterfaceType.None)]
[Guid("4EDCB26C-D24C-4E72-AF07-B576699AC0DE")]
[TypeLibType(34)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
public class MsRdpClient4Class
{
}
[ComImport]
[Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
[CoClass(typeof(MsRdpClient4Class))]
public interface MsRdpClient4 : IMsRdpClient4
{
}
[ComImport]
[Guid("54CE37E0-9834-41AE-9896-4DAB69DC022B")]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(34)]
public class MsRdpClient4aClass
{
}
[ComImport]
[Guid("095E0738-D97D-488B-B9F6-DD0E8D66C0DE")]
[CoClass(typeof(MsRdpClient4aClass))]
public interface MsRdpClient4a : IMsRdpClient4
{
}
[ComImport]
[Guid("4EB2F086-C818-447E-B32C-C51CE2B30D31")]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(34)]
public class MsRdpClient5NotSafeForScriptingClass
{
}
[ComImport]
[Guid("4EB5335B-6429-477D-B922-E06A28ECD8BF")]
[CoClass(typeof(MsRdpClient5NotSafeForScriptingClass))]
public interface MsRdpClient5NotSafeForScripting : IMsRdpClient5
{
}
[ComImport]
[TypeLibType(4160)]
[Guid("4EB5335B-6429-477D-B922-E06A28ECD8BF")]
public interface IMsRdpClient5 : IMsRdpClient4
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(103)]
	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	new IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	new string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(300)]
	new IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(400)]
	new IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(500)]
	IMsRdpClientTransportSettings TransportSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(500)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(502)]
	IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(502)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(503)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

	[DispId(504)]
	ITSRemoteProgram RemoteProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(504)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(505)]
	IMsRdpClientShell MsRdpClientShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(505)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
[ComImport]
[TypeLibType(4160)]
[Guid("720298C0-A099-46F5-9F82-96921BAE4701")]
public interface IMsRdpClientTransportSettings
{
	[DispId(210)]
	string GatewayHostname
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	uint GatewayUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	uint GatewayProfileUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	uint GatewayCredsSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(216)]
	uint GatewayUserSelectedCredsSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(214)]
	int GatewayIsSupported
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(214)]
		get;
	}

	[DispId(215)]
	uint GatewayDefaultUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}
}
[ComImport]
[TypeLibType(4160)]
[Guid("FBA7F64E-6783-4405-DA45-FA4A763DABD0")]
public interface IMsRdpClientAdvancedSettings5 : IMsRdpClientAdvancedSettings4
{
	[DispId(121)]
	new int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	new int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	new int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	new string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	new string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	new string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	new int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	new int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	new int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}

	[DispId(101)]
	new int SmoothScroll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		get;
	}

	[DispId(102)]
	new int AcceleratorPassthrough
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	new int ShadowBitmap
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	[DispId(104)]
	new int TransportType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[DispId(105)]
	new int SasSequence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		get;
	}

	[DispId(106)]
	new int EncryptionEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	new int DedicatedTerminal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	new int RDPPort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[DispId(109)]
	new int EnableMouse
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		get;
	}

	[DispId(110)]
	new int DisableCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		get;
	}

	[DispId(111)]
	new int EnableWindowsKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		get;
	}

	[DispId(112)]
	new int DoubleClickDetect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[DispId(113)]
	new int MaximizeShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		get;
	}

	[DispId(114)]
	new int HotKeyFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	new int HotKeyCtrlEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	new int HotKeyAltEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[DispId(117)]
	new int HotKeyAltTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		get;
	}

	[DispId(118)]
	new int HotKeyAltShiftTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[DispId(119)]
	new int HotKeyAltSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		get;
	}

	[DispId(120)]
	new int HotKeyCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		get;
	}

	[DispId(123)]
	new int orderDrawThreshold
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
	}

	[DispId(124)]
	new int BitmapCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
	}

	[DispId(125)]
	new int BitmapVirtualCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
	}

	[DispId(175)]
	new int ScaleBitmapCachesByBPP
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
	}

	[DispId(126)]
	new int NumBitmapCaches
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
	}

	[DispId(127)]
	new int CachePersistenceActive
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
	}

	[DispId(138)]
	new string PersistCacheDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(156)]
	new int brushSupportLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	new int minInputSendInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	new int InputEventsAtOnce
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[DispId(159)]
	new int maxEventCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		get;
	}

	[DispId(160)]
	new int keepAliveInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		get;
	}

	[DispId(163)]
	new int shutdownTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		get;
	}

	[DispId(164)]
	new int overallConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[DispId(165)]
	new int singleConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		get;
	}

	[DispId(166)]
	new int KeyboardType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		get;
	}

	[DispId(167)]
	new int KeyboardSubType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		get;
	}

	[DispId(168)]
	new int KeyboardFunctionKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		get;
	}

	[DispId(169)]
	new int WinceFixedPalette
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		get;
	}

	[DispId(178)]
	new bool ConnectToServerConsole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
	}

	[DispId(182)]
	new int BitmapPersistence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
	}

	[DispId(183)]
	new int MinutesToIdleTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
	}

	[DispId(184)]
	new bool SmartSizing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[DispId(185)]
	new string RdpdrLocalPrintingDocName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(201)]
	new string RdpdrClipCleanTempDirString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(202)]
	new string RdpdrClipPasteInfoString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(186)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(187)]
	new bool DisplayConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		get;
	}

	[DispId(188)]
	new bool PinConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		get;
	}

	[DispId(189)]
	new bool GrabFocusOnConnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		get;
	}

	[DispId(190)]
	new string LoadBalanceInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(191)]
	new bool RedirectDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		get;
	}

	[DispId(192)]
	new bool RedirectPrinters
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		get;
	}

	[DispId(193)]
	new bool RedirectPorts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		get;
	}

	[DispId(194)]
	new bool RedirectSmartCards
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		get;
	}

	[DispId(195)]
	new int BitmapVirtualCache16BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		get;
	}

	[DispId(196)]
	new int BitmapVirtualCache24BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		get;
	}

	[DispId(200)]
	new int PerformanceFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(203)]
	new IntPtr ConnectWithEndpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(204)]
	new bool NotifyTSPublicKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	new bool CanAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(206)]
	new bool EnableAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
	}

	[DispId(207)]
	new int MaxReconnectAttempts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
	}

	[DispId(210)]
	new bool ConnectionBarShowMinimizeButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		get;
	}

	[DispId(211)]
	new bool ConnectionBarShowRestoreButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	new uint AuthenticationLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	bool RedirectClipboard
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(215)]
	uint AudioRedirectionMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}

	[DispId(216)]
	bool ConnectionBarShowPinButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(217)]
	bool PublicMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		get;
	}

	[DispId(218)]
	bool RedirectDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		get;
	}

	[DispId(219)]
	bool RedirectPOSDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		get;
	}

	[DispId(220)]
	int BitmapVirtualCache32BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		get;
	}
}
[ComImport]
[TypeLibType(4176)]
[Guid("FDD029F9-467A-4C49-8529-64B521DBD1B4")]
public interface ITSRemoteProgram
{
	[DispId(200)]
	bool RemoteProgramMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(201)]
	void ServerStartProgram([In][MarshalAs(UnmanagedType.BStr)] string bstrExecutablePath, [In][MarshalAs(UnmanagedType.BStr)] string bstrFilePath, [In][MarshalAs(UnmanagedType.BStr)] string bstrWorkingDirectory, [In] bool vbExpandEnvVarInWorkingDirectoryOnServer, [In][MarshalAs(UnmanagedType.BStr)] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);
}
[ComImport]
[TypeLibType(4160)]
[Guid("D012AE6D-C19A-4BFE-B367-201F8911F134")]
public interface IMsRdpClientShell
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(201)]
	void Launch();

	[DispId(202)]
	string RdpFileContents
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(203)]
	void SetRdpProperty([In][MarshalAs(UnmanagedType.BStr)] string szProperty, [In][MarshalAs(UnmanagedType.Struct)] object Value);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(204)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetRdpProperty([In][MarshalAs(UnmanagedType.BStr)] string szProperty);

	[DispId(205)]
	bool IsRemoteProgramClientInstalled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(211)]
	bool PublicMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(212)]
	void ShowTrustedSitesManagementDialog();
}
[ComImport]
[InterfaceType(1)]
[Guid("B3378D90-0728-45C7-8ED7-B6159FB92219")]
public interface IMsRdpClientNonScriptable3 : IMsRdpClientNonScriptable2
{
	[DispId(1)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	new string PortablePassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string PortableSalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string BinaryPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string BinarySalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void ResetPassword();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void NotifyRedirectDeviceChange([In][ComAliasName("MSTSCLib.UINT_PTR")] uint wParam, [In][ComAliasName("MSTSCLib.LONG_PTR")] int lParam);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

	[ComAliasName("MSTSCLib.wireHWND")]
	[DispId(13)]
	new IntPtr UIParentWindowHandle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: ComAliasName("MSTSCLib.wireHWND")]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: ComAliasName("MSTSCLib.wireHWND")]
		get;
	}

	[DispId(14)]
	bool ShowRedirectionWarningDialog
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(15)]
	bool PromptForCredentials
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(16)]
	bool NegotiateSecurityLayer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(17)]
	bool EnableCredSspSupport
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(21)]
	bool RedirectDynamicDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(20)]
	bool RedirectDynamicDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(18)]
	IMsRdpDeviceCollection DeviceCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(19)]
	IMsRdpDriveCollection DriveCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(23)]
	bool WarnAboutSendingCredentials
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(22)]
	bool WarnAboutClipboardRedirection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(24)]
	string ConnectionBarText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
[ComImport]
[Guid("56540617-D281-488C-8738-6A8FDF64A118")]
[InterfaceType(1)]
public interface IMsRdpDeviceCollection
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void RescanDevices([In] bool vboolDynRedir);

	// C# has no syntax for parameterized property 'DeviceByIndex';
	// tlbimp emits it as a get_ method, keeping the DispId for IDispatch binding.
	[DispId(228)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsRdpDevice get_DeviceByIndex([In] uint index);

	// C# has no syntax for parameterized property 'DeviceById';
	// tlbimp emits it as a get_ method, keeping the DispId for IDispatch binding.
	[DispId(227)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsRdpDevice get_DeviceById([In][MarshalAs(UnmanagedType.BStr)] string devInstanceId);

	[DispId(225)]
	uint DeviceCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
[ComImport]
[Guid("60C3B9C8-9E92-4F5E-A3E7-604A912093EA")]
[InterfaceType(1)]
public interface IMsRdpDevice
{
	[DispId(222)]
	string DeviceInstanceId
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(220)]
	string FriendlyName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(221)]
	string DeviceDescription
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(223)]
	bool RedirectionState
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
[ComImport]
[Guid("7FF17599-DA2C-4677-AD35-F60C04FE1585")]
[InterfaceType(1)]
public interface IMsRdpDriveCollection
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void RescanDrives(bool vboolDynRedir);

	// C# has no syntax for parameterized property 'DriveByIndex';
	// tlbimp emits it as a get_ method, keeping the DispId for IDispatch binding.
	[DispId(231)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IMsRdpDrive get_DriveByIndex([In] uint index);

	[DispId(233)]
	uint DriveCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
[ComImport]
[InterfaceType(1)]
[Guid("D28B5458-F694-47A8-8E61-40356A767E46")]
public interface IMsRdpDrive
{
	[DispId(229)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(230)]
	bool RedirectionState
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
[ComImport]
[Guid("4EB89FF4-7F78-4A0F-8B8D-2BF02E94E4B2")]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(34)]
[ClassInterface(ClassInterfaceType.None)]
public class MsRdpClient5Class
{
}
[ComImport]
[Guid("4EB5335B-6429-477D-B922-E06A28ECD8BF")]
[CoClass(typeof(MsRdpClient5Class))]
public interface MsRdpClient5 : IMsRdpClient5
{
}
[ComImport]
[Guid("D2EA46A7-C2BF-426B-AF24-E19C44456399")]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(34)]
public class MsRdpClient6NotSafeForScriptingClass
{
}
[ComImport]
[CoClass(typeof(MsRdpClient6NotSafeForScriptingClass))]
[Guid("D43B7D80-8517-4B6D-9EAC-96AD6800D7F2")]
public interface MsRdpClient6NotSafeForScripting : IMsRdpClient6
{
}
[ComImport]
[Guid("D43B7D80-8517-4B6D-9EAC-96AD6800D7F2")]
[TypeLibType(4160)]
public interface IMsRdpClient6 : IMsRdpClient5
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	[DispId(103)]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	new IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	new string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(300)]
	new IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(400)]
	new IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(500)]
	new IMsRdpClientTransportSettings TransportSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(500)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(502)]
	new IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(502)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(503)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

	[DispId(504)]
	new ITSRemoteProgram RemoteProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(504)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(505)]
	new IMsRdpClientShell MsRdpClientShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(505)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(507)]
	IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(507)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(506)]
	IMsRdpClientTransportSettings2 TransportSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(506)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
[ComImport]
[Guid("222C4B5D-45D9-4DF0-A7C6-60CF9089D285")]
[TypeLibType(4160)]
public interface IMsRdpClientAdvancedSettings6 : IMsRdpClientAdvancedSettings5
{
	[DispId(121)]
	new int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	new int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	new int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	new string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	new string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	new string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	new int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	new int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	new int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}

	[DispId(101)]
	new int SmoothScroll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		get;
	}

	[DispId(102)]
	new int AcceleratorPassthrough
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	new int ShadowBitmap
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	[DispId(104)]
	new int TransportType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[DispId(105)]
	new int SasSequence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		get;
	}

	[DispId(106)]
	new int EncryptionEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	new int DedicatedTerminal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	new int RDPPort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[DispId(109)]
	new int EnableMouse
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		get;
	}

	[DispId(110)]
	new int DisableCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		get;
	}

	[DispId(111)]
	new int EnableWindowsKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		get;
	}

	[DispId(112)]
	new int DoubleClickDetect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[DispId(113)]
	new int MaximizeShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		get;
	}

	[DispId(114)]
	new int HotKeyFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	new int HotKeyCtrlEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	new int HotKeyAltEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[DispId(117)]
	new int HotKeyAltTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		get;
	}

	[DispId(118)]
	new int HotKeyAltShiftTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[DispId(119)]
	new int HotKeyAltSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		get;
	}

	[DispId(120)]
	new int HotKeyCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		get;
	}

	[DispId(123)]
	new int orderDrawThreshold
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
	}

	[DispId(124)]
	new int BitmapCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
	}

	[DispId(125)]
	new int BitmapVirtualCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
	}

	[DispId(175)]
	new int ScaleBitmapCachesByBPP
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
	}

	[DispId(126)]
	new int NumBitmapCaches
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
	}

	[DispId(127)]
	new int CachePersistenceActive
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
	}

	[DispId(138)]
	new string PersistCacheDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(156)]
	new int brushSupportLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	new int minInputSendInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	new int InputEventsAtOnce
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[DispId(159)]
	new int maxEventCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		get;
	}

	[DispId(160)]
	new int keepAliveInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		get;
	}

	[DispId(163)]
	new int shutdownTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		get;
	}

	[DispId(164)]
	new int overallConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[DispId(165)]
	new int singleConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		get;
	}

	[DispId(166)]
	new int KeyboardType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		get;
	}

	[DispId(167)]
	new int KeyboardSubType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		get;
	}

	[DispId(168)]
	new int KeyboardFunctionKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		get;
	}

	[DispId(169)]
	new int WinceFixedPalette
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		get;
	}

	[DispId(178)]
	new bool ConnectToServerConsole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
	}

	[DispId(182)]
	new int BitmapPersistence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
	}

	[DispId(183)]
	new int MinutesToIdleTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
	}

	[DispId(184)]
	new bool SmartSizing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[DispId(185)]
	new string RdpdrLocalPrintingDocName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(201)]
	new string RdpdrClipCleanTempDirString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(202)]
	new string RdpdrClipPasteInfoString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(186)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(187)]
	new bool DisplayConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		get;
	}

	[DispId(188)]
	new bool PinConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		get;
	}

	[DispId(189)]
	new bool GrabFocusOnConnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		get;
	}

	[DispId(190)]
	new string LoadBalanceInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(191)]
	new bool RedirectDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		get;
	}

	[DispId(192)]
	new bool RedirectPrinters
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		get;
	}

	[DispId(193)]
	new bool RedirectPorts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		get;
	}

	[DispId(194)]
	new bool RedirectSmartCards
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		get;
	}

	[DispId(195)]
	new int BitmapVirtualCache16BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		get;
	}

	[DispId(196)]
	new int BitmapVirtualCache24BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		get;
	}

	[DispId(200)]
	new int PerformanceFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(203)]
	new IntPtr ConnectWithEndpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(204)]
	new bool NotifyTSPublicKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	new bool CanAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(206)]
	new bool EnableAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
	}

	[DispId(207)]
	new int MaxReconnectAttempts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
	}

	[DispId(210)]
	new bool ConnectionBarShowMinimizeButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		get;
	}

	[DispId(211)]
	new bool ConnectionBarShowRestoreButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	new uint AuthenticationLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	new bool RedirectClipboard
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(215)]
	new uint AudioRedirectionMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}

	[DispId(216)]
	new bool ConnectionBarShowPinButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(217)]
	new bool PublicMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		get;
	}

	[DispId(218)]
	new bool RedirectDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		get;
	}

	[DispId(219)]
	new bool RedirectPOSDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		get;
	}

	[DispId(220)]
	new int BitmapVirtualCache32BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		get;
	}

	[DispId(221)]
	bool RelativeMouseMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		get;
	}

	[DispId(222)]
	string AuthenticationServiceClass
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(223)]
	string PCB
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(224)]
	int HotKeyFocusReleaseLeft
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		get;
	}

	[DispId(225)]
	int HotKeyFocusReleaseRight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		get;
	}

	[DispId(17)]
	bool EnableCredSspSupport
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(226)]
	uint AuthenticationType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(226)]
		get;
	}

	[DispId(227)]
	bool ConnectToAdministerServer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		get;
	}
}
[ComImport]
[Guid("67341688-D606-4C73-A5D2-2E0489009319")]
[TypeLibType(4160)]
public interface IMsRdpClientTransportSettings2 : IMsRdpClientTransportSettings
{
	[DispId(210)]
	new string GatewayHostname
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	new uint GatewayUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	new uint GatewayProfileUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	new uint GatewayCredsSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(216)]
	new uint GatewayUserSelectedCredsSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(214)]
	new int GatewayIsSupported
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(214)]
		get;
	}

	[DispId(215)]
	new uint GatewayDefaultUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}

	[DispId(222)]
	uint GatewayCredSharing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		get;
	}

	[DispId(217)]
	uint GatewayPreAuthRequirement
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		get;
	}

	[DispId(218)]
	string GatewayPreAuthServerAddr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(219)]
	string GatewaySupportUrl
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(220)]
	string GatewayEncryptedOtpCookie
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(221)]
	uint GatewayEncryptedOtpCookieSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		get;
	}

	[DispId(223)]
	string GatewayUsername
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(224)]
	string GatewayDomain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(225)]
	string GatewayPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
[ComImport]
[InterfaceType(1)]
[Guid("F50FA8AA-1C7D-4F59-B15C-A90CACAE1FCB")]
public interface IMsRdpClientNonScriptable4 : IMsRdpClientNonScriptable3
{
	[DispId(1)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	new string PortablePassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string PortableSalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string BinaryPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string BinarySalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void ResetPassword();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void NotifyRedirectDeviceChange([In][ComAliasName("MSTSCLib.UINT_PTR")] uint wParam, [In][ComAliasName("MSTSCLib.LONG_PTR")] int lParam);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

	[ComAliasName("MSTSCLib.wireHWND")]
	[DispId(13)]
	new IntPtr UIParentWindowHandle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: ComAliasName("MSTSCLib.wireHWND")]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: ComAliasName("MSTSCLib.wireHWND")]
		get;
	}

	[DispId(14)]
	new bool ShowRedirectionWarningDialog
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(15)]
	new bool PromptForCredentials
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(16)]
	new bool NegotiateSecurityLayer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(17)]
	new bool EnableCredSspSupport
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(21)]
	new bool RedirectDynamicDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(20)]
	new bool RedirectDynamicDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(18)]
	new IMsRdpDeviceCollection DeviceCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(19)]
	new IMsRdpDriveCollection DriveCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(23)]
	new bool WarnAboutSendingCredentials
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(22)]
	new bool WarnAboutClipboardRedirection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(24)]
	new string ConnectionBarText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(25)]
	[ComAliasName("MSTSCLib.RedirectionWarningType")]
	RedirectionWarningType RedirectionWarningType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: ComAliasName("MSTSCLib.RedirectionWarningType")]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: ComAliasName("MSTSCLib.RedirectionWarningType")]
		get;
	}

	[DispId(28)]
	bool MarkRdpSettingsSecure
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(26)]
	object PublisherCertificateChain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(27)]
	bool WarnAboutPrinterRedirection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(29)]
	bool AllowCredentialSaving
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(30)]
	bool PromptForCredsOnClient
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(31)]
	bool LaunchedViaClientShellInterface
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(32)]
	bool TrustedZoneSite
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
public enum RedirectionWarningType
{
	RedirectionWarningTypeDefault = 0,
	RedirectionWarningTypeUnsigned = 1,
	RedirectionWarningTypeUnknown = 2,
	RedirectionWarningTypeUser = 3,
	RedirectionWarningTypeThirdPartySigned = 4,
	RedirectionWarningTypeTrusted = 5,
	RedirectionWarningTypeMax = RedirectionWarningTypeTrusted
}
public enum __MIDL_IMsRdpClientNonScriptable4_0001
{
	RedirectionWarningTypeDefault = 0,
	RedirectionWarningTypeUnsigned = 1,
	RedirectionWarningTypeUnknown = 2,
	RedirectionWarningTypeUser = 3,
	RedirectionWarningTypeThirdPartySigned = 4,
	RedirectionWarningTypeTrusted = 5,
	RedirectionWarningTypeMax = RedirectionWarningTypeTrusted
}
[ComImport]
[Guid("7390F3D8-0439-4C05-91E3-CF5CB290C3D0")]
[TypeLibType(34)]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
public class MsRdpClient6Class
{
}
[ComImport]
[Guid("D43B7D80-8517-4B6D-9EAC-96AD6800D7F2")]
[CoClass(typeof(MsRdpClient6Class))]
public interface MsRdpClient6 : IMsRdpClient6
{
}
[ComImport]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(34)]
[ClassInterface(ClassInterfaceType.None)]
[Guid("54D38BF7-B1EF-4479-9674-1BD6EA465258")]
public class MsRdpClient7NotSafeForScriptingClass
{
}
[ComImport]
[Guid("B2A5B5CE-3461-444A-91D4-ADD26D070638")]
[CoClass(typeof(MsRdpClient7NotSafeForScriptingClass))]
public interface MsRdpClient7NotSafeForScripting : IMsRdpClient7
{
}
[ComImport]
[Guid("B2A5B5CE-3461-444A-91D4-ADD26D070638")]
[TypeLibType(4160)]
public interface IMsRdpClient7 : IMsRdpClient6
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(103)]
	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	new IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	new string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(300)]
	new IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(400)]
	new IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(500)]
	new IMsRdpClientTransportSettings TransportSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(500)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(502)]
	new IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(502)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(503)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

	[DispId(504)]
	new ITSRemoteProgram RemoteProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(504)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(505)]
	new IMsRdpClientShell MsRdpClientShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(505)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(507)]
	new IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(507)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(506)]
	new IMsRdpClientTransportSettings2 TransportSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(506)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(600)]
	IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(600)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(601)]
	IMsRdpClientTransportSettings3 TransportSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(601)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(602)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetStatusText([In] uint statusCode);

	[DispId(603)]
	IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(603)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(604)]
	ITSRemoteProgram2 RemoteProgram2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(604)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
[ComImport]
[Guid("26036036-4010-4578-8091-0DB9A1EDF9C3")]
[TypeLibType(4160)]
public interface IMsRdpClientAdvancedSettings7 : IMsRdpClientAdvancedSettings6
{
	[DispId(121)]
	new int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	new int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	new int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	new string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	new string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	new string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	new int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	new int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	new int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}

	[DispId(101)]
	new int SmoothScroll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		get;
	}

	[DispId(102)]
	new int AcceleratorPassthrough
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	new int ShadowBitmap
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	[DispId(104)]
	new int TransportType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[DispId(105)]
	new int SasSequence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		get;
	}

	[DispId(106)]
	new int EncryptionEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	new int DedicatedTerminal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	new int RDPPort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[DispId(109)]
	new int EnableMouse
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		get;
	}

	[DispId(110)]
	new int DisableCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		get;
	}

	[DispId(111)]
	new int EnableWindowsKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		get;
	}

	[DispId(112)]
	new int DoubleClickDetect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[DispId(113)]
	new int MaximizeShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		get;
	}

	[DispId(114)]
	new int HotKeyFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	new int HotKeyCtrlEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	new int HotKeyAltEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[DispId(117)]
	new int HotKeyAltTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		get;
	}

	[DispId(118)]
	new int HotKeyAltShiftTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[DispId(119)]
	new int HotKeyAltSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		get;
	}

	[DispId(120)]
	new int HotKeyCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		get;
	}

	[DispId(123)]
	new int orderDrawThreshold
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
	}

	[DispId(124)]
	new int BitmapCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
	}

	[DispId(125)]
	new int BitmapVirtualCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
	}

	[DispId(175)]
	new int ScaleBitmapCachesByBPP
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
	}

	[DispId(126)]
	new int NumBitmapCaches
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
	}

	[DispId(127)]
	new int CachePersistenceActive
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
	}

	[DispId(138)]
	new string PersistCacheDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(156)]
	new int brushSupportLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	new int minInputSendInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	new int InputEventsAtOnce
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[DispId(159)]
	new int maxEventCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		get;
	}

	[DispId(160)]
	new int keepAliveInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		get;
	}

	[DispId(163)]
	new int shutdownTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		get;
	}

	[DispId(164)]
	new int overallConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[DispId(165)]
	new int singleConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		get;
	}

	[DispId(166)]
	new int KeyboardType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		get;
	}

	[DispId(167)]
	new int KeyboardSubType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		get;
	}

	[DispId(168)]
	new int KeyboardFunctionKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		get;
	}

	[DispId(169)]
	new int WinceFixedPalette
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		get;
	}

	[DispId(178)]
	new bool ConnectToServerConsole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
	}

	[DispId(182)]
	new int BitmapPersistence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
	}

	[DispId(183)]
	new int MinutesToIdleTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
	}

	[DispId(184)]
	new bool SmartSizing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[DispId(185)]
	new string RdpdrLocalPrintingDocName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(201)]
	new string RdpdrClipCleanTempDirString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(202)]
	new string RdpdrClipPasteInfoString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(186)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(187)]
	new bool DisplayConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		get;
	}

	[DispId(188)]
	new bool PinConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		get;
	}

	[DispId(189)]
	new bool GrabFocusOnConnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		get;
	}

	[DispId(190)]
	new string LoadBalanceInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(191)]
	new bool RedirectDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		get;
	}

	[DispId(192)]
	new bool RedirectPrinters
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		get;
	}

	[DispId(193)]
	new bool RedirectPorts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		get;
	}

	[DispId(194)]
	new bool RedirectSmartCards
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		get;
	}

	[DispId(195)]
	new int BitmapVirtualCache16BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		get;
	}

	[DispId(196)]
	new int BitmapVirtualCache24BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		get;
	}

	[DispId(200)]
	new int PerformanceFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(203)]
	new IntPtr ConnectWithEndpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(204)]
	new bool NotifyTSPublicKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	new bool CanAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(206)]
	new bool EnableAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
	}

	[DispId(207)]
	new int MaxReconnectAttempts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
	}

	[DispId(210)]
	new bool ConnectionBarShowMinimizeButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		get;
	}

	[DispId(211)]
	new bool ConnectionBarShowRestoreButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	new uint AuthenticationLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	new bool RedirectClipboard
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(215)]
	new uint AudioRedirectionMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}

	[DispId(216)]
	new bool ConnectionBarShowPinButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(217)]
	new bool PublicMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		get;
	}

	[DispId(218)]
	new bool RedirectDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		get;
	}

	[DispId(219)]
	new bool RedirectPOSDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		get;
	}

	[DispId(220)]
	new int BitmapVirtualCache32BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		get;
	}

	[DispId(221)]
	new bool RelativeMouseMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		get;
	}

	[DispId(222)]
	new string AuthenticationServiceClass
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(223)]
	new string PCB
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(224)]
	new int HotKeyFocusReleaseLeft
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		get;
	}

	[DispId(225)]
	new int HotKeyFocusReleaseRight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		get;
	}

	[DispId(17)]
	new bool EnableCredSspSupport
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(226)]
	new uint AuthenticationType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(226)]
		get;
	}

	[DispId(227)]
	new bool ConnectToAdministerServer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		get;
	}

	[DispId(228)]
	bool AudioCaptureRedirectionMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(228)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(228)]
		get;
	}

	[DispId(229)]
	uint VideoPlaybackMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(229)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(229)]
		get;
	}

	[DispId(230)]
	bool EnableSuperPan
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(230)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(230)]
		get;
	}

	[DispId(231)]
	uint SuperPanAccelerationFactor
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(231)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(231)]
		get;
	}

	[DispId(232)]
	bool NegotiateSecurityLayer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(232)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(232)]
		get;
	}

	[DispId(233)]
	uint AudioQualityMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(233)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(233)]
		get;
	}

	[DispId(234)]
	bool RedirectDirectX
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(234)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(234)]
		get;
	}

	[DispId(235)]
	uint NetworkConnectionType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(235)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(235)]
		get;
	}
}
[ComImport]
[Guid("3D5B21AC-748D-41DE-8F30-E15169586BD4")]
[TypeLibType(4160)]
public interface IMsRdpClientTransportSettings3 : IMsRdpClientTransportSettings2
{
	[DispId(210)]
	new string GatewayHostname
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	new uint GatewayUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	new uint GatewayProfileUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	new uint GatewayCredsSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(216)]
	new uint GatewayUserSelectedCredsSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(214)]
	new int GatewayIsSupported
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(214)]
		get;
	}

	[DispId(215)]
	new uint GatewayDefaultUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}

	[DispId(222)]
	new uint GatewayCredSharing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		get;
	}

	[DispId(217)]
	new uint GatewayPreAuthRequirement
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		get;
	}

	[DispId(218)]
	new string GatewayPreAuthServerAddr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(219)]
	new string GatewaySupportUrl
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(220)]
	new string GatewayEncryptedOtpCookie
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(221)]
	new uint GatewayEncryptedOtpCookieSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		get;
	}

	[DispId(223)]
	new string GatewayUsername
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(224)]
	new string GatewayDomain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(225)]
	new string GatewayPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(226)]
	uint GatewayCredSourceCookie
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(226)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(226)]
		get;
	}

	[DispId(227)]
	string GatewayAuthCookieServerAddr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(228)]
	string GatewayEncryptedAuthCookie
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(228)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(228)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(229)]
	uint GatewayEncryptedAuthCookieSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(229)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(229)]
		get;
	}

	[DispId(230)]
	string GatewayAuthLoginPage
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(230)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(230)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
[ComImport]
[TypeLibType(4160)]
[Guid("25F2CE20-8B1D-4971-A7CD-549DAE201FC0")]
public interface IMsRdpClientSecuredSettings2 : IMsRdpClientSecuredSettings
{
	[DispId(1)]
	new string StartProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string WorkDir
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new int FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		get;
	}

	[DispId(4)]
	new int KeyboardHookMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		get;
	}

	[DispId(5)]
	new int AudioRedirectionMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		get;
	}

	[DispId(6)]
	string PCB
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
[ComImport]
[TypeLibType(4176)]
[Guid("92C38A7D-241A-418C-9936-099872C9AF20")]
public interface ITSRemoteProgram2 : ITSRemoteProgram
{
	[DispId(200)]
	new bool RemoteProgramMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(201)]
	new void ServerStartProgram([In][MarshalAs(UnmanagedType.BStr)] string bstrExecutablePath, [In][MarshalAs(UnmanagedType.BStr)] string bstrFilePath, [In][MarshalAs(UnmanagedType.BStr)] string bstrWorkingDirectory, [In] bool vbExpandEnvVarInWorkingDirectoryOnServer, [In][MarshalAs(UnmanagedType.BStr)] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);

	[DispId(202)]
	string RemoteApplicationName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(203)]
	string RemoteApplicationProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(204)]
	string RemoteApplicationArgs
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
[ComImport]
[InterfaceType(1)]
[Guid("4F6996D5-D7B1-412C-B0FF-063718566907")]
public interface IMsRdpClientNonScriptable5 : IMsRdpClientNonScriptable4
{
	[DispId(1)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	new string PortablePassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string PortableSalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string BinaryPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string BinarySalt
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void ResetPassword();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void NotifyRedirectDeviceChange([In][ComAliasName("MSTSCLib.UINT_PTR")] uint wParam, [In][ComAliasName("MSTSCLib.LONG_PTR")] int lParam);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	new void SendKeys([In] int numKeys, [In] ref bool pbArrayKeyUp, [In] ref int plKeyData);

	[ComAliasName("MSTSCLib.wireHWND")]
	[DispId(13)]
	new IntPtr UIParentWindowHandle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: ComAliasName("MSTSCLib.wireHWND")]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: ComAliasName("MSTSCLib.wireHWND")]
		get;
	}

	[DispId(14)]
	new bool ShowRedirectionWarningDialog
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(15)]
	new bool PromptForCredentials
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(16)]
	new bool NegotiateSecurityLayer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(17)]
	new bool EnableCredSspSupport
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(21)]
	new bool RedirectDynamicDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(20)]
	new bool RedirectDynamicDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(18)]
	new IMsRdpDeviceCollection DeviceCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(19)]
	new IMsRdpDriveCollection DriveCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(23)]
	new bool WarnAboutSendingCredentials
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(22)]
	new bool WarnAboutClipboardRedirection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(24)]
	new string ConnectionBarText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[ComAliasName("MSTSCLib.RedirectionWarningType")]
	[DispId(25)]
	new RedirectionWarningType RedirectionWarningType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: ComAliasName("MSTSCLib.RedirectionWarningType")]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: ComAliasName("MSTSCLib.RedirectionWarningType")]
		get;
	}

	[DispId(28)]
	new bool MarkRdpSettingsSecure
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(26)]
	new object PublisherCertificateChain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(27)]
	new bool WarnAboutPrinterRedirection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(29)]
	new bool AllowCredentialSaving
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(30)]
	new bool PromptForCredsOnClient
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(31)]
	new bool LaunchedViaClientShellInterface
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(32)]
	new bool TrustedZoneSite
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(33)]
	bool UseMultimon
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(35)]
	uint RemoteMonitorCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void GetRemoteMonitorsBoundingBox(out int pLeft, out int pTop, out int pRight, out int pBottom);

	[DispId(37)]
	bool RemoteMonitorLayoutMatchesLocal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(38)]
	bool DisableConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}

	[DispId(39)]
	bool DisableRemoteAppCapsCheck
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(40)]
	bool WarnAboutDirectXRedirection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[DispId(41)]
	bool AllowPromptingForCredentials
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
[ComImport]
[Guid("FDD029F9-9574-4DEF-8529-64B521CCCAA4")]
[InterfaceType(1)]
public interface IMsRdpPreferredRedirectionInfo
{
	[DispId(1)]
	bool UseRedirectionServerName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}
}
[ComImport]
[Guid("302D8188-0052-4807-806A-362B628F9AC5")]
[InterfaceType(1)]
public interface IMsRdpExtendedSettings
{
	// C# has no syntax for parameterized property 'Property';
	// tlbimp emits it as a get_ method, keeping the DispId for IDispatch binding.
	[DispId(1)]
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object get_Property([In][MarshalAs(UnmanagedType.BStr)] string bstrPropertyName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void set_Property([In][MarshalAs(UnmanagedType.BStr)] string bstrPropertyName, [In][MarshalAs(UnmanagedType.Struct)] ref object pValue);
}
[ComImport]
[Guid("A9D7038D-B5ED-472E-9C47-94BEA90A5910")]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(2)]
public class MsRdpClient7Class
{
}
[ComImport]
[CoClass(typeof(MsRdpClient7Class))]
[Guid("B2A5B5CE-3461-444A-91D4-ADD26D070638")]
public interface MsRdpClient7 : IMsRdpClient7
{
}
[ComImport]
[Guid("A3BC03A0-041D-42E3-AD22-882B7865C9C5")]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(2)]
public class MsRdpClient8NotSafeForScriptingClass
{
}
[ComImport]
[CoClass(typeof(MsRdpClient8NotSafeForScriptingClass))]
[Guid("4247E044-9271-43A9-BC49-E2AD9E855D62")]
public interface MsRdpClient8NotSafeForScripting : IMsRdpClient8
{
}
[ComImport]
[Guid("4247E044-9271-43A9-BC49-E2AD9E855D62")]
[TypeLibType(4160)]
public interface IMsRdpClient8 : IMsRdpClient7
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(64)]
		[DispId(99)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	[DispId(103)]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	new IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	new string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(300)]
	new IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(400)]
	new IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(500)]
	new IMsRdpClientTransportSettings TransportSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(500)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(502)]
	new IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(502)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(503)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

	[DispId(504)]
	new ITSRemoteProgram RemoteProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(504)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(505)]
	new IMsRdpClientShell MsRdpClientShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(505)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(507)]
	new IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(507)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(506)]
	new IMsRdpClientTransportSettings2 TransportSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(506)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(600)]
	new IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(600)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(601)]
	new IMsRdpClientTransportSettings3 TransportSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(601)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(602)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetStatusText([In] uint statusCode);

	[DispId(603)]
	new IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(603)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(604)]
	new ITSRemoteProgram2 RemoteProgram2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(604)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(700)]
	void SendRemoteAction([In][ComAliasName("MSTSCLib.RemoteSessionActionType")] RemoteSessionActionType actionType);

	[DispId(701)]
	IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(701)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(702)]
	[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
	ControlReconnectStatus Reconnect([In] uint ulWidth, [In] uint ulHeight);
}
public enum RemoteSessionActionType
{
	RemoteSessionActionCharms,
	RemoteSessionActionAppbar,
	RemoteSessionActionSnap,
	RemoteSessionActionStartScreen,
	RemoteSessionActionAppSwitch,
	RemoteSessionActionActionCenter
}
public enum __MIDL___MIDL_itf_mstsax_0000_0000_0004
{
	RemoteSessionActionCharms,
	RemoteSessionActionAppbar,
	RemoteSessionActionSnap,
	RemoteSessionActionStartScreen,
	RemoteSessionActionAppSwitch,
	RemoteSessionActionActionCenter
}
[ComImport]
[Guid("89ACB528-2557-4D16-8625-226A30E97E9A")]
[TypeLibType(4160)]
public interface IMsRdpClientAdvancedSettings8 : IMsRdpClientAdvancedSettings7
{
	[DispId(121)]
	new int Compress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(121)]
		get;
	}

	[DispId(122)]
	new int BitmapPeristence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(122)]
		get;
	}

	[DispId(161)]
	new int allowBackgroundInput
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(161)]
		get;
	}

	[DispId(162)]
	new string KeyBoardLayoutStr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(162)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(170)]
	new string PluginDlls
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(170)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(171)]
	new string IconFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(171)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(172)]
	new int IconIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(172)]
		[param: In]
		set;
	}

	[DispId(173)]
	new int ContainerHandledFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(173)]
		get;
	}

	[DispId(174)]
	new int DisableRdpdr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(174)]
		get;
	}

	[DispId(101)]
	new int SmoothScroll
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		get;
	}

	[DispId(102)]
	new int AcceleratorPassthrough
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		get;
	}

	[DispId(103)]
	new int ShadowBitmap
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		get;
	}

	[DispId(104)]
	new int TransportType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[DispId(105)]
	new int SasSequence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(105)]
		get;
	}

	[DispId(106)]
	new int EncryptionEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(106)]
		get;
	}

	[DispId(107)]
	new int DedicatedTerminal
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(107)]
		get;
	}

	[DispId(108)]
	new int RDPPort
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(108)]
		get;
	}

	[DispId(109)]
	new int EnableMouse
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(109)]
		get;
	}

	[DispId(110)]
	new int DisableCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(110)]
		get;
	}

	[DispId(111)]
	new int EnableWindowsKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(111)]
		get;
	}

	[DispId(112)]
	new int DoubleClickDetect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(112)]
		get;
	}

	[DispId(113)]
	new int MaximizeShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(113)]
		get;
	}

	[DispId(114)]
	new int HotKeyFullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(114)]
		get;
	}

	[DispId(115)]
	new int HotKeyCtrlEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(115)]
		get;
	}

	[DispId(116)]
	new int HotKeyAltEsc
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(116)]
		get;
	}

	[DispId(117)]
	new int HotKeyAltTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(117)]
		get;
	}

	[DispId(118)]
	new int HotKeyAltShiftTab
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(118)]
		get;
	}

	[DispId(119)]
	new int HotKeyAltSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(119)]
		get;
	}

	[DispId(120)]
	new int HotKeyCtrlAltDel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(120)]
		get;
	}

	[DispId(123)]
	new int orderDrawThreshold
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(123)]
		get;
	}

	[DispId(124)]
	new int BitmapCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(124)]
		get;
	}

	[DispId(125)]
	new int BitmapVirtualCacheSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(125)]
		get;
	}

	[DispId(175)]
	new int ScaleBitmapCachesByBPP
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(175)]
		get;
	}

	[DispId(126)]
	new int NumBitmapCaches
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(126)]
		get;
	}

	[DispId(127)]
	new int CachePersistenceActive
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(127)]
		get;
	}

	[DispId(138)]
	new string PersistCacheDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(156)]
	new int brushSupportLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(156)]
		get;
	}

	[DispId(157)]
	new int minInputSendInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(157)]
		get;
	}

	[DispId(158)]
	new int InputEventsAtOnce
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(158)]
		get;
	}

	[DispId(159)]
	new int maxEventCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(159)]
		get;
	}

	[DispId(160)]
	new int keepAliveInterval
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(160)]
		get;
	}

	[DispId(163)]
	new int shutdownTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(163)]
		get;
	}

	[DispId(164)]
	new int overallConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(164)]
		get;
	}

	[DispId(165)]
	new int singleConnectionTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(165)]
		get;
	}

	[DispId(166)]
	new int KeyboardType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(166)]
		get;
	}

	[DispId(167)]
	new int KeyboardSubType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(167)]
		get;
	}

	[DispId(168)]
	new int KeyboardFunctionKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(168)]
		get;
	}

	[DispId(169)]
	new int WinceFixedPalette
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(169)]
		get;
	}

	[DispId(178)]
	new bool ConnectToServerConsole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(178)]
		get;
	}

	[DispId(182)]
	new int BitmapPersistence
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(182)]
		get;
	}

	[DispId(183)]
	new int MinutesToIdleTimeout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(183)]
		get;
	}

	[DispId(184)]
	new bool SmartSizing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(184)]
		get;
	}

	[DispId(185)]
	new string RdpdrLocalPrintingDocName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(185)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(201)]
	new string RdpdrClipCleanTempDirString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(202)]
	new string RdpdrClipPasteInfoString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(186)]
	new string ClearTextPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(186)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(187)]
	new bool DisplayConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(187)]
		get;
	}

	[DispId(188)]
	new bool PinConnectionBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(188)]
		get;
	}

	[DispId(189)]
	new bool GrabFocusOnConnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(189)]
		get;
	}

	[DispId(190)]
	new string LoadBalanceInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(190)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(191)]
	new bool RedirectDrives
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(191)]
		get;
	}

	[DispId(192)]
	new bool RedirectPrinters
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(192)]
		get;
	}

	[DispId(193)]
	new bool RedirectPorts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(193)]
		get;
	}

	[DispId(194)]
	new bool RedirectSmartCards
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(194)]
		get;
	}

	[DispId(195)]
	new int BitmapVirtualCache16BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(195)]
		get;
	}

	[DispId(196)]
	new int BitmapVirtualCache24BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(196)]
		get;
	}

	[DispId(200)]
	new int PerformanceFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[DispId(203)]
	new IntPtr ConnectWithEndpoint
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(204)]
	new bool NotifyTSPublicKey
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	new bool CanAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(205)]
		get;
	}

	[DispId(206)]
	new bool EnableAutoReconnect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(206)]
		get;
	}

	[DispId(207)]
	new int MaxReconnectAttempts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(207)]
		get;
	}

	[DispId(210)]
	new bool ConnectionBarShowMinimizeButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		get;
	}

	[DispId(211)]
	new bool ConnectionBarShowRestoreButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	new uint AuthenticationLevel
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	new bool RedirectClipboard
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(215)]
	new uint AudioRedirectionMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}

	[DispId(216)]
	new bool ConnectionBarShowPinButton
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(217)]
	new bool PublicMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		get;
	}

	[DispId(218)]
	new bool RedirectDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		get;
	}

	[DispId(219)]
	new bool RedirectPOSDevices
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		get;
	}

	[DispId(220)]
	new int BitmapVirtualCache32BppSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		get;
	}

	[DispId(221)]
	new bool RelativeMouseMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		get;
	}

	[DispId(222)]
	new string AuthenticationServiceClass
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(223)]
	new string PCB
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(224)]
	new int HotKeyFocusReleaseLeft
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		get;
	}

	[DispId(225)]
	new int HotKeyFocusReleaseRight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		get;
	}

	[DispId(17)]
	new bool EnableCredSspSupport
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(226)]
	new uint AuthenticationType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(226)]
		get;
	}

	[DispId(227)]
	new bool ConnectToAdministerServer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		get;
	}

	[DispId(228)]
	new bool AudioCaptureRedirectionMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(228)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(228)]
		get;
	}

	[DispId(229)]
	new uint VideoPlaybackMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(229)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(229)]
		get;
	}

	[DispId(230)]
	new bool EnableSuperPan
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(230)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(230)]
		get;
	}

	[DispId(231)]
	new uint SuperPanAccelerationFactor
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(231)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(231)]
		get;
	}

	[DispId(232)]
	new bool NegotiateSecurityLayer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(232)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(232)]
		get;
	}

	[DispId(233)]
	new uint AudioQualityMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(233)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(233)]
		get;
	}

	[DispId(234)]
	new bool RedirectDirectX
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(234)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(234)]
		get;
	}

	[DispId(235)]
	new uint NetworkConnectionType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(235)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(235)]
		get;
	}

	[DispId(236)]
	bool BandwidthDetection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(236)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(236)]
		get;
	}

	[DispId(237)]
	[ComAliasName("MSTSCLib.ClientSpec")]
	ClientSpec ClientProtocolSpec
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(237)]
		[param: In]
		[param: ComAliasName("MSTSCLib.ClientSpec")]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(237)]
		[return: ComAliasName("MSTSCLib.ClientSpec")]
		get;
	}
}
public enum ClientSpec
{
	FullMode,
	ThinClientMode,
	SmallCacheMode
}
public enum __MIDL___MIDL_itf_mstsax_0000_0000_0003
{
	FullMode,
	ThinClientMode,
	SmallCacheMode
}
public enum ControlReconnectStatus
{
	controlReconnectStarted,
	controlReconnectBlocked
}
public enum __MIDL_IMsRdpClient8_0001
{
	controlReconnectStarted,
	controlReconnectBlocked
}
[ComImport]
[Guid("5F681803-2900-4C43-A1CC-CF405404A676")]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(2)]
public class MsRdpClient8Class
{
}
[ComImport]
[CoClass(typeof(MsRdpClient8Class))]
[Guid("4247E044-9271-43A9-BC49-E2AD9E855D62")]
public interface MsRdpClient8 : IMsRdpClient8
{
}
[ComImport]
[Guid("8B918B82-7985-4C24-89DF-C33AD2BBFBCD")]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(2)]
public class MsRdpClient9NotSafeForScriptingClass
{
}
[ComImport]
[Guid("28904001-04B6-436C-A55B-0AF1A0883DC9")]
[CoClass(typeof(MsRdpClient9NotSafeForScriptingClass))]
public interface MsRdpClient9NotSafeForScripting : IMsRdpClient9
{
}
[ComImport]
[TypeLibType(4160)]
[Guid("28904001-04B6-436C-A55B-0AF1A0883DC9")]
public interface IMsRdpClient9 : IMsRdpClient8
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(103)]
	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	new IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	new string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(300)]
	new IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(400)]
	new IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(500)]
	new IMsRdpClientTransportSettings TransportSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(500)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(502)]
	new IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(502)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(503)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

	[DispId(504)]
	new ITSRemoteProgram RemoteProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(504)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(505)]
	new IMsRdpClientShell MsRdpClientShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(505)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(507)]
	new IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(507)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(506)]
	new IMsRdpClientTransportSettings2 TransportSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(506)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(600)]
	new IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(600)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(601)]
	new IMsRdpClientTransportSettings3 TransportSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(601)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(602)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetStatusText([In] uint statusCode);

	[DispId(603)]
	new IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(603)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(604)]
	new ITSRemoteProgram2 RemoteProgram2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(604)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(700)]
	new void SendRemoteAction([In][ComAliasName("MSTSCLib.RemoteSessionActionType")] RemoteSessionActionType actionType);

	[DispId(701)]
	new IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(701)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(702)]
	[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
	new ControlReconnectStatus Reconnect([In] uint ulWidth, [In] uint ulHeight);

	[DispId(800)]
	IMsRdpClientTransportSettings4 TransportSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(800)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(801)]
	void SyncSessionDisplaySettings();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(802)]
	void UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(803)]
	void attachEvent([In][MarshalAs(UnmanagedType.BStr)] string eventName, [In][MarshalAs(UnmanagedType.IDispatch)] object callback);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(804)]
	void detachEvent([In][MarshalAs(UnmanagedType.BStr)] string eventName, [In][MarshalAs(UnmanagedType.IDispatch)] object callback);
}
[ComImport]
[Guid("011C3236-4D81-4515-9143-067AB630D299")]
[TypeLibType(4160)]
public interface IMsRdpClientTransportSettings4 : IMsRdpClientTransportSettings3
{
	[DispId(210)]
	new string GatewayHostname
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	new uint GatewayUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(211)]
		get;
	}

	[DispId(212)]
	new uint GatewayProfileUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(212)]
		get;
	}

	[DispId(213)]
	new uint GatewayCredsSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(213)]
		get;
	}

	[DispId(216)]
	new uint GatewayUserSelectedCredsSource
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(216)]
		get;
	}

	[DispId(214)]
	new int GatewayIsSupported
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(214)]
		get;
	}

	[DispId(215)]
	new uint GatewayDefaultUsageMethod
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(215)]
		get;
	}

	[DispId(222)]
	new uint GatewayCredSharing
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(222)]
		get;
	}

	[DispId(217)]
	new uint GatewayPreAuthRequirement
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(217)]
		get;
	}

	[DispId(218)]
	new string GatewayPreAuthServerAddr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(218)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(219)]
	new string GatewaySupportUrl
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(219)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(220)]
	new string GatewayEncryptedOtpCookie
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(220)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(221)]
	new uint GatewayEncryptedOtpCookieSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(221)]
		get;
	}

	[DispId(223)]
	new string GatewayUsername
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(223)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(224)]
	new string GatewayDomain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(224)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(225)]
	new string GatewayPassword
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(225)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(226)]
	new uint GatewayCredSourceCookie
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(226)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(226)]
		get;
	}

	[DispId(227)]
	new string GatewayAuthCookieServerAddr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(227)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(228)]
	new string GatewayEncryptedAuthCookie
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(228)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(228)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(229)]
	new uint GatewayEncryptedAuthCookieSize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(229)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(229)]
		get;
	}

	[DispId(230)]
	new string GatewayAuthLoginPage
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(230)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(230)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(231)]
	uint GatewayBrokeringType
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(231)]
		[param: In]
		set;
	}
}
[ComImport]
[Guid("301B94BA-5D25-4A12-BFFE-3B6E7A616585")]
[TypeLibType(2)]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
public class MsRdpClient9Class
{
}
[ComImport]
[Guid("28904001-04B6-436C-A55B-0AF1A0883DC9")]
[CoClass(typeof(MsRdpClient9Class))]
public interface MsRdpClient9 : IMsRdpClient9
{
}
[ComImport]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(2)]
[ClassInterface(ClassInterfaceType.None)]
[Guid("A0C63C30-F08D-4AB4-907C-34905D770C7D")]
public class MsRdpClient10NotSafeForScriptingClass
{
}
[ComImport]
[CoClass(typeof(MsRdpClient10NotSafeForScriptingClass))]
[Guid("7ED92C39-EB38-4927-A70A-708AC5A59321")]
public interface MsRdpClient10NotSafeForScripting : IMsRdpClient10
{
}
[ComImport]
[Guid("7ED92C39-EB38-4927-A70A-708AC5A59321")]
[TypeLibType(4160)]
public interface IMsRdpClient10 : IMsRdpClient9
{
	[DispId(1)]
	new string Server
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	new string Domain
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(3)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(4)]
	new string DisconnectedText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(5)]
	new string ConnectingText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	new short Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(6)]
		get;
	}

	[DispId(12)]
	new int DesktopWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(12)]
		get;
	}

	[DispId(13)]
	new int DesktopHeight
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(13)]
		get;
	}

	[DispId(16)]
	new int StartConnected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(16)]
		get;
	}

	[DispId(17)]
	new int HorizontalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(17)]
		get;
	}

	[DispId(18)]
	new int VerticalScrollBarVisible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(18)]
		get;
	}

	[DispId(19)]
	new string FullScreenTitle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(19)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(20)]
	new int CipherStrength
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(20)]
		get;
	}

	[DispId(21)]
	new string Version
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(22)]
	new int SecuredSettingsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(22)]
		get;
	}

	[DispId(97)]
	new IMsTscSecuredSettings SecuredSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(98)]
	new IMsTscAdvancedSettings AdvancedSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(98)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(99)]
	new IMsTscDebug Debugger
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(99)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(30)]
	new void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(31)]
	new void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(33)]
	new void CreateVirtualChannels([In][MarshalAs(UnmanagedType.BStr)] string newVal);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(34)]
	new void SendOnVirtualChannel([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In][MarshalAs(UnmanagedType.BStr)] string ChanData);

	[DispId(100)]
	new int ColorDepth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		get;
	}

	[DispId(101)]
	new IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(102)]
	new IMsRdpClientSecuredSettings SecuredSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(102)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(103)]
	[ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
	new ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(103)]
		[return: ComAliasName("MSTSCLib.ExtendedDisconnectReasonCode")]
		get;
	}

	[DispId(104)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(104)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(35)]
	new void SetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName, [In] int chanOptions);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(36)]
	new int GetVirtualChannelOptions([In][MarshalAs(UnmanagedType.BStr)] string chanName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(37)]
	[return: ComAliasName("MSTSCLib.ControlCloseStatus")]
	new ControlCloseStatus RequestClose();

	[DispId(200)]
	new IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(201)]
	new string ConnectedStatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(300)]
	new IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(400)]
	new IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(500)]
	new IMsRdpClientTransportSettings TransportSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(500)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(502)]
	new IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(502)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(503)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetErrorDescription([In] uint disconnectReason, [In] uint ExtendedDisconnectReason);

	[DispId(504)]
	new ITSRemoteProgram RemoteProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(504)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(505)]
	new IMsRdpClientShell MsRdpClientShell
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(505)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(507)]
	new IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(507)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(506)]
	new IMsRdpClientTransportSettings2 TransportSettings2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(506)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(600)]
	new IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(600)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(601)]
	new IMsRdpClientTransportSettings3 TransportSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(601)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(602)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetStatusText([In] uint statusCode);

	[DispId(603)]
	new IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(603)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(604)]
	new ITSRemoteProgram2 RemoteProgram2
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(604)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(700)]
	new void SendRemoteAction([In][ComAliasName("MSTSCLib.RemoteSessionActionType")] RemoteSessionActionType actionType);

	[DispId(701)]
	new IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(701)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(702)]
	[return: ComAliasName("MSTSCLib.ControlReconnectStatus")]
	new ControlReconnectStatus Reconnect([In] uint ulWidth, [In] uint ulHeight);

	[DispId(800)]
	new IMsRdpClientTransportSettings4 TransportSettings4
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(800)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(801)]
	new void SyncSessionDisplaySettings();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(802)]
	new void UpdateSessionDisplaySettings([In] uint ulDesktopWidth, [In] uint ulDesktopHeight, [In] uint ulPhysicalWidth, [In] uint ulPhysicalHeight, [In] uint ulOrientation, [In] uint ulDesktopScaleFactor, [In] uint ulDeviceScaleFactor);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(803)]
	new void attachEvent([In][MarshalAs(UnmanagedType.BStr)] string eventName, [In][MarshalAs(UnmanagedType.IDispatch)] object callback);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(804)]
	new void detachEvent([In][MarshalAs(UnmanagedType.BStr)] string eventName, [In][MarshalAs(UnmanagedType.IDispatch)] object callback);

	[DispId(900)]
	ITSRemoteProgram3 RemoteProgram3
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(900)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
[ComImport]
[Guid("4B84EA77-ACEA-418C-881A-4A8C28AB1510")]
[TypeLibType(4176)]
public interface ITSRemoteProgram3 : ITSRemoteProgram2
{
	[DispId(200)]
	new bool RemoteProgramMode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(201)]
	new void ServerStartProgram([In][MarshalAs(UnmanagedType.BStr)] string bstrExecutablePath, [In][MarshalAs(UnmanagedType.BStr)] string bstrFilePath, [In][MarshalAs(UnmanagedType.BStr)] string bstrWorkingDirectory, [In] bool vbExpandEnvVarInWorkingDirectoryOnServer, [In][MarshalAs(UnmanagedType.BStr)] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);

	[DispId(202)]
	new string RemoteApplicationName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(202)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(203)]
	new string RemoteApplicationProgram
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(203)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(204)]
	new string RemoteApplicationArgs
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(204)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(205)]
	void ServerStartApp([In][MarshalAs(UnmanagedType.BStr)] string bstrAppUserModelId, [In][MarshalAs(UnmanagedType.BStr)] string bstrArguments, [In] bool vbExpandEnvVarInArgumentsOnServer);
}
[ComImport]
[Guid("C0EFA91A-EEB7-41C7-97FA-F0ED645EFB24")]
[ClassInterface(ClassInterfaceType.None)]
[ComSourceInterfaces("MSTSCLib.IMsTscAxEvents\0\0")]
[TypeLibType(2)]
public class MsRdpClient10Class
{
}
[ComImport]
[Guid("7ED92C39-EB38-4927-A70A-708AC5A59321")]
[CoClass(typeof(MsRdpClient10Class))]
public interface MsRdpClient10 : IMsRdpClient10
{
}
[ComImport]
[TypeLibType(4096)]
[InterfaceType(2)]
[Guid("079863B7-6D47-4105-8BFE-0CDCB360E67D")]
public interface IRemoteDesktopClientEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(750)]
	void OnConnecting();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(751)]
	void OnConnected();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(752)]
	void OnLoginCompleted();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(753)]
	void OnDisconnected([In] int disconnectReason, [In] int ExtendedDisconnectReason, [In][MarshalAs(UnmanagedType.BStr)] string disconnectErrorMessage);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(754)]
	void OnStatusChanged([In] int statusCode, [In][MarshalAs(UnmanagedType.BStr)] string statusMessage);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(755)]
	void OnAutoReconnecting([In] int disconnectReason, [In] int ExtendedDisconnectReason, [In][MarshalAs(UnmanagedType.BStr)] string disconnectErrorMessage, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(756)]
	void OnAutoReconnected();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(757)]
	void OnDialogDisplaying();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(758)]
	void OnDialogDismissed();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(759)]
	void OnNetworkStatusChanged([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(760)]
	void OnAdminMessageReceived([In][MarshalAs(UnmanagedType.BStr)] string adminMessage);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(761)]
	void OnKeyCombinationPressed([In] int keyCombination);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(762)]
	void OnRemoteDesktopSizeChanged([In] int width, [In] int height);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(800)]
	void OnTouchPointerCursorMoved([In] int x, [In] int y);
}
[ComImport]
[ComSourceInterfaces("MSTSCLib.IRemoteDesktopClientEvents\0\0")]
[TypeLibType(2)]
[ClassInterface(ClassInterfaceType.None)]
[Guid("EAB16C5D-EED1-4E95-868B-0FBA1B42C092")]
public class RemoteDesktopClientClass
{
}
[ComVisible(false)]
[TypeLibType(16)]
public interface IRemoteDesktopClientEvents_Event
{
	event IRemoteDesktopClientEvents_OnConnectingEventHandler OnConnecting;

	event IRemoteDesktopClientEvents_OnConnectedEventHandler OnConnected;

	event IRemoteDesktopClientEvents_OnLoginCompletedEventHandler OnLoginCompleted;

	event IRemoteDesktopClientEvents_OnDisconnectedEventHandler OnDisconnected;

	event IRemoteDesktopClientEvents_OnStatusChangedEventHandler OnStatusChanged;

	event IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	event IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler OnAutoReconnected;

	event IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler OnDialogDisplaying;

	event IRemoteDesktopClientEvents_OnDialogDismissedEventHandler OnDialogDismissed;

	event IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	event IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler OnAdminMessageReceived;

	event IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler OnKeyCombinationPressed;

	event IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler OnRemoteDesktopSizeChanged;

	event IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler OnTouchPointerCursorMoved;
}
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnConnectingEventHandler();
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnConnectedEventHandler();
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnLoginCompletedEventHandler();
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnDisconnectedEventHandler([In] int disconnectReason, [In] int ExtendedDisconnectReason, [In][MarshalAs(UnmanagedType.BStr)] string disconnectErrorMessage);
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnStatusChangedEventHandler([In] int statusCode, [In][MarshalAs(UnmanagedType.BStr)] string statusMessage);
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler([In] int disconnectReason, [In] int ExtendedDisconnectReason, [In][MarshalAs(UnmanagedType.BStr)] string disconnectErrorMessage, [In] bool networkAvailable, [In] int attemptCount, [In] int maxAttemptCount);
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler();
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler();
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnDialogDismissedEventHandler();
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler([In] uint qualityLevel, [In] int bandwidth, [In] int rtt);
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler([In][MarshalAs(UnmanagedType.BStr)] string adminMessage);
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler([In] int keyCombination);
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler([In] int width, [In] int height);
[ComVisible(false)]
public delegate void IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler([In] int x, [In] int y);
[ComImport]
[Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
[CoClass(typeof(RemoteDesktopClientClass))]
public interface RemoteDesktopClient : IRemoteDesktopClient
{
}
[ComImport]
[TypeLibType(4160)]
[Guid("57D25668-625A-4905-BE4E-304CAA13F89C")]
public interface IRemoteDesktopClient
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(701)]
	void Connect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(702)]
	void Disconnect();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(703)]
	void Reconnect([In] uint width, [In] uint height);

	[DispId(710)]
	IRemoteDesktopClientSettings Settings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(710)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(711)]
	IRemoteDesktopClientActions Actions
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(711)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(712)]
	IRemoteDesktopClientTouchPointer TouchPointer
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(712)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(704)]
	void DeleteSavedCredentials([In][MarshalAs(UnmanagedType.BStr)] string serverName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(705)]
	void UpdateSessionDisplaySettings([In] uint width, [In] uint height);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(706)]
	void attachEvent([In][MarshalAs(UnmanagedType.BStr)] string eventName, [In][MarshalAs(UnmanagedType.IDispatch)] object callback);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(707)]
	void detachEvent([In][MarshalAs(UnmanagedType.BStr)] string eventName, [In][MarshalAs(UnmanagedType.IDispatch)] object callback);
}
[ComImport]
[Guid("48A0F2A7-2713-431F-BBAC-6F4558E7D64D")]
[TypeLibType(4160)]
public interface IRemoteDesktopClientSettings
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(722)]
	void ApplySettings([In][MarshalAs(UnmanagedType.BStr)] string RdpFileContents);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(723)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string RetrieveSettings();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(721)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetRdpProperty([In][MarshalAs(UnmanagedType.BStr)] string propertyName);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(720)]
	void SetRdpProperty([In][MarshalAs(UnmanagedType.BStr)] string propertyName, [In][MarshalAs(UnmanagedType.Struct)] object Value);
}
[ComImport]
[Guid("7D54BC4E-1028-45D4-8B0A-B9B6BFFBA176")]
[TypeLibType(4160)]
public interface IRemoteDesktopClientActions
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(730)]
	void SuspendScreenUpdates();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(731)]
	void ResumeScreenUpdates();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(732)]
	void ExecuteRemoteAction([In][ComAliasName("MSTSCLib.RemoteActionType")] RemoteActionType remoteAction);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(733)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetSnapshot([In][ComAliasName("MSTSCLib.SnapshotEncodingType")] SnapshotEncodingType snapshotEncoding, [In][ComAliasName("MSTSCLib.SnapshotFormatType")] SnapshotFormatType snapshotFormat, [In] uint snapshotWidth, [In] uint snapshotHeight);
}
public enum RemoteActionType
{
	RemoteActionCharms,
	RemoteActionAppbar,
	RemoteActionSnap,
	RemoteActionStartScreen,
	RemoteActionAppSwitch
}
public enum __MIDL_IRemoteDesktopClientActions_0001
{
	RemoteActionCharms,
	RemoteActionAppbar,
	RemoteActionSnap,
	RemoteActionStartScreen,
	RemoteActionAppSwitch
}
public enum SnapshotEncodingType
{
	SnapshotEncodingDataUri
}
public enum __MIDL_IRemoteDesktopClientActions_0002
{
	SnapshotEncodingDataUri
}
public enum SnapshotFormatType
{
	SnapshotFormatPng,
	SnapshotFormatJpeg,
	SnapshotFormatBmp
}
public enum __MIDL_IRemoteDesktopClientActions_0003
{
	SnapshotFormatPng,
	SnapshotFormatJpeg,
	SnapshotFormatBmp
}
[ComImport]
[Guid("260EC22D-8CBC-44B5-9E88-2A37F6C93AE9")]
[TypeLibType(4160)]
public interface IRemoteDesktopClientTouchPointer
{
	[DispId(740)]
	bool Enabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(740)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(740)]
		get;
	}

	[DispId(741)]
	bool EventsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(741)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(741)]
		get;
	}

	[DispId(742)]
	uint PointerSpeed
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(742)]
		[param: In]
		set;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(742)]
		get;
	}
}
[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class IMsTscAxEvents_SinkHelper : IMsTscAxEvents
{
	public IMsTscAxEvents_OnConnectingEventHandler m_OnConnectingDelegate;

	public IMsTscAxEvents_OnConnectedEventHandler m_OnConnectedDelegate;

	public IMsTscAxEvents_OnLoginCompleteEventHandler m_OnLoginCompleteDelegate;

	public IMsTscAxEvents_OnDisconnectedEventHandler m_OnDisconnectedDelegate;

	public IMsTscAxEvents_OnEnterFullScreenModeEventHandler m_OnEnterFullScreenModeDelegate;

	public IMsTscAxEvents_OnLeaveFullScreenModeEventHandler m_OnLeaveFullScreenModeDelegate;

	public IMsTscAxEvents_OnChannelReceivedDataEventHandler m_OnChannelReceivedDataDelegate;

	public IMsTscAxEvents_OnRequestGoFullScreenEventHandler m_OnRequestGoFullScreenDelegate;

	public IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler m_OnRequestLeaveFullScreenDelegate;

	public IMsTscAxEvents_OnFatalErrorEventHandler m_OnFatalErrorDelegate;

	public IMsTscAxEvents_OnWarningEventHandler m_OnWarningDelegate;

	public IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler m_OnRemoteDesktopSizeChangeDelegate;

	public IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler m_OnIdleTimeoutNotificationDelegate;

	public IMsTscAxEvents_OnRequestContainerMinimizeEventHandler m_OnRequestContainerMinimizeDelegate;

	public IMsTscAxEvents_OnConfirmCloseEventHandler m_OnConfirmCloseDelegate;

	public IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler m_OnReceivedTSPublicKeyDelegate;

	public IMsTscAxEvents_OnAutoReconnectingEventHandler m_OnAutoReconnectingDelegate;

	public IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler m_OnAuthenticationWarningDisplayedDelegate;

	public IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler m_OnAuthenticationWarningDismissedDelegate;

	public IMsTscAxEvents_OnRemoteProgramResultEventHandler m_OnRemoteProgramResultDelegate;

	public IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler m_OnRemoteProgramDisplayedDelegate;

	public IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler m_OnRemoteWindowDisplayedDelegate;

	public IMsTscAxEvents_OnLogonErrorEventHandler m_OnLogonErrorDelegate;

	public IMsTscAxEvents_OnFocusReleasedEventHandler m_OnFocusReleasedDelegate;

	public IMsTscAxEvents_OnUserNameAcquiredEventHandler m_OnUserNameAcquiredDelegate;

	public IMsTscAxEvents_OnMouseInputModeChangedEventHandler m_OnMouseInputModeChangedDelegate;

	public IMsTscAxEvents_OnServiceMessageReceivedEventHandler m_OnServiceMessageReceivedDelegate;

	public IMsTscAxEvents_OnConnectionBarPullDownEventHandler m_OnConnectionBarPullDownDelegate;

	public IMsTscAxEvents_OnNetworkStatusChangedEventHandler m_OnNetworkStatusChangedDelegate;

	public IMsTscAxEvents_OnDevicesButtonPressedEventHandler m_OnDevicesButtonPressedDelegate;

	public IMsTscAxEvents_OnAutoReconnectedEventHandler m_OnAutoReconnectedDelegate;

	public IMsTscAxEvents_OnAutoReconnecting2EventHandler m_OnAutoReconnecting2Delegate;

	public int m_dwCookie;

	public void OnConnecting()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnConnectingDelegate != null)
		{
			m_OnConnectingDelegate();
		}
	}

	public void OnConnected()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnConnectedDelegate != null)
		{
			m_OnConnectedDelegate();
		}
	}

	public void OnLoginComplete()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnLoginCompleteDelegate != null)
		{
			m_OnLoginCompleteDelegate();
		}
	}

	public void OnDisconnected(int P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnDisconnectedDelegate != null)
		{
			m_OnDisconnectedDelegate(P_0);
		}
	}

	public void OnEnterFullScreenMode()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnEnterFullScreenModeDelegate != null)
		{
			m_OnEnterFullScreenModeDelegate();
		}
	}

	public void OnLeaveFullScreenMode()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnLeaveFullScreenModeDelegate != null)
		{
			m_OnLeaveFullScreenModeDelegate();
		}
	}

	public void OnChannelReceivedData(string P_0, string P_1)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnChannelReceivedDataDelegate != null)
		{
			m_OnChannelReceivedDataDelegate(P_0, P_1);
		}
	}

	public void OnRequestGoFullScreen()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnRequestGoFullScreenDelegate != null)
		{
			m_OnRequestGoFullScreenDelegate();
		}
	}

	public void OnRequestLeaveFullScreen()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnRequestLeaveFullScreenDelegate != null)
		{
			m_OnRequestLeaveFullScreenDelegate();
		}
	}

	public void OnFatalError(int P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnFatalErrorDelegate != null)
		{
			m_OnFatalErrorDelegate(P_0);
		}
	}

	public void OnWarning(int P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnWarningDelegate != null)
		{
			m_OnWarningDelegate(P_0);
		}
	}

	public void OnRemoteDesktopSizeChange(int P_0, int P_1)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnRemoteDesktopSizeChangeDelegate != null)
		{
			m_OnRemoteDesktopSizeChangeDelegate(P_0, P_1);
		}
	}

	public void OnIdleTimeoutNotification()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnIdleTimeoutNotificationDelegate != null)
		{
			m_OnIdleTimeoutNotificationDelegate();
		}
	}

	public void OnRequestContainerMinimize()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnRequestContainerMinimizeDelegate != null)
		{
			m_OnRequestContainerMinimizeDelegate();
		}
	}

	public bool OnConfirmClose()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnConfirmCloseDelegate != null)
		{
			return m_OnConfirmCloseDelegate();
		}
		return false;
	}

	public bool OnReceivedTSPublicKey(string P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnReceivedTSPublicKeyDelegate != null)
		{
			return m_OnReceivedTSPublicKeyDelegate(P_0);
		}
		return false;
	}

	public AutoReconnectContinueState OnAutoReconnecting(int P_0, int P_1)
	{
		if (m_OnAutoReconnectingDelegate != null)
		{
			return m_OnAutoReconnectingDelegate(P_0, P_1);
		}
		AutoReconnectContinueState result = default(AutoReconnectContinueState);
		return result;
	}

	public void OnAuthenticationWarningDisplayed()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnAuthenticationWarningDisplayedDelegate != null)
		{
			m_OnAuthenticationWarningDisplayedDelegate();
		}
	}

	public void OnAuthenticationWarningDismissed()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnAuthenticationWarningDismissedDelegate != null)
		{
			m_OnAuthenticationWarningDismissedDelegate();
		}
	}

	public void OnRemoteProgramResult(string P_0, RemoteProgramResult P_1, bool P_2)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnRemoteProgramResultDelegate != null)
		{
			m_OnRemoteProgramResultDelegate(P_0, P_1, P_2);
		}
	}

	public void OnRemoteProgramDisplayed(bool P_0, uint P_1)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnRemoteProgramDisplayedDelegate != null)
		{
			m_OnRemoteProgramDisplayedDelegate(P_0, P_1);
		}
	}

	public void OnRemoteWindowDisplayed(bool P_0, ref _RemotableHandle P_1, RemoteWindowDisplayedAttribute P_2)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnRemoteWindowDisplayedDelegate != null)
		{
			m_OnRemoteWindowDisplayedDelegate(P_0, ref P_1, P_2);
		}
	}

	public void OnLogonError(int P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnLogonErrorDelegate != null)
		{
			m_OnLogonErrorDelegate(P_0);
		}
	}

	public void OnFocusReleased(int P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnFocusReleasedDelegate != null)
		{
			m_OnFocusReleasedDelegate(P_0);
		}
	}

	public void OnUserNameAcquired(string P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnUserNameAcquiredDelegate != null)
		{
			m_OnUserNameAcquiredDelegate(P_0);
		}
	}

	public void OnMouseInputModeChanged(bool P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnMouseInputModeChangedDelegate != null)
		{
			m_OnMouseInputModeChangedDelegate(P_0);
		}
	}

	public void OnServiceMessageReceived(string P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnServiceMessageReceivedDelegate != null)
		{
			m_OnServiceMessageReceivedDelegate(P_0);
		}
	}

	public void OnConnectionBarPullDown()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnConnectionBarPullDownDelegate != null)
		{
			m_OnConnectionBarPullDownDelegate();
		}
	}

	public void OnNetworkStatusChanged(uint P_0, int P_1, int P_2)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnNetworkStatusChangedDelegate != null)
		{
			m_OnNetworkStatusChangedDelegate(P_0, P_1, P_2);
		}
	}

	public void OnDevicesButtonPressed()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnDevicesButtonPressedDelegate != null)
		{
			m_OnDevicesButtonPressedDelegate();
		}
	}

	public void OnAutoReconnected()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnAutoReconnectedDelegate != null)
		{
			m_OnAutoReconnectedDelegate();
		}
	}

	public void OnAutoReconnecting2(int P_0, bool P_1, int P_2, int P_3)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnAutoReconnecting2Delegate != null)
		{
			m_OnAutoReconnecting2Delegate(P_0, P_1, P_2, P_3);
		}
	}

	internal IMsTscAxEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_OnConnectingDelegate = null;
		m_OnConnectedDelegate = null;
		m_OnLoginCompleteDelegate = null;
		m_OnDisconnectedDelegate = null;
		m_OnEnterFullScreenModeDelegate = null;
		m_OnLeaveFullScreenModeDelegate = null;
		m_OnChannelReceivedDataDelegate = null;
		m_OnRequestGoFullScreenDelegate = null;
		m_OnRequestLeaveFullScreenDelegate = null;
		m_OnFatalErrorDelegate = null;
		m_OnWarningDelegate = null;
		m_OnRemoteDesktopSizeChangeDelegate = null;
		m_OnIdleTimeoutNotificationDelegate = null;
		m_OnRequestContainerMinimizeDelegate = null;
		m_OnConfirmCloseDelegate = null;
		m_OnReceivedTSPublicKeyDelegate = null;
		m_OnAutoReconnectingDelegate = null;
		m_OnAuthenticationWarningDisplayedDelegate = null;
		m_OnAuthenticationWarningDismissedDelegate = null;
		m_OnRemoteProgramResultDelegate = null;
		m_OnRemoteProgramDisplayedDelegate = null;
		m_OnRemoteWindowDisplayedDelegate = null;
		m_OnLogonErrorDelegate = null;
		m_OnFocusReleasedDelegate = null;
		m_OnUserNameAcquiredDelegate = null;
		m_OnMouseInputModeChangedDelegate = null;
		m_OnServiceMessageReceivedDelegate = null;
		m_OnConnectionBarPullDownDelegate = null;
		m_OnNetworkStatusChangedDelegate = null;
		m_OnDevicesButtonPressedDelegate = null;
		m_OnAutoReconnectedDelegate = null;
		m_OnAutoReconnecting2Delegate = null;
	}
}
internal sealed class IMsTscAxEvents_EventProvider : IMsTscAxEvents_Event, IDisposable
{

// C# 显式接口事件访问器（转发到下方 add_X / remove_X 方法，与 IL 版行为一致）

	event IMsTscAxEvents_OnConnectingEventHandler IMsTscAxEvents_Event.OnConnecting
	{
		add
		{
			add_OnConnecting(value);
		}
		remove
		{
			remove_OnConnecting(value);
		}
	}

	event IMsTscAxEvents_OnConnectedEventHandler IMsTscAxEvents_Event.OnConnected
	{
		add
		{
			add_OnConnected(value);
		}
		remove
		{
			remove_OnConnected(value);
		}
	}

	event IMsTscAxEvents_OnLoginCompleteEventHandler IMsTscAxEvents_Event.OnLoginComplete
	{
		add
		{
			add_OnLoginComplete(value);
		}
		remove
		{
			remove_OnLoginComplete(value);
		}
	}

	event IMsTscAxEvents_OnDisconnectedEventHandler IMsTscAxEvents_Event.OnDisconnected
	{
		add
		{
			add_OnDisconnected(value);
		}
		remove
		{
			remove_OnDisconnected(value);
		}
	}

	event IMsTscAxEvents_OnEnterFullScreenModeEventHandler IMsTscAxEvents_Event.OnEnterFullScreenMode
	{
		add
		{
			add_OnEnterFullScreenMode(value);
		}
		remove
		{
			remove_OnEnterFullScreenMode(value);
		}
	}

	event IMsTscAxEvents_OnLeaveFullScreenModeEventHandler IMsTscAxEvents_Event.OnLeaveFullScreenMode
	{
		add
		{
			add_OnLeaveFullScreenMode(value);
		}
		remove
		{
			remove_OnLeaveFullScreenMode(value);
		}
	}

	event IMsTscAxEvents_OnChannelReceivedDataEventHandler IMsTscAxEvents_Event.OnChannelReceivedData
	{
		add
		{
			add_OnChannelReceivedData(value);
		}
		remove
		{
			remove_OnChannelReceivedData(value);
		}
	}

	event IMsTscAxEvents_OnRequestGoFullScreenEventHandler IMsTscAxEvents_Event.OnRequestGoFullScreen
	{
		add
		{
			add_OnRequestGoFullScreen(value);
		}
		remove
		{
			remove_OnRequestGoFullScreen(value);
		}
	}

	event IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler IMsTscAxEvents_Event.OnRequestLeaveFullScreen
	{
		add
		{
			add_OnRequestLeaveFullScreen(value);
		}
		remove
		{
			remove_OnRequestLeaveFullScreen(value);
		}
	}

	event IMsTscAxEvents_OnFatalErrorEventHandler IMsTscAxEvents_Event.OnFatalError
	{
		add
		{
			add_OnFatalError(value);
		}
		remove
		{
			remove_OnFatalError(value);
		}
	}

	event IMsTscAxEvents_OnWarningEventHandler IMsTscAxEvents_Event.OnWarning
	{
		add
		{
			add_OnWarning(value);
		}
		remove
		{
			remove_OnWarning(value);
		}
	}

	event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler IMsTscAxEvents_Event.OnRemoteDesktopSizeChange
	{
		add
		{
			add_OnRemoteDesktopSizeChange(value);
		}
		remove
		{
			remove_OnRemoteDesktopSizeChange(value);
		}
	}

	event IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler IMsTscAxEvents_Event.OnIdleTimeoutNotification
	{
		add
		{
			add_OnIdleTimeoutNotification(value);
		}
		remove
		{
			remove_OnIdleTimeoutNotification(value);
		}
	}

	event IMsTscAxEvents_OnRequestContainerMinimizeEventHandler IMsTscAxEvents_Event.OnRequestContainerMinimize
	{
		add
		{
			add_OnRequestContainerMinimize(value);
		}
		remove
		{
			remove_OnRequestContainerMinimize(value);
		}
	}

	event IMsTscAxEvents_OnConfirmCloseEventHandler IMsTscAxEvents_Event.OnConfirmClose
	{
		add
		{
			add_OnConfirmClose(value);
		}
		remove
		{
			remove_OnConfirmClose(value);
		}
	}

	event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler IMsTscAxEvents_Event.OnReceivedTSPublicKey
	{
		add
		{
			add_OnReceivedTSPublicKey(value);
		}
		remove
		{
			remove_OnReceivedTSPublicKey(value);
		}
	}

	event IMsTscAxEvents_OnAutoReconnectingEventHandler IMsTscAxEvents_Event.OnAutoReconnecting
	{
		add
		{
			add_OnAutoReconnecting(value);
		}
		remove
		{
			remove_OnAutoReconnecting(value);
		}
	}

	event IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler IMsTscAxEvents_Event.OnAuthenticationWarningDisplayed
	{
		add
		{
			add_OnAuthenticationWarningDisplayed(value);
		}
		remove
		{
			remove_OnAuthenticationWarningDisplayed(value);
		}
	}

	event IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler IMsTscAxEvents_Event.OnAuthenticationWarningDismissed
	{
		add
		{
			add_OnAuthenticationWarningDismissed(value);
		}
		remove
		{
			remove_OnAuthenticationWarningDismissed(value);
		}
	}

	event IMsTscAxEvents_OnRemoteProgramResultEventHandler IMsTscAxEvents_Event.OnRemoteProgramResult
	{
		add
		{
			add_OnRemoteProgramResult(value);
		}
		remove
		{
			remove_OnRemoteProgramResult(value);
		}
	}

	event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler IMsTscAxEvents_Event.OnRemoteProgramDisplayed
	{
		add
		{
			add_OnRemoteProgramDisplayed(value);
		}
		remove
		{
			remove_OnRemoteProgramDisplayed(value);
		}
	}

	event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler IMsTscAxEvents_Event.OnRemoteWindowDisplayed
	{
		add
		{
			add_OnRemoteWindowDisplayed(value);
		}
		remove
		{
			remove_OnRemoteWindowDisplayed(value);
		}
	}

	event IMsTscAxEvents_OnLogonErrorEventHandler IMsTscAxEvents_Event.OnLogonError
	{
		add
		{
			add_OnLogonError(value);
		}
		remove
		{
			remove_OnLogonError(value);
		}
	}

	event IMsTscAxEvents_OnFocusReleasedEventHandler IMsTscAxEvents_Event.OnFocusReleased
	{
		add
		{
			add_OnFocusReleased(value);
		}
		remove
		{
			remove_OnFocusReleased(value);
		}
	}

	event IMsTscAxEvents_OnUserNameAcquiredEventHandler IMsTscAxEvents_Event.OnUserNameAcquired
	{
		add
		{
			add_OnUserNameAcquired(value);
		}
		remove
		{
			remove_OnUserNameAcquired(value);
		}
	}

	event IMsTscAxEvents_OnMouseInputModeChangedEventHandler IMsTscAxEvents_Event.OnMouseInputModeChanged
	{
		add
		{
			add_OnMouseInputModeChanged(value);
		}
		remove
		{
			remove_OnMouseInputModeChanged(value);
		}
	}

	event IMsTscAxEvents_OnServiceMessageReceivedEventHandler IMsTscAxEvents_Event.OnServiceMessageReceived
	{
		add
		{
			add_OnServiceMessageReceived(value);
		}
		remove
		{
			remove_OnServiceMessageReceived(value);
		}
	}

	event IMsTscAxEvents_OnConnectionBarPullDownEventHandler IMsTscAxEvents_Event.OnConnectionBarPullDown
	{
		add
		{
			add_OnConnectionBarPullDown(value);
		}
		remove
		{
			remove_OnConnectionBarPullDown(value);
		}
	}

	event IMsTscAxEvents_OnNetworkStatusChangedEventHandler IMsTscAxEvents_Event.OnNetworkStatusChanged
	{
		add
		{
			add_OnNetworkStatusChanged(value);
		}
		remove
		{
			remove_OnNetworkStatusChanged(value);
		}
	}

	event IMsTscAxEvents_OnDevicesButtonPressedEventHandler IMsTscAxEvents_Event.OnDevicesButtonPressed
	{
		add
		{
			add_OnDevicesButtonPressed(value);
		}
		remove
		{
			remove_OnDevicesButtonPressed(value);
		}
	}

	event IMsTscAxEvents_OnAutoReconnectedEventHandler IMsTscAxEvents_Event.OnAutoReconnected
	{
		add
		{
			add_OnAutoReconnected(value);
		}
		remove
		{
			remove_OnAutoReconnected(value);
		}
	}

	event IMsTscAxEvents_OnAutoReconnecting2EventHandler IMsTscAxEvents_Event.OnAutoReconnecting2
	{
		add
		{
			add_OnAutoReconnecting2(value);
		}
		remove
		{
			remove_OnAutoReconnecting2(value);
		}
	}
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			98, 85, 109, 51, 168, 239, 46, 72, 140, 179,
			197, 192, 252, 122, 125, 182
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_OnConnecting(IMsTscAxEvents_OnConnectingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnConnectingDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnConnecting(IMsTscAxEvents_OnConnectingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnConnectingDelegate != null && ((msTscAxEvents_SinkHelper.m_OnConnectingDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnConnected(IMsTscAxEvents_OnConnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnConnectedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnConnected(IMsTscAxEvents_OnConnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnConnectedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnConnectedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnLoginComplete(IMsTscAxEvents_OnLoginCompleteEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnLoginCompleteDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnLoginComplete(IMsTscAxEvents_OnLoginCompleteEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnLoginCompleteDelegate != null && ((msTscAxEvents_SinkHelper.m_OnLoginCompleteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnDisconnected(IMsTscAxEvents_OnDisconnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnDisconnectedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnDisconnected(IMsTscAxEvents_OnDisconnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnDisconnectedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnDisconnectedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnEnterFullScreenMode(IMsTscAxEvents_OnEnterFullScreenModeEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnEnterFullScreenModeDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnEnterFullScreenMode(IMsTscAxEvents_OnEnterFullScreenModeEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnEnterFullScreenModeDelegate != null && ((msTscAxEvents_SinkHelper.m_OnEnterFullScreenModeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnLeaveFullScreenMode(IMsTscAxEvents_OnLeaveFullScreenModeEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnLeaveFullScreenModeDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnLeaveFullScreenMode(IMsTscAxEvents_OnLeaveFullScreenModeEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnLeaveFullScreenModeDelegate != null && ((msTscAxEvents_SinkHelper.m_OnLeaveFullScreenModeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnChannelReceivedData(IMsTscAxEvents_OnChannelReceivedDataEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnChannelReceivedDataDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnChannelReceivedData(IMsTscAxEvents_OnChannelReceivedDataEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnChannelReceivedDataDelegate != null && ((msTscAxEvents_SinkHelper.m_OnChannelReceivedDataDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnRequestGoFullScreen(IMsTscAxEvents_OnRequestGoFullScreenEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnRequestGoFullScreenDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnRequestGoFullScreen(IMsTscAxEvents_OnRequestGoFullScreenEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnRequestGoFullScreenDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRequestGoFullScreenDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnRequestLeaveFullScreen(IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnRequestLeaveFullScreenDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnRequestLeaveFullScreen(IMsTscAxEvents_OnRequestLeaveFullScreenEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnRequestLeaveFullScreenDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRequestLeaveFullScreenDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnFatalError(IMsTscAxEvents_OnFatalErrorEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnFatalErrorDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnFatalError(IMsTscAxEvents_OnFatalErrorEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnFatalErrorDelegate != null && ((msTscAxEvents_SinkHelper.m_OnFatalErrorDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnWarning(IMsTscAxEvents_OnWarningEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnWarningDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnWarning(IMsTscAxEvents_OnWarningEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnWarningDelegate != null && ((msTscAxEvents_SinkHelper.m_OnWarningDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnRemoteDesktopSizeChange(IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnRemoteDesktopSizeChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnRemoteDesktopSizeChange(IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnRemoteDesktopSizeChangeDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRemoteDesktopSizeChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnIdleTimeoutNotification(IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnIdleTimeoutNotificationDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnIdleTimeoutNotification(IMsTscAxEvents_OnIdleTimeoutNotificationEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnIdleTimeoutNotificationDelegate != null && ((msTscAxEvents_SinkHelper.m_OnIdleTimeoutNotificationDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnRequestContainerMinimize(IMsTscAxEvents_OnRequestContainerMinimizeEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnRequestContainerMinimizeDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnRequestContainerMinimize(IMsTscAxEvents_OnRequestContainerMinimizeEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnRequestContainerMinimizeDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRequestContainerMinimizeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnConfirmClose(IMsTscAxEvents_OnConfirmCloseEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnConfirmCloseDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnConfirmClose(IMsTscAxEvents_OnConfirmCloseEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnConfirmCloseDelegate != null && ((msTscAxEvents_SinkHelper.m_OnConfirmCloseDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnReceivedTSPublicKey(IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnReceivedTSPublicKeyDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnReceivedTSPublicKey(IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnReceivedTSPublicKeyDelegate != null && ((msTscAxEvents_SinkHelper.m_OnReceivedTSPublicKeyDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnAutoReconnecting(IMsTscAxEvents_OnAutoReconnectingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnAutoReconnectingDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnAutoReconnecting(IMsTscAxEvents_OnAutoReconnectingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnAutoReconnectingDelegate != null && ((msTscAxEvents_SinkHelper.m_OnAutoReconnectingDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnAuthenticationWarningDisplayed(IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDisplayedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnAuthenticationWarningDisplayed(IMsTscAxEvents_OnAuthenticationWarningDisplayedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDisplayedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDisplayedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnAuthenticationWarningDismissed(IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDismissedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnAuthenticationWarningDismissed(IMsTscAxEvents_OnAuthenticationWarningDismissedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDismissedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnAuthenticationWarningDismissedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnRemoteProgramResult(IMsTscAxEvents_OnRemoteProgramResultEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnRemoteProgramResultDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnRemoteProgramResult(IMsTscAxEvents_OnRemoteProgramResultEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnRemoteProgramResultDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRemoteProgramResultDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnRemoteProgramDisplayed(IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnRemoteProgramDisplayedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnRemoteProgramDisplayed(IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnRemoteProgramDisplayedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRemoteProgramDisplayedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnRemoteWindowDisplayed(IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnRemoteWindowDisplayedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnRemoteWindowDisplayed(IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnRemoteWindowDisplayedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnRemoteWindowDisplayedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnLogonError(IMsTscAxEvents_OnLogonErrorEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnLogonErrorDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnLogonError(IMsTscAxEvents_OnLogonErrorEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnLogonErrorDelegate != null && ((msTscAxEvents_SinkHelper.m_OnLogonErrorDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnFocusReleased(IMsTscAxEvents_OnFocusReleasedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnFocusReleasedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnFocusReleased(IMsTscAxEvents_OnFocusReleasedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnFocusReleasedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnFocusReleasedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnUserNameAcquired(IMsTscAxEvents_OnUserNameAcquiredEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnUserNameAcquiredDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnUserNameAcquired(IMsTscAxEvents_OnUserNameAcquiredEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnUserNameAcquiredDelegate != null && ((msTscAxEvents_SinkHelper.m_OnUserNameAcquiredDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnMouseInputModeChanged(IMsTscAxEvents_OnMouseInputModeChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnMouseInputModeChangedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnMouseInputModeChanged(IMsTscAxEvents_OnMouseInputModeChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnMouseInputModeChangedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnMouseInputModeChangedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnServiceMessageReceived(IMsTscAxEvents_OnServiceMessageReceivedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnServiceMessageReceivedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnServiceMessageReceived(IMsTscAxEvents_OnServiceMessageReceivedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnServiceMessageReceivedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnServiceMessageReceivedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnConnectionBarPullDown(IMsTscAxEvents_OnConnectionBarPullDownEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnConnectionBarPullDownDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnConnectionBarPullDown(IMsTscAxEvents_OnConnectionBarPullDownEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnConnectionBarPullDownDelegate != null && ((msTscAxEvents_SinkHelper.m_OnConnectionBarPullDownDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnNetworkStatusChanged(IMsTscAxEvents_OnNetworkStatusChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnNetworkStatusChangedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnNetworkStatusChanged(IMsTscAxEvents_OnNetworkStatusChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnNetworkStatusChangedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnNetworkStatusChangedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnDevicesButtonPressed(IMsTscAxEvents_OnDevicesButtonPressedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnDevicesButtonPressedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnDevicesButtonPressed(IMsTscAxEvents_OnDevicesButtonPressedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnDevicesButtonPressedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnDevicesButtonPressedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnAutoReconnected(IMsTscAxEvents_OnAutoReconnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnAutoReconnectedDelegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnAutoReconnected(IMsTscAxEvents_OnAutoReconnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnAutoReconnectedDelegate != null && ((msTscAxEvents_SinkHelper.m_OnAutoReconnectedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnAutoReconnecting2(IMsTscAxEvents_OnAutoReconnecting2EventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = new IMsTscAxEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msTscAxEvents_SinkHelper, out pdwCookie);
			msTscAxEvents_SinkHelper.m_dwCookie = pdwCookie;
			msTscAxEvents_SinkHelper.m_OnAutoReconnecting2Delegate = P_0;
			m_aEventSinkHelpers.Add(msTscAxEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnAutoReconnecting2(IMsTscAxEvents_OnAutoReconnecting2EventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msTscAxEvents_SinkHelper.m_OnAutoReconnecting2Delegate != null && ((msTscAxEvents_SinkHelper.m_OnAutoReconnecting2Delegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public IMsTscAxEvents_EventProvider(object P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_ConnectionPointContainer = (IConnectionPointContainer)P_0;
	}

	~IMsTscAxEvents_EventProvider()
	{
		Cleanup();
	}

	private void Cleanup()
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 < count)
			{
				do
				{
					IMsTscAxEvents_SinkHelper msTscAxEvents_SinkHelper = (IMsTscAxEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(msTscAxEvents_SinkHelper.m_dwCookie);
					num++;
				}
				while (num < count);
			}
			Marshal.ReleaseComObject(m_ConnectionPoint);
		}
		catch (Exception)
		{
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void Dispose()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Cleanup();
		GC.SuppressFinalize(this);
	}
}
[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class IRemoteDesktopClientEvents_SinkHelper : IRemoteDesktopClientEvents
{
	public IRemoteDesktopClientEvents_OnConnectingEventHandler m_OnConnectingDelegate;

	public IRemoteDesktopClientEvents_OnConnectedEventHandler m_OnConnectedDelegate;

	public IRemoteDesktopClientEvents_OnLoginCompletedEventHandler m_OnLoginCompletedDelegate;

	public IRemoteDesktopClientEvents_OnDisconnectedEventHandler m_OnDisconnectedDelegate;

	public IRemoteDesktopClientEvents_OnStatusChangedEventHandler m_OnStatusChangedDelegate;

	public IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler m_OnAutoReconnectingDelegate;

	public IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler m_OnAutoReconnectedDelegate;

	public IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler m_OnDialogDisplayingDelegate;

	public IRemoteDesktopClientEvents_OnDialogDismissedEventHandler m_OnDialogDismissedDelegate;

	public IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler m_OnNetworkStatusChangedDelegate;

	public IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler m_OnAdminMessageReceivedDelegate;

	public IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler m_OnKeyCombinationPressedDelegate;

	public IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler m_OnRemoteDesktopSizeChangedDelegate;

	public IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler m_OnTouchPointerCursorMovedDelegate;

	public int m_dwCookie;

	public void OnConnecting()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnConnectingDelegate != null)
		{
			m_OnConnectingDelegate();
		}
	}

	public void OnConnected()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnConnectedDelegate != null)
		{
			m_OnConnectedDelegate();
		}
	}

	public void OnLoginCompleted()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnLoginCompletedDelegate != null)
		{
			m_OnLoginCompletedDelegate();
		}
	}

	public void OnDisconnected(int P_0, int P_1, string P_2)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnDisconnectedDelegate != null)
		{
			m_OnDisconnectedDelegate(P_0, P_1, P_2);
		}
	}

	public void OnStatusChanged(int P_0, string P_1)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnStatusChangedDelegate != null)
		{
			m_OnStatusChangedDelegate(P_0, P_1);
		}
	}

	public void OnAutoReconnecting(int P_0, int P_1, string P_2, bool P_3, int P_4, int P_5)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnAutoReconnectingDelegate != null)
		{
			m_OnAutoReconnectingDelegate(P_0, P_1, P_2, P_3, P_4, P_5);
		}
	}

	public void OnAutoReconnected()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnAutoReconnectedDelegate != null)
		{
			m_OnAutoReconnectedDelegate();
		}
	}

	public void OnDialogDisplaying()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnDialogDisplayingDelegate != null)
		{
			m_OnDialogDisplayingDelegate();
		}
	}

	public void OnDialogDismissed()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnDialogDismissedDelegate != null)
		{
			m_OnDialogDismissedDelegate();
		}
	}

	public void OnNetworkStatusChanged(uint P_0, int P_1, int P_2)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnNetworkStatusChangedDelegate != null)
		{
			m_OnNetworkStatusChangedDelegate(P_0, P_1, P_2);
		}
	}

	public void OnAdminMessageReceived(string P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnAdminMessageReceivedDelegate != null)
		{
			m_OnAdminMessageReceivedDelegate(P_0);
		}
	}

	public void OnKeyCombinationPressed(int P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnKeyCombinationPressedDelegate != null)
		{
			m_OnKeyCombinationPressedDelegate(P_0);
		}
	}

	public void OnRemoteDesktopSizeChanged(int P_0, int P_1)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnRemoteDesktopSizeChangedDelegate != null)
		{
			m_OnRemoteDesktopSizeChangedDelegate(P_0, P_1);
		}
	}

	public void OnTouchPointerCursorMoved(int P_0, int P_1)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnTouchPointerCursorMovedDelegate != null)
		{
			m_OnTouchPointerCursorMovedDelegate(P_0, P_1);
		}
	}

	internal IRemoteDesktopClientEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_OnConnectingDelegate = null;
		m_OnConnectedDelegate = null;
		m_OnLoginCompletedDelegate = null;
		m_OnDisconnectedDelegate = null;
		m_OnStatusChangedDelegate = null;
		m_OnAutoReconnectingDelegate = null;
		m_OnAutoReconnectedDelegate = null;
		m_OnDialogDisplayingDelegate = null;
		m_OnDialogDismissedDelegate = null;
		m_OnNetworkStatusChangedDelegate = null;
		m_OnAdminMessageReceivedDelegate = null;
		m_OnKeyCombinationPressedDelegate = null;
		m_OnRemoteDesktopSizeChangedDelegate = null;
		m_OnTouchPointerCursorMovedDelegate = null;
	}
}
internal sealed class IRemoteDesktopClientEvents_EventProvider : IRemoteDesktopClientEvents_Event, IDisposable
{

// C# 显式接口事件访问器（转发到下方 add_X / remove_X 方法，与 IL 版行为一致）

	event IRemoteDesktopClientEvents_OnConnectingEventHandler IRemoteDesktopClientEvents_Event.OnConnecting
	{
		add
		{
			add_OnConnecting(value);
		}
		remove
		{
			remove_OnConnecting(value);
		}
	}

	event IRemoteDesktopClientEvents_OnConnectedEventHandler IRemoteDesktopClientEvents_Event.OnConnected
	{
		add
		{
			add_OnConnected(value);
		}
		remove
		{
			remove_OnConnected(value);
		}
	}

	event IRemoteDesktopClientEvents_OnLoginCompletedEventHandler IRemoteDesktopClientEvents_Event.OnLoginCompleted
	{
		add
		{
			add_OnLoginCompleted(value);
		}
		remove
		{
			remove_OnLoginCompleted(value);
		}
	}

	event IRemoteDesktopClientEvents_OnDisconnectedEventHandler IRemoteDesktopClientEvents_Event.OnDisconnected
	{
		add
		{
			add_OnDisconnected(value);
		}
		remove
		{
			remove_OnDisconnected(value);
		}
	}

	event IRemoteDesktopClientEvents_OnStatusChangedEventHandler IRemoteDesktopClientEvents_Event.OnStatusChanged
	{
		add
		{
			add_OnStatusChanged(value);
		}
		remove
		{
			remove_OnStatusChanged(value);
		}
	}

	event IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler IRemoteDesktopClientEvents_Event.OnAutoReconnecting
	{
		add
		{
			add_OnAutoReconnecting(value);
		}
		remove
		{
			remove_OnAutoReconnecting(value);
		}
	}

	event IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler IRemoteDesktopClientEvents_Event.OnAutoReconnected
	{
		add
		{
			add_OnAutoReconnected(value);
		}
		remove
		{
			remove_OnAutoReconnected(value);
		}
	}

	event IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler IRemoteDesktopClientEvents_Event.OnDialogDisplaying
	{
		add
		{
			add_OnDialogDisplaying(value);
		}
		remove
		{
			remove_OnDialogDisplaying(value);
		}
	}

	event IRemoteDesktopClientEvents_OnDialogDismissedEventHandler IRemoteDesktopClientEvents_Event.OnDialogDismissed
	{
		add
		{
			add_OnDialogDismissed(value);
		}
		remove
		{
			remove_OnDialogDismissed(value);
		}
	}

	event IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler IRemoteDesktopClientEvents_Event.OnNetworkStatusChanged
	{
		add
		{
			add_OnNetworkStatusChanged(value);
		}
		remove
		{
			remove_OnNetworkStatusChanged(value);
		}
	}

	event IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler IRemoteDesktopClientEvents_Event.OnAdminMessageReceived
	{
		add
		{
			add_OnAdminMessageReceived(value);
		}
		remove
		{
			remove_OnAdminMessageReceived(value);
		}
	}

	event IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler IRemoteDesktopClientEvents_Event.OnKeyCombinationPressed
	{
		add
		{
			add_OnKeyCombinationPressed(value);
		}
		remove
		{
			remove_OnKeyCombinationPressed(value);
		}
	}

	event IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler IRemoteDesktopClientEvents_Event.OnRemoteDesktopSizeChanged
	{
		add
		{
			add_OnRemoteDesktopSizeChanged(value);
		}
		remove
		{
			remove_OnRemoteDesktopSizeChanged(value);
		}
	}

	event IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler IRemoteDesktopClientEvents_Event.OnTouchPointerCursorMoved
	{
		add
		{
			add_OnTouchPointerCursorMoved(value);
		}
		remove
		{
			remove_OnTouchPointerCursorMoved(value);
		}
	}
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			183, 99, 152, 7, 71, 109, 5, 65, 139, 254,
			12, 220, 179, 96, 230, 125
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_OnConnecting(IRemoteDesktopClientEvents_OnConnectingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnConnectingDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnConnecting(IRemoteDesktopClientEvents_OnConnectingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnConnectingDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnConnectingDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnConnected(IRemoteDesktopClientEvents_OnConnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnConnectedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnConnected(IRemoteDesktopClientEvents_OnConnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnConnectedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnConnectedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnLoginCompleted(IRemoteDesktopClientEvents_OnLoginCompletedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnLoginCompletedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnLoginCompleted(IRemoteDesktopClientEvents_OnLoginCompletedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnLoginCompletedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnLoginCompletedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnDisconnected(IRemoteDesktopClientEvents_OnDisconnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnDisconnectedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnDisconnected(IRemoteDesktopClientEvents_OnDisconnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnDisconnectedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnDisconnectedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnStatusChanged(IRemoteDesktopClientEvents_OnStatusChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnStatusChangedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnStatusChanged(IRemoteDesktopClientEvents_OnStatusChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnStatusChangedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnStatusChangedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnAutoReconnecting(IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectingDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnAutoReconnecting(IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectingDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectingDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnAutoReconnected(IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnAutoReconnected(IRemoteDesktopClientEvents_OnAutoReconnectedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnAutoReconnectedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnDialogDisplaying(IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnDialogDisplayingDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnDialogDisplaying(IRemoteDesktopClientEvents_OnDialogDisplayingEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnDialogDisplayingDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnDialogDisplayingDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnDialogDismissed(IRemoteDesktopClientEvents_OnDialogDismissedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnDialogDismissedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnDialogDismissed(IRemoteDesktopClientEvents_OnDialogDismissedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnDialogDismissedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnDialogDismissedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnNetworkStatusChanged(IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnNetworkStatusChangedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnNetworkStatusChanged(IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnNetworkStatusChangedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnNetworkStatusChangedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnAdminMessageReceived(IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnAdminMessageReceivedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnAdminMessageReceived(IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnAdminMessageReceivedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnAdminMessageReceivedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnKeyCombinationPressed(IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnKeyCombinationPressedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnKeyCombinationPressed(IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnKeyCombinationPressedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnKeyCombinationPressedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnRemoteDesktopSizeChanged(IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnRemoteDesktopSizeChangedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnRemoteDesktopSizeChanged(IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnRemoteDesktopSizeChangedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnRemoteDesktopSizeChangedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void add_OnTouchPointerCursorMoved(IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = new IRemoteDesktopClientEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(remoteDesktopClientEvents_SinkHelper, out pdwCookie);
			remoteDesktopClientEvents_SinkHelper.m_dwCookie = pdwCookie;
			remoteDesktopClientEvents_SinkHelper.m_OnTouchPointerCursorMovedDelegate = P_0;
			m_aEventSinkHelpers.Add(remoteDesktopClientEvents_SinkHelper);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void remove_OnTouchPointerCursorMoved(IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler P_0)
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (remoteDesktopClientEvents_SinkHelper.m_OnTouchPointerCursorMovedDelegate != null && ((remoteDesktopClientEvents_SinkHelper.m_OnTouchPointerCursorMovedDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public IRemoteDesktopClientEvents_EventProvider(object P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_ConnectionPointContainer = (IConnectionPointContainer)P_0;
	}

	~IRemoteDesktopClientEvents_EventProvider()
	{
		Cleanup();
	}

	private void Cleanup()
	{
		bool lockTaken = default(bool);
		try
		{
			Monitor.Enter(this, ref lockTaken);
			if (m_ConnectionPoint == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 < count)
			{
				do
				{
					IRemoteDesktopClientEvents_SinkHelper remoteDesktopClientEvents_SinkHelper = (IRemoteDesktopClientEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(remoteDesktopClientEvents_SinkHelper.m_dwCookie);
					num++;
				}
				while (num < count);
			}
			Marshal.ReleaseComObject(m_ConnectionPoint);
		}
		catch (Exception)
		{
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this);
			}
		}
	}

	public void Dispose()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Cleanup();
		GC.SuppressFinalize(this);
	}
}
}
