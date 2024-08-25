using System;

namespace System
{
	// Token: 0x020000BC RID: 188
	internal enum TokenType
	{
		// Token: 0x0400030D RID: 781
		NumberToken = 1,
		// Token: 0x0400030E RID: 782
		YearNumberToken,
		// Token: 0x0400030F RID: 783
		Am,
		// Token: 0x04000310 RID: 784
		Pm,
		// Token: 0x04000311 RID: 785
		MonthToken,
		// Token: 0x04000312 RID: 786
		EndOfString,
		// Token: 0x04000313 RID: 787
		DayOfWeekToken,
		// Token: 0x04000314 RID: 788
		TimeZoneToken,
		// Token: 0x04000315 RID: 789
		EraToken,
		// Token: 0x04000316 RID: 790
		DateWordToken,
		// Token: 0x04000317 RID: 791
		UnknownToken,
		// Token: 0x04000318 RID: 792
		HebrewNumber,
		// Token: 0x04000319 RID: 793
		JapaneseEraToken,
		// Token: 0x0400031A RID: 794
		TEraToken,
		// Token: 0x0400031B RID: 795
		IgnorableSymbol,
		// Token: 0x0400031C RID: 796
		SEP_Unk = 256,
		// Token: 0x0400031D RID: 797
		SEP_End = 512,
		// Token: 0x0400031E RID: 798
		SEP_Space = 768,
		// Token: 0x0400031F RID: 799
		SEP_Am = 1024,
		// Token: 0x04000320 RID: 800
		SEP_Pm = 1280,
		// Token: 0x04000321 RID: 801
		SEP_Date = 1536,
		// Token: 0x04000322 RID: 802
		SEP_Time = 1792,
		// Token: 0x04000323 RID: 803
		SEP_YearSuff = 2048,
		// Token: 0x04000324 RID: 804
		SEP_MonthSuff = 2304,
		// Token: 0x04000325 RID: 805
		SEP_DaySuff = 2560,
		// Token: 0x04000326 RID: 806
		SEP_HourSuff = 2816,
		// Token: 0x04000327 RID: 807
		SEP_MinuteSuff = 3072,
		// Token: 0x04000328 RID: 808
		SEP_SecondSuff = 3328,
		// Token: 0x04000329 RID: 809
		SEP_LocalTimeMark = 3584,
		// Token: 0x0400032A RID: 810
		SEP_DateOrOffset = 3840,
		// Token: 0x0400032B RID: 811
		RegularTokenMask = 255,
		// Token: 0x0400032C RID: 812
		SeparatorTokenMask = 65280
	}
}
