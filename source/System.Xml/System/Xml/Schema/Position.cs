using System;

namespace System.Xml.Schema
{
	// Token: 0x020000C6 RID: 198
	internal struct Position
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x0001A02C File Offset: 0x0001822C
		public Position(int symbol, object particle)
		{
			this.symbol = symbol;
			this.particle = particle;
		}

		// Token: 0x04000420 RID: 1056
		public int symbol;

		// Token: 0x04000421 RID: 1057
		public object particle;
	}
}
