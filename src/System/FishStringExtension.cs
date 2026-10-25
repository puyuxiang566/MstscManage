using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.FishExtension;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class FishStringExtension
	{
		public static byte ToHexByte(this char code)
		{
			bool flag = code >= 'A' && code <= 'F';
			byte result;
			if (flag)
			{
				result = (byte)('\n' + (code - 'A'));
			}
			else
			{
				bool flag2 = code >= 'a' && code <= 'f';
				if (flag2)
				{
					result = (byte)('\n' + (code - 'a'));
				}
				else
				{
					bool flag3 = code >= '0' && code <= '9';
					if (flag3)
					{
						result = (byte)(code - '0');
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		public static bool IsNullOrEmpty(this string str)
		{
			return string.IsNullOrEmpty(str);
		}

		public static bool IsNullOrEmpty(this object str)
		{
			bool flag = str == null;
			return flag || string.IsNullOrEmpty(str.ToString());
		}

		public static string[] ToLines(this string value)
		{
			bool flag = string.IsNullOrEmpty(value);
			string[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = value.Split(new char[]
				{
					'\r',
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries);
			}
			return result;
		}

		public static string TemplateTagReplace(this string template, string[] tags, string[] dest)
		{
			bool flag = tags.Length != dest.Length;
			if (flag)
			{
				throw new InvalidOperationException("数组长度必须一样.");
			}
			for (int i = 0; i < tags.Length; i++)
			{
				template = template.Replace(tags[i], dest[i]);
			}
			return template;
		}

		public static string EncodeToJsExpression(this string value)
		{
			bool flag = value.IsNullOrEmpty();
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				result = FishStringExtension.ExpressConvertor.Replace(value, delegate(Match s)
				{
					bool flag2 = s.Value == "\r";
					string result2;
					if (flag2)
					{
						result2 = "\\r";
					}
					else
					{
						bool flag3 = s.Value == "\n";
						if (flag3)
						{
							result2 = "\\n";
						}
						else
						{
							result2 = "\\" + s.Value;
						}
					}
					return result2;
				});
			}
			return result;
		}

		public static string DecodeFromJsExpression(this string value)
		{
			bool flag = value.IsNullOrEmpty();
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				result = FishStringExtension.ExpressReConvertor.Replace(value, delegate(Match s)
				{
					string key = s.Groups[1].Value;
					bool flag2 = key == "r";
					string result2;
					if (flag2)
					{
						result2 = "\r";
					}
					else
					{
						bool flag3 = key == "n";
						if (flag3)
						{
							result2 = "\n";
						}
						else
						{
							bool flag4 = key[0] == 'u';
							if (flag4)
							{
								result2 = ((char)s.Groups[2].Value.ToInt32(0, NumberStyles.AllowHexSpecifier, null)).ToString();
							}
							else
							{
								result2 = key;
							}
						}
					}
					return result2;
				});
			}
			return result;
		}

		public static string DefaultForEmpty(this string value, string defaultValue)
		{
			return string.IsNullOrEmpty(value) ? defaultValue : value;
		}

		[StringFormatMethod("value")]
		public static string FormatWith(this string value, params object[] args)
		{
			bool flag = value == null;
			if (flag)
			{
				throw new ArgumentNullException("value");
			}
			bool flag2 = value.Length == 0;
			string result;
			if (flag2)
			{
				result = string.Empty;
			}
			else
			{
				bool flag3 = args.Length == 0;
				if (flag3)
				{
					result = value;
				}
				else
				{
					result = string.Format(value, args);
				}
			}
			return result;
		}

		public static bool IsEmail(this string value)
		{
			return !value.IsNullOrEmpty() && FishStringExtension._emailReg.IsMatch(value);
		}

		public static bool IsIgnoreCaseEqualTo(this string value, string compareTo)
		{
			return string.Compare(value, compareTo, true) == 0;
		}

		public static string EnsureEndWith(this string value, string ending)
		{
			bool flag = value == null || value.EndsWith(ending);
			string result;
			if (flag)
			{
				result = value;
			}
			else
			{
				result = value + ending;
			}
			return result;
		}

		public static int GetByteCount(this string value)
		{
			return value.GetByteCount(Encoding.Unicode);
		}

		public static int GetByteCount(this string value, Encoding encoding)
		{
			bool flag = value.IsNullOrEmpty();
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = encoding.GetByteCount(value);
			}
			return result;
		}

		public static byte[] ToBytes(this string value)
		{
			return value.ToBytes(null);
		}

		public static byte[] ToBytes(this string value, Encoding encoding)
		{
			return value.IsNullOrEmpty() ? new byte[0] : (encoding ?? Encoding.Unicode).GetBytes(value);
		}

		public static bool Contains(this string str, string key, StringComparison comparison)
		{
			return str.IndexOf(key, comparison) != -1;
		}

		public static IEnumerable<string> SplitByTag(this string text, string startTag, string endTag, int startPos = 0)
		{
			int index = 0;
			while ((index = text.IndexOf(startTag, startPos, StringComparison.OrdinalIgnoreCase)) != -1)
			{
				int endIndex = text.IndexOf(endTag, index + startTag.Length, StringComparison.OrdinalIgnoreCase);
				bool flag = endIndex == -1;
				if (flag)
				{
					yield break;
				}
				string str = text.Substring(index, endIndex - index + endTag.Length);
				startPos = endIndex + endTag.Length + 1;
				yield return str;
				str = null;
			}
			yield break;
		}

		public static string[] RegMatch(this string text, string pattern, RegexOptions options = RegexOptions.IgnoreCase)
		{
			Match i = Regex.Match(text, pattern, options);
			bool flag = !i.Success;
			string[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = (from Group s in i.Groups
				select s.Value).ToArray<string>();
			}
			return result;
		}

		public static List<string[]> RegMatches(this string text, string pattern, RegexOptions options = RegexOptions.IgnoreCase)
		{
			MatchCollection i = Regex.Matches(text, pattern, options);
			return (from Match s in i
			select (from Group x in s.Groups
			select x.Value).ToArray<string>()).ToList<string[]>();
		}

		public static string SearchStringTag(this string text, string beginTag, string endTag, int beginIndex = 0, bool includeTag = true, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
		{
			return text.SearchStringTag(beginTag, endTag, ref beginIndex, includeTag, comparison);
		}

		public static string SearchStringTag(this string text, string beginTag, string endTag, ref int beginIndex, bool includeTag = true, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
		{
			bool flag = string.IsNullOrEmpty(text) || beginIndex >= text.Length;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				int startIndex = beginIndex;
				int endIndex = text.Length;
				bool tagStartEmpty = beginTag.IsNullOrEmpty();
				bool tagEndEmpty = endTag.IsNullOrEmpty();
				bool flag2 = !tagStartEmpty;
				if (flag2)
				{
					startIndex = text.IndexOf(beginTag, startIndex, comparison);
				}
				bool flag3 = startIndex == -1;
				if (flag3)
				{
					result = string.Empty;
				}
				else
				{
					bool flag4 = !tagEndEmpty;
					if (flag4)
					{
						endIndex = text.IndexOf(endTag, startIndex + ((!tagStartEmpty) ? (beginTag.Length + 1) : 1), comparison);
					}
					bool flag5 = endIndex == -1;
					if (flag5)
					{
						result = string.Empty;
					}
					else
					{
						beginIndex = endIndex + ((!tagEndEmpty) ? (endTag.Length + 1) : 1);
						result = text.Substring(startIndex + ((includeTag || tagStartEmpty) ? 0 : beginTag.Length), endIndex - startIndex - ((includeTag || tagStartEmpty) ? 0 : beginTag.Length) + ((tagEndEmpty || !includeTag) ? 0 : endTag.Length));
					}
				}
			}
			return result;
		}

		public static string MD5(this string key)
		{
			return key.MD5(Encoding.UTF8);
		}

		public static string MD5(this string key, string encoding)
		{
			return key.MD5(Encoding.GetEncoding(encoding));
		}

		public static string MD5(this string key, Encoding encoding)
		{
			bool flag = key == null;
			if (flag)
			{
				throw new ArgumentNullException();
			}
			MD5 md5 = System.Security.Cryptography.MD5.Create();
			byte[] has = md5.ComputeHash(encoding.GetBytes(key));
			return BitConverter.ToString(has).Replace("-", "").ToUpper();
		}

		public static int ToInt32ByDBNull(this object value, int defaultValue = 0, NumberStyles style = NumberStyles.Any, IFormatProvider provider = null)
		{
			bool flag = !Convert.IsDBNull(value) && value != null;
			int result;
			if (flag)
			{
				result = value.ToString().ToInt32(0, NumberStyles.Any, null);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		public static int ToInt32(this string value, int defaultValue = 0, NumberStyles style = NumberStyles.Any, IFormatProvider provider = null)
		{
			int temp;
			return int.TryParse(value, style, provider, out temp) ? temp : defaultValue;
		}

		public static int? ToInt32Nullable(this string value, NumberStyles style = NumberStyles.Any, IFormatProvider provider = null)
		{
			int temp;
			return int.TryParse(value, style, provider, out temp) ? new int?(temp) : null;
		}

		public static int[] SplitAsIntArray(this string value, NumberStyles style = NumberStyles.Any, IFormatProvider provider = null)
		{
			bool flag = string.IsNullOrEmpty(value);
			int[] result;
			if (flag)
			{
				result = new int[0];
			}
			else
			{
				result = (from s in value.Split(FishStringExtension.StringSpliter, StringSplitOptions.RemoveEmptyEntries)
				select s.ToInt32(0, style, provider)).ToArray<int>();
			}
			return result;
		}

		public static long ToInt64(this string value, long defaultValue = 0L, NumberStyles style = NumberStyles.Any, IFormatProvider provider = null)
		{
			long temp;
			return long.TryParse(value, style, provider, out temp) ? temp : defaultValue;
		}

		public static long? ToInt64Nullable(this string value, NumberStyles style = NumberStyles.Any, IFormatProvider provider = null)
		{
			long temp;
			return long.TryParse(value, style, provider, out temp) ? new long?(temp) : null;
		}

		public static float ToSingle(this string value, float defaultValue = 0f, NumberStyles style = NumberStyles.Any, IFormatProvider provider = null)
		{
			float temp;
			return float.TryParse(value, style, provider, out temp) ? temp : defaultValue;
		}

		public static float? ToSingleNullable(this string value, NumberStyles style = NumberStyles.Any, IFormatProvider provider = null)
		{
			float temp;
			return float.TryParse(value, style, provider, out temp) ? new float?(temp) : null;
		}

		public static DateTime ToDateTime(this string value, DateTime defaultValue, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParse(value, formatProvider, styles, out temp) ? temp : defaultValue;
		}

		public static DateTime ToDateTimeExact(this string value, DateTime defaultValue, string format, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParseExact(value, format, formatProvider, styles, out temp) ? temp : defaultValue;
		}

		public static DateTime ToDateTimeExact(this string value, DateTime defaultValue, string[] formats, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParseExact(value, formats, formatProvider, styles, out temp) ? temp : defaultValue;
		}

		public static DateTime ToDateTime(this string value, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParse(value, formatProvider, styles, out temp) ? temp : DateTime.MinValue;
		}

		public static DateTime ToDateTimeExact(this string value, string[] format = null, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParseExact(value, format, formatProvider, styles, out temp) ? temp : DateTime.MinValue;
		}

		public static DateTime ToDateTimeExact(this string value, string format, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParseExact(value, format, formatProvider, styles, out temp) ? temp : DateTime.MinValue;
		}

		public static DateTime? ToDateTimeNullable(this string value, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParse(value, out temp) ? new DateTime?(temp) : null;
		}

		public static DateTime? ToDateTimeNullableExact(this string value, string format, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParseExact(value, format, formatProvider, styles, out temp) ? new DateTime?(temp) : null;
		}

		public static DateTime? ToDateTimeNullableExact(this string value, string[] formats, IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTime temp;
			return DateTime.TryParseExact(value, formats, formatProvider, styles, out temp) ? new DateTime?(temp) : null;
		}

		public static double ToDouble(this string value, double defaultValue = 0.0, NumberStyles styles = NumberStyles.Any, IFormatProvider formatProvider = null)
		{
			double temp;
			return double.TryParse(value, styles, formatProvider, out temp) ? temp : defaultValue;
		}

		public static double? ToDoubleNullable(this string value, NumberStyles styles = NumberStyles.Any, IFormatProvider formatProvider = null)
		{
			double temp;
			return double.TryParse(value, styles, formatProvider, out temp) ? new double?(temp) : null;
		}

		public static decimal ToDecimal(this string value, decimal defaultValue = 0m, NumberStyles styles = NumberStyles.Any, IFormatProvider formatProvider = null)
		{
			decimal temp;
			return decimal.TryParse(value, styles, formatProvider, out temp) ? temp : defaultValue;
		}

		public static decimal? ToDecimalNullable(this string value, NumberStyles styles = NumberStyles.Any, IFormatProvider formatProvider = null)
		{
			decimal temp;
			return decimal.TryParse(value, styles, formatProvider, out temp) ? new decimal?(temp) : null;
		}

		public static Point ParseToPoint(this string location)
		{
			bool flag = string.IsNullOrEmpty(location);
			Point result;
			if (flag)
			{
				result = Point.Empty;
			}
			else
			{
				string[] pts = location.Split(new char[]
				{
					','
				}, StringSplitOptions.RemoveEmptyEntries);
				bool flag2 = pts.Length < 2;
				if (flag2)
				{
					result = Point.Empty;
				}
				else
				{
					result = new Point(pts[0].ToInt32(0, NumberStyles.Any, null), pts[1].ToInt32(0, NumberStyles.Any, null));
				}
			}
			return result;
		}

		public static DirectoryInfo AsDirectoryInfo(this string folder)
		{
			return new DirectoryInfo(folder);
		}

		public static FileInfo AsFileInfo(this string filePath)
		{
			return new FileInfo(filePath);
		}

		public static byte[] ConvertBase64ToBytes(this string base64String)
		{
			bool flag = base64String.IsNullOrEmpty();
			byte[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = Convert.FromBase64String(base64String);
			}
			return result;
		}

		public static byte[] Compress(this string source)
		{
			byte[] result;
			using (MemoryStream ms = new MemoryStream())
			{
				using (GZipStream gzip = new GZipStream(ms, CompressionMode.Compress))
				{
					using (StreamWriter sw = new StreamWriter(gzip, Encoding.UTF8))
					{
						sw.Write(source);
						sw.Dispose();
						result = ms.ToArray();
					}
				}
			}
			return result;
		}

		public static string DecompressAsString(this byte[] source)
		{
			string result;
			using (MemoryStream ms = new MemoryStream(source))
			{
				using (GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress))
				{
					using (StreamReader sr = new StreamReader(gzip, Encoding.UTF8, true))
					{
						result = sr.ReadToEnd();
					}
				}
			}
			return result;
		}

		public static byte[] ConvertHexStringToBytes(this string source)
		{
			bool flag = source.IsNullOrEmpty();
			byte[] result;
			if (flag)
			{
				result = new byte[0];
			}
			else
			{
				MatchCollection matches = Regex.Matches(source, "[a-f\\d]{2}", RegexOptions.IgnoreCase);
				result = (from Match s in matches
				select (byte)(((int)s.Value[0].ToHexByte() << 4) + (int)s.Value[0].ToHexByte())).ToArray<byte>();
			}
			return result;
		}

		public static string ToStringFormat(this Point point)
		{
			return point.X.ToString() + "," + point.Y.ToString();
		}

		private static readonly Regex ExpressConvertor = new Regex("(\\r|\\n|'|\"|\\\\|/)");

		private static readonly Regex ExpressReConvertor = new Regex("\\\\(r|n|'|\"|\\|/|u([a-fA-F0-9]{4}))");

		private static readonly Regex _emailReg = new Regex("^\\w+[\\.\\-_0-9a-z]+@[0-9a-z]+([\\-_\\.][0-9a-z]+)*\\.[a-z]{2,3}$", RegexOptions.IgnoreCase);

		private static char[] StringSpliter = new char[]
		{
			',',
			'|',
			'\\',
			'/',
			':',
			';',
			'_',
			'#',
			'$',
			'%',
			'@',
			'!',
			'^',
			'&',
			'*'
		};
	}
}
