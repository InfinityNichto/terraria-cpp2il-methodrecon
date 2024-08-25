using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002A0 RID: 672
	public abstract class IPInterfaceProperties
	{
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001283 RID: 4739
		public abstract UnicastIPAddressInformationCollection UnicastAddresses { get; }

		// Token: 0x06001284 RID: 4740 RVA: 0x00039F2C File Offset: 0x0003812C
		protected IPInterfaceProperties()
		{
		}
	}
}
