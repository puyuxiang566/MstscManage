using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MstscManage
{
	public class RDPFile
	{
		public int ScreenMode
		{
			get
			{
				return this._screenMode;
			}
			set
			{
				this._screenMode = value;
			}
		}

		public int DesktopWidth
		{
			get
			{
				return this._desktopWidth;
			}
			set
			{
				this._desktopWidth = value;
			}
		}

		public int DesktopHeight
		{
			get
			{
				return this._desktopHeight;
			}
			set
			{
				this._desktopHeight = value;
			}
		}

		public RDPFile.SessionBPPs SessionBPP
		{
			get
			{
				return this._sessionBPP;
			}
			set
			{
				this._sessionBPP = value;
			}
		}

		public RDPFile.WindowsPosition WinPosStr
		{
			get
			{
				return this._winPosStr;
			}
			set
			{
				this._winPosStr = value;
			}
		}

		public string FullAddress
		{
			get
			{
				return this._fullAddress;
			}
			set
			{
				this._fullAddress = value;
			}
		}

		public int Compression
		{
			get
			{
				return this._compression;
			}
			set
			{
				this._compression = value;
			}
		}

		public RDPFile.KeyboardHooks KeyboardHook
		{
			get
			{
				return this._keyboardHook;
			}
			set
			{
				this._keyboardHook = value;
			}
		}

		public RDPFile.AudioModes AudioMode
		{
			get
			{
				return this._audiomode;
			}
			set
			{
				this._audiomode = value;
			}
		}

		public int RedirectDrives
		{
			get
			{
				return this._redirectDrives;
			}
			set
			{
				this._redirectDrives = value;
			}
		}

		public int RedirectPrinters
		{
			get
			{
				return this._redirectPrinters;
			}
			set
			{
				this._redirectPrinters = value;
			}
		}

		public int RedirectComPorts
		{
			get
			{
				return this._redirectComPorts;
			}
			set
			{
				this._redirectComPorts = value;
			}
		}

		public int RedirectSmartCards
		{
			get
			{
				return this._redirectSmartCards;
			}
			set
			{
				this._redirectSmartCards = value;
			}
		}

		public int DisplayConnectionBar
		{
			get
			{
				return this._displayConnectionBar;
			}
			set
			{
				this._displayConnectionBar = value;
			}
		}

		public int AutoReconnectionEnabled
		{
			get
			{
				return this._autoReconnectionEnabled;
			}
			set
			{
				this._autoReconnectionEnabled = value;
			}
		}

		public string Username
		{
			get
			{
				return this._username;
			}
			set
			{
				this._username = value;
			}
		}

		public string Domain
		{
			get
			{
				return this._domain;
			}
			set
			{
				this._domain = value;
			}
		}

		public string AlternateShell
		{
			get
			{
				return this._alternateShell;
			}
			set
			{
				this._alternateShell = value;
			}
		}

		public string ShellWorkingDirectory
		{
			get
			{
				return this._shellWorkingDirectory;
			}
			set
			{
				this._shellWorkingDirectory = value;
			}
		}

		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
			}
		}

		public int DisableWallpaper
		{
			get
			{
				return this._disableWallpaper;
			}
			set
			{
				this._disableWallpaper = value;
			}
		}

		public int DisableFullWindowDrag
		{
			get
			{
				return this._disableFullWindowDrag;
			}
			set
			{
				this._disableFullWindowDrag = value;
			}
		}

		public int DisableMenuAnims
		{
			get
			{
				return this._disableMenuAnims;
			}
			set
			{
				this._disableMenuAnims = value;
			}
		}

		public int DisableThemes
		{
			get
			{
				return this._disableThemes;
			}
			set
			{
				this._disableThemes = value;
			}
		}

		public int DisableCursorSettings
		{
			get
			{
				return this._disableCursorSettings;
			}
			set
			{
				this._displayConnectionBar = value;
			}
		}

		public int BitmapCachePersistEnable
		{
			get
			{
				return this._bitmapCachePersistEnable;
			}
			set
			{
				this._bitmapCachePersistEnable = value;
			}
		}

		public void Read(string filepath)
		{
			this._filename = filepath;
			string data = string.Empty;
			using (StreamReader reader = new StreamReader(filepath, Encoding.UTF8))
			{
				data = reader.ReadToEnd();
			}
			string[] settings = data.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.RemoveEmptyEntries);
			foreach (string thisSetting in settings)
			{
				string regex = "(?<type>.*)\\:(?<dtype>\\w)\\:(?<value>.*)";
				RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace;
				Regex reg = new Regex(regex, options);
				bool flag = reg.IsMatch(thisSetting);
				if (flag)
				{
					Match i = reg.Match(thisSetting);
					string v = i.Groups["value"].Value;
					string text = i.Groups["type"].Value;
					if (text == "disable themes")
					{
						this._disableThemes = int.Parse(v);
					}
					else if (text == "password 51")
					{
						this._password = v;
					}
					else if (text == "disable full window drag")
					{
						this._disableFullWindowDrag = int.Parse(v);
					}
					else if (text == "compression")
					{
						this._compression = int.Parse(v);
					}
					else if (text == "redirectcomports")
					{
						this._redirectComPorts = int.Parse(v);
					}
					else if (text == "desktopwidth")
					{
						this._desktopWidth = int.Parse(v);
					}
					else if (text == "shell working directory")
					{
						this._shellWorkingDirectory = v;
					}
					else if (text == "username")
					{
						this._username = v;
					}
					else if (text == "redirectsmartcards")
					{
						this._redirectSmartCards = int.Parse(v);
					}
					else if (text == "displayconnectionbar")
					{
						this._displayConnectionBar = int.Parse(v);
					}
					else if (text == "session bpp")
					{
						this._sessionBPP = (RDPFile.SessionBPPs)int.Parse(v);
					}
					else if (text == "disable wallpaper")
					{
						this._disableWallpaper = int.Parse(v);
					}
					else if (text == "disable cursor setting")
					{
						this._disableCursorSettings = int.Parse(v);
					}
					else if (text == "screen mode id")
					{
						this._screenMode = int.Parse(v);
					}
					else if (text == "full address")
					{
						this._fullAddress = v;
					}
					else if (text == "audiomode")
					{
						this._audiomode = (RDPFile.AudioModes)int.Parse(v);
					}
					else if (text == "disable menu anims")
					{
						this._disableMenuAnims = int.Parse(v);
					}
					else if (text == "desktopheight")
					{
						this._desktopHeight = int.Parse(v);
					}
					else if (text == "redirectdrives")
					{
						this._redirectDrives = int.Parse(v);
					}
					else if (text == "bitmapcachepersistenable")
					{
						this._bitmapCachePersistEnable = int.Parse(v);
					}
					else if (text == "keyboardhook")
					{
						this._keyboardHook = (RDPFile.KeyboardHooks)int.Parse(v);
					}
					else if (text == "domain")
					{
						this._domain = v;
					}
					else if (text == "autoreconnection enabled")
					{
						this._autoReconnectionEnabled = int.Parse(v);
					}
					else if (text == "winposstr")
					{
						string[] vals = v.Split(new char[]
						{
							','
						});
						this._winPosStr.WinState = (RDPFile.WindowState)int.Parse(vals[1]);
						this._winPosStr.Rect.Top = int.Parse(vals[2]);
						this._winPosStr.Rect.Left = int.Parse(vals[3]);
						this._winPosStr.Rect.Width = int.Parse(vals[4]);
						this._winPosStr.Rect.Height = int.Parse(vals[5]);
					}
					else if (text == "redirectprinters")
					{
						this._redirectPrinters = int.Parse(v);
					}
					else if (text == "alternate shell")
					{
						this._alternateShell = v;
					}
				}
			}
		}

		public void Update()
		{
			this.Save(this._filename);
		}

		public void Save(string filepath)
		{
			this._filename = filepath;
			string template = string.Empty;
			foreach (string temp in this._rdpTemplate)
			{
				template = template + temp + "\r\n";
			}
			string data = string.Format(template, new object[]
			{
				this._screenMode,
				this._desktopWidth,
				this._desktopHeight,
				(int)this._sessionBPP,
				(int)this._winPosStr.WinState,
				this._winPosStr.Rect.Top,
				this._winPosStr.Rect.Left,
				this._winPosStr.Rect.Width,
				this._winPosStr.Rect.Height,
				this._fullAddress,
				this._compression,
				(int)this._keyboardHook,
				(int)this._audiomode,
				this._redirectDrives,
				this._redirectPrinters,
				this._redirectComPorts,
				this._redirectSmartCards,
				this._displayConnectionBar,
				this._autoReconnectionEnabled,
				this._username,
				this._domain,
				this._alternateShell,
				this._shellWorkingDirectory,
				this._password,
				this._disableWallpaper,
				this._disableFullWindowDrag,
				this._disableMenuAnims,
				this._disableThemes,
				this._disableCursorSettings,
				this._bitmapCachePersistEnable
			});
			using (StreamWriter writer = new StreamWriter(filepath, false, Encoding.UTF8))
			{
				writer.Write(data);
			}
		}

		private string _filename = string.Empty;

		private string[] _rdpTemplate = new string[]
		{
			"screen mode id:i:{0}",
			"desktopwidth:i:{1}",
			"desktopheight:i:{2}",
			"session bpp:i:{3}",
			"winposstr:s:0,{4},{5},{6},{7},{8}",
			"full address:s:{9}",
			"compression:i:{10}",
			"keyboardhook:i:{11}",
			"audiomode:i:{12}",
			"redirectdrives:i:{13}",
			"redirectprinters:i:{14}",
			"redirectcomports:i:{15}",
			"redirectsmartcards:i:{16}",
			"displayconnectionbar:i:{17}",
			"autoreconnection enabled:i:{18}",
			"username:s:{19}",
			"domain:s:{20}",
			"alternate shell:s:{21}",
			"shell working directory:s:{22}",
			"password 51:b:{23}",
			"disable wallpaper:i:{24}",
			"disable full window drag:i:{25}",
			"disable menu anims:i:{26}",
			"disable themes:i:{27}",
			"disable cursor setting:i:{28}",
			"bitmapcachepersistenable:i:{29}",
			"administrative Session:i:1",
			"drivestoredirect:s:" + Config.GetConfig().SelectDiskList
		};

		private int _screenMode = 0;

		private int _desktopWidth = 0;

		private int _desktopHeight = 0;

		private RDPFile.SessionBPPs _sessionBPP = (RDPFile.SessionBPPs)0;

		private RDPFile.WindowsPosition _winPosStr;

		private string _fullAddress = string.Empty;

		private int _compression = 0;

		private RDPFile.KeyboardHooks _keyboardHook = RDPFile.KeyboardHooks.ON_THE_LOCAL_COMPUTER;

		private RDPFile.AudioModes _audiomode = RDPFile.AudioModes.BRING_TO_THIS_COMPUTER;

		private int _redirectDrives = 0;

		private int _redirectPrinters = 0;

		private int _redirectComPorts = 0;

		private int _redirectSmartCards = 0;

		private int _displayConnectionBar = 0;

		private int _autoReconnectionEnabled = 0;

		private string _username = string.Empty;

		private string _domain = string.Empty;

		private string _alternateShell = string.Empty;

		private string _shellWorkingDirectory = string.Empty;

		private string _password = string.Empty;

		private int _disableWallpaper = 0;

		private int _disableFullWindowDrag = 0;

		private int _disableMenuAnims = 0;

		private int _disableThemes = 0;

		private int _disableCursorSettings = 0;

		private int _bitmapCachePersistEnable = 0;

		public enum KeyboardHooks
		{
			ON_THE_LOCAL_COMPUTER,
			ON_THE_REMOTE_COMPUTER,
			IN_FULL_SCREEN_MODE_ONLY
		}

		public enum AudioModes
		{
			BRING_TO_THIS_COMPUTER,
			DO_NOT_PLAY,
			LeAVE_AT_REMOTE_COMOPUTER
		}

		public enum WindowState
		{
			NORMAL = 1,
			MAXMIZE = 3
		}

		public enum SessionBPPs
		{
			BPP_8 = 8,
			BPP_15 = 15,
			BPP_16,
			BPP_24 = 24
		}

		public struct RECT
		{
			public int Top;

			public int Left;

			public int Width;

			public int Height;
		}

		public struct WindowsPosition
		{
			public RDPFile.WindowState WinState;

			public RDPFile.RECT Rect;
		}
	}
}
