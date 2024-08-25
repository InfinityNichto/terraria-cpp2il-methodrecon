using System;

namespace System.Net
{
	// Token: 0x0200014F RID: 335
	[Flags]
	internal enum FtpMethodFlags
	{
		// Token: 0x040006AE RID: 1710
		None = 0,
		// Token: 0x040006AF RID: 1711
		IsDownload = 1,
		// Token: 0x040006B0 RID: 1712
		IsUpload = 2,
		// Token: 0x040006B1 RID: 1713
		TakesParameter = 4,
		// Token: 0x040006B2 RID: 1714
		MayTakeParameter = 8,
		// Token: 0x040006B3 RID: 1715
		DoesNotTakeParameter = 16,
		// Token: 0x040006B4 RID: 1716
		ParameterIsDirectory = 32,
		// Token: 0x040006B5 RID: 1717
		ShouldParseForResponseUri = 64,
		// Token: 0x040006B6 RID: 1718
		HasHttpCommand = 128,
		// Token: 0x040006B7 RID: 1719
		MustChangeWorkingDirectoryToPath = 256
	}
}
