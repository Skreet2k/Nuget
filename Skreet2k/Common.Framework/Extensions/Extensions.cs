using System;

namespace Common.Framework.Extensions
{
	public static class Extensions
	{
		public static object GetDefaultValue(this Type type)
		{
			return type.IsValueType ? Activator.CreateInstance(type) : null;
		}
	}
}