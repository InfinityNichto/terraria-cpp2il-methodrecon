using System;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020002D9 RID: 729
	internal struct sockaddr_in
	{
		// Token: 0x04000F44 RID: 3908
		public byte sin_len;

		// Token: 0x04000F45 RID: 3909
		public byte sin_family;

		// Token: 0x04000F46 RID: 3910
		public ushort sin_port;

		// Token: 0x04000F47 RID: 3911
		public uint sin_addr;
	}
}
