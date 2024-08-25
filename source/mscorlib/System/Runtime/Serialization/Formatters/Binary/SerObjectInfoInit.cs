using System;
using System.Collections;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200041B RID: 1051
	internal sealed class SerObjectInfoInit
	{
		// Token: 0x060020A5 RID: 8357 RVA: 0x00048618 File Offset: 0x00046818
		public SerObjectInfoInit()
		{
		}

		// Token: 0x0400112F RID: 4399
		internal Hashtable seenBeforeTable;

		// Token: 0x04001130 RID: 4400
		internal int objectInfoIdCount;

		// Token: 0x04001131 RID: 4401
		internal SerStack oiPool;
	}
}
