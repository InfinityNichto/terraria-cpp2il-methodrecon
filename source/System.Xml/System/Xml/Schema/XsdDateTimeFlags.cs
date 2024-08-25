using System;

namespace System.Xml.Schema
{
	// Token: 0x02000168 RID: 360
	[Flags]
	internal enum XsdDateTimeFlags
	{
		// Token: 0x04000631 RID: 1585
		DateTime = 1,
		// Token: 0x04000632 RID: 1586
		Time = 2,
		// Token: 0x04000633 RID: 1587
		Date = 4,
		// Token: 0x04000634 RID: 1588
		GYearMonth = 8,
		// Token: 0x04000635 RID: 1589
		GYear = 16,
		// Token: 0x04000636 RID: 1590
		GMonthDay = 32,
		// Token: 0x04000637 RID: 1591
		GDay = 64,
		// Token: 0x04000638 RID: 1592
		GMonth = 128,
		// Token: 0x04000639 RID: 1593
		XdrDateTimeNoTz = 256,
		// Token: 0x0400063A RID: 1594
		XdrDateTime = 512,
		// Token: 0x0400063B RID: 1595
		XdrTimeNoTz = 1024,
		// Token: 0x0400063C RID: 1596
		AllXsd = 255
	}
}
