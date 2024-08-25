using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200029E RID: 670
	public abstract class IPAddressInformation
	{
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600127D RID: 4733
		public abstract IPAddress Address { get; }

		// Token: 0x0600127E RID: 4734 RVA: 0x00039EDC File Offset: 0x000380DC
		protected IPAddressInformation()
		{
		}
	}
}
