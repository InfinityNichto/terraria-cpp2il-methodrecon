using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000239 RID: 569
	[Flags]
	public enum TaskCreationOptions
	{
		// Token: 0x04000A80 RID: 2688
		None = 0,
		// Token: 0x04000A81 RID: 2689
		PreferFairness = 1,
		// Token: 0x04000A82 RID: 2690
		LongRunning = 2,
		// Token: 0x04000A83 RID: 2691
		AttachedToParent = 4,
		// Token: 0x04000A84 RID: 2692
		DenyChildAttach = 8,
		// Token: 0x04000A85 RID: 2693
		HideScheduler = 16,
		// Token: 0x04000A86 RID: 2694
		RunContinuationsAsynchronously = 64
	}
}
