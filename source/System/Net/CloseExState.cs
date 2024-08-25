using System;

namespace System.Net
{
	// Token: 0x020001ED RID: 493
	[Flags]
	internal enum CloseExState
	{
		// Token: 0x04000A80 RID: 2688
		Normal = 0,
		// Token: 0x04000A81 RID: 2689
		Abort = 1,
		// Token: 0x04000A82 RID: 2690
		Silent = 2
	}
}
