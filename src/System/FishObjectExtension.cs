using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.FishExtension;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace System
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class FishObjectExtension
	{
		public static byte[] ToBytes(this Image image)
		{
			return image.ToBytes(ImageFormat.Png);
		}

		public static byte[] ToBytes(this Image image, ImageFormat format)
		{
			bool flag = image == null;
			byte[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				using (MemoryStream ms = new MemoryStream())
				{
					image.Save(ms, format);
					ms.Close();
					result = ms.ToArray();
				}
			}
			return result;
		}

		public static void SaveAsJpeg(this Image image, string path)
		{
			image.SaveAsJpeg(path, 90);
		}

		public static void SaveAsJpeg(this Image image, string path, int quality)
		{
			EncoderParameters parameters = new EncoderParameters(1);
			parameters.Param[0] = new EncoderParameter(Encoder.Quality, (long)quality);
			ImageCodecInfo myImageCodecInfo = (from p in ImageCodecInfo.GetImageEncoders()
			where p.MimeType == "image/jpeg"
			select p).Single<ImageCodecInfo>();
			image.Save(path, myImageCodecInfo, parameters);
		}

		public static Image ResizeWithMargin(this Image image, int width, int height)
		{
			bool flag = image == null || image.Width >= width || image.Height >= height;
			Image result;
			if (flag)
			{
				result = image;
			}
			else
			{
				Bitmap nimg = new Bitmap(width, height);
				using (Graphics g = Graphics.FromImage(nimg))
				{
					g.DrawImage(image, (width - image.Width) / 2, (height - image.Height) / 2, image.Height, image.Width);
				}
				result = nimg;
			}
			return result;
		}

		public static string ToWebRgbColor(this Color color, bool upperCase = true)
		{
			string format = upperCase ? "X2" : "x2";
			return "#" + color.R.ToString(format) + color.G.ToString(format) + color.B.ToString(format);
		}

		public static string ToWebRgbaColor(this Color color)
		{
			return string.Format("rgba({0},{1},{2},{3})", new object[]
			{
				color.R,
				color.G,
				color.B,
				((double)color.A / 255.0).ToString("#0.00")
			});
		}

		internal static Type GetTypeInfo(Type type)
		{
			return type;
		}

		public static Dictionary<Type, T[]> GetFilteredTypeWithCustomerAttribute<T>(this Assembly assembly)
		{
			Dictionary<Type, T[]> dic = assembly.GetTypes().ToDictionary((Type s) => s, (Type s) => FishObjectExtension.GetTypeInfo(s).GetCustomAttributes(typeof(T), true).Cast<T>().ToArray<T>());
			(from s in dic.Keys
			where dic[s].Length == 0
			select s).ToArray<Type>().ForEach(delegate(Type s)
			{
				dic.Remove(s);
			});
			return dic;
		}

		public static Dictionary<MethodInfo, T[]> GetFilteredMethodWithCustomerAttribute<T>(this Type type)
		{
			return type.GetFilteredMethodWithCustomerAttribute<T>(BindingFlags.Instance | BindingFlags.Public);
		}

		public static Dictionary<MethodInfo, T[]> GetFilteredMethodWithCustomerAttribute<T>(this Type type, BindingFlags flags)
		{
			Dictionary<MethodInfo, T[]> dic = FishObjectExtension.GetTypeInfo(type).GetMethods(flags).ToDictionary((MethodInfo s) => s, (MethodInfo s) => s.GetCustomAttributes(typeof(T), true).Cast<T>().ToArray<T>());
			(from s in dic.Keys
			where dic[s].Length == 0
			select s).ToArray<MethodInfo>().ForEach(delegate(MethodInfo s)
			{
				dic.Remove(s);
			});
			return dic;
		}

		public static Dictionary<PropertyInfo, T[]> GetFilteredPropertyWithCustomerAttribute<T>(this Type type)
		{
			return type.GetFilteredPropertyWithCustomerAttribute<T>(BindingFlags.Instance | BindingFlags.Public);
		}

		public static Dictionary<PropertyInfo, T[]> GetFilteredPropertyWithCustomerAttribute<T>(this Type type, BindingFlags flags)
		{
			Dictionary<PropertyInfo, T[]> dic = FishObjectExtension.GetTypeInfo(type).GetProperties(flags).ToDictionary((PropertyInfo s) => s, (PropertyInfo s) => s.GetCustomAttributes(typeof(T), true).Cast<T>().ToArray<T>());
			(from s in dic.Keys
			where dic[s].Length == 0
			select s).ToArray<PropertyInfo>().ForEach(delegate(PropertyInfo s)
			{
				dic.Remove(s);
			});
			return dic;
		}

		public static string GetLocation(this Assembly assembly)
		{
			return Path.GetDirectoryName(assembly.Location);
		}

		public static Version GetVersion(this Assembly assembly)
		{
			return assembly.GetName().Version;
		}

		public static FileVersionInfo GetFileVersionInfo(this Assembly assembly)
		{
			return FileVersionInfo.GetVersionInfo(assembly.Location);
		}

		[Obsolete("This method was meaning less and will be removed soon.")]
		public static IEnumerable<Type> FilterType<T>(this IEnumerable<Type> typeList)
		{
			return typeList.FilterType<T>(false);
		}

		[Obsolete("This method was meaning less and will be removed soon.")]
		public static IEnumerable<Type> FilterType<T>(this IEnumerable<Type> typeList, bool ignoreAttribute)
		{
			Type t = typeof(T);
			bool isInterface = t.IsInterface;
			IEnumerable<Type> result;
			if (isInterface)
			{
				result = from s in typeList
				where s.GetInterface(t.FullName) != null
				select s;
			}
			else
			{
				bool flag = !ignoreAttribute && t.IsClass && t.IsSubclassOf(typeof(Attribute));
				if (flag)
				{
					result = from s in typeList
					where !s.GetCustomAttributes(t, true).IsEmpty<object>()
					select s;
				}
				else
				{
					bool isClass = t.IsClass;
					if (isClass)
					{
						result = from s in typeList
						where s.IsSubclassOf(t)
						select s;
					}
					else
					{
						result = typeList;
					}
				}
			}
			return result;
		}

		[Obsolete("This method will be removed soon and not intend to use. Using `type.AssemblyQualifiedName` instead.")]
		public static string GetTypeFullNameWithAssembly(this Type type)
		{
			return type.FullName + ", " + Path.GetFileNameWithoutExtension(type.Assembly.Location);
		}

		public static T[] GetCustomerAttributes<T>(this ICustomAttributeProvider type, bool inherit) where T : Attribute
		{
			bool flag = type == null;
			T[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = type.GetCustomAttributes(typeof(T), inherit).Cast<T>().ToArray<T>();
			}
			return result;
		}

		public static T[] GetCustomerAttributes<T>(this ICustomAttributeProvider type) where T : Attribute
		{
			bool flag = type == null;
			T[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = type.GetCustomAttributes(typeof(T), false).Cast<T>().ToArray<T>();
			}
			return result;
		}

		public static bool IsDebugAssembly(this Assembly assembly)
		{
			bool flag = assembly == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				DebuggableAttribute[] debugAttributes = assembly.GetCustomerAttributes<DebuggableAttribute>();
				result = (!debugAttributes.IsEmpty<DebuggableAttribute>() && debugAttributes[0].IsJITTrackingEnabled);
			}
			return result;
		}

		public static IEnumerable<string> FormatValue<T>(this IEnumerable<T> source, string format, params Func<T, object>[] selector)
		{
			return (from s in source
			select string.Format(format, from m in selector
			select m(s))).ToArray<string>();
		}

		public static R SelectValue<T, R>(this T obj, Func<T, R> selector) where T : class
		{
			bool flag = obj == null;
			R result;
			if (flag)
			{
				result = default(R);
			}
			else
			{
				result = selector(obj);
			}
			return result;
		}

		public static R SelectValue<T, R>(this T obj, Func<T, R> selector, R defaultValue) where T : class
		{
			bool flag = obj == null;
			R result;
			if (flag)
			{
				result = defaultValue;
			}
			else
			{
				result = selector(obj);
			}
			return result;
		}

		public static string SelectValue<T>(this T obj, Func<T, string> selector) where T : class
		{
			bool flag = obj == null;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = selector(obj);
			}
			return result;
		}

		public static string SelectValue<T>(this T obj, Func<T, string> selector, string defaultValue) where T : class
		{
			bool flag = obj == null;
			string result;
			if (flag)
			{
				result = defaultValue;
			}
			else
			{
				result = selector(obj);
			}
			return result;
		}

		public static DateTime SelectValue<T>(this T obj, Func<T, DateTime> selector) where T : class
		{
			bool flag = obj == null;
			DateTime result;
			if (flag)
			{
				result = DateTime.MinValue;
			}
			else
			{
				result = selector(obj);
			}
			return result;
		}

		public static DateTime SelectValue<T>(this T obj, Func<T, DateTime> selector, DateTime defaultValue) where T : class
		{
			bool flag = obj == null;
			DateTime result;
			if (flag)
			{
				result = defaultValue;
			}
			else
			{
				result = selector(obj);
			}
			return result;
		}

		public static int SelectValue<T>(this T obj, Func<T, int> selector) where T : class
		{
			bool flag = obj == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = selector(obj);
			}
			return result;
		}

		public static int SelectValue<T>(this T obj, Func<T, int> selector, int defaultValue) where T : class
		{
			bool flag = obj == null;
			int result;
			if (flag)
			{
				result = defaultValue;
			}
			else
			{
				result = selector(obj);
			}
			return result;
		}

		public static string JoinAsString<T>(this IEnumerable<T> src)
		{
			return src.JoinAsString(",");
		}

		public static string JoinAsString<T>(this IEnumerable<T> src, string seperator)
		{
			return (from s in src
			where s != null
			select s.ToString()).Join(seperator);
		}

		public static string GetGroupValue(this Match match, int index)
		{
			return (match == null || !match.Success || match.Groups.Count <= index) ? null : match.Groups[index].Value;
		}

		public static IEnumerable<T> UnionWith<T>(this IEnumerable<T> source, IEnumerable<T> second)
		{
			bool flag = source == null ^ second == null;
			IEnumerable<T> result;
			if (flag)
			{
				result = ((second == null) ? source : second);
			}
			else
			{
				result = ((source == null) ? null : source.Union(second));
			}
			return result;
		}

		public static void PagedExecute<T>(this IEnumerable<T> source, int pagesize, Action<int, IEnumerable<T>> executor)
		{
			int count = source.Count<T>();
			int pagecount = count.CeilingDivide(pagesize);
			for (int i = 0; i < pagecount; i++)
			{
				executor(i, source.Skip(pagesize * i).Take(pagesize).ToArray<T>());
			}
		}

		public static IEnumerable<T> PopulateTree<T, TKey>(this IEnumerable<T> src, Func<T, TKey> keySelector, Func<T, TKey> parentSelector, Func<T, IList<T>> childrenSelector, IEqualityComparer<TKey> comparer = null) where T : class
		{
			bool flag = src == null;
			if (flag)
			{
				throw new ArgumentNullException("src", "src is null.");
			}
			bool flag2 = keySelector == null;
			if (flag2)
			{
				throw new ArgumentNullException("parentSelector", "keySelector is null.");
			}
			bool flag3 = parentSelector == null;
			if (flag3)
			{
				throw new ArgumentNullException("parentSelector", "parentSelector is null.");
			}
			bool flag4 = childrenSelector == null;
			if (flag4)
			{
				throw new ArgumentNullException("childrenSelector", "childrenSelector is null.");
			}
			bool flag5 = comparer == null;
			if (flag5)
			{
				comparer = EqualityComparer<TKey>.Default;
			}
			TKey emptyValue = default(TKey);
			T[] array = src.ToArray<T>();
			Dictionary<TKey, T> dicCache = array.ToDictionary(keySelector, comparer);
			T[] result = (from s in array
			where comparer.Equals(parentSelector(s), emptyValue)
			select s).ToArray<T>();
			array.ForEach(delegate(T s)
			{
				TKey pkey = parentSelector(s);
				bool flag6 = comparer.Equals(pkey, emptyValue);
				if (!flag6)
				{
					T parent = dicCache.GetValue(pkey);
					bool flag7 = parent == null;
					if (flag7)
					{
						throw new Exception("指定的ParentID无效");
					}
					IList<T> children = childrenSelector(parent);
					bool flag8 = children == null;
					if (!flag8)
					{
						children.Add(s);
					}
				}
			});
			return result;
		}

		public static string GetFileName(this Uri uri)
		{
			bool flag = uri == null;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				string path = uri.LocalPath;
				int index = path.LastIndexOf("/");
				result = ((index == -1) ? path : path.Substring(index + 1));
			}
			return result;
		}

		public static string GetTopLevelHost(this Uri uri)
		{
			Match i = FishObjectExtension._topLevelHostReg.Match(uri.Host);
			bool success = i.Success;
			string result;
			if (success)
			{
				result = i.Value;
			}
			else
			{
				result = uri.Host;
			}
			return result;
		}

		public static ushort ReadUInt16(this Stream stream)
		{
			return BitConverter.ToUInt16(stream.ReadBuffer(2), 0);
		}

		public static uint ReadUInt32(this Stream stream)
		{
			return BitConverter.ToUInt32(stream.ReadBuffer(4), 0);
		}

		public static ulong ReadUInt64(this Stream stream)
		{
			return BitConverter.ToUInt64(stream.ReadBuffer(8), 0);
		}

		public static short ReadInt16(this Stream stream)
		{
			return BitConverter.ToInt16(stream.ReadBuffer(2), 0);
		}

		public static int ReadInt32(this Stream stream)
		{
			return BitConverter.ToInt32(stream.ReadBuffer(4), 0);
		}

		public static long ReadInt64(this Stream stream)
		{
			return BitConverter.ToInt64(stream.ReadBuffer(8), 0);
		}

		public static double ReadDouble(this Stream stream)
		{
			return BitConverter.ToDouble(stream.ReadBuffer(8), 0);
		}

		public static byte[] ReadBuffer(this Stream stream, int length)
		{
			int count = 0;
			return stream.ReadBuffer(length, out count);
		}

		public static byte[] ReadBuffer(this Stream stream, int length, out int readedBytesCount)
		{
			byte[] buffer = new byte[length];
			readedBytesCount = stream.Read(buffer, 0, buffer.Length);
			return buffer;
		}

		[Obsolete("此函数没有很大的意义，将会被移除。This method will be removed soon due to no means.")]
		public static byte[] FillBuffer(this Stream stream, byte[] buffer)
		{
			bool flag = stream.Read(buffer, 0, buffer.Length) != buffer.Length;
			if (flag)
			{
				throw new Exception();
			}
			return buffer;
		}

		[CanBeNull]
		public static MemoryStream ReadToEnd([NotNull] this Stream stream, int readBufferSize = 1024)
		{
			bool flag = !stream.CanRead;
			MemoryStream result;
			if (flag)
			{
				result = null;
			}
			else
			{
				MemoryStream end = stream as MemoryStream;
				bool flag2 = end != null;
				if (flag2)
				{
					result = end;
				}
				else
				{
					MemoryStream ms = new MemoryStream();
					byte[] buffer = new byte[readBufferSize];
					int count;
					while ((count = stream.Read(buffer, 0, buffer.Length)) > 0)
					{
						ms.Write(buffer, 0, count);
					}
					ms.Flush();
					ms.Seek(0L, SeekOrigin.Begin);
					result = ms;
				}
			}
			return result;
		}

		public static Stream Zip(this Stream stream)
		{
			return new GZipStream(stream, CompressionMode.Compress);
		}

		public static Stream UnZip(this Stream stream)
		{
			return new GZipStream(stream, CompressionMode.Decompress);
		}

		public static string GetPositionString(this Stream stream)
		{
			return string.Format("0x{0:X8}", stream.Position);
		}

		public static T Write<T>(this T stream, byte[] buffer) where T : Stream
		{
			stream.Write(buffer, 0, buffer.Length);
			return stream;
		}

		public static T Write<T>(this T stream, IEnumerable<byte> buffer) where T : Stream
		{
			stream.Write(buffer.ToArray<byte>());
			return stream;
		}

		public static T Write<T>(this T stream, int value) where T : Stream
		{
			stream.Write(BitConverter.GetBytes(value));
			return stream;
		}

		public static T Write<T>(this T stream, uint value) where T : Stream
		{
			stream.Write(BitConverter.GetBytes(value));
			return stream;
		}

		public static T Write<T>(this T stream, short value) where T : Stream
		{
			stream.Write(BitConverter.GetBytes(value));
			return stream;
		}

		public static T Write<T>(this T stream, ushort value) where T : Stream
		{
			stream.Write(BitConverter.GetBytes(value));
			return stream;
		}

		public static T Write<T>(this T stream, long value) where T : Stream
		{
			stream.Write(BitConverter.GetBytes(value));
			return stream;
		}

		public static T Write<T>(this T stream, ulong value) where T : Stream
		{
			stream.Write(BitConverter.GetBytes(value));
			return stream;
		}

		public static void ExecuteIf<T>(this T value, Func<T, bool> eval, Action<T> action)
		{
			bool flag = eval(value);
			if (flag)
			{
				action(value);
			}
		}

		public static void ExecuteIfPositive(this int value, Action<int> action)
		{
			bool flag = value > 0;
			if (flag)
			{
				action(value);
			}
		}

		public static void ExecuteIfNotEmpty(this string value, Action<string> action)
		{
			bool flag = !string.IsNullOrEmpty(value);
			if (flag)
			{
				action(value);
			}
		}

		public static void ExecuteIfNotEmpty<T>(this T value, Action<T> action) where T : class
		{
			bool flag = value != null;
			if (flag)
			{
				action(value);
			}
		}

		public static void ExecuteIfNotEmpty<T>(this IEnumerable<T> value, Action<IEnumerable<T>> action)
		{
			bool flag = value != null && value.Any<T>();
			if (flag)
			{
				action(value);
			}
		}

		public static void LockExecute(this object obj, Func<bool> condition, Action action)
		{
			bool flag = action == null || obj == null;
			if (!flag)
			{
				bool flag2 = condition == null || condition();
				if (flag2)
				{
					lock (obj)
					{
						bool flag4 = condition == null || condition();
						if (flag4)
						{
							action();
						}
					}
				}
			}
		}

		public static List<T> TableToClass<T>(this DataTable table)
		{
			bool flag = table.Rows.Count == 0;
			List<T> result;
			if (flag)
			{
				result = new List<T>();
			}
			else
			{
				Type type = typeof(T);
				PropertyInfo[] propArr = type.GetProperties();
				List<T> list = new List<T>();
				DataRowCollection rows = table.Rows;
				int len = rows[0].ItemArray.Length;
				for (int i = 0; i < rows.Count; i++)
				{
					T t = (T)((object)Activator.CreateInstance(type));
					for (int j = 0; j < len; j++)
					{
						try
						{
							bool flag2 = rows[i][j].GetType().Name != "DBNull";
							if (flag2)
							{
								propArr[j].SetValue(t, rows[i][j]);
							}
						}
						catch (Exception)
						{
						}
					}
					list.Add(t);
					t = default(T);
				}
				result = list;
			}
			return result;
		}

		public static T RowToClass<T>(this DataRow row)
		{
			Type type = typeof(T);
			T t = (T)((object)Activator.CreateInstance(type));
			PropertyInfo[] propArr = type.GetProperties();
			int len = row.ItemArray.Length;
			for (int i = 0; i < len; i++)
			{
				try
				{
					bool flag = row[i].GetType().Name != "DBNull";
					if (flag)
					{
						propArr[i].SetValue(t, row[i]);
					}
				}
				catch (Exception)
				{
				}
			}
			return t;
		}

		public static List<T> RowToClass<T>(this DataRow row, DataRow[] rowArr)
		{
			Type type = typeof(T);
			PropertyInfo[] propArr = type.GetProperties();
			int len = rowArr[0].ItemArray.Length;
			List<T> list = new List<T>();
			for (int i = 0; i < rowArr.Length; i++)
			{
				T t = (T)((object)Activator.CreateInstance(type));
				for (int j = 0; j < len; j++)
				{
					try
					{
						bool flag = rowArr[i][j].GetType().Name != "DBNull";
						if (flag)
						{
							propArr[j].SetValue(t, rowArr[i][j]);
						}
					}
					catch (Exception)
					{
					}
				}
				list.Add(t);
				t = default(T);
			}
			return list;
		}

		public static bool IsNumericType(this object obj)
		{
			TypeCode typeCode = Type.GetTypeCode(obj.GetType());
			TypeCode typeCode2 = typeCode;
			return typeCode2 - TypeCode.SByte <= 10;
		}

		private static readonly Regex _topLevelHostReg = new Regex("[-a-zA-Z\\d]+\\.[-a-zA-Z\\d]+$", RegexOptions.IgnoreCase);
	}
}
