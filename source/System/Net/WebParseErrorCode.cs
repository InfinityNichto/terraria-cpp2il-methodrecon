using System;

namespace System.Net
{
	// Token: 0x020001E7 RID: 487
	internal enum WebParseErrorCode
	{
		// Token: 0x04000A44 RID: 2628
		Generic,
		// Token: 0x04000A45 RID: 2629
		InvalidHeaderName,
		// Token: 0x04000A46 RID: 2630
		InvalidContentLength,
		// Token: 0x04000A47 RID: 2631
		IncompleteHeaderLine,
		// Token: 0x04000A48 RID: 2632
		CrLfError,
		// Token: 0x04000A49 RID: 2633
		InvalidChunkFormat,
		// Token: 0x04000A4A RID: 2634
		UnexpectedServerResponse
	}
}
