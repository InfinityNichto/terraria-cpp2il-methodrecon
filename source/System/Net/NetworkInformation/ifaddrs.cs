using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002B4 RID: 692
	internal struct ifaddrs
	{
		// Token: 0x04000ED6 RID: 3798
		public IntPtr ifa_next;

		// Token: 0x04000ED7 RID: 3799
		public string ifa_name;

		// Token: 0x04000ED8 RID: 3800
		public uint ifa_flags;

		// Token: 0x04000ED9 RID: 3801
		public IntPtr ifa_addr;

		// Token: 0x04000EDA RID: 3802
		public IntPtr ifa_netmask;

		// Token: 0x04000EDB RID: 3803
		public ifa_ifu ifa_ifu;

		// Token: 0x04000EDC RID: 3804
		public IntPtr ifa_data;
	}
}
