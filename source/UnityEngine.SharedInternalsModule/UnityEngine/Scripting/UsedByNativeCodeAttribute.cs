using System;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting
{
	// Token: 0x02000008 RID: 8
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	internal class UsedByNativeCodeAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002148 File Offset: 0x00000348
		public UsedByNativeCodeAttribute()
		{
		}
	}
}
