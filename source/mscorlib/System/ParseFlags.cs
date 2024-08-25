using System;

namespace System
{
	// Token: 0x020000B9 RID: 185
	[Flags]
	internal enum ParseFlags
	{
		// Token: 0x040002E2 RID: 738
		HaveYear = 1,
		// Token: 0x040002E3 RID: 739
		HaveMonth = 2,
		// Token: 0x040002E4 RID: 740
		HaveDay = 4,
		// Token: 0x040002E5 RID: 741
		HaveHour = 8,
		// Token: 0x040002E6 RID: 742
		HaveMinute = 16,
		// Token: 0x040002E7 RID: 743
		HaveSecond = 32,
		// Token: 0x040002E8 RID: 744
		HaveTime = 64,
		// Token: 0x040002E9 RID: 745
		HaveDate = 128,
		// Token: 0x040002EA RID: 746
		TimeZoneUsed = 256,
		// Token: 0x040002EB RID: 747
		TimeZoneUtc = 512,
		// Token: 0x040002EC RID: 748
		ParsedMonthName = 1024,
		// Token: 0x040002ED RID: 749
		CaptureOffset = 2048,
		// Token: 0x040002EE RID: 750
		YearDefault = 4096,
		// Token: 0x040002EF RID: 751
		Rfc1123Pattern = 8192,
		// Token: 0x040002F0 RID: 752
		UtcSortPattern = 16384
	}
}
