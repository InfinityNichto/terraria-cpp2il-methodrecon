using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001A RID: 26
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	internal class NativeThrowsAttribute : Attribute
	{
		// Token: 0x17000016 RID: 22
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002590 File Offset: 0x00000790
		public bool ThrowsException
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000025A0 File Offset: 0x000007A0
		public NativeThrowsAttribute()
		{
			this.<ThrowsException>k__BackingField = true;
		}

		// Token: 0x04000024 RID: 36
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool <ThrowsException>k__BackingField;
	}
}
