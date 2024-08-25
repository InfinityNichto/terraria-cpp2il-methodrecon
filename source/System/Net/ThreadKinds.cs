using System;

namespace System.Net
{
	// Token: 0x020001F2 RID: 498
	[Flags]
	internal enum ThreadKinds
	{
		// Token: 0x04000A91 RID: 2705
		Unknown = 0,
		// Token: 0x04000A92 RID: 2706
		User = 1,
		// Token: 0x04000A93 RID: 2707
		System = 2,
		// Token: 0x04000A94 RID: 2708
		Sync = 4,
		// Token: 0x04000A95 RID: 2709
		Async = 8,
		// Token: 0x04000A96 RID: 2710
		Timer = 16,
		// Token: 0x04000A97 RID: 2711
		CompletionPort = 32,
		// Token: 0x04000A98 RID: 2712
		Worker = 64,
		// Token: 0x04000A99 RID: 2713
		Finalization = 128,
		// Token: 0x04000A9A RID: 2714
		Other = 256,
		// Token: 0x04000A9B RID: 2715
		OwnerMask = 3,
		// Token: 0x04000A9C RID: 2716
		SyncMask = 12,
		// Token: 0x04000A9D RID: 2717
		SourceMask = 496,
		// Token: 0x04000A9E RID: 2718
		SafeSources = 352,
		// Token: 0x04000A9F RID: 2719
		ThreadPool = 96
	}
}
