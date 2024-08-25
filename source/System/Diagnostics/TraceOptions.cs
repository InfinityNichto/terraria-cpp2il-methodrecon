using System;

namespace System.Diagnostics
{
	// Token: 0x020000D3 RID: 211
	[Flags]
	public enum TraceOptions
	{
		// Token: 0x040003B9 RID: 953
		None = 0,
		// Token: 0x040003BA RID: 954
		LogicalOperationStack = 1,
		// Token: 0x040003BB RID: 955
		DateTime = 2,
		// Token: 0x040003BC RID: 956
		Timestamp = 4,
		// Token: 0x040003BD RID: 957
		ProcessId = 8,
		// Token: 0x040003BE RID: 958
		ThreadId = 16,
		// Token: 0x040003BF RID: 959
		Callstack = 32
	}
}
