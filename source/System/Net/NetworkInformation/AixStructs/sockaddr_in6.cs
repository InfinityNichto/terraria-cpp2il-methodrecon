using System;

namespace System.Net.NetworkInformation.AixStructs
{
	// Token: 0x020002DB RID: 731
	internal struct sockaddr_in6
	{
		// Token: 0x04000F49 RID: 3913
		public byte sin6_len;

		// Token: 0x04000F4A RID: 3914
		public byte sin6_family;

		// Token: 0x04000F4B RID: 3915
		public ushort sin6_port;

		// Token: 0x04000F4C RID: 3916
		public uint sin6_flowinfo;

		// Token: 0x04000F4D RID: 3917
		public in6_addr sin6_addr;

		// Token: 0x04000F4E RID: 3918
		public uint sin6_scope_id;
	}
}
