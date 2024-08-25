using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200023A RID: 570
	[Flags]
	internal enum InternalTaskOptions
	{
		// Token: 0x04000A88 RID: 2696
		None = 0,
		// Token: 0x04000A89 RID: 2697
		InternalOptionsMask = 65280,
		// Token: 0x04000A8A RID: 2698
		ContinuationTask = 512,
		// Token: 0x04000A8B RID: 2699
		PromiseTask = 1024,
		// Token: 0x04000A8C RID: 2700
		LazyCancellation = 4096,
		// Token: 0x04000A8D RID: 2701
		QueuedByRuntime = 8192,
		// Token: 0x04000A8E RID: 2702
		DoNotDispose = 16384
	}
}
