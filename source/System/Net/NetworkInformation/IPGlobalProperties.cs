using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200029F RID: 671
	public abstract class IPGlobalProperties
	{
		// Token: 0x0600127F RID: 4735 RVA: 0x00039EF0 File Offset: 0x000380F0
		public static IPGlobalProperties GetIPGlobalProperties()
		{
			return IPGlobalPropertiesFactoryPal.Create();
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00039F04 File Offset: 0x00038104
		internal static IPGlobalProperties InternalGetIPGlobalProperties()
		{
			return IPGlobalPropertiesFactoryPal.Create();
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001281 RID: 4737
		public abstract string DomainName { get; }

		// Token: 0x06001282 RID: 4738 RVA: 0x00039F18 File Offset: 0x00038118
		protected IPGlobalProperties()
		{
		}
	}
}
