using System;

namespace System.Net
{
	// Token: 0x0200019B RID: 411
	public class IPHostEntry
	{
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000231E4 File Offset: 0x000213E4
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x000231F8 File Offset: 0x000213F8
		public string HostName
		{
			get
			{
				return this.hostName;
			}
			set
			{
				this.hostName = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0002320C File Offset: 0x0002140C
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00023220 File Offset: 0x00021420
		public string[] Aliases
		{
			get
			{
				return this.aliases;
			}
			set
			{
				this.aliases = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00023234 File Offset: 0x00021434
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00023248 File Offset: 0x00021448
		public IPAddress[] AddressList
		{
			get
			{
				return this.addressList;
			}
			set
			{
				this.addressList = value;
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0002325C File Offset: 0x0002145C
		public IPHostEntry()
		{
		}

		// Token: 0x0400084E RID: 2126
		private string hostName;

		// Token: 0x0400084F RID: 2127
		private string[] aliases;

		// Token: 0x04000850 RID: 2128
		private IPAddress[] addressList;

		// Token: 0x04000851 RID: 2129
		internal bool isTrustedHost = true;
	}
}
