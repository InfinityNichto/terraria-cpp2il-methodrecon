using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativePropertyAttribute : NativeMethodAttribute
	{
		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002360 File Offset: 0x00000560
		public TargetType TargetType
		{
			[CompilerGenerated]
			set
			{
				this.<TargetType>k__BackingField = value;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002374 File Offset: 0x00000574
		public NativePropertyAttribute()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002388 File Offset: 0x00000588
		public NativePropertyAttribute(string name)
			: base(name)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000239C File Offset: 0x0000059C
		public NativePropertyAttribute(string name, bool isFree, TargetType targetType)
			: base(name)
		{
			this.TargetType = targetType;
		}

		// Token: 0x04000014 RID: 20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TargetType <TargetType>k__BackingField;
	}
}
