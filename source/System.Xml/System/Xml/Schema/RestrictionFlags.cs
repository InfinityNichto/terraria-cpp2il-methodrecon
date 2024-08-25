using System;

namespace System.Xml.Schema
{
	// Token: 0x020000DA RID: 218
	[Flags]
	internal enum RestrictionFlags
	{
		// Token: 0x04000453 RID: 1107
		Length = 1,
		// Token: 0x04000454 RID: 1108
		MinLength = 2,
		// Token: 0x04000455 RID: 1109
		MaxLength = 4,
		// Token: 0x04000456 RID: 1110
		Pattern = 8,
		// Token: 0x04000457 RID: 1111
		Enumeration = 16,
		// Token: 0x04000458 RID: 1112
		WhiteSpace = 32,
		// Token: 0x04000459 RID: 1113
		MaxInclusive = 64,
		// Token: 0x0400045A RID: 1114
		MaxExclusive = 128,
		// Token: 0x0400045B RID: 1115
		MinInclusive = 256,
		// Token: 0x0400045C RID: 1116
		MinExclusive = 512,
		// Token: 0x0400045D RID: 1117
		TotalDigits = 1024,
		// Token: 0x0400045E RID: 1118
		FractionDigits = 2048
	}
}
