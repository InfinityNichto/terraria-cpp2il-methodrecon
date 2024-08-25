using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002BF RID: 703
	internal static class SystemNetworkInterface
	{
		// Token: 0x060012BC RID: 4796 RVA: 0x0003A5C4 File Offset: 0x000387C4
		public static NetworkInterface[] GetNetworkInterfaces()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0003A5D8 File Offset: 0x000387D8
		// Note: this type is marked as 'beforefieldinit'.
		static SystemNetworkInterface()
		{
			NetworkInterfaceFactory networkInterfaceFactory = NetworkInterfaceFactoryPal.Create();
		}

		// Token: 0x04000F09 RID: 3849
		private static readonly NetworkInterfaceFactory nif;
	}
}
