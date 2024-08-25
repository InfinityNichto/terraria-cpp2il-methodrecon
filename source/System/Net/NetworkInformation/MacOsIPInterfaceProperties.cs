using System;
using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002BB RID: 699
	internal class MacOsIPInterfaceProperties : UnixIPInterfaceProperties
	{
		// Token: 0x060012B5 RID: 4789 RVA: 0x0003A4B0 File Offset: 0x000386B0
		public MacOsIPInterfaceProperties(MacOsNetworkInterface iface, List<IPAddress> addresses)
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
