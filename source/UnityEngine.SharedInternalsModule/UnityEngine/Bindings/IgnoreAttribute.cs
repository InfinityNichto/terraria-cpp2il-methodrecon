using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Field)]
	[VisibleToOtherModules]
	internal class IgnoreAttribute : Attribute
	{
		// Token: 0x17000017 RID: 23
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000025BC File Offset: 0x000007BC
		public bool DoesNotContributeToSize
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000025CC File Offset: 0x000007CC
		public IgnoreAttribute()
		{
		}

		// Token: 0x04000025 RID: 37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <DoesNotContributeToSize>k__BackingField;
	}
}
