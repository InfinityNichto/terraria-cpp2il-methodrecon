using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020002BA RID: 698
	internal class LinuxUnicastIPAddressInformation : UnicastIPAddressInformation
	{
		// Token: 0x060012B3 RID: 4787 RVA: 0x0003A480 File Offset: 0x00038680
		public LinuxUnicastIPAddressInformation(IPAddress address)
		{
			this.address = address;
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0003A49C File Offset: 0x0003869C
		public override IPAddress Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x04000EFF RID: 3839
		private IPAddress address;
	}
}
