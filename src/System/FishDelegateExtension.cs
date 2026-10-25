using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace System
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class FishDelegateExtension
	{
		public static bool HasBound(this Delegate publisher, Delegate handler)
		{
			bool flag = publisher == null || handler == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = publisher == handler;
				if (flag2)
				{
					result = true;
				}
				else
				{
					Delegate[] publisherList = publisher.GetInvocationList();
					Delegate[] handlerList = handler.GetInvocationList();
					bool flag3 = handlerList.Length > publisherList.Length;
					if (flag3)
					{
						result = false;
					}
					else
					{
						EqualityComparer<Delegate> comparer = EqualityComparer<Delegate>.Default;
						for (int i = 0; i <= publisherList.Length - handlerList.Length; i++)
						{
							for (int j = 0; j < handlerList.Length; j++)
							{
								bool flag4 = !comparer.Equals(publisherList[j + i], handlerList[j]);
								if (flag4)
								{
									return false;
								}
							}
						}
						result = true;
					}
				}
			}
			return result;
		}

		public static bool HasBound<TEventArgs>(this EventHandler<TEventArgs> publisher, EventHandler<TEventArgs> handler) where TEventArgs : EventArgs
		{
			return publisher.HasBound(handler);
		}

		public static bool HasBound(this EventHandler publisher, EventHandler handler)
		{
			return publisher.HasBound(handler);
		}
	}
}
