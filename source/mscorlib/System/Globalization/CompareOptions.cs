using System;

namespace System.Globalization
{
	// Token: 0x02000583 RID: 1411
	[Flags]
	public enum CompareOptions
	{
		// Token: 0x040016C4 RID: 5828
		None = 0,
		// Token: 0x040016C5 RID: 5829
		IgnoreCase = 1,
		// Token: 0x040016C6 RID: 5830
		IgnoreNonSpace = 2,
		// Token: 0x040016C7 RID: 5831
		IgnoreSymbols = 4,
		// Token: 0x040016C8 RID: 5832
		IgnoreKanaType = 8,
		// Token: 0x040016C9 RID: 5833
		IgnoreWidth = 16,
		// Token: 0x040016CA RID: 5834
		OrdinalIgnoreCase = 268435456,
		// Token: 0x040016CB RID: 5835
		StringSort = 536870912,
		// Token: 0x040016CC RID: 5836
		Ordinal = 1073741824
	}
}
