using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace System
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public static class FishArrayExtension
	{
		public static T[] Filter<T>(this T[] array, Func<int, T, bool> filterExpression)
		{
			bool flag = array == null;
			if (flag)
			{
				throw new ArgumentNullException("array");
			}
			bool flag2 = filterExpression == null;
			if (flag2)
			{
				throw new ArgumentNullException("filterExpression");
			}
			List<T> list = new List<T>(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				bool flag3 = filterExpression(i, array[i]);
				if (flag3)
				{
					list.Add(array[i]);
				}
			}
			return list.ToArray();
		}

		public static void ForEachWithIndex<T>(this T[] array, Action<int, T> action)
		{
			bool flag = array == null;
			if (flag)
			{
				throw new ArgumentNullException("array");
			}
			bool flag2 = action == null;
			if (flag2)
			{
				throw new ArgumentNullException("action");
			}
			for (int i = 0; i < array.Length; i++)
			{
				action(i, array[i]);
			}
		}

		public static bool Contains<T>(this T[] array, T value, Func<T, T, bool> comparer)
		{
			bool flag = array == null;
			if (flag)
			{
				throw new ArgumentNullException("array");
			}
			bool flag2 = comparer == null;
			if (flag2)
			{
				throw new ArgumentNullException("comparer");
			}
			foreach (T item in array)
			{
				bool flag3 = comparer(value, item);
				if (flag3)
				{
					return true;
				}
			}
			return false;
		}

		public static void ForEach<T>(this IEnumerable<T> enumberable, Action<T> predicate)
		{
			bool flag = enumberable == null;
			if (flag)
			{
				throw new ArgumentNullException("enumberable", "enumberable is null.");
			}
			bool flag2 = predicate == null;
			if (flag2)
			{
				throw new ArgumentNullException("predicate", "predicate is null.");
			}
			foreach (T item in enumberable)
			{
				predicate(item);
			}
		}

		public static bool IsEmpty<T>(this T[] array)
		{
			return array == null || array.Length == 0;
		}

		public static string Join(this string[] array, string seperator)
		{
			return string.Join(seperator, array);
		}

		public static string Join(this IEnumerable<string> array, string seperator)
		{
			return array.ToArray<string>().Join(seperator);
		}

		public static string Join(this IEnumerable<char> array, string seperator)
		{
			return (from s in array
			select s.ToString()).ToArray<string>().Join(seperator);
		}

		public static bool WithinIndex(this Array source, int index)
		{
			return source.WithinIndex(index, 0);
		}

		public static bool WithinIndex(this Array source, int index, int dimension)
		{
			return source != null && index >= source.GetLowerBound(dimension) && index <= source.GetUpperBound(dimension);
		}

		public static void Clear<T>(this T[] array)
		{
			bool flag = array == null;
			if (!flag)
			{
				Array.Clear(array, 0, array.Length);
			}
		}

		public static int FindIndex<T>(this IEnumerable<T> src, Func<T, bool> predicate)
		{
			bool flag = src == null;
			if (flag)
			{
				throw new ArgumentNullException("src", "src is null.");
			}
			bool flag2 = predicate == null;
			if (flag2)
			{
				throw new ArgumentNullException("predicate", "predicate is null.");
			}
			int index = 0;
			foreach (T item in src)
			{
				bool flag3 = predicate(item);
				if (flag3)
				{
					return index;
				}
				index++;
			}
			return -1;
		}

		public static int FindSequence<T>(this T[] array, T[] sequence, int startIndex = 0, IEqualityComparer<T> comparer = null)
		{
			bool flag = array == null || sequence == null || array.Length < sequence.Length + startIndex;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				bool flag2 = comparer == null;
				if (flag2)
				{
					comparer = EqualityComparer<T>.Default;
				}
				int len = sequence.Length;
				int limitLen = array.Length - sequence.Length;
				for (int i = startIndex; i <= limitLen; i++)
				{
					int j;
					for (j = 0; j < len; j++)
					{
						bool flag3 = !comparer.Equals(array[i], sequence[j]);
						if (flag3)
						{
							break;
						}
					}
					bool flag4 = j == len;
					if (flag4)
					{
						return i;
					}
				}
				result = -1;
			}
			return result;
		}

		public static int FindSequence(this byte[] array, byte[] sequence, int startIndex = 0)
		{
			bool flag = array == null || sequence == null || array.Length < sequence.Length + startIndex;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int len = sequence.Length;
				int limitLen = array.Length - sequence.Length;
				for (int i = startIndex; i <= limitLen; i++)
				{
					int j;
					for (j = 0; j < len; j++)
					{
						bool flag2 = array[i] != sequence[j];
						if (flag2)
						{
							break;
						}
					}
					bool flag3 = j == len;
					if (flag3)
					{
						return i;
					}
				}
				result = -1;
			}
			return result;
		}

		public static int FindSequence(this int[] array, int[] sequence, int startIndex = 0)
		{
			bool flag = array == null || sequence == null || array.Length < sequence.Length + startIndex;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int len = sequence.Length;
				int limitLen = array.Length - sequence.Length;
				for (int i = startIndex; i <= limitLen; i++)
				{
					int j;
					for (j = 0; j < len; j++)
					{
						bool flag2 = array[i] != sequence[j];
						if (flag2)
						{
							break;
						}
					}
					bool flag3 = j == len;
					if (flag3)
					{
						return i;
					}
				}
				result = -1;
			}
			return result;
		}

		public static int FindSequence(this char[] array, char[] sequence, int startIndex = 0)
		{
			bool flag = array == null || sequence == null || array.Length < sequence.Length + startIndex;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int len = sequence.Length;
				int limitLen = array.Length - sequence.Length;
				for (int i = startIndex; i <= limitLen; i++)
				{
					int j;
					for (j = 0; j < len; j++)
					{
						bool flag2 = array[i] != sequence[j];
						if (flag2)
						{
							break;
						}
					}
					bool flag3 = j == len;
					if (flag3)
					{
						return i;
					}
				}
				result = -1;
			}
			return result;
		}

		public static string ToBase64(this byte[] array)
		{
			return Convert.ToBase64String(array);
		}

		public static Image ToImage(this byte[] array)
		{
			Image result;
			try
			{
				using (MemoryStream ms = new MemoryStream())
				{
					ms.Write(array, 0, array.Length);
					ms.Seek(0L, SeekOrigin.Begin);
					Image img = Image.FromStream(ms);
					ms.Dispose();
					result = img;
				}
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		public static byte[] ToBytes(this bool value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this short value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this ushort value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this char value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this long value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this ulong value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this int value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this uint value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this float value)
		{
			return BitConverter.GetBytes(value);
		}

		public static byte[] ToBytes(this double value)
		{
			return BitConverter.GetBytes(value);
		}

		public static bool ToBoolean(this byte[] buffer)
		{
			return buffer.ToBoolean(0);
		}

		public static bool ToBoolean(this byte[] buffer, int offset)
		{
			return BitConverter.ToBoolean(buffer, offset);
		}

		public static char ToChar(this byte[] buffer)
		{
			return buffer.ToChar(0);
		}

		public static char ToChar(this byte[] buffer, int offset)
		{
			return BitConverter.ToChar(buffer, offset);
		}

		public static double ToDouble(this byte[] buffer)
		{
			return buffer.ToDouble(0);
		}

		public static double ToDouble(this byte[] buffer, int offset)
		{
			return BitConverter.ToDouble(buffer, offset);
		}

		public static short ToShort(this byte[] buffer)
		{
			return buffer.ToShort(0);
		}

		public static short ToShort(this byte[] buffer, int offset)
		{
			return BitConverter.ToInt16(buffer, offset);
		}

		public static int ToInt(this byte[] buffer)
		{
			return buffer.ToInt32(0);
		}

		public static int ToInt32(this byte[] buffer, int offset)
		{
			return BitConverter.ToInt32(buffer, offset);
		}

		public static long ToInt64(this byte[] buffer)
		{
			return buffer.ToInt64(0);
		}

		public static long ToInt64(this byte[] buffer, int offset)
		{
			return BitConverter.ToInt64(buffer, offset);
		}

		public static float ToSingle(this byte[] buffer)
		{
			return buffer.ToSingle(0);
		}

		public static float ToSingle(this byte[] buffer, int offset)
		{
			return BitConverter.ToSingle(buffer, offset);
		}

		public static string ToHexString(this byte[] buffer, int offset = 0, int length = 0, char seperator = '\0', bool upperCase = true)
		{
			bool flag = seperator == '-';
			string result;
			if (flag)
			{
				result = BitConverter.ToString(buffer, offset, length);
			}
			else
			{
				bool flag2 = length == 0;
				if (flag2)
				{
					length = buffer.Length;
				}
				StringBuilder sb = new StringBuilder(length * 2 + ((seperator == '\0') ? 0 : (length - 1)));
				int endOffset = offset + length;
				for (int i = offset; i < endOffset; i++)
				{
					sb.Append(buffer[i].ToString(upperCase ? "X2" : "x2"));
					bool flag3 = seperator != '\0' && i < endOffset - 1;
					if (flag3)
					{
						sb.Append(seperator);
					}
				}
				result = sb.ToString();
			}
			return result;
		}

		public static ushort ToUInt16(this byte[] buffer, int offset)
		{
			return BitConverter.ToUInt16(buffer, offset);
		}

		public static uint ToInt32U(this byte[] buffer, int offset)
		{
			return BitConverter.ToUInt32(buffer, offset);
		}

		public static ulong ToUInt64(this byte[] buffer, int offset)
		{
			return BitConverter.ToUInt64(buffer, offset);
		}

		public static void CopyToBuffer(this int value, byte[] buffer)
		{
			value.CopyToBuffer(buffer, 0);
		}

		public static void CopyToBuffer(this int value, byte[] buffer, int offset)
		{
			bool flag = buffer == null || buffer.Length < offset + 4;
			if (flag)
			{
				throw new ArgumentException();
			}
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, offset, 4);
		}

		public static void CopyToBuffer(this uint value, byte[] buffer)
		{
			value.CopyToBuffer(buffer, 0);
		}

		public static void CopyToBuffer(this uint value, byte[] buffer, int offset)
		{
			bool flag = buffer == null || buffer.Length < offset + 4;
			if (flag)
			{
				throw new ArgumentException();
			}
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, offset, 4);
		}

		public static void CopyToBuffer(this short value, byte[] buffer)
		{
			value.CopyToBuffer(buffer, 0);
		}

		public static void CopyToBuffer(this short value, byte[] buffer, int offset)
		{
			bool flag = buffer == null || buffer.Length < offset + 2;
			if (flag)
			{
				throw new ArgumentException();
			}
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, offset, 2);
		}

		public static void CopyToBuffer(this ushort value, byte[] buffer)
		{
			value.CopyToBuffer(buffer, 0);
		}

		public static void CopyToBuffer(this ushort value, byte[] buffer, int offset)
		{
			bool flag = buffer == null || buffer.Length < offset + 2;
			if (flag)
			{
				throw new ArgumentException();
			}
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, offset, 2);
		}

		public static void CopyToBuffer(this long value, byte[] buffer)
		{
			((float)value).CopyToBuffer(buffer, 0);
		}

		public static void CopyToBuffer(this ulong value, byte[] buffer, int offset)
		{
			bool flag = buffer == null || buffer.Length < offset + 8;
			if (flag)
			{
				throw new ArgumentException();
			}
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, offset, 8);
		}

		public static void CopyToBuffer(this float value, byte[] buffer)
		{
			value.CopyToBuffer(buffer, 0);
		}

		public static void CopyToBuffer(this float value, byte[] buffer, int offset)
		{
			bool flag = buffer == null || buffer.Length < offset + 4;
			if (flag)
			{
				throw new ArgumentException();
			}
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, offset, 4);
		}

		public static void CopyToBuffer(this double value, byte[] buffer)
		{
			value.CopyToBuffer(buffer, 0);
		}

		public static void CopyToBuffer(this double value, byte[] buffer, int offset)
		{
			bool flag = buffer == null || buffer.Length < offset + 8;
			if (flag)
			{
				throw new ArgumentException();
			}
			Array.Copy(BitConverter.GetBytes(value), 0, buffer, offset, 8);
		}

		public static int CopyToBuffer(this string value, byte[] buffer)
		{
			return value.CopyToBuffer(buffer, 0);
		}

		public static int CopyToBuffer(this string value, byte[] buffer, int offset)
		{
			return value.CopyToBuffer(null, buffer, offset);
		}

		public static int CopyToBuffer(this string value, Encoding encoding, byte[] buffer, int offset)
		{
			bool flag = buffer == null;
			if (flag)
			{
				throw new ArgumentNullException("buffer");
			}
			bool flag2 = value.IsNullOrEmpty();
			int result;
			if (flag2)
			{
				result = 0;
			}
			else
			{
				byte[] bytes = (encoding ?? Encoding.Unicode).GetBytes(value);
				bool flag3 = buffer.Length < offset + bytes.Length;
				if (flag3)
				{
					throw new InvalidOperationException("缓冲数组长度不足");
				}
				Array.Copy(bytes, 0, buffer, offset, buffer.Length);
				result = buffer.Length;
			}
			return result;
		}

		public static byte[] MD5(this byte[] source)
		{
			MD5 md5 = System.Security.Cryptography.MD5.Create();
			return md5.ComputeHash(source);
		}

		public static string Md5String(this byte[] source)
		{
			return BitConverter.ToString(source.MD5()).Replace("-", "").ToUpper();
		}

		public static byte[] Sha1(this byte[] source)
		{
			SHA1 sha = SHA1.Create();
			return sha.ComputeHash(source);
		}

		public static string Sha1String(this byte[] source)
		{
			return BitConverter.ToString(source.Sha1()).Replace("-", "").ToUpper();
		}

		public static byte[] Compress(this byte[] source)
		{
			byte[] result;
			using (MemoryStream ms = new MemoryStream())
			{
				using (GZipStream gzip = new GZipStream(ms, CompressionMode.Compress))
				{
					gzip.Write(source);
					gzip.Dispose();
					result = ms.ToArray();
				}
			}
			return result;
		}

		public static byte[] Decompress(this byte[] source)
		{
			byte[] result;
			using (MemoryStream ms = new MemoryStream(source))
			{
				using (GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress))
				{
					using (MemoryStream msout = new MemoryStream())
					{
						byte[] buffer = new byte[1024];
						int count;
						while ((count = gzip.Read(buffer, 0, buffer.Length)) > 0)
						{
							msout.Write(buffer, 0, count);
						}
						msout.Dispose();
						result = msout.ToArray();
					}
				}
			}
			return result;
		}
	}
}
