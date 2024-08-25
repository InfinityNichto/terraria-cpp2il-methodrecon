using System;

namespace System.Threading
{
	// Token: 0x020001F9 RID: 505
	[Serializable]
	internal enum StackCrawlMark
	{
		// Token: 0x040009B0 RID: 2480
		LookForMe,
		// Token: 0x040009B1 RID: 2481
		LookForMyCaller,
		// Token: 0x040009B2 RID: 2482
		LookForMyCallersCaller,
		// Token: 0x040009B3 RID: 2483
		LookForThread
	}
}
