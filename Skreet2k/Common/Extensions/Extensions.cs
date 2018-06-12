using System;

namespace S2k.Common.Core.Extensions
{
	public static class Extensions
	{
		public static object GetDefaultValue(this Type type)
		{
			return type.IsValueType ? Activator.CreateInstance(type) : null;
		}
	}
}