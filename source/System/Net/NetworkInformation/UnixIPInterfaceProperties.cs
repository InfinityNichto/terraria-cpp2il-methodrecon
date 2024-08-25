using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002C7 RID: 711
	internal abstract class UnixIPInterfaceProperties : IPInterfaceProperties
	{
		// Token: 0x060012CC RID: 4812 RVA: 0x0003A744 File Offset: 0x00038944
		public UnixIPInterfaceProperties(UnixNetworkInterface iface, List<IPAddress> addresses)
		{
			this.iface = iface;
			this.addresses = addresses;
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x0003A768 File Offset: 0x00038968
		public override UnicastIPAddressInformationCollection UnicastAddresses
		{
			get
			{
				List<IPAddress> list = this.addresses;
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0003A78C File Offset: 0x0003898C
		// Note: this type is marked as 'beforefieldinit'.
		static UnixIPInterfaceProperties()
		{
		}

		// Token: 0x04000F12 RID: 3858
		protected UnixNetworkInterface iface;

		// Token: 0x04000F13 RID: 3859
		private List<IPAddress> addresses;

		// Token: 0x04000F14 RID: 3860
		private static global::System.Text.RegularExpressions.Regex ns;

		// Token: 0x04000F15 RID: 3861
		private static global::System.Text.RegularExpressions.Regex search;
	}
}
