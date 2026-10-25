using System;

namespace System.Globalization
{
	public static class ChineseLunisolarCalendarExtension
	{
		public static string GetLunisolarYear(int year)
		{
			bool flag = year > 3;
			if (flag)
			{
				int tgIndex = (year - 4) % 10;
				int dzIndex = (year - 4) % 12;
				return ChineseLunisolarCalendarExtension._tiangan[tgIndex] + ChineseLunisolarCalendarExtension._dizhi[dzIndex];
			}
			throw new ArgumentOutOfRangeException("无效的年份!");
		}

		public static string GetLunisolarYear(this ChineseLunisolarCalendar calendar, DateTime date)
		{
			return ChineseLunisolarCalendarExtension.GetLunisolarYear(calendar.GetYear(date));
		}

		public static string GetLunisolarMonth(int month)
		{
			bool flag = month < 13 && month > 0;
			if (flag)
			{
				return ChineseLunisolarCalendarExtension.months[month - 1];
			}
			throw new ArgumentOutOfRangeException("无效的月份!");
		}

		public static string GetLunisolarMonth(this ChineseLunisolarCalendar calendar, DateTime date)
		{
			int month = calendar.GetMonth(date);
			int leapMonth = calendar.GetLeapMonth(calendar.GetYear(date), calendar.GetEra(date));
			bool isleep = leapMonth > 0 && leapMonth == month;
			bool flag = leapMonth > 0;
			if (flag)
			{
				bool flag2 = leapMonth <= month;
				if (flag2)
				{
					month--;
				}
			}
			return (isleep ? "闰" : string.Empty) + ChineseLunisolarCalendarExtension.GetLunisolarMonth(month) + "月";
		}

		public static string GetLunisolarDay(int day)
		{
			bool flag = day > 0 && day < 32;
			if (flag)
			{
				bool flag2 = day != 20 && day != 30;
				string result;
				if (flag2)
				{
					result = ChineseLunisolarCalendarExtension.days1[(day - 1) / 10] + ChineseLunisolarCalendarExtension.days[(day - 1) % 10];
				}
				else
				{
					result = ChineseLunisolarCalendarExtension.days[(day - 1) / 10] + ChineseLunisolarCalendarExtension.days1[1];
				}
				return result;
			}
			throw new ArgumentOutOfRangeException("无效的日!");
		}

		public static string GetLunisolarDay(this ChineseLunisolarCalendar calendar, DateTime datetime)
		{
			return ChineseLunisolarCalendarExtension.GetLunisolarDay(calendar.GetDayOfMonth(datetime));
		}

		public static string GetShengXiao(this ChineseLunisolarCalendar calendar, DateTime datetime)
		{
			return ChineseLunisolarCalendarExtension._shengxiao[calendar.GetTerrestrialBranch(calendar.GetSexagenaryYear(datetime)) - 1];
		}

		public static string GetLunisolarDateString(this ChineseLunisolarCalendar calendar, DateTime date)
		{
			return calendar.GetLunisolarYear(date) + "年" + calendar.GetLunisolarMonth(date) + calendar.GetLunisolarDay(date);
		}

		private static string[] _tiangan = new string[]
		{
			"甲",
			"乙",
			"丙",
			"丁",
			"戊",
			"己",
			"庚",
			"辛",
			"壬",
			"癸"
		};

		private static string[] _dizhi = new string[]
		{
			"子",
			"丑",
			"寅",
			"卯",
			"辰",
			"巳",
			"午",
			"未",
			"申",
			"酉",
			"戌",
			"亥"
		};

		private static string[] _shengxiao = new string[]
		{
			"鼠",
			"牛",
			"虎",
			"免",
			"龙",
			"蛇",
			"马",
			"羊",
			"猴",
			"鸡",
			"狗",
			"猪"
		};

		private static string[] months = new string[]
		{
			"正",
			"二",
			"三",
			"四",
			"五",
			"六",
			"七",
			"八",
			"九",
			"十",
			"十一",
			"十二(腊)"
		};

		private static string[] days1 = new string[]
		{
			"初",
			"十",
			"廿",
			"三"
		};

		private static string[] days = new string[]
		{
			"一",
			"二",
			"三",
			"四",
			"五",
			"六",
			"七",
			"八",
			"九",
			"十"
		};
	}
}
