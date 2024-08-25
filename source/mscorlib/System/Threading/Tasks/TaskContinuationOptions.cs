using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200023B RID: 571
	[Flags]
	public enum TaskContinuationOptions
	{
		// Token: 0x04000A90 RID: 2704
		None = 0,
		// Token: 0x04000A91 RID: 2705
		PreferFairness = 1,
		// Token: 0x04000A92 RID: 2706
		LongRunning = 2,
		// Token: 0x04000A93 RID: 2707
		AttachedToParent = 4,
		// Token: 0x04000A94 RID: 2708
		DenyChildAttach = 8,
		// Token: 0x04000A95 RID: 2709
		HideScheduler = 16,
		// Token: 0x04000A96 RID: 2710
		LazyCancellation = 32,
		// Token: 0x04000A97 RID: 2711
		RunContinuationsAsynchronously = 64,
		// Token: 0x04000A98 RID: 2712
		NotOnRanToCompletion = 65536,
		// Token: 0x04000A99 RID: 2713
		NotOnFaulted = 131072,
		// Token: 0x04000A9A RID: 2714
		NotOnCanceled = 262144,
		// Token: 0x04000A9B RID: 2715
		OnlyOnRanToCompletion = 393216,
		// Token: 0x04000A9C RID: 2716
		OnlyOnFaulted = 327680,
		// Token: 0x04000A9D RID: 2717
		OnlyOnCanceled = 196608,
		// Token: 0x04000A9E RID: 2718
		ExecuteSynchronously = 524288
	}
}
