using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MstscManage
{
	public class IniHelp
	{
		public string IniFile = Application.StartupPath + "\\Config.ini";
		public string path;

		public IniHelp(string FilePath = "")
		{
			this.path = (FilePath.IsNullOrEmpty() ? this.IniFile : FilePath);
		}

		public string ReadValue(string key, string section = "Config")
		{
			if (!File.Exists(this.path))
			{
				return string.Empty;
			}

			string[] lines = File.ReadAllLines(this.path, Encoding.UTF8);
			bool inSection = false;
			foreach (string line in lines)
			{
				string trimmed = line.Trim();
				if (trimmed.StartsWith("["))
				{
					inSection = trimmed.Equals("[" + section + "]", StringComparison.OrdinalIgnoreCase);
					continue;
				}
				if (inSection && trimmed.Contains("="))
				{
					int eqIndex = trimmed.IndexOf('=');
					string k = trimmed.Substring(0, eqIndex).Trim();
					if (k.Equals(key, StringComparison.OrdinalIgnoreCase))
					{
						return trimmed.Substring(eqIndex + 1).Trim();
					}
				}
			}
			return string.Empty;
		}

		public void WriteValue(string key, string value, string section = "Config")
		{
			string dir = Path.GetDirectoryName(this.path);
			if (!Directory.Exists(dir))
			{
				Directory.CreateDirectory(dir);
			}

			StringBuilder sb = new StringBuilder();
			bool sectionExists = false;
			bool keyWritten = false;

			if (File.Exists(this.path))
			{
				string[] lines = File.ReadAllLines(this.path, Encoding.UTF8);
				bool inSection = false;
				foreach (string line in lines)
				{
					string trimmed = line.Trim();
					if (trimmed.StartsWith("["))
					{
						if (inSection && !keyWritten)
						{
							sb.AppendLine(key + "=" + value);
							keyWritten = true;
						}
						inSection = trimmed.Equals("[" + section + "]", StringComparison.OrdinalIgnoreCase);
						if (inSection)
						{
							sectionExists = true;
						}
					}
					else if (inSection && trimmed.Contains("="))
					{
						int eqIndex = trimmed.IndexOf('=');
						string k = trimmed.Substring(0, eqIndex).Trim();
						if (k.Equals(key, StringComparison.OrdinalIgnoreCase))
						{
							sb.AppendLine(key + "=" + value);
							keyWritten = true;
							continue;
						}
					}
					sb.AppendLine(line);
				}
				if (inSection && !keyWritten)
				{
					sb.AppendLine(key + "=" + value);
					keyWritten = true;
				}
			}

			if (!sectionExists)
			{
				if (sb.Length > 0)
				{
					sb.AppendLine();
				}
				sb.AppendLine("[" + section + "]");
				sb.AppendLine(key + "=" + value);
			}

			File.WriteAllText(this.path, sb.ToString(), Encoding.UTF8);
		}
	}
}
