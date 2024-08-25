using System;

namespace Terraria.Net
{
	// Token: 0x020006A9 RID: 1705
	public abstract class RemoteAddress
	{
		// Token: 0x060038AA RID: 14506
		public abstract string GetIdentifier();

		// Token: 0x060038AB RID: 14507
		public abstract string GetFriendlyName();

		// Token: 0x060038AC RID: 14508
		public abstract bool IsLocalHost();

		// Token: 0x060038AD RID: 14509 RVA: 0x0022639C File Offset: 0x0022459C
		protected RemoteAddress()
		{
		}

		// Token: 0x04007956 RID: 31062
		public AddressType Type;
	}
}
