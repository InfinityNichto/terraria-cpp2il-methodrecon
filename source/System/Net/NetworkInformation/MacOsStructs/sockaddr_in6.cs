using System;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020002CF RID: 719
	internal struct sockaddr_in6
	{
		// Token: 0x04000F29 RID: 3881
		public byte sin6_len;

		// Token: 0x04000F2A RID: 3882
		public byte sin6_family;

		// Token: 0x04000F2B RID: 3883
		public ushort sin6_port;

		// Token: 0x04000F2C RID: 3884
		public uint sin6_flowinfo;

		// Token: 0x04000F2D RID: 3885
		public in6_addr sin6_addr;

		// Token: 0x04000F2E RID: 3886
		public uint sin6_scope_id;
	}
}
