using System;

namespace System.Xml.Schema
{
	// Token: 0x020000D7 RID: 215
	internal sealed class RangeContentValidator : ContentValidator
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x0001AA90 File Offset: 0x00018C90
		internal RangeContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount)
		{
			if (!true)
			{
			}
			base..ctor();
			this.contentType = contentType;
			this.isEmptiable = isEmptiable;
			this.firstpos = firstpos;
			this.followpos = followpos;
			this.symbols = symbols;
			this.positions = positions;
		}

		// Token: 0x04000445 RID: 1093
		private BitSet firstpos;

		// Token: 0x04000446 RID: 1094
		private BitSet[] followpos;

		// Token: 0x04000447 RID: 1095
		private BitSet positionsWithRangeTerminals;

		// Token: 0x04000448 RID: 1096
		private SymbolsDictionary symbols;

		// Token: 0x04000449 RID: 1097
		private Positions positions;

		// Token: 0x0400044A RID: 1098
		private int minMaxNodesCount;

		// Token: 0x0400044B RID: 1099
		private int endMarkerPos;
	}
}
