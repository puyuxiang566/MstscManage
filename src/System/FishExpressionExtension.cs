using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace System
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class FishExpressionExtension
	{
		public static string GetExpressionAccessedMemberName<TSource, TValue>(this Expression<Func<TSource, TValue>> expression)
		{
			bool flag = expression == null;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = expression.Body.NodeType != ExpressionType.MemberAccess || !((expression.Body as MemberExpression).Member is PropertyInfo);
				if (flag2)
				{
					result = null;
				}
				else
				{
					result = ((expression.Body as MemberExpression).Member as PropertyInfo).Name;
				}
			}
			return result;
		}
	}
}
