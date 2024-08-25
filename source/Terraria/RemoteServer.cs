using System;
using Telepathy;

namespace Terraria
{
	// Token: 0x0200044B RID: 1099
	public class RemoteServer
	{
		// Token: 0x06002965 RID: 10597 RVA: 0x0019B5C0 File Offset: 0x001997C0
		public RemoteServer()
		{
		}

		// Token: 0x04003678 RID: 13944
		public Server Client;

		// Token: 0x04003679 RID: 13945
		public bool IsActive;

		// Token: 0x0400367A RID: 13946
		public int State;

		// Token: 0x0400367B RID: 13947
		public int TimeOutTimer;

		// Token: 0x0400367C RID: 13948
		public string StatusText;

		// Token: 0x0400367D RID: 13949
		public int StatusCount;

		// Token: 0x0400367E RID: 13950
		public int StatusMax;
	}
}
