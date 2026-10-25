using System;

namespace MstscManage
{
	public class Config
	{
		public string MstscType { get; set; }

		public string CheckPort { get; set; }

		public string LoginPwd { get; set; }

		public string SelectGrouping { get; set; }

		public string GroupingItem { get; set; }

		public string SelectDiskList { get; set; }

		public string MstscParameter { get; set; }

		private static string ReadValue(string key, string DefaultStr = "")
		{
			string Value = Config.help.ReadValue(key, "Config");
			return (!Value.IsNullOrEmpty()) ? Value : DefaultStr;
		}

		private static void WriteValue(string key, string value)
		{
			Config.help.WriteValue(key, value, "Config");
		}

		public static Config GetConfig()
		{
			string loginPwdValue = Config.ReadValue("LoginPwd", "");
			string loginPwd = string.Empty;
			try
			{
				loginPwd = DES.Decrypt_DES(loginPwdValue, "");
			}
			catch
			{
				loginPwd = string.Empty;
			}
			Config Model = new Config
			{
				MstscType = Config.ReadValue("MstscType", ""),
				CheckPort = Config.ReadValue("CheckPort", ""),
				LoginPwd = loginPwd,
				MstscParameter = Config.ReadValue("MstscParameter", ""),
				SelectGrouping = Config.ReadValue("SelectGrouping", ""),
				SelectDiskList = Config.ReadValue("SelectDiskList", ""),
				GroupingItem = Config.ReadValue("GroupingItem", "").Replace("，", ",")
			};
			bool flag = Model.MstscType.IsNullOrEmpty();
			if (flag)
			{
				Model.MstscType = "内置远程桌面";
				Config.WriteValue("MstscType", Model.MstscType);
			}
			bool flag2 = Model.GroupingItem.IsNullOrEmpty();
			if (flag2)
			{
				Model.GroupingItem = " 本地主机,网络主机";
				Config.WriteValue("GroupingItem", Model.GroupingItem);
			}
			bool flag3 = Model.CheckPort.IsNullOrEmpty();
			if (flag3)
			{
				Model.CheckPort = "1433,3389,80";
				Config.UpdateCheckPort(Model.CheckPort);
			}
			bool flag4 = Model.SelectGrouping.IsNullOrEmpty();
			if (flag4)
			{
				Model.SelectGrouping = "全部主机";
				Config.WriteValue("SelectGrouping", Model.SelectGrouping);
			}
			return Model;
		}

		public static void UpdateConfig(string MstscType, string MstscParameter, string SelectDiskList, string LoginPwd)
		{
			Config.WriteValue("MstscType", MstscType);
			Config.WriteValue("MstscParameter", MstscParameter);
			Config.WriteValue("SelectDiskList", SelectDiskList);
			Config.WriteValue("LoginPwd", DES.Encrypt_DES(LoginPwd, ""));
		}

		public static void UpdateConfigBySelectGrouping(string SelectGrouping)
		{
			Config.WriteValue("SelectGrouping", SelectGrouping);
		}

		public static void UpdateCheckPort(string CheckPort)
		{
			Config.WriteValue("CheckPort", CheckPort);
		}

		private static IniHelp help = new IniHelp("");
	}
}
