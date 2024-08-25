using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002C0 RID: 704
	internal abstract class NetworkInterfaceFactory
	{
		// Token: 0x060012BE RID: 4798
		public abstract NetworkInterface[] GetAllNetworkInterfaces();

		// Token: 0x060012BF RID: 4799 RVA: 0x0003A5EC File Offset: 0x000387EC
		public static NetworkInterfaceFactory Create()
		{
			return NetworkInterfaceFactoryPal.Create();
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0003A600 File Offset: 0x00038800
		protected NetworkInterfaceFactory()
		{
		}
	}
}
