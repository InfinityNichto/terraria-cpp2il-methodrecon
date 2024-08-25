using System;

namespace System.Xml.Schema
{
	// Token: 0x020000D6 RID: 214
	internal sealed class NfaContentValidator : ContentValidator
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x0001AA4C File Offset: 0x00018C4C
		internal NfaContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
			if (!true)
			{
			}
			base..ctor();
			this.contentType = contentType;
			this.firstpos = firstpos;
			this.followpos = followpos;
			this.symbols = symbols;
			this.positions = positions;
			this.endMarkerPos = endMarkerPos;
		}

		// Token: 0x04000440 RID: 1088
		private BitSet firstpos;

		// Token: 0x04000441 RID: 1089
		private BitSet[] followpos;

		// Token: 0x04000442 RID: 1090
		private SymbolsDictionary symbols;

		// Token: 0x04000443 RID: 1091
		private Positions positions;

		// Token: 0x04000444 RID: 1092
		private int endMarkerPos;
	}
}
