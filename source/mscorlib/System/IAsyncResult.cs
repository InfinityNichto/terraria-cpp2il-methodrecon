using System;
using System.Threading;

namespace System
{
	// Token: 0x020000C2 RID: 194
	public interface IAsyncResult
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000753 RID: 1875
		bool IsCompleted { get; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000754 RID: 1876
		WaitHandle AsyncWaitHandle { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000755 RID: 1877
		object AsyncState { get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000756 RID: 1878
		bool CompletedSynchronously { get; }
	}
}
