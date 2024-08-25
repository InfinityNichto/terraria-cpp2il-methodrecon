using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002B6 RID: 694
	internal struct sockaddr_in6
	{
		// Token: 0x04000EE0 RID: 3808
		public ushort sin6_family;

		// Token: 0x04000EE1 RID: 3809
		public ushort sin6_port;

		// Token: 0x04000EE2 RID: 3810
		public uint sin6_flowinfo;

		// Token: 0x04000EE3 RID: 3811
		public in6_addr sin6_addr;

		// Token: 0x04000EE4 RID: 3812
		public uint sin6_scope_id;
	}
}
