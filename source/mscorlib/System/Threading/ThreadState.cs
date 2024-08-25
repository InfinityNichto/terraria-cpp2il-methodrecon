using System;

namespace System.Threading
{
	// Token: 0x020001C4 RID: 452
	[Flags]
	public enum ThreadState
	{
		// Token: 0x0400090A RID: 2314
		Running = 0,
		// Token: 0x0400090B RID: 2315
		StopRequested = 1,
		// Token: 0x0400090C RID: 2316
		SuspendRequested = 2,
		// Token: 0x0400090D RID: 2317
		Background = 4,
		// Token: 0x0400090E RID: 2318
		Unstarted = 8,
		// Token: 0x0400090F RID: 2319
		Stopped = 16,
		// Token: 0x04000910 RID: 2320
		WaitSleepJoin = 32,
		// Token: 0x04000911 RID: 2321
		Suspended = 64,
		// Token: 0x04000912 RID: 2322
		AbortRequested = 128,
		// Token: 0x04000913 RID: 2323
		Aborted = 256
	}
}
