using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace System
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class FishValueExtension
	{
		public static bool IsValueInRange(this int value, int minValue, int maxValue)
		{
			return value >= minValue && value <= maxValue;
		}

		public static int LimitRange(this int value, int min, int max)
		{
			return (value < min) ? min : ((value > max) ? max : value);
		}

		public static int CeilingDivide(this int value, int divideBy)
		{
			bool flag = divideBy == 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("divideBy");
			}
			return (int)Math.Ceiling((double)value * 1.0 / (double)divideBy);
		}

		public static int Min(this int value, int minValue)
		{
			return (value < minValue) ? minValue : value;
		}

		public static int Max(this int value, int maxValue)
		{
			return (value > maxValue) ? maxValue : value;
		}

		public static bool? ToBooleanNullable(this string value)
		{
			bool flag = string.IsNullOrEmpty(value);
			bool? result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = value == "1" || string.Compare("true", value, true) == 0;
				if (flag2)
				{
					result = new bool?(true);
				}
				else
				{
					bool flag3 = value == "0" || string.Compare("false", value, true) == 0;
					if (flag3)
					{
						result = new bool?(false);
					}
					else
					{
						result = null;
					}
				}
			}
			return result;
		}

		public static bool ToBoolean(this string value)
		{
			return value.ToBoolean(false);
		}

		public static bool ToBoolean(this string value, bool defaultValue)
		{
			bool? b = value.ToBooleanNullable();
			return (b != null) ? b.Value : defaultValue;
		}

		public static T GetValue<T>(this T? value) where T : struct
		{
			return (value != null) ? value.Value : default(T);
		}

		public static T GetValue<T>(this T? value, T defaultValue) where T : struct
		{
			return (value != null) ? value.Value : defaultValue;
		}

		public static double GetPercentageBy(this double first, double second)
		{
			bool flag = second == 0.0;
			double result;
			if (flag)
			{
				result = 0.0;
			}
			else
			{
				result = first / second;
			}
			return result;
		}

		public static decimal GetPercentageBy(this decimal first, decimal second)
		{
			bool flag = second == 0.0m;
			decimal result;
			if (flag)
			{
				result = 0m;
			}
			else
			{
				result = first / second;
			}
			return result;
		}

		public static string ToDisplayString(this int? value)
		{
			return (value == null) ? "" : value.ToString();
		}

		public static string ToDisplayString(this int? value, string defaultDisplayString)
		{
			return (value == null) ? defaultDisplayString : value.ToString();
		}

		public static string ToDisplayString(this float? value)
		{
			return (value == null) ? "" : value.ToString();
		}

		public static string ToDisplayString(this float? value, string defaultDisplayString)
		{
			return (value == null) ? defaultDisplayString : value.ToString();
		}

		public static string ToDisplayString(this double? value)
		{
			return (value == null) ? "" : value.ToString();
		}

		public static string ToDisplayString(this double? value, string defaultDisplayString)
		{
			return (value == null) ? defaultDisplayString : value.ToString();
		}

		internal static string GetInitialCodeString()
		{
			int[] array = new int[62];
			array.ForEachWithIndex(delegate(int i, int b)
			{
				array[i] = ((i < 10) ? (48 + i) : ((i < 36) ? (65 + i - 10) : (97 + i - 10 - 26)));
			});
			return new string((from s in array
			select (char)s).ToArray<char>());
		}

		public static string CompressToString(this int value)
		{
			List<char> map = new List<char>();
			int step = FishValueExtension._numberCode.Length;
			while (value > 0)
			{
				int digit = value % step;
				value = (value - digit) / step;
				map.Add(FishValueExtension._numberCode[digit]);
			}
			return new string(map.Reverse<char>().ToArray<char>());
		}

		public static int DecompressToInt(this string value)
		{
			int[] array = (from s in value
			select FishValueExtension._numberCode.IndexOf(s)).Reverse<int>().ToArray<int>();
			int result = 0;
			int step = 1;
			for (int i = 0; i < array.Length; i++)
			{
				result += array[i] * step;
				step *= FishValueExtension._numberCode.Length;
			}
			return result;
		}

		private static readonly string _numberCode = FishValueExtension.GetInitialCodeString();
	}
}
