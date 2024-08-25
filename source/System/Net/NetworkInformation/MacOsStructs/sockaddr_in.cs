using System;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020002CD RID: 717
	internal struct sockaddr_in
	{
		// Token: 0x04000F24 RID: 3876
		public byte sin_len;

		// Token: 0x04000F25 RID: 3877
		public byte sin_family;

		// Token: 0x04000F26 RID: 3878
		public ushort sin_port;

		// Token: 0x04000F27 RID: 3879
		public uint sin_addr;
	}
}
