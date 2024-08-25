using System;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020002CB RID: 715
	internal struct ifaddrs
	{
		// Token: 0x04000F1B RID: 3867
		public IntPtr ifa_next;

		// Token: 0x04000F1C RID: 3868
		public string ifa_name;

		// Token: 0x04000F1D RID: 3869
		public uint ifa_flags;

		// Token: 0x04000F1E RID: 3870
		public IntPtr ifa_addr;

		// Token: 0x04000F1F RID: 3871
		public IntPtr ifa_netmask;

		// Token: 0x04000F20 RID: 3872
		public IntPtr ifa_dstaddr;

		// Token: 0x04000F21 RID: 3873
		public IntPtr ifa_data;
	}
}
