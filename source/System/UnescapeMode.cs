using System;

namespace System
{
	// Token: 0x0200008F RID: 143
	[Flags]
	internal enum UnescapeMode
	{
		// Token: 0x0400021B RID: 539
		CopyOnly = 0,
		// Token: 0x0400021C RID: 540
		Escape = 1,
		// Token: 0x0400021D RID: 541
		Unescape = 2,
		// Token: 0x0400021E RID: 542
		EscapeUnescape = 3,
		// Token: 0x0400021F RID: 543
		V1ToStringFlag = 4,
		// Token: 0x04000220 RID: 544
		UnescapeAll = 8,
		// Token: 0x04000221 RID: 545
		UnescapeAllOrThrow = 24
	}
}
