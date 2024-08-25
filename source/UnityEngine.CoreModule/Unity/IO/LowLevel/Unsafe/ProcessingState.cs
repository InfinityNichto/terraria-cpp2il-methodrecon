using System;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200000F RID: 15
	[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
	public enum ProcessingState
	{
		// Token: 0x0400001E RID: 30
		Unknown,
		// Token: 0x0400001F RID: 31
		InQueue,
		// Token: 0x04000020 RID: 32
		Reading,
		// Token: 0x04000021 RID: 33
		Completed,
		// Token: 0x04000022 RID: 34
		Failed,
		// Token: 0x04000023 RID: 35
		Canceled
	}
}
