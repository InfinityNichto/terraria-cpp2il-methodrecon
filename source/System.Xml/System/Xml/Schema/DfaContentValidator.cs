using System;

namespace System.Xml.Schema
{
	// Token: 0x020000D5 RID: 213
	internal sealed class DfaContentValidator : ContentValidator
	{
		// Token: 0x0600086A RID: 2154 RVA: 0x0001AA10 File Offset: 0x00018C10
		internal DfaContentValidator(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
			if (!true)
			{
			}
			base..ctor();
			this.contentType = contentType;
			this.isOpen = isOpen;
			this.isEmptiable = isEmptiable;
			this.transitionTable = transitionTable;
			this.symbols = symbols;
		}

		// Token: 0x0400043E RID: 1086
		private int[][] transitionTable;

		// Token: 0x0400043F RID: 1087
		private SymbolsDictionary symbols;
	}
}
