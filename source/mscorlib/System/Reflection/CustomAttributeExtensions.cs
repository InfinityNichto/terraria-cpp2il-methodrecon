using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004FB RID: 1275
	public static class CustomAttributeExtensions
	{
		// Token: 0x060024F3 RID: 9459 RVA: 0x00051C04 File Offset: 0x0004FE04
		public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
		{
			Attribute attribute;
			return attribute;
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00051C14 File Offset: 0x0004FE14
		public static T GetCustomAttribute<T>(this Assembly element) where T : Attribute
		{
			Attribute attribute;
			while (attribute != null)
			{
				if (attribute == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x0000207A File Offset: 0x0000027A
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00051C30 File Offset: 0x0004FE30
		public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute
		{
			IEnumerable<Attribute> customAttributes;
			do
			{
				Type type;
				customAttributes = CustomAttributeExtensions.GetCustomAttributes(type, type);
				if (customAttributes == null)
				{
					return;
				}
			}
			while (customAttributes != null);
			throw new InvalidCastException();
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00051C54 File Offset: 0x0004FE54
		public static bool IsDefined(this MemberInfo element, Type attributeType)
		{
			bool flag;
			return flag;
		}
	}
}
