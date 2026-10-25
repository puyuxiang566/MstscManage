using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MSTSCLib;

[assembly: AxHost.TypeLibraryTimeStamp("09/29/2017 21:42:25")]

namespace AxMSTSCLib
{

[Clsid("{a41a4187-5a86-4e26-b40a-856f9035d9cb}")]
[DefaultEvent("OnConnecting")]
[DesignTimeVisible(true)]
public class AxMsTscAxNotSafeForScripting : AxHost
{
	private IMsTscAx ocx;

	private AxMsTscAxNotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(2)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(98)]
	[Browsable(false)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	[Browsable(false)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsTscAxNotSafeForScripting()
		: base("a41a4187-5a86-4e26-b40a-856f9035d9cb")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsTscAxNotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsTscAx)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
public delegate void IMsTscAxEvents_OnDisconnectedEventHandler(object sender, IMsTscAxEvents_OnDisconnectedEvent e);
public class IMsTscAxEvents_OnDisconnectedEvent
{
	public int discReason;

	public IMsTscAxEvents_OnDisconnectedEvent(int discReason)
	{
		this.discReason = discReason;
	}
}
public delegate void IMsTscAxEvents_OnChannelReceivedDataEventHandler(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e);
public class IMsTscAxEvents_OnChannelReceivedDataEvent
{
	public string chanName;

	public string data;

	public IMsTscAxEvents_OnChannelReceivedDataEvent(string chanName, string data)
	{
		this.chanName = chanName;
		this.data = data;
	}
}
public delegate void IMsTscAxEvents_OnFatalErrorEventHandler(object sender, IMsTscAxEvents_OnFatalErrorEvent e);
public class IMsTscAxEvents_OnFatalErrorEvent
{
	public int errorCode;

	public IMsTscAxEvents_OnFatalErrorEvent(int errorCode)
	{
		this.errorCode = errorCode;
	}
}
public delegate void IMsTscAxEvents_OnWarningEventHandler(object sender, IMsTscAxEvents_OnWarningEvent e);
public class IMsTscAxEvents_OnWarningEvent
{
	public int warningCode;

	public IMsTscAxEvents_OnWarningEvent(int warningCode)
	{
		this.warningCode = warningCode;
	}
}
public delegate void IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e);
public class IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent
{
	public int width;

	public int height;

	public IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(int width, int height)
	{
		this.width = width;
		this.height = height;
	}
}
public delegate bool IMsTscAxEvents_OnConfirmCloseEventHandler(object sender, IMsTscAxEvents_OnConfirmCloseEvent e);
public class IMsTscAxEvents_OnConfirmCloseEvent
{
}
public delegate bool IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e);
public class IMsTscAxEvents_OnReceivedTSPublicKeyEvent
{
	public string publicKey;

	public IMsTscAxEvents_OnReceivedTSPublicKeyEvent(string publicKey)
	{
		this.publicKey = publicKey;
	}
}
public delegate AutoReconnectContinueState IMsTscAxEvents_OnAutoReconnectingEventHandler(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e);
public class IMsTscAxEvents_OnAutoReconnectingEvent
{
	public int disconnectReason;

	public int attemptCount;

	public IMsTscAxEvents_OnAutoReconnectingEvent(int disconnectReason, int attemptCount)
	{
		this.disconnectReason = disconnectReason;
		this.attemptCount = attemptCount;
	}
}
public delegate void IMsTscAxEvents_OnRemoteProgramResultEventHandler(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e);
public class IMsTscAxEvents_OnRemoteProgramResultEvent
{
	public string bstrRemoteProgram;

	public RemoteProgramResult lError;

	public bool vbIsExecutable;

	public IMsTscAxEvents_OnRemoteProgramResultEvent(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		this.bstrRemoteProgram = bstrRemoteProgram;
		this.lError = lError;
		this.vbIsExecutable = vbIsExecutable;
	}
}
public delegate void IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e);
public class IMsTscAxEvents_OnRemoteProgramDisplayedEvent
{
	public bool vbDisplayed;

	public uint uDisplayInformation;

	public IMsTscAxEvents_OnRemoteProgramDisplayedEvent(bool vbDisplayed, uint uDisplayInformation)
	{
		this.vbDisplayed = vbDisplayed;
		this.uDisplayInformation = uDisplayInformation;
	}
}
public delegate void IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e);
public class IMsTscAxEvents_OnRemoteWindowDisplayedEvent
{
	public bool vbDisplayed;

	public _RemotableHandle hwnd;

	public RemoteWindowDisplayedAttribute windowAttribute;

	public IMsTscAxEvents_OnRemoteWindowDisplayedEvent(bool vbDisplayed, _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		this.vbDisplayed = vbDisplayed;
		this.hwnd = hwnd;
		this.windowAttribute = windowAttribute;
	}
}
public delegate void IMsTscAxEvents_OnLogonErrorEventHandler(object sender, IMsTscAxEvents_OnLogonErrorEvent e);
public class IMsTscAxEvents_OnLogonErrorEvent
{
	public int lError;

	public IMsTscAxEvents_OnLogonErrorEvent(int lError)
	{
		this.lError = lError;
	}
}
public delegate void IMsTscAxEvents_OnFocusReleasedEventHandler(object sender, IMsTscAxEvents_OnFocusReleasedEvent e);
public class IMsTscAxEvents_OnFocusReleasedEvent
{
	public int iDirection;

	public IMsTscAxEvents_OnFocusReleasedEvent(int iDirection)
	{
		this.iDirection = iDirection;
	}
}
public delegate void IMsTscAxEvents_OnUserNameAcquiredEventHandler(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e);
public class IMsTscAxEvents_OnUserNameAcquiredEvent
{
	public string bstrUserName;

	public IMsTscAxEvents_OnUserNameAcquiredEvent(string bstrUserName)
	{
		this.bstrUserName = bstrUserName;
	}
}
public delegate void IMsTscAxEvents_OnMouseInputModeChangedEventHandler(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e);
public class IMsTscAxEvents_OnMouseInputModeChangedEvent
{
	public bool fMouseModeRelative;

	public IMsTscAxEvents_OnMouseInputModeChangedEvent(bool fMouseModeRelative)
	{
		this.fMouseModeRelative = fMouseModeRelative;
	}
}
public delegate void IMsTscAxEvents_OnServiceMessageReceivedEventHandler(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e);
public class IMsTscAxEvents_OnServiceMessageReceivedEvent
{
	public string serviceMessage;

	public IMsTscAxEvents_OnServiceMessageReceivedEvent(string serviceMessage)
	{
		this.serviceMessage = serviceMessage;
	}
}
public delegate void IMsTscAxEvents_OnNetworkStatusChangedEventHandler(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e);
public class IMsTscAxEvents_OnNetworkStatusChangedEvent
{
	public uint qualityLevel;

	public int bandwidth;

	public int rtt;

	public IMsTscAxEvents_OnNetworkStatusChangedEvent(uint qualityLevel, int bandwidth, int rtt)
	{
		this.qualityLevel = qualityLevel;
		this.bandwidth = bandwidth;
		this.rtt = rtt;
	}
}
public delegate void IMsTscAxEvents_OnAutoReconnecting2EventHandler(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e);
public class IMsTscAxEvents_OnAutoReconnecting2Event
{
	public int disconnectReason;

	public bool networkAvailable;

	public int attemptCount;

	public int maxAttemptCount;

	public IMsTscAxEvents_OnAutoReconnecting2Event(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		this.disconnectReason = disconnectReason;
		this.networkAvailable = networkAvailable;
		this.attemptCount = attemptCount;
		this.maxAttemptCount = maxAttemptCount;
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsTscAxNotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsTscAxNotSafeForScripting parent;

	public AxMsTscAxNotSafeForScriptingEventMulticaster(AxMsTscAxNotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{7cacbd7b-0d99-468f-ac33-22e495c0afe5}")]
[DesignTimeVisible(true)]
public class AxMsRdpClientNotSafeForScripting : AxHost
{
	private IMsRdpClient ocx;

	private AxMsRdpClientNotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DispId(21)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(22)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DispId(97)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(98)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(102)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClientNotSafeForScripting()
		: base("7cacbd7b-0d99-468f-ac33-22e495c0afe5")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClientNotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClientNotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClientNotSafeForScripting parent;

	public AxMsRdpClientNotSafeForScriptingEventMulticaster(AxMsRdpClientNotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{3523c2fb-4031-44e4-9a3b-f1e94986ee7f}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient2NotSafeForScripting : AxHost
{
	private IMsRdpClient2 ocx;

	private AxMsRdpClient2NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	[Browsable(false)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(97)]
	[Browsable(false)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(98)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DispId(99)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DispId(101)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DispId(200)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient2NotSafeForScripting()
		: base("3523c2fb-4031-44e4-9a3b-f1e94986ee7f")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient2NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient2)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient2NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient2NotSafeForScripting parent;

	public AxMsRdpClient2NotSafeForScriptingEventMulticaster(AxMsRdpClient2NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[Clsid("{9059f30f-4eb1-4bd2-9fdc-36f43a218f4a}")]
[DesignTimeVisible(true)]
[DefaultEvent("OnConnecting")]
public class AxMsRdpClient2 : AxHost
{
	private IMsRdpClient2 ocx;

	private AxMsRdpClient2EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(12)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DispId(19)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(22)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(97)]
	[Browsable(false)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DispId(98)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(103)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(200)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient2()
		: base("9059f30f-4eb1-4bd2-9fdc-36f43a218f4a")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient2EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient2)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient2EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient2 parent;

	public AxMsRdpClient2EventMulticaster(AxMsRdpClient2 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[Clsid("{971127bb-259f-48c2-bd75-5f97a3331551}")]
[DesignTimeVisible(true)]
[DefaultEvent("OnConnecting")]
public class AxMsRdpClient2a : AxHost
{
	private IMsRdpClient2 ocx;

	private AxMsRdpClient2aEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	[Browsable(false)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DispId(21)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DispId(97)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DispId(98)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(102)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(200)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient2a()
		: base("971127bb-259f-48c2-bd75-5f97a3331551")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient2aEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient2)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient2aEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient2a parent;

	public AxMsRdpClient2aEventMulticaster(AxMsRdpClient2a parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[Clsid("{ace575fd-1fcf-4074-9401-ebab990fa9de}")]
[DefaultEvent("OnConnecting")]
[DesignTimeVisible(true)]
public class AxMsRdpClient3NotSafeForScripting : AxHost
{
	private IMsRdpClient3 ocx;

	private AxMsRdpClient3NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(12)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DispId(19)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DispId(98)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DispId(99)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(103)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DispId(200)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DispId(300)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient3NotSafeForScripting()
		: base("ace575fd-1fcf-4074-9401-ebab990fa9de")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient3NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient3)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient3NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient3NotSafeForScripting parent;

	public AxMsRdpClient3NotSafeForScriptingEventMulticaster(AxMsRdpClient3NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{7584c670-2274-4efb-b00b-d6aaba6d3850}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient3 : AxHost
{
	private IMsRdpClient3 ocx;

	private AxMsRdpClient3EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DispId(19)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(97)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(98)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(102)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DispId(200)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(300)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient3()
		: base("7584c670-2274-4efb-b00b-d6aaba6d3850")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient3EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient3)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient3EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient3 parent;

	public AxMsRdpClient3EventMulticaster(AxMsRdpClient3 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{6a6f4b83-45c5-4ca9-bdd9-0d81c12295e4}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient3a : AxHost
{
	private IMsRdpClient3 ocx;

	private AxMsRdpClient3aEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DispId(98)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DispId(99)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DispId(101)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DispId(200)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DispId(300)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient3a()
		: base("6a6f4b83-45c5-4ca9-bdd9-0d81c12295e4")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient3aEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient3)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient3aEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient3a parent;

	public AxMsRdpClient3aEventMulticaster(AxMsRdpClient3a parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{6ae29350-321b-42be-bbe5-12fb5270c0de}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient4NotSafeForScripting : AxHost
{
	private IMsRdpClient4 ocx;

	private AxMsRdpClient4NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(2)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(97)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DispId(98)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DispId(99)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(103)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(200)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[Browsable(false)]
	[DispId(300)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DispId(400)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient4NotSafeForScripting()
		: base("6ae29350-321b-42be-bbe5-12fb5270c0de")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient4NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient4)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient4NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient4NotSafeForScripting parent;

	public AxMsRdpClient4NotSafeForScriptingEventMulticaster(AxMsRdpClient4NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{4edcb26c-d24c-4e72-af07-b576699ac0de}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient4 : AxHost
{
	private IMsRdpClient4 ocx;

	private AxMsRdpClient4EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(22)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(98)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DispId(99)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DispId(101)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DispId(102)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DispId(200)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[Browsable(false)]
	[DispId(300)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(400)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient4()
		: base("4edcb26c-d24c-4e72-af07-b576699ac0de")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient4EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient4)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient4EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient4 parent;

	public AxMsRdpClient4EventMulticaster(AxMsRdpClient4 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{54ce37e0-9834-41ae-9896-4dab69dc022b}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient4a : AxHost
{
	private IMsRdpClient4 ocx;

	private AxMsRdpClient4aEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(2)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(12)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DispId(19)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DispId(21)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DispId(97)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DispId(98)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DispId(99)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(103)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(200)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(300)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DispId(400)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient4a()
		: base("54ce37e0-9834-41ae-9896-4dab69dc022b")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient4aEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient4)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient4aEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient4a parent;

	public AxMsRdpClient4aEventMulticaster(AxMsRdpClient4a parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{4eb2f086-c818-447e-b32c-c51ce2b30d31}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient5NotSafeForScripting : AxHost
{
	private IMsRdpClient5 ocx;

	private AxMsRdpClient5NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DispId(19)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(98)]
	[Browsable(false)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DispId(101)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(102)]
	[Browsable(false)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(103)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(200)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DispId(300)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DispId(400)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(500)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[Browsable(false)]
	[DispId(502)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(504)]
	[Browsable(false)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(505)]
	[Browsable(false)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient5NotSafeForScripting()
		: base("4eb2f086-c818-447e-b32c-c51ce2b30d31")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient5NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient5)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient5NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient5NotSafeForScripting parent;

	public AxMsRdpClient5NotSafeForScriptingEventMulticaster(AxMsRdpClient5NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[Clsid("{4eb89ff4-7f78-4a0f-8b8d-2bf02e94e4b2}")]
[DesignTimeVisible(true)]
[DefaultEvent("OnConnecting")]
public class AxMsRdpClient5 : AxHost
{
	private IMsRdpClient5 ocx;

	private AxMsRdpClient5EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(2)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(97)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(98)]
	[Browsable(false)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DispId(102)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(200)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(300)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DispId(400)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(500)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(502)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[Browsable(false)]
	[DispId(504)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[Browsable(false)]
	[DispId(505)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient5()
		: base("4eb89ff4-7f78-4a0f-8b8d-2bf02e94e4b2")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient5EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient5)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient5EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient5 parent;

	public AxMsRdpClient5EventMulticaster(AxMsRdpClient5 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[Clsid("{d2ea46a7-c2bf-426b-af24-e19c44456399}")]
[DesignTimeVisible(true)]
[DefaultEvent("OnConnecting")]
public class AxMsRdpClient6NotSafeForScripting : AxHost
{
	private IMsRdpClient6 ocx;

	private AxMsRdpClient6NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DispId(98)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DispId(102)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DispId(200)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(300)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(400)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DispId(500)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[DispId(502)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(504)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(505)]
	[Browsable(false)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(507)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[Browsable(false)]
	[DispId(506)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient6NotSafeForScripting()
		: base("d2ea46a7-c2bf-426b-af24-e19c44456399")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient6NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient6)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient6NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient6NotSafeForScripting parent;

	public AxMsRdpClient6NotSafeForScriptingEventMulticaster(AxMsRdpClient6NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DesignTimeVisible(true)]
[Clsid("{7390f3d8-0439-4c05-91e3-cf5cb290c3d0}")]
[DefaultEvent("OnConnecting")]
public class AxMsRdpClient6 : AxHost
{
	private IMsRdpClient6 ocx;

	private AxMsRdpClient6EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DispId(19)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(97)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(98)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DispId(99)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(102)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(200)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DispId(300)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[Browsable(false)]
	[DispId(400)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(500)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(502)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[DispId(504)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[DispId(505)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[DispId(507)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(506)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient6()
		: base("7390f3d8-0439-4c05-91e3-cf5cb290c3d0")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient6EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient6)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient6EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient6 parent;

	public AxMsRdpClient6EventMulticaster(AxMsRdpClient6 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[Clsid("{54d38bf7-b1ef-4479-9674-1bd6ea465258}")]
[DefaultEvent("OnConnecting")]
[DesignTimeVisible(true)]
public class AxMsRdpClient7NotSafeForScripting : AxHost
{
	private IMsRdpClient7 ocx;

	private AxMsRdpClient7NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(2)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(12)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(97)]
	[Browsable(false)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(98)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DispId(200)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(300)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(400)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DispId(500)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[DispId(502)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(504)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[Browsable(false)]
	[DispId(505)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[DispId(507)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[DispId(506)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	[Browsable(false)]
	[DispId(600)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings8", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings8;
		}
	}

	[DispId(601)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings3 TransportSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(603)]
	[Browsable(false)]
	public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings3;
		}
	}

	[DispId(604)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram2 RemoteProgram2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram2;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient7NotSafeForScripting()
		: base("54d38bf7-b1ef-4479-9674-1bd6ea465258")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	public virtual string GetStatusText(uint statusCode)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetStatusText", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetStatusText(statusCode);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient7NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient7)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient7NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient7NotSafeForScripting parent;

	public AxMsRdpClient7NotSafeForScriptingEventMulticaster(AxMsRdpClient7NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{a9d7038d-b5ed-472e-9c47-94bea90a5910}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient7 : AxHost
{
	private IMsRdpClient7 ocx;

	private AxMsRdpClient7EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(2)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(12)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DispId(98)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	[Browsable(false)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DispId(101)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(103)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DispId(200)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(300)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DispId(400)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(500)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[DispId(502)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[Browsable(false)]
	[DispId(504)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(505)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[DispId(507)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[DispId(506)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	[DispId(600)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings8", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings8;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(601)]
	public virtual IMsRdpClientTransportSettings3 TransportSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(603)]
	[Browsable(false)]
	public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings3;
		}
	}

	[DispId(604)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram2 RemoteProgram2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram2;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient7()
		: base("a9d7038d-b5ed-472e-9c47-94bea90a5910")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	public virtual string GetStatusText(uint statusCode)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetStatusText", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetStatusText(statusCode);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient7EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient7)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient7EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient7 parent;

	public AxMsRdpClient7EventMulticaster(AxMsRdpClient7 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{a3bc03a0-041d-42e3-ad22-882b7865c9c5}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient8NotSafeForScripting : AxHost
{
	private IMsRdpClient8 ocx;

	private AxMsRdpClient8NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(4)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(16)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DispId(21)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(97)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DispId(98)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DispId(102)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DispId(200)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(300)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(400)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DispId(500)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[DispId(502)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(504)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[DispId(505)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(507)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[Browsable(false)]
	[DispId(506)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(600)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings8", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings8;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(601)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings3 TransportSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings3;
		}
	}

	[DispId(603)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings3;
		}
	}

	[Browsable(false)]
	[DispId(604)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram2 RemoteProgram2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram2;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(701)]
	public virtual IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings9", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings9;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient8NotSafeForScripting()
		: base("a3bc03a0-041d-42e3-ad22-882b7865c9c5")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	public virtual string GetStatusText(uint statusCode)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetStatusText", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetStatusText(statusCode);
	}

	public virtual void SendRemoteAction(RemoteSessionActionType actionType)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendRemoteAction", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendRemoteAction(actionType);
	}

	public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Reconnect", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.Reconnect(ulWidth, ulHeight);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient8NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient8)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient8NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient8NotSafeForScripting parent;

	public AxMsRdpClient8NotSafeForScriptingEventMulticaster(AxMsRdpClient8NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{5f681803-2900-4c43-a1cc-cf405404a676}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient8 : AxHost
{
	private IMsRdpClient8 ocx;

	private AxMsRdpClient8EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(19)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(22)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DispId(97)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[Browsable(false)]
	[DispId(98)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DispId(101)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(102)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(200)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DispId(300)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(400)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[Browsable(false)]
	[DispId(500)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(502)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[Browsable(false)]
	[DispId(504)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[DispId(505)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(507)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[DispId(506)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	[Browsable(false)]
	[DispId(600)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings8", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings8;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(601)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings3 TransportSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(603)]
	public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings3;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(604)]
	public virtual ITSRemoteProgram2 RemoteProgram2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram2;
		}
	}

	[Browsable(false)]
	[DispId(701)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings9", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings9;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient8()
		: base("5f681803-2900-4c43-a1cc-cf405404a676")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	public virtual string GetStatusText(uint statusCode)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetStatusText", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetStatusText(statusCode);
	}

	public virtual void SendRemoteAction(RemoteSessionActionType actionType)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendRemoteAction", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendRemoteAction(actionType);
	}

	public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Reconnect", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.Reconnect(ulWidth, ulHeight);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient8EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient8)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient8EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient8 parent;

	public AxMsRdpClient8EventMulticaster(AxMsRdpClient8 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{8b918b82-7985-4c24-89df-c33ad2bbfbcd}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient9NotSafeForScripting : AxHost
{
	private IMsRdpClient9 ocx;

	private AxMsRdpClient9NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DispId(19)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DispId(21)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(22)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DispId(98)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DispId(99)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DispId(101)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[Browsable(false)]
	[DispId(102)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(103)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DispId(200)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DispId(300)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(400)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DispId(500)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(502)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(504)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(505)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[DispId(507)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[DispId(506)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(600)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings8", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings8;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(601)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings3 TransportSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings3;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(603)]
	public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings3;
		}
	}

	[DispId(604)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual ITSRemoteProgram2 RemoteProgram2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram2;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(701)]
	public virtual IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings9", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings9;
		}
	}

	[DispId(800)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings4 TransportSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings4;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient9NotSafeForScripting()
		: base("8b918b82-7985-4c24-89df-c33ad2bbfbcd")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	public virtual string GetStatusText(uint statusCode)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetStatusText", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetStatusText(statusCode);
	}

	public virtual void SendRemoteAction(RemoteSessionActionType actionType)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendRemoteAction", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendRemoteAction(actionType);
	}

	public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Reconnect", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.Reconnect(ulWidth, ulHeight);
	}

	public virtual void SyncSessionDisplaySettings()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SyncSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SyncSessionDisplaySettings();
	}

	public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("UpdateSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
	}

	public virtual void attachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("attachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.attachEvent(eventName, callback);
	}

	public virtual void detachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("detachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.detachEvent(eventName, callback);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient9NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient9)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient9NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient9NotSafeForScripting parent;

	public AxMsRdpClient9NotSafeForScriptingEventMulticaster(AxMsRdpClient9NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{301b94ba-5d25-4a12-bffe-3b6e7a616585}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient9 : AxHost
{
	private IMsRdpClient9 ocx;

	private AxMsRdpClient9EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(1)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DispId(2)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DispId(13)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[DispId(19)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(21)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DispId(97)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DispId(98)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DispId(99)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(100)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(102)]
	[Browsable(false)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DispId(200)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DispId(201)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(300)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[Browsable(false)]
	[DispId(400)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DispId(500)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[DispId(502)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(504)]
	[Browsable(false)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(505)]
	[Browsable(false)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(507)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[DispId(506)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(600)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings8", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings8;
		}
	}

	[DispId(601)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings3 TransportSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings3;
		}
	}

	[Browsable(false)]
	[DispId(603)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings3;
		}
	}

	[DispId(604)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram2 RemoteProgram2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(701)]
	public virtual IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings9", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings9;
		}
	}

	[DispId(800)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings4 TransportSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings4;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient9()
		: base("301b94ba-5d25-4a12-bffe-3b6e7a616585")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	public virtual string GetStatusText(uint statusCode)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetStatusText", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetStatusText(statusCode);
	}

	public virtual void SendRemoteAction(RemoteSessionActionType actionType)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendRemoteAction", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendRemoteAction(actionType);
	}

	public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Reconnect", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.Reconnect(ulWidth, ulHeight);
	}

	public virtual void SyncSessionDisplaySettings()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SyncSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SyncSessionDisplaySettings();
	}

	public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("UpdateSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
	}

	public virtual void attachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("attachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.attachEvent(eventName, callback);
	}

	public virtual void detachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("detachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.detachEvent(eventName, callback);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient9EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient9)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient9EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient9 parent;

	public AxMsRdpClient9EventMulticaster(AxMsRdpClient9 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[Clsid("{a0c63c30-f08d-4ab4-907c-34905d770c7d}")]
[DesignTimeVisible(true)]
public class AxMsRdpClient10NotSafeForScripting : AxHost
{
	private IMsRdpClient10 ocx;

	private AxMsRdpClient10NotSafeForScriptingEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(2)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DispId(3)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DispId(5)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(6)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(17)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DispId(18)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DispId(19)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DispId(20)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DispId(21)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(22)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(97)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DispId(98)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[DispId(99)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DispId(101)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(103)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DispId(104)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(200)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(300)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[DispId(400)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[Browsable(false)]
	[DispId(500)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[DispId(502)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[DispId(504)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[Browsable(false)]
	[DispId(505)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(507)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(506)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(600)]
	public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings8", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings8;
		}
	}

	[DispId(601)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings3 TransportSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings3;
		}
	}

	[DispId(603)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(604)]
	[Browsable(false)]
	public virtual ITSRemoteProgram2 RemoteProgram2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram2;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(701)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings9", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings9;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(800)]
	public virtual IMsRdpClientTransportSettings4 TransportSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings4;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(900)]
	public virtual ITSRemoteProgram3 RemoteProgram3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram3;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient10NotSafeForScripting()
		: base("a0c63c30-f08d-4ab4-907c-34905d770c7d")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	public virtual string GetStatusText(uint statusCode)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetStatusText", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetStatusText(statusCode);
	}

	public virtual void SendRemoteAction(RemoteSessionActionType actionType)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendRemoteAction", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendRemoteAction(actionType);
	}

	public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Reconnect", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.Reconnect(ulWidth, ulHeight);
	}

	public virtual void SyncSessionDisplaySettings()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SyncSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SyncSessionDisplaySettings();
	}

	public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("UpdateSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
	}

	public virtual void attachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("attachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.attachEvent(eventName, callback);
	}

	public virtual void detachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("detachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.detachEvent(eventName, callback);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient10NotSafeForScriptingEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient10)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient10NotSafeForScriptingEventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient10NotSafeForScripting parent;

	public AxMsRdpClient10NotSafeForScriptingEventMulticaster(AxMsRdpClient10NotSafeForScripting parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DefaultEvent("OnConnecting")]
[DesignTimeVisible(true)]
[Clsid("{c0efa91a-eeb7-41c7-97fa-f0ed645efb24}")]
public class AxMsRdpClient10 : AxHost
{
	private IMsRdpClient10 ocx;

	private AxMsRdpClient10EventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(1)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Server
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Server;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Server", ActiveXInvokeKind.PropertySet);
			}
			ocx.Server = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(2)]
	public virtual string Domain
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Domain;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Domain", ActiveXInvokeKind.PropertySet);
			}
			ocx.Domain = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(3)]
	public virtual string UserName
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.UserName;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("UserName", ActiveXInvokeKind.PropertySet);
			}
			ocx.UserName = value;
		}
	}

	[DispId(4)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string DisconnectedText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DisconnectedText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DisconnectedText", ActiveXInvokeKind.PropertySet);
			}
			ocx.DisconnectedText = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(5)]
	public virtual string ConnectingText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectingText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectingText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectingText = value;
		}
	}

	[DispId(6)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual short Connected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Connected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Connected;
		}
	}

	[DispId(12)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int DesktopWidth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopWidth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopWidth", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopWidth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(13)]
	public virtual int DesktopHeight
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.DesktopHeight;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("DesktopHeight", ActiveXInvokeKind.PropertySet);
			}
			ocx.DesktopHeight = value;
		}
	}

	[DispId(16)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int StartConnected
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.StartConnected;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("StartConnected", ActiveXInvokeKind.PropertySet);
			}
			ocx.StartConnected = value;
		}
	}

	[DispId(17)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HorizontalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("HorizontalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.HorizontalScrollBarVisible;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(18)]
	public virtual int VerticalScrollBarVisible
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("VerticalScrollBarVisible", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.VerticalScrollBarVisible;
		}
	}

	[Browsable(false)]
	[DispId(19)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string FullScreenTitle
	{
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreenTitle", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreenTitle = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(20)]
	public virtual int CipherStrength
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("CipherStrength", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.CipherStrength;
		}
	}

	[DispId(21)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual string Version
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Version", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Version;
		}
	}

	[DispId(22)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int SecuredSettingsEnabled
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettingsEnabled", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettingsEnabled;
		}
	}

	[DispId(97)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscSecuredSettings SecuredSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings;
		}
	}

	[DispId(98)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsTscAdvancedSettings AdvancedSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(99)]
	public virtual IMsTscDebug Debugger
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Debugger", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Debugger;
		}
	}

	[DispId(100)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int ColorDepth
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ColorDepth;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ColorDepth", ActiveXInvokeKind.PropertySet);
			}
			ocx.ColorDepth = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(101)]
	[Browsable(false)]
	public virtual IMsRdpClientAdvancedSettings AdvancedSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings2;
		}
	}

	[DispId(102)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings SecuredSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings2;
		}
	}

	[DispId(103)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ExtendedDisconnectReasonCode ExtendedDisconnectReason
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ExtendedDisconnectReason", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ExtendedDisconnectReason;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(104)]
	public virtual bool FullScreen
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.FullScreen;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("FullScreen", ActiveXInvokeKind.PropertySet);
			}
			ocx.FullScreen = value;
		}
	}

	[Browsable(false)]
	[DispId(200)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings2 AdvancedSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings3;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(201)]
	public virtual string ConnectedStatusText
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.ConnectedStatusText;
		}
		set
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("ConnectedStatusText", ActiveXInvokeKind.PropertySet);
			}
			ocx.ConnectedStatusText = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(300)]
	public virtual IMsRdpClientAdvancedSettings3 AdvancedSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings4;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(400)]
	public virtual IMsRdpClientAdvancedSettings4 AdvancedSettings5
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings5", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings5;
		}
	}

	[DispId(500)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings TransportSettings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings;
		}
	}

	[Browsable(false)]
	[DispId(502)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings5 AdvancedSettings6
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings6", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings6;
		}
	}

	[DispId(504)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram RemoteProgram
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram;
		}
	}

	[Browsable(false)]
	[DispId(505)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientShell MsRdpClientShell
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("MsRdpClientShell", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.MsRdpClientShell;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(507)]
	public virtual IMsRdpClientAdvancedSettings6 AdvancedSettings7
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings7", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings7;
		}
	}

	[DispId(506)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientTransportSettings2 TransportSettings2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings2;
		}
	}

	[DispId(600)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings7 AdvancedSettings8
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings8", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings8;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(601)]
	[Browsable(false)]
	public virtual IMsRdpClientTransportSettings3 TransportSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings3;
		}
	}

	[DispId(603)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientSecuredSettings2 SecuredSettings3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("SecuredSettings3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.SecuredSettings3;
		}
	}

	[Browsable(false)]
	[DispId(604)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ITSRemoteProgram2 RemoteProgram2
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram2", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram2;
		}
	}

	[DispId(701)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IMsRdpClientAdvancedSettings8 AdvancedSettings9
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("AdvancedSettings9", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.AdvancedSettings9;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DispId(800)]
	public virtual IMsRdpClientTransportSettings4 TransportSettings4
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TransportSettings4", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TransportSettings4;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DispId(900)]
	public virtual ITSRemoteProgram3 RemoteProgram3
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("RemoteProgram3", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.RemoteProgram3;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginComplete;

	public event IMsTscAxEvents_OnDisconnectedEventHandler OnDisconnected;

	public event EventHandler OnEnterFullScreenMode;

	public event EventHandler OnLeaveFullScreenMode;

	public event IMsTscAxEvents_OnChannelReceivedDataEventHandler OnChannelReceivedData;

	public event EventHandler OnRequestGoFullScreen;

	public event EventHandler OnRequestLeaveFullScreen;

	public event IMsTscAxEvents_OnFatalErrorEventHandler OnFatalError;

	public event IMsTscAxEvents_OnWarningEventHandler OnWarning;

	public event IMsTscAxEvents_OnRemoteDesktopSizeChangeEventHandler OnRemoteDesktopSizeChange;

	public event EventHandler OnIdleTimeoutNotification;

	public event EventHandler OnRequestContainerMinimize;

	public event IMsTscAxEvents_OnConfirmCloseEventHandler OnConfirmClose;

	public event IMsTscAxEvents_OnReceivedTSPublicKeyEventHandler OnReceivedTSPublicKey;

	public event IMsTscAxEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAuthenticationWarningDisplayed;

	public event EventHandler OnAuthenticationWarningDismissed;

	public event IMsTscAxEvents_OnRemoteProgramResultEventHandler OnRemoteProgramResult;

	public event IMsTscAxEvents_OnRemoteProgramDisplayedEventHandler OnRemoteProgramDisplayed;

	public event IMsTscAxEvents_OnRemoteWindowDisplayedEventHandler OnRemoteWindowDisplayed;

	public event IMsTscAxEvents_OnLogonErrorEventHandler OnLogonError;

	public event IMsTscAxEvents_OnFocusReleasedEventHandler OnFocusReleased;

	public event IMsTscAxEvents_OnUserNameAcquiredEventHandler OnUserNameAcquired;

	public event IMsTscAxEvents_OnMouseInputModeChangedEventHandler OnMouseInputModeChanged;

	public event IMsTscAxEvents_OnServiceMessageReceivedEventHandler OnServiceMessageReceived;

	public event EventHandler OnConnectionBarPullDown;

	public event IMsTscAxEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event EventHandler OnDevicesButtonPressed;

	public event EventHandler OnAutoReconnected;

	public event IMsTscAxEvents_OnAutoReconnecting2EventHandler OnAutoReconnecting2;

	public AxMsRdpClient10()
		: base("c0efa91a-eeb7-41c7-97fa-f0ed645efb24")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void CreateVirtualChannels(string newVal)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("CreateVirtualChannels", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.CreateVirtualChannels(newVal);
	}

	public virtual void SendOnVirtualChannel(string chanName, string chanData)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendOnVirtualChannel", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendOnVirtualChannel(chanName, chanData);
	}

	public virtual void SetVirtualChannelOptions(string chanName, int chanOptions)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SetVirtualChannelOptions(chanName, chanOptions);
	}

	public virtual int GetVirtualChannelOptions(string chanName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetVirtualChannelOptions", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetVirtualChannelOptions(chanName);
	}

	public virtual ControlCloseStatus RequestClose()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("RequestClose", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.RequestClose();
	}

	public virtual string GetErrorDescription(uint disconnectReason, uint extendedDisconnectReason)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetErrorDescription", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetErrorDescription(disconnectReason, extendedDisconnectReason);
	}

	public virtual string GetStatusText(uint statusCode)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("GetStatusText", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.GetStatusText(statusCode);
	}

	public virtual void SendRemoteAction(RemoteSessionActionType actionType)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SendRemoteAction", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SendRemoteAction(actionType);
	}

	public virtual ControlReconnectStatus Reconnect(uint ulWidth, uint ulHeight)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Reconnect", ActiveXInvokeKind.MethodInvoke);
		}
		return ocx.Reconnect(ulWidth, ulHeight);
	}

	public virtual void SyncSessionDisplaySettings()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("SyncSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.SyncSessionDisplaySettings();
	}

	public virtual void UpdateSessionDisplaySettings(uint ulDesktopWidth, uint ulDesktopHeight, uint ulPhysicalWidth, uint ulPhysicalHeight, uint ulOrientation, uint ulDesktopScaleFactor, uint ulDeviceScaleFactor)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("UpdateSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.UpdateSessionDisplaySettings(ulDesktopWidth, ulDesktopHeight, ulPhysicalWidth, ulPhysicalHeight, ulOrientation, ulDesktopScaleFactor, ulDeviceScaleFactor);
	}

	public virtual void attachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("attachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.attachEvent(eventName, callback);
	}

	public virtual void detachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("detachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.detachEvent(eventName, callback);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxMsRdpClient10EventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IMsTscAxEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IMsRdpClient10)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginComplete(object sender, EventArgs e)
	{
		if (OnLoginComplete != null)
		{
			OnLoginComplete(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnEnterFullScreenMode(object sender, EventArgs e)
	{
		if (OnEnterFullScreenMode != null)
		{
			OnEnterFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnLeaveFullScreenMode(object sender, EventArgs e)
	{
		if (OnLeaveFullScreenMode != null)
		{
			OnLeaveFullScreenMode(sender, e);
		}
	}

	internal void RaiseOnOnChannelReceivedData(object sender, IMsTscAxEvents_OnChannelReceivedDataEvent e)
	{
		if (OnChannelReceivedData != null)
		{
			OnChannelReceivedData(sender, e);
		}
	}

	internal void RaiseOnOnRequestGoFullScreen(object sender, EventArgs e)
	{
		if (OnRequestGoFullScreen != null)
		{
			OnRequestGoFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnRequestLeaveFullScreen(object sender, EventArgs e)
	{
		if (OnRequestLeaveFullScreen != null)
		{
			OnRequestLeaveFullScreen(sender, e);
		}
	}

	internal void RaiseOnOnFatalError(object sender, IMsTscAxEvents_OnFatalErrorEvent e)
	{
		if (OnFatalError != null)
		{
			OnFatalError(sender, e);
		}
	}

	internal void RaiseOnOnWarning(object sender, IMsTscAxEvents_OnWarningEvent e)
	{
		if (OnWarning != null)
		{
			OnWarning(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChange(object sender, IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e)
	{
		if (OnRemoteDesktopSizeChange != null)
		{
			OnRemoteDesktopSizeChange(sender, e);
		}
	}

	internal void RaiseOnOnIdleTimeoutNotification(object sender, EventArgs e)
	{
		if (OnIdleTimeoutNotification != null)
		{
			OnIdleTimeoutNotification(sender, e);
		}
	}

	internal void RaiseOnOnRequestContainerMinimize(object sender, EventArgs e)
	{
		if (OnRequestContainerMinimize != null)
		{
			OnRequestContainerMinimize(sender, e);
		}
	}

	internal bool RaiseOnOnConfirmClose(object sender, IMsTscAxEvents_OnConfirmCloseEvent e)
	{
		if (OnConfirmClose != null)
		{
			return OnConfirmClose(sender, e);
		}
		return false;
	}

	internal bool RaiseOnOnReceivedTSPublicKey(object sender, IMsTscAxEvents_OnReceivedTSPublicKeyEvent e)
	{
		if (OnReceivedTSPublicKey != null)
		{
			return OnReceivedTSPublicKey(sender, e);
		}
		return false;
	}

	internal AutoReconnectContinueState RaiseOnOnAutoReconnecting(object sender, IMsTscAxEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			return OnAutoReconnecting(sender, e);
		}
		return AutoReconnectContinueState.autoReconnectContinueAutomatic;
	}

	internal void RaiseOnOnAuthenticationWarningDisplayed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDisplayed != null)
		{
			OnAuthenticationWarningDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnAuthenticationWarningDismissed(object sender, EventArgs e)
	{
		if (OnAuthenticationWarningDismissed != null)
		{
			OnAuthenticationWarningDismissed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramResult(object sender, IMsTscAxEvents_OnRemoteProgramResultEvent e)
	{
		if (OnRemoteProgramResult != null)
		{
			OnRemoteProgramResult(sender, e);
		}
	}

	internal void RaiseOnOnRemoteProgramDisplayed(object sender, IMsTscAxEvents_OnRemoteProgramDisplayedEvent e)
	{
		if (OnRemoteProgramDisplayed != null)
		{
			OnRemoteProgramDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteWindowDisplayed(object sender, IMsTscAxEvents_OnRemoteWindowDisplayedEvent e)
	{
		if (OnRemoteWindowDisplayed != null)
		{
			OnRemoteWindowDisplayed(sender, e);
		}
	}

	internal void RaiseOnOnLogonError(object sender, IMsTscAxEvents_OnLogonErrorEvent e)
	{
		if (OnLogonError != null)
		{
			OnLogonError(sender, e);
		}
	}

	internal void RaiseOnOnFocusReleased(object sender, IMsTscAxEvents_OnFocusReleasedEvent e)
	{
		if (OnFocusReleased != null)
		{
			OnFocusReleased(sender, e);
		}
	}

	internal void RaiseOnOnUserNameAcquired(object sender, IMsTscAxEvents_OnUserNameAcquiredEvent e)
	{
		if (OnUserNameAcquired != null)
		{
			OnUserNameAcquired(sender, e);
		}
	}

	internal void RaiseOnOnMouseInputModeChanged(object sender, IMsTscAxEvents_OnMouseInputModeChangedEvent e)
	{
		if (OnMouseInputModeChanged != null)
		{
			OnMouseInputModeChanged(sender, e);
		}
	}

	internal void RaiseOnOnServiceMessageReceived(object sender, IMsTscAxEvents_OnServiceMessageReceivedEvent e)
	{
		if (OnServiceMessageReceived != null)
		{
			OnServiceMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnConnectionBarPullDown(object sender, EventArgs e)
	{
		if (OnConnectionBarPullDown != null)
		{
			OnConnectionBarPullDown(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IMsTscAxEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnDevicesButtonPressed(object sender, EventArgs e)
	{
		if (OnDevicesButtonPressed != null)
		{
			OnDevicesButtonPressed(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting2(object sender, IMsTscAxEvents_OnAutoReconnecting2Event e)
	{
		if (OnAutoReconnecting2 != null)
		{
			OnAutoReconnecting2(sender, e);
		}
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxMsRdpClient10EventMulticaster : IMsTscAxEvents
{
	private AxMsRdpClient10 parent;

	public AxMsRdpClient10EventMulticaster(AxMsRdpClient10 parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginComplete()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginComplete(parent, e);
	}

	public virtual void OnDisconnected(int discReason)
	{
		IMsTscAxEvents_OnDisconnectedEvent e = new IMsTscAxEvents_OnDisconnectedEvent(discReason);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnEnterFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnEnterFullScreenMode(parent, e);
	}

	public virtual void OnLeaveFullScreenMode()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLeaveFullScreenMode(parent, e);
	}

	public virtual void OnChannelReceivedData(string chanName, string data)
	{
		IMsTscAxEvents_OnChannelReceivedDataEvent e = new IMsTscAxEvents_OnChannelReceivedDataEvent(chanName, data);
		parent.RaiseOnOnChannelReceivedData(parent, e);
	}

	public virtual void OnRequestGoFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestGoFullScreen(parent, e);
	}

	public virtual void OnRequestLeaveFullScreen()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestLeaveFullScreen(parent, e);
	}

	public virtual void OnFatalError(int errorCode)
	{
		IMsTscAxEvents_OnFatalErrorEvent e = new IMsTscAxEvents_OnFatalErrorEvent(errorCode);
		parent.RaiseOnOnFatalError(parent, e);
	}

	public virtual void OnWarning(int warningCode)
	{
		IMsTscAxEvents_OnWarningEvent e = new IMsTscAxEvents_OnWarningEvent(warningCode);
		parent.RaiseOnOnWarning(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChange(int width, int height)
	{
		IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e = new IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChange(parent, e);
	}

	public virtual void OnIdleTimeoutNotification()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnIdleTimeoutNotification(parent, e);
	}

	public virtual void OnRequestContainerMinimize()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnRequestContainerMinimize(parent, e);
	}

	public virtual bool OnConfirmClose()
	{
		IMsTscAxEvents_OnConfirmCloseEvent e = new IMsTscAxEvents_OnConfirmCloseEvent();
		return parent.RaiseOnOnConfirmClose(parent, e);
	}

	public virtual bool OnReceivedTSPublicKey(string publicKey)
	{
		IMsTscAxEvents_OnReceivedTSPublicKeyEvent e = new IMsTscAxEvents_OnReceivedTSPublicKeyEvent(publicKey);
		return parent.RaiseOnOnReceivedTSPublicKey(parent, e);
	}

	public virtual AutoReconnectContinueState OnAutoReconnecting(int disconnectReason, int attemptCount)
	{
		IMsTscAxEvents_OnAutoReconnectingEvent e = new IMsTscAxEvents_OnAutoReconnectingEvent(disconnectReason, attemptCount);
		return parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAuthenticationWarningDisplayed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDisplayed(parent, e);
	}

	public virtual void OnAuthenticationWarningDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAuthenticationWarningDismissed(parent, e);
	}

	public virtual void OnRemoteProgramResult(string bstrRemoteProgram, RemoteProgramResult lError, bool vbIsExecutable)
	{
		IMsTscAxEvents_OnRemoteProgramResultEvent e = new IMsTscAxEvents_OnRemoteProgramResultEvent(bstrRemoteProgram, lError, vbIsExecutable);
		parent.RaiseOnOnRemoteProgramResult(parent, e);
	}

	public virtual void OnRemoteProgramDisplayed(bool vbDisplayed, uint uDisplayInformation)
	{
		IMsTscAxEvents_OnRemoteProgramDisplayedEvent e = new IMsTscAxEvents_OnRemoteProgramDisplayedEvent(vbDisplayed, uDisplayInformation);
		parent.RaiseOnOnRemoteProgramDisplayed(parent, e);
	}

	public virtual void OnRemoteWindowDisplayed(bool vbDisplayed, ref _RemotableHandle hwnd, RemoteWindowDisplayedAttribute windowAttribute)
	{
		IMsTscAxEvents_OnRemoteWindowDisplayedEvent msTscAxEvents_OnRemoteWindowDisplayedEvent = new IMsTscAxEvents_OnRemoteWindowDisplayedEvent(vbDisplayed, hwnd, windowAttribute);
		parent.RaiseOnOnRemoteWindowDisplayed(parent, msTscAxEvents_OnRemoteWindowDisplayedEvent);
		hwnd = msTscAxEvents_OnRemoteWindowDisplayedEvent.hwnd;
	}

	public virtual void OnLogonError(int lError)
	{
		IMsTscAxEvents_OnLogonErrorEvent e = new IMsTscAxEvents_OnLogonErrorEvent(lError);
		parent.RaiseOnOnLogonError(parent, e);
	}

	public virtual void OnFocusReleased(int iDirection)
	{
		IMsTscAxEvents_OnFocusReleasedEvent e = new IMsTscAxEvents_OnFocusReleasedEvent(iDirection);
		parent.RaiseOnOnFocusReleased(parent, e);
	}

	public virtual void OnUserNameAcquired(string bstrUserName)
	{
		IMsTscAxEvents_OnUserNameAcquiredEvent e = new IMsTscAxEvents_OnUserNameAcquiredEvent(bstrUserName);
		parent.RaiseOnOnUserNameAcquired(parent, e);
	}

	public virtual void OnMouseInputModeChanged(bool fMouseModeRelative)
	{
		IMsTscAxEvents_OnMouseInputModeChangedEvent e = new IMsTscAxEvents_OnMouseInputModeChangedEvent(fMouseModeRelative);
		parent.RaiseOnOnMouseInputModeChanged(parent, e);
	}

	public virtual void OnServiceMessageReceived(string serviceMessage)
	{
		IMsTscAxEvents_OnServiceMessageReceivedEvent e = new IMsTscAxEvents_OnServiceMessageReceivedEvent(serviceMessage);
		parent.RaiseOnOnServiceMessageReceived(parent, e);
	}

	public virtual void OnConnectionBarPullDown()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnectionBarPullDown(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IMsTscAxEvents_OnNetworkStatusChangedEvent e = new IMsTscAxEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnDevicesButtonPressed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDevicesButtonPressed(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnAutoReconnecting2(int disconnectReason, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IMsTscAxEvents_OnAutoReconnecting2Event e = new IMsTscAxEvents_OnAutoReconnecting2Event(disconnectReason, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting2(parent, e);
	}
}
[DesignTimeVisible(true)]
[Clsid("{eab16c5d-eed1-4e95-868b-0fba1b42c092}")]
public class AxRemoteDesktopClient : AxHost
{
	private IRemoteDesktopClient ocx;

	private AxRemoteDesktopClientEventMulticaster eventMulticaster;

	private ConnectionPointCookie cookie;

	[DispId(710)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual IRemoteDesktopClientSettings Settings
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Settings", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Settings;
		}
	}

	[DispId(711)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IRemoteDesktopClientActions Actions
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("Actions", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.Actions;
		}
	}

	[DispId(712)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual IRemoteDesktopClientTouchPointer TouchPointer
	{
		get
		{
			if (ocx == null)
			{
				throw new InvalidActiveXStateException("TouchPointer", ActiveXInvokeKind.PropertyGet);
			}
			return ocx.TouchPointer;
		}
	}

	public event EventHandler OnConnecting;

	public event EventHandler OnConnected;

	public event EventHandler OnLoginCompleted;

	public event IRemoteDesktopClientEvents_OnDisconnectedEventHandler OnDisconnected;

	public event IRemoteDesktopClientEvents_OnStatusChangedEventHandler OnStatusChanged;

	public event IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler OnAutoReconnecting;

	public event EventHandler OnAutoReconnected;

	public event EventHandler OnDialogDisplaying;

	public event EventHandler OnDialogDismissed;

	public event IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler OnNetworkStatusChanged;

	public event IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler OnAdminMessageReceived;

	public event IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler OnKeyCombinationPressed;

	public event IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler OnRemoteDesktopSizeChanged;

	public event IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler OnTouchPointerCursorMoved;

	public AxRemoteDesktopClient()
		: base("eab16c5d-eed1-4e95-868b-0fba1b42c092")
	{
	}

	public virtual void Connect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Connect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Connect();
	}

	public virtual void Disconnect()
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Disconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Disconnect();
	}

	public virtual void Reconnect(uint width, uint height)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("Reconnect", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.Reconnect(width, height);
	}

	public virtual void DeleteSavedCredentials(string serverName)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("DeleteSavedCredentials", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.DeleteSavedCredentials(serverName);
	}

	public virtual void UpdateSessionDisplaySettings(uint width, uint height)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("UpdateSessionDisplaySettings", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.UpdateSessionDisplaySettings(width, height);
	}

	public virtual void attachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("attachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.attachEvent(eventName, callback);
	}

	public virtual void detachEvent(string eventName, object callback)
	{
		if (ocx == null)
		{
			throw new InvalidActiveXStateException("detachEvent", ActiveXInvokeKind.MethodInvoke);
		}
		ocx.detachEvent(eventName, callback);
	}

	protected override void CreateSink()
	{
		try
		{
			eventMulticaster = new AxRemoteDesktopClientEventMulticaster(this);
			cookie = new ConnectionPointCookie(ocx, eventMulticaster, typeof(IRemoteDesktopClientEvents));
		}
		catch (Exception)
		{
		}
	}

	protected override void DetachSink()
	{
		try
		{
			cookie.Disconnect();
		}
		catch (Exception)
		{
		}
	}

	protected override void AttachInterfaces()
	{
		try
		{
			ocx = (IRemoteDesktopClient)GetOcx();
		}
		catch (Exception)
		{
		}
	}

	internal void RaiseOnOnConnecting(object sender, EventArgs e)
	{
		if (OnConnecting != null)
		{
			OnConnecting(sender, e);
		}
	}

	internal void RaiseOnOnConnected(object sender, EventArgs e)
	{
		if (OnConnected != null)
		{
			OnConnected(sender, e);
		}
	}

	internal void RaiseOnOnLoginCompleted(object sender, EventArgs e)
	{
		if (OnLoginCompleted != null)
		{
			OnLoginCompleted(sender, e);
		}
	}

	internal void RaiseOnOnDisconnected(object sender, IRemoteDesktopClientEvents_OnDisconnectedEvent e)
	{
		if (OnDisconnected != null)
		{
			OnDisconnected(sender, e);
		}
	}

	internal void RaiseOnOnStatusChanged(object sender, IRemoteDesktopClientEvents_OnStatusChangedEvent e)
	{
		if (OnStatusChanged != null)
		{
			OnStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnecting(object sender, IRemoteDesktopClientEvents_OnAutoReconnectingEvent e)
	{
		if (OnAutoReconnecting != null)
		{
			OnAutoReconnecting(sender, e);
		}
	}

	internal void RaiseOnOnAutoReconnected(object sender, EventArgs e)
	{
		if (OnAutoReconnected != null)
		{
			OnAutoReconnected(sender, e);
		}
	}

	internal void RaiseOnOnDialogDisplaying(object sender, EventArgs e)
	{
		if (OnDialogDisplaying != null)
		{
			OnDialogDisplaying(sender, e);
		}
	}

	internal void RaiseOnOnDialogDismissed(object sender, EventArgs e)
	{
		if (OnDialogDismissed != null)
		{
			OnDialogDismissed(sender, e);
		}
	}

	internal void RaiseOnOnNetworkStatusChanged(object sender, IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent e)
	{
		if (OnNetworkStatusChanged != null)
		{
			OnNetworkStatusChanged(sender, e);
		}
	}

	internal void RaiseOnOnAdminMessageReceived(object sender, IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent e)
	{
		if (OnAdminMessageReceived != null)
		{
			OnAdminMessageReceived(sender, e);
		}
	}

	internal void RaiseOnOnKeyCombinationPressed(object sender, IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent e)
	{
		if (OnKeyCombinationPressed != null)
		{
			OnKeyCombinationPressed(sender, e);
		}
	}

	internal void RaiseOnOnRemoteDesktopSizeChanged(object sender, IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent e)
	{
		if (OnRemoteDesktopSizeChanged != null)
		{
			OnRemoteDesktopSizeChanged(sender, e);
		}
	}

	internal void RaiseOnOnTouchPointerCursorMoved(object sender, IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent e)
	{
		if (OnTouchPointerCursorMoved != null)
		{
			OnTouchPointerCursorMoved(sender, e);
		}
	}
}
public delegate void IRemoteDesktopClientEvents_OnDisconnectedEventHandler(object sender, IRemoteDesktopClientEvents_OnDisconnectedEvent e);
public class IRemoteDesktopClientEvents_OnDisconnectedEvent
{
	public int disconnectReason;

	public int extendedDisconnectReason;

	public string disconnectErrorMessage;

	public IRemoteDesktopClientEvents_OnDisconnectedEvent(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage)
	{
		this.disconnectReason = disconnectReason;
		this.extendedDisconnectReason = extendedDisconnectReason;
		this.disconnectErrorMessage = disconnectErrorMessage;
	}
}
public delegate void IRemoteDesktopClientEvents_OnStatusChangedEventHandler(object sender, IRemoteDesktopClientEvents_OnStatusChangedEvent e);
public class IRemoteDesktopClientEvents_OnStatusChangedEvent
{
	public int statusCode;

	public string statusMessage;

	public IRemoteDesktopClientEvents_OnStatusChangedEvent(int statusCode, string statusMessage)
	{
		this.statusCode = statusCode;
		this.statusMessage = statusMessage;
	}
}
public delegate void IRemoteDesktopClientEvents_OnAutoReconnectingEventHandler(object sender, IRemoteDesktopClientEvents_OnAutoReconnectingEvent e);
public class IRemoteDesktopClientEvents_OnAutoReconnectingEvent
{
	public int disconnectReason;

	public int extendedDisconnectReason;

	public string disconnectErrorMessage;

	public bool networkAvailable;

	public int attemptCount;

	public int maxAttemptCount;

	public IRemoteDesktopClientEvents_OnAutoReconnectingEvent(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		this.disconnectReason = disconnectReason;
		this.extendedDisconnectReason = extendedDisconnectReason;
		this.disconnectErrorMessage = disconnectErrorMessage;
		this.networkAvailable = networkAvailable;
		this.attemptCount = attemptCount;
		this.maxAttemptCount = maxAttemptCount;
	}
}
public delegate void IRemoteDesktopClientEvents_OnNetworkStatusChangedEventHandler(object sender, IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent e);
public class IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent
{
	public uint qualityLevel;

	public int bandwidth;

	public int rtt;

	public IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent(uint qualityLevel, int bandwidth, int rtt)
	{
		this.qualityLevel = qualityLevel;
		this.bandwidth = bandwidth;
		this.rtt = rtt;
	}
}
public delegate void IRemoteDesktopClientEvents_OnAdminMessageReceivedEventHandler(object sender, IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent e);
public class IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent
{
	public string adminMessage;

	public IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent(string adminMessage)
	{
		this.adminMessage = adminMessage;
	}
}
public delegate void IRemoteDesktopClientEvents_OnKeyCombinationPressedEventHandler(object sender, IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent e);
public class IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent
{
	public int keyCombination;

	public IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent(int keyCombination)
	{
		this.keyCombination = keyCombination;
	}
}
public delegate void IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEventHandler(object sender, IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent e);
public class IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent
{
	public int width;

	public int height;

	public IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent(int width, int height)
	{
		this.width = width;
		this.height = height;
	}
}
public delegate void IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEventHandler(object sender, IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent e);
public class IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent
{
	public int x;

	public int y;

	public IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent(int x, int y)
	{
		this.x = x;
		this.y = y;
	}
}
[ClassInterface(ClassInterfaceType.None)]
public class AxRemoteDesktopClientEventMulticaster : IRemoteDesktopClientEvents
{
	private AxRemoteDesktopClient parent;

	public AxRemoteDesktopClientEventMulticaster(AxRemoteDesktopClient parent)
	{
		this.parent = parent;
	}

	public virtual void OnConnecting()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnecting(parent, e);
	}

	public virtual void OnConnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnConnected(parent, e);
	}

	public virtual void OnLoginCompleted()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnLoginCompleted(parent, e);
	}

	public virtual void OnDisconnected(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage)
	{
		IRemoteDesktopClientEvents_OnDisconnectedEvent e = new IRemoteDesktopClientEvents_OnDisconnectedEvent(disconnectReason, extendedDisconnectReason, disconnectErrorMessage);
		parent.RaiseOnOnDisconnected(parent, e);
	}

	public virtual void OnStatusChanged(int statusCode, string statusMessage)
	{
		IRemoteDesktopClientEvents_OnStatusChangedEvent e = new IRemoteDesktopClientEvents_OnStatusChangedEvent(statusCode, statusMessage);
		parent.RaiseOnOnStatusChanged(parent, e);
	}

	public virtual void OnAutoReconnecting(int disconnectReason, int extendedDisconnectReason, string disconnectErrorMessage, bool networkAvailable, int attemptCount, int maxAttemptCount)
	{
		IRemoteDesktopClientEvents_OnAutoReconnectingEvent e = new IRemoteDesktopClientEvents_OnAutoReconnectingEvent(disconnectReason, extendedDisconnectReason, disconnectErrorMessage, networkAvailable, attemptCount, maxAttemptCount);
		parent.RaiseOnOnAutoReconnecting(parent, e);
	}

	public virtual void OnAutoReconnected()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnAutoReconnected(parent, e);
	}

	public virtual void OnDialogDisplaying()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDialogDisplaying(parent, e);
	}

	public virtual void OnDialogDismissed()
	{
		EventArgs e = new EventArgs();
		parent.RaiseOnOnDialogDismissed(parent, e);
	}

	public virtual void OnNetworkStatusChanged(uint qualityLevel, int bandwidth, int rtt)
	{
		IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent e = new IRemoteDesktopClientEvents_OnNetworkStatusChangedEvent(qualityLevel, bandwidth, rtt);
		parent.RaiseOnOnNetworkStatusChanged(parent, e);
	}

	public virtual void OnAdminMessageReceived(string adminMessage)
	{
		IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent e = new IRemoteDesktopClientEvents_OnAdminMessageReceivedEvent(adminMessage);
		parent.RaiseOnOnAdminMessageReceived(parent, e);
	}

	public virtual void OnKeyCombinationPressed(int keyCombination)
	{
		IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent e = new IRemoteDesktopClientEvents_OnKeyCombinationPressedEvent(keyCombination);
		parent.RaiseOnOnKeyCombinationPressed(parent, e);
	}

	public virtual void OnRemoteDesktopSizeChanged(int width, int height)
	{
		IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent e = new IRemoteDesktopClientEvents_OnRemoteDesktopSizeChangedEvent(width, height);
		parent.RaiseOnOnRemoteDesktopSizeChanged(parent, e);
	}

	public virtual void OnTouchPointerCursorMoved(int x, int y)
	{
		IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent e = new IRemoteDesktopClientEvents_OnTouchPointerCursorMovedEvent(x, y);
		parent.RaiseOnOnTouchPointerCursorMoved(parent, e);
	}
}
}
