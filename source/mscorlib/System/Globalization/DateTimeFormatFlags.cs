using System;

namespace System.Globalization
{
	// Token: 0x02000587 RID: 1415
	[Flags]
	internal enum DateTimeFormatFlags
	{
		// Token: 0x040016DD RID: 5853
		None = 0,
		// Token: 0x040016DE RID: 5854
		UseGenitiveMonth = 1,
		// Token: 0x040016DF RID: 5855
		UseLeapYearMonth = 2,
		// Token: 0x040016E0 RID: 5856
		UseSpacesInMonthNames = 4,
		// Token: 0x040016E1 RID: 5857
		UseHebrewRule = 8,
		// Token: 0x040016E2 RID: 5858
		UseSpacesInDayNames = 16,
		// Token: 0x040016E3 RID: 5859
		UseDigitPrefixInTokens = 32,
		// Token: 0x040016E4 RID: 5860
		NotInitialized = -1
	}
}
