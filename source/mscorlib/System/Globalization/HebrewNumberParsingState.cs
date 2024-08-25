using System;

namespace System.Globalization
{
	// Token: 0x02000592 RID: 1426
	internal enum HebrewNumberParsingState
	{
		// Token: 0x04001779 RID: 6009
		InvalidHebrewNumber,
		// Token: 0x0400177A RID: 6010
		NotHebrewDigit,
		// Token: 0x0400177B RID: 6011
		FoundEndOfHebrewNumber,
		// Token: 0x0400177C RID: 6012
		ContinueParsing
	}
}
