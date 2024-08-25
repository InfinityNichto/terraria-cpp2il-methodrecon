using System;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000032 RID: 50
	internal class TailoringInfo
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x0000303C File Offset: 0x0000123C
		public TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort)
		{
			this.LCID = lcid;
			this.TailoringCount = tailoringIndex;
			this.TailoringCount = tailoringCount;
		}

		// Token: 0x040000D9 RID: 217
		public readonly int LCID;

		// Token: 0x040000DA RID: 218
		public readonly int TailoringIndex;

		// Token: 0x040000DB RID: 219
		public readonly int TailoringCount;

		// Token: 0x040000DC RID: 220
		public readonly bool FrenchSort;
	}
}
