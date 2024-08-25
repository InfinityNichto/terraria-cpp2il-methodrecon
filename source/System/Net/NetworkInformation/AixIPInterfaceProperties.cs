using System;
using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002A8 RID: 680
	internal class AixIPInterfaceProperties : UnixIPInterfaceProperties
	{
		// Token: 0x0600129A RID: 4762 RVA: 0x0003A0A8 File Offset: 0x000382A8
		public AixIPInterfaceProperties(AixNetworkInterface iface, List<IPAddress> addresses, int mtu)
		{
			if (!true)
			{
			}
			base..ctor();
			this.iface = iface;
			this.addresses = addresses;
			this._mtu = mtu;
		}

		// Token: 0x04000EBD RID: 3773
		private int _mtu;
	}
}
