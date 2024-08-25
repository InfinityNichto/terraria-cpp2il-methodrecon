using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002C1 RID: 705
	internal static class NetworkInterfaceFactoryPal
	{
		// Token: 0x060012C1 RID: 4801 RVA: 0x0003A614 File Offset: 0x00038814
		public static NetworkInterfaceFactory Create()
		{
			NetworkInterfaceFactory networkInterfaceFactory;
			do
			{
				networkInterfaceFactory = UnixNetworkInterfaceFactoryPal.Create();
			}
			while (networkInterfaceFactory == null);
			return networkInterfaceFactory;
		}
	}
}
