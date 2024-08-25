using System;

namespace System.IO
{
	// Token: 0x02000536 RID: 1334
	[Flags]
	public enum FileOptions
	{
		// Token: 0x04001575 RID: 5493
		None = 0,
		// Token: 0x04001576 RID: 5494
		WriteThrough = -2147483648,
		// Token: 0x04001577 RID: 5495
		Asynchronous = 1073741824,
		// Token: 0x04001578 RID: 5496
		RandomAccess = 268435456,
		// Token: 0x04001579 RID: 5497
		DeleteOnClose = 67108864,
		// Token: 0x0400157A RID: 5498
		SequentialScan = 134217728,
		// Token: 0x0400157B RID: 5499
		Encrypted = 16384
	}
}
