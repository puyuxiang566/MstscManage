using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MstscManage.Database
{
	internal class ObjectPropertyCompare<T> : IComparer<T>
	{
		public ObjectPropertyCompare(PropertyDescriptor property, ListSortDirection direction)
		{
			this.property = property;
			this.direction = direction;
		}

		public int Compare(T x, T y)
		{
			object xValue = x.GetType().GetProperty(this.property.Name).GetValue(x, null);
			object yValue = y.GetType().GetProperty(this.property.Name).GetValue(y, null);
			bool flag = xValue is IComparable;
			int returnValue;
			if (flag)
			{
				returnValue = ((IComparable)xValue).CompareTo(yValue);
			}
			else
			{
				bool flag2 = xValue.Equals(yValue);
				if (flag2)
				{
					returnValue = 0;
				}
				else
				{
					returnValue = xValue.ToString().CompareTo(yValue.ToString());
				}
			}
			bool flag3 = this.direction == ListSortDirection.Ascending;
			int result;
			if (flag3)
			{
				result = returnValue;
			}
			else
			{
				result = returnValue * -1;
			}
			return result;
		}

		public bool Equals(T xWord, T yWord)
		{
			return xWord.Equals(yWord);
		}

		public int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}

		private PropertyDescriptor property;

		private ListSortDirection direction;
	}
}
