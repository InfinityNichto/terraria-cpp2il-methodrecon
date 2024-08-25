using System;
using System.Globalization;

namespace System.Reflection
{
	// Token: 0x0200050B RID: 1291
	internal abstract class RtFieldInfo : FieldInfo
	{
		// Token: 0x0600259E RID: 9630
		internal abstract object UnsafeGetValue(object obj);

		// Token: 0x0600259F RID: 9631
		internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		// Token: 0x060025A0 RID: 9632
		internal abstract void CheckConsistency(object target);

		// Token: 0x060025A1 RID: 9633 RVA: 0x00052E3C File Offset: 0x0005103C
		protected RtFieldInfo()
		{
		}
	}
}
