using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000E RID: 14
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class NativeWritableSelfAttribute : Attribute
	{
		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002280 File Offset: 0x00000480
		public bool WritableSelf
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002290 File Offset: 0x00000490
		public NativeWritableSelfAttribute()
		{
			this.<WritableSelf>k__BackingField = true;
		}

		// Token: 0x0400000B RID: 11
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <WritableSelf>k__BackingField;
	}
}
