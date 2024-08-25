using System;

namespace System.Globalization
{
	// Token: 0x0200058E RID: 1422
	[Flags]
	public enum DateTimeStyles
	{
		// Token: 0x04001766 RID: 5990
		None = 0,
		// Token: 0x04001767 RID: 5991
		AllowLeadingWhite = 1,
		// Token: 0x04001768 RID: 5992
		AllowTrailingWhite = 2,
		// Token: 0x04001769 RID: 5993
		AllowInnerWhite = 4,
		// Token: 0x0400176A RID: 5994
		AllowWhiteSpaces = 7,
		// Token: 0x0400176B RID: 5995
		NoCurrentDateDefault = 8,
		// Token: 0x0400176C RID: 5996
		AdjustToUniversal = 16,
		// Token: 0x0400176D RID: 5997
		AssumeLocal = 32,
		// Token: 0x0400176E RID: 5998
		AssumeUniversal = 64,
		// Token: 0x0400176F RID: 5999
		RoundtripKind = 128
	}
}
