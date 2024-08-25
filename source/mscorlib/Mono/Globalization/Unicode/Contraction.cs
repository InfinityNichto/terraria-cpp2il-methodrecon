using System;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000033 RID: 51
	internal class Contraction
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00003064 File Offset: 0x00001264
		public Contraction(int index, char[] source, string replacement, byte[] sortkey)
		{
			this.Index = index;
			this.Source = source;
			this.Replacement = replacement;
			this.SortKey = sortkey;
		}

		// Token: 0x040000DD RID: 221
		public int Index;

		// Token: 0x040000DE RID: 222
		public readonly char[] Source;

		// Token: 0x040000DF RID: 223
		public readonly string Replacement;

		// Token: 0x040000E0 RID: 224
		public readonly byte[] SortKey;
	}
}
