using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002AF RID: 687
	internal static class IPGlobalPropertiesFactoryPal
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x0003A270 File Offset: 0x00038470
		public static IPGlobalProperties Create()
		{
			IPGlobalProperties ipglobalProperties;
			do
			{
				ipglobalProperties = UnixIPGlobalPropertiesFactoryPal.Create();
			}
			while (ipglobalProperties == null);
			return ipglobalProperties;
		}
	}
}
