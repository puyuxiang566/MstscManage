using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace System
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class FishCollectionExtension
	{
		public static Dictionary<string, string> ToDictionary(this NameValueCollection collection)
		{
			Dictionary<string, string> dic = new Dictionary<string, string>((collection == null) ? 10 : collection.Count, StringComparer.OrdinalIgnoreCase);
			bool flag = collection != null;
			if (flag)
			{
				collection.AllKeys.ForEach(delegate(string s)
				{
					dic.Add(s, collection[s]);
				});
			}
			return dic;
		}

		public static string GetValue(this NameValueCollection collection, string key)
		{
			return collection.GetValue(key, string.Empty);
		}

		public static string GetValue(this NameValueCollection collection, string key, string defaultValue)
		{
			bool flag = string.IsNullOrEmpty(key);
			if (flag)
			{
				throw new ArgumentNullException("key");
			}
			bool flag2 = collection == null;
			string result;
			if (flag2)
			{
				result = defaultValue;
			}
			else
			{
				string e = collection[key];
				bool flag3 = e == null;
				if (flag3)
				{
					result = defaultValue;
				}
				else
				{
					result = e;
				}
			}
			return result;
		}

		public static T[] RandomOrder<T>(this T[] source)
		{
			int i = source.Length / 2;
			for (int j = 0; j < i; j++)
			{
				int x = FishCollectionExtension.m_Random.Next(0, source.Length - 1);
				int y = FishCollectionExtension.m_Random.Next(0, source.Length - 1);
				bool flag = x == y;
				if (!flag)
				{
					T t = source[y];
					source[y] = source[x];
					source[x] = t;
				}
			}
			return source;
		}

		public static T[] SplitPage<T>(this IList<T> obj, int pagesize, ref int pageindex, out int totalpage)
		{
			bool flag = pagesize < 1;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("pagesize", "每页尺寸不得小于1");
			}
			totalpage = obj.Count.CeilingDivide(pagesize);
			bool flag2 = pageindex < 1;
			if (flag2)
			{
				pageindex = 1;
			}
			else
			{
				bool flag3 = pageindex > totalpage;
				if (flag3)
				{
					pageindex = totalpage;
				}
			}
			bool flag4 = totalpage * pagesize > obj.Count;
			int count;
			if (flag4)
			{
				count = obj.Count - totalpage * (pagesize - 1);
			}
			else
			{
				count = pagesize;
			}
			T[] result = new T[count];
			int startIndex = pagesize * (pageindex - 1);
			for (int i = 0; i < count; i++)
			{
				result[i] = obj[i + startIndex];
			}
			return result;
		}

		public static T RandomTake<T>(this List<T> list, Random random = null)
		{
			bool flag = list == null || list.Count == 0;
			T result;
			if (flag)
			{
				result = default(T);
			}
			else
			{
				result = list[(random ?? new Random()).Next(list.Count)];
			}
			return result;
		}

		public static TValue GetValue<Tkey, TValue>(this Dictionary<Tkey, TValue> dic, Tkey key)
		{
			return dic.GetValue(key, default(TValue));
		}

		public static TValue GetValue<Tkey, TValue>(this Dictionary<Tkey, TValue> dic, Tkey key, Func<Tkey, TValue> initialValueFunc)
		{
			bool flag = dic.ContainsKey(key);
			TValue result;
			if (flag)
			{
				result = dic[key];
			}
			else
			{
					bool flag2 = initialValueFunc == null;
				if (flag2)
				{
					result = default(TValue);
				}
				else
				{
					lock (dic)
					{
						bool flag4 = !dic.ContainsKey(key);
						if (flag4)
						{
							dic.Add(key, initialValueFunc(key));
						}
					}
					result = dic[key];
				}
			}
			return result;
		}

		public static TValue GetValue<Tkey, TValue>(this Dictionary<Tkey, TValue> dic, Tkey key, TValue defaultValue)
		{
			TValue value = default(TValue);
			bool flag = !dic.TryGetValue(key, out value);
			if (flag)
			{
				value = defaultValue;
			}
			return value;
		}

		public static int GetIndex<TKey, TValue>(this SortedDictionary<TKey, TValue> dic, TKey key)
		{
			bool flag = dic == null;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int idx = 0;
				foreach (TKey keyidx in dic.Keys)
				{
					bool flag2 = keyidx.Equals(key);
					if (flag2)
					{
						return idx;
					}
					idx++;
				}
				result = -1;
			}
			return result;
		}

		public static int GetIndex<TKey, TValue>(this SortedList<TKey, TValue> list, TKey key)
		{
			bool flag = list == null;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int idx = 0;
				foreach (TKey keyidx in list.Keys)
				{
					bool flag2 = keyidx.Equals(key);
					if (flag2)
					{
						return idx;
					}
					idx++;
				}
				result = -1;
			}
			return result;
		}

		public static void AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key, TValue value)
		{
			bool flag = dic.ContainsKey(key);
			if (flag)
			{
				dic[key] = value;
			}
			else
			{
				dic.Add(key, value);
			}
		}

		public static bool TryRemove<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey key, out TValue value)
		{
			value = default(TValue);
			bool flag = dic.ContainsKey(key);
			if (flag)
			{
				lock (dic)
				{
					bool flag3 = dic.ContainsKey(key);
					if (flag3)
					{
						value = dic[key];
						dic.Remove(key);
						return true;
					}
				}
			}
			return false;
		}

		public static IEnumerable<TOut> CastToAnonymousType<TIn, TOut>(this IEnumerable<TIn> src, TOut targetObj)
		{
			return src.Cast<TOut>();
		}

		public static IEnumerable<T> ExceptNull<T>(this IEnumerable<T> source) where T : class
		{
			return from s in source
			where s != null
			select s;
		}

		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
		{
			return new HashSet<T>(source);
		}

		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source, IEqualityComparer<T> comparer)
		{
			return new HashSet<T>(source, comparer);
		}

		public static IEnumerable<KeyValuePair<T1, T2>> CrossJoin<T1, T2>(this IEnumerable<T1> t1, IEnumerable<T2> t2)
		{
			foreach (T1 t3 in t1)
			{
				foreach (T2 tt in t2)
				{
					yield return new KeyValuePair<T1, T2>(t3, tt);
				}
			}
		}

		public static Queue<T> ToQueue<T>(this IEnumerable<T> source)
		{
			return new Queue<T>(source);
		}

		public static Stack<T> ToStack<T>(this IEnumerable<T> source)
		{
			return new Stack<T>(source);
		}

		public static List<T[]> SplitPage<T>(this IEnumerable<T> source, int pagesize)
		{
			bool flag = source == null;
			if (flag)
			{
				throw new ArgumentNullException("source");
			}
			bool flag2 = pagesize < 1;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("pagesize");
			}
			int index = 0;
			int count = source.Count<T>();
			List<T[]> result = new List<T[]>(count.CeilingDivide(pagesize));
			while (index < count)
			{
				result.Add(source.Skip(index).Take(pagesize).ToArray<T>());
				index += pagesize;
			}
			return result;
		}

		public static void EnqueueMany<T>(this Queue<T> queue, IEnumerable<T> eles)
		{
			eles.ForEach(new Action<T>(queue.Enqueue));
		}

		public static bool SafeAdd<T>(this HashSet<T> hashset, T obj)
		{
			bool flag = hashset.Contains(obj);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				hashset.Add(obj);
				result = true;
			}
			return result;
		}

		private static Random m_Random = new Random();
	}
}
