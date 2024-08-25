using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting
{
	// Token: 0x02000009 RID: 9
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	[VisibleToOtherModules]
	internal class RequiredByNativeCodeAttribute : Attribute
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000215C File Offset: 0x0000035C
		public RequiredByNativeCodeAttribute()
		{
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002170 File Offset: 0x00000370
		public bool Optional
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002180 File Offset: 0x00000380
		public bool GenerateProxy
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x04000005 RID: 5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <Optional>k__BackingField;

		// Token: 0x04000006 RID: 6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <GenerateProxy>k__BackingField;
	}
}
