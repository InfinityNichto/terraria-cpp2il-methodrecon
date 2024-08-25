using System;

namespace System.Globalization
{
	// Token: 0x02000597 RID: 1431
	[Flags]
	public enum NumberStyles
	{
		// Token: 0x040017A3 RID: 6051
		None = 0,
		// Token: 0x040017A4 RID: 6052
		AllowLeadingWhite = 1,
		// Token: 0x040017A5 RID: 6053
		AllowTrailingWhite = 2,
		// Token: 0x040017A6 RID: 6054
		AllowLeadingSign = 4,
		// Token: 0x040017A7 RID: 6055
		AllowTrailingSign = 8,
		// Token: 0x040017A8 RID: 6056
		AllowParentheses = 16,
		// Token: 0x040017A9 RID: 6057
		AllowDecimalPoint = 32,
		// Token: 0x040017AA RID: 6058
		AllowThousands = 64,
		// Token: 0x040017AB RID: 6059
		AllowExponent = 128,
		// Token: 0x040017AC RID: 6060
		AllowCurrencySymbol = 256,
		// Token: 0x040017AD RID: 6061
		AllowHexSpecifier = 512,
		// Token: 0x040017AE RID: 6062
		Integer = 7,
		// Token: 0x040017AF RID: 6063
		HexNumber = 515,
		// Token: 0x040017B0 RID: 6064
		Number = 111,
		// Token: 0x040017B1 RID: 6065
		Float = 167,
		// Token: 0x040017B2 RID: 6066
		Currency = 383,
		// Token: 0x040017B3 RID: 6067
		Any = 511
	}
}
