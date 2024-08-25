using System;
using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002B0 RID: 688
	internal class LinuxIPInterfaceProperties : UnixIPInterfaceProperties
	{
		// Token: 0x060012A9 RID: 4777 RVA: 0x0003A288 File Offset: 0x00038488
		public LinuxIPInterfaceProperties(LinuxNetworkInterface iface, List<IPAddress> addresses)
		{
			if (!true)
			{
			}
			base..ctor();
			this.iface = iface;
			this.addresses = addresses;
		}
	}
}
