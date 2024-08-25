using System;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000A RID: 10
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[VisibleToOtherModules]
	internal class VisibleToOtherModulesAttribute : Attribute
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002190 File Offset: 0x00000390
		public VisibleToOtherModulesAttribute()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021A4 File Offset: 0x000003A4
		public VisibleToOtherModulesAttribute(params string[] modules)
		{
		}
	}
}
