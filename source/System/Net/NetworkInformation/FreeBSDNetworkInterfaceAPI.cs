using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002AE RID: 686
	internal class FreeBSDNetworkInterfaceAPI : MacOsNetworkInterfaceAPI
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x0003A254 File Offset: 0x00038454
		public FreeBSDNetworkInterfaceAPI()
		{
			this.AF_INET6 = 28;
		}
	}
}
