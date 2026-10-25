using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace System
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class FishDateTimeExtension
	{
		public static string MakeDateFriendly(this DateTime dt)
		{
			TimeSpan ts = dt.Date - DateTime.Now.Date;
			string result;
			switch (ts.Days)
			{
			case -2:
				result = "前天";
				break;
			case -1:
				result = "昨天";
				break;
			case 0:
				result = "今天";
				break;
			case 1:
				result = "明天";
				break;
			case 2:
				result = "后天";
				break;
			default:
				result = Math.Abs(ts.Days).ToString() + "天" + ((ts.Days > 0) ? "后" : "前");
				break;
			}
			return result;
		}

		public static long ToJsTicks(this DateTime dt)
		{
			return (long)(dt - FishDateTimeExtension.JsTicksStartBase).TotalMilliseconds;
		}

		public static long ToUnixTicks(this DateTime dt)
		{
			return dt.ToJsTicks() / 1000L;
		}

		public static double GetMonthesBetween(this DateTime beginDate, DateTime endDate)
		{
			double months = 0.0;
			while (beginDate <= endDate)
			{
				months += 1.0;
				beginDate = beginDate.AddMonths(1);
			}
			return months - (beginDate - endDate).TotalDays / (double)DateTime.DaysInMonth(endDate.Year, endDate.Month);
		}

		public static double GetDaysBetween(this DateTime beginDate, DateTime endDate)
		{
			return (endDate.Date - beginDate.Date).TotalDays;
		}

		public static DateTime GetMonthStart(this DateTime dt)
		{
			return dt.AddDays((double)(-(double)DateTime.Now.Day + 1));
		}

		public static DateTime GetMonthEnd(this DateTime dt)
		{
			return dt.AddDays((double)(DateTime.DaysInMonth(dt.Year, dt.Month) - dt.Day));
		}

		public static DateTime TrimToMilliSecond(this DateTime dt)
		{
			long ticks = dt.Ticks;
			ticks -= ticks % 10000L;
			return new DateTime(ticks);
		}

		public static DateTime TrimToSecond(this DateTime dt)
		{
			long ticks = dt.Ticks;
			ticks -= ticks % 10000000L;
			return new DateTime(ticks);
		}

		public static DateTime TrimToMinute(this DateTime dt)
		{
			long ticks = dt.Ticks;
			ticks -= ticks % 600000000L;
			return new DateTime(ticks);
		}

		public static DateTime TrimToHour(this DateTime dt)
		{
			long ticks = dt.Ticks;
			ticks -= ticks % 36000000000L;
			return new DateTime(ticks);
		}

		public static DateTime TrimToDay(this DateTime dt)
		{
			long ticks = dt.Ticks;
			ticks -= ticks % 864000000000L;
			return new DateTime(ticks);
		}

		public static TimeSpan AddHours(this TimeSpan timeSpan, int hours)
		{
			return timeSpan.Add(new TimeSpan(hours, 0, 0));
		}

		public static TimeSpan AddMinutes(this TimeSpan timeSpan, int minutes)
		{
			return timeSpan.Add(new TimeSpan(0, minutes, 0));
		}

		public static TimeSpan AddSeconds(this TimeSpan timeSpan, int seconds)
		{
			return timeSpan.Add(new TimeSpan(0, 0, seconds));
		}

		public static TimeSpan AddDays(this TimeSpan timeSpan, int days)
		{
			return timeSpan.Add(new TimeSpan(days, 0, 0, 0));
		}

		public static string ToFriendlyDisplay(this TimeSpan ts)
		{
			string[] arr = new string[]
			{
				"",
				"",
				"",
				"",
				""
			};
			bool flag = ts.Days > 0;
			if (flag)
			{
				arr[0] = string.Format("{0}天", ts.Days);
			}
			bool flag2 = ts.Hours > 0;
			if (flag2)
			{
				arr[1] = string.Format("{0}时", ts.Hours);
			}
			bool flag3 = ts.Minutes > 0;
			if (flag3)
			{
				arr[2] = string.Format("{0}分", ts.Minutes);
			}
			bool flag4 = ts.Seconds > 0;
			if (flag4)
			{
				arr[3] = string.Format("{0}秒", ts.Seconds);
			}
			bool flag5 = ts.Milliseconds > 0;
			if (flag5)
			{
				arr[4] = string.Format("{0}毫秒", ts.Milliseconds);
			}
			return arr.JoinAsString("");
		}

		public static string ToFriendlyDisplayShort(this TimeSpan ts)
		{
			string[] arr = new string[]
			{
				"",
				"",
				"",
				"",
				""
			};
			bool flag = ts.Days > 0;
			if (flag)
			{
				arr[0] = string.Format("{0}d", ts.Days);
			}
			bool flag2 = ts.Hours > 0;
			if (flag2)
			{
				arr[1] = string.Format("{0}h", ts.Hours);
			}
			bool flag3 = ts.Minutes > 0;
			if (flag3)
			{
				arr[2] = string.Format("{0}m", ts.Minutes);
			}
			bool flag4 = ts.Seconds > 0;
			if (flag4)
			{
				arr[3] = string.Format("{0}s", ts.Seconds);
			}
			bool flag5 = ts.Milliseconds > 0;
			if (flag5)
			{
				arr[4] = string.Format("{0}ms", ts.Milliseconds);
			}
			return arr.JoinAsString("");
		}

		public static TimeSpan Sum(this IEnumerable<TimeSpan> timespans)
		{
			return timespans.Aggregate(TimeSpan.Zero, (TimeSpan x, TimeSpan y) => x + y);
		}

		public static TimeSpan? Sum(this IEnumerable<TimeSpan?> timespans)
		{
			return timespans.Aggregate(null, delegate(TimeSpan? x, TimeSpan? y)
			{
				bool flag = y != null;
				TimeSpan? result;
				if (flag)
				{
					result = new TimeSpan?((x != null) ? (x.Value + y.Value) : y.Value);
				}
				else
				{
					result = x;
				}
				return result;
			});
		}

		public static readonly DateTime JsTicksStartBase = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
	}
}
