using System;

namespace System.IO
{
	// Token: 0x02000537 RID: 1335
	[Flags]
	public enum FileShare
	{
		// Token: 0x0400157D RID: 5501
		None = 0,
		// Token: 0x0400157E RID: 5502
		Read = 1,
		// Token: 0x0400157F RID: 5503
		Write = 2,
		// Token: 0x04001580 RID: 5504
		ReadWrite = 3,
		// Token: 0x04001581 RID: 5505
		Delete = 4,
		// Token: 0x04001582 RID: 5506
		Inheritable = 16
	}
}
