using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002B8 RID: 696
	internal struct sockaddr_ll
	{
		// Token: 0x04000EE6 RID: 3814
		public ushort sll_family;

		// Token: 0x04000EE7 RID: 3815
		public ushort sll_protocol;

		// Token: 0x04000EE8 RID: 3816
		public int sll_ifindex;

		// Token: 0x04000EE9 RID: 3817
		public ushort sll_hatype;

		// Token: 0x04000EEA RID: 3818
		public byte sll_pkttype;

		// Token: 0x04000EEB RID: 3819
		public byte sll_halen;

		// Token: 0x04000EEC RID: 3820
		public byte[] sll_addr;
	}
}
