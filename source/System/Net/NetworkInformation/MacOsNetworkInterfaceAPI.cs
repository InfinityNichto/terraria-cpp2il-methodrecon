using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002BC RID: 700
	internal class MacOsNetworkInterfaceAPI : UnixNetworkInterfaceAPI
	{
		// Token: 0x060012B6 RID: 4790 RVA: 0x0003A4D4 File Offset: 0x000386D4
		public MacOsNetworkInterfaceAPI()
		{
			this.AF_INET6 = 30;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0003A4F0 File Offset: 0x000386F0
		protected MacOsNetworkInterfaceAPI(int AF_INET6)
		{
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0003A504 File Offset: 0x00038704
		public override NetworkInterface[] GetAllNetworkInterfaces()
		{
			int num;
			if (num == 0)
			{
				int af_INET = this.AF_INET6;
				long num2 = 0L;
				while (num2 == 0L)
				{
				}
				int num3 = Math.Min(0, (int)num2);
				bool flag;
				UnixNetworkInterfaceAPI.freeifaddrs(flag ? 1 : 0);
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04000F00 RID: 3840
		protected readonly int AF_INET6;
	}
}
