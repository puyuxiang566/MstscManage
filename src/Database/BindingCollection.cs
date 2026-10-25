using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MstscManage.Database
{
	public class BindingCollection<T> : BindingList<T>
	{
		protected override bool IsSortedCore
		{
			get
			{
				return this.isSorted;
			}
		}

		protected override bool SupportsSortingCore
		{
			get
			{
				return true;
			}
		}

		protected override ListSortDirection SortDirectionCore
		{
			get
			{
				return this.sortDirection;
			}
		}

		protected override PropertyDescriptor SortPropertyCore
		{
			get
			{
				return this.sortProperty;
			}
		}

		protected override bool SupportsSearchingCore
		{
			get
			{
				return true;
			}
		}

		protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
		{
			List<T> items = base.Items as List<T>;
			bool flag = items != null;
			if (flag)
			{
				ObjectPropertyCompare<T> pc = new ObjectPropertyCompare<T>(property, direction);
				items.Sort(pc);
				this.isSorted = true;
			}
			else
			{
				this.isSorted = false;
			}
			this.sortProperty = property;
			this.sortDirection = direction;
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		protected override void RemoveSortCore()
		{
			this.isSorted = false;
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}

		public void Sort(PropertyDescriptor property, ListSortDirection direction)
		{
			this.ApplySortCore(property, direction);
		}

		private bool isSorted;

		private PropertyDescriptor sortProperty;

		private ListSortDirection sortDirection;
	}
}
