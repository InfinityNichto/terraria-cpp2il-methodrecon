using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002C8 RID: 712
	internal abstract class UnixNetworkInterfaceAPI : NetworkInterfaceFactory
	{
		// Token: 0x060012CF RID: 4815
		protected static extern int getifaddrs([Out] IntPtr ifap);

		// Token: 0x060012D0 RID: 4816
		protected static extern void freeifaddrs(IntPtr ifap);

		// Token: 0x060012D1 RID: 4817 RVA: 0x0003A79C File Offset: 0x0003899C
		protected UnixNetworkInterfaceAPI()
		{
		}
	}
}
