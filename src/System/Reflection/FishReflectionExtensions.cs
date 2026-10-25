using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace System.Reflection
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class FishReflectionExtensions
	{
		public static bool HasInterface<T>(this Type t)
		{
			return t != null && FishObjectExtension.GetTypeInfo(t).GetInterface(typeof(T).FullName) != null;
		}

		public static IEnumerable<Type> FilterByInterface<T>(this IEnumerable<Type> src)
		{
			bool flag = src == null;
			IEnumerable<Type> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = from x in src
				where x.HasInterface<T>()
				select x;
			}
			return result;
		}
	}
}
