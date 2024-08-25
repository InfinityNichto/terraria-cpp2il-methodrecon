using System;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x020001B1 RID: 433
	[StructLayout(0)]
	internal class SecChannelBindings
	{
		// Token: 0x06000A9E RID: 2718 RVA: 0x00023650 File Offset: 0x00021850
		public SecChannelBindings()
		{
		}

		// Token: 0x04000903 RID: 2307
		internal int dwInitiatorAddrType;

		// Token: 0x04000904 RID: 2308
		internal int cbInitiatorLength;

		// Token: 0x04000905 RID: 2309
		internal int dwInitiatorOffset;

		// Token: 0x04000906 RID: 2310
		internal int dwAcceptorAddrType;

		// Token: 0x04000907 RID: 2311
		internal int cbAcceptorLength;

		// Token: 0x04000908 RID: 2312
		internal int dwAcceptorOffset;

		// Token: 0x04000909 RID: 2313
		internal int cbApplicationDataLength;

		// Token: 0x0400090A RID: 2314
		internal int dwApplicationDataOffset;
	}
}
