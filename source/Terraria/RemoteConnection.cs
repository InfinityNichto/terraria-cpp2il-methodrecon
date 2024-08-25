using System;
using Telepathy;

namespace Terraria
{
	// Token: 0x0200044A RID: 1098
	public class RemoteConnection
	{
		// Token: 0x06002964 RID: 10596 RVA: 0x0019B5AC File Offset: 0x001997AC
		public RemoteConnection()
		{
		}

		// Token: 0x04003671 RID: 13937
		public Client Client;

		// Token: 0x04003672 RID: 13938
		public bool IsActive;

		// Token: 0x04003673 RID: 13939
		public int State;

		// Token: 0x04003674 RID: 13940
		public int TimeOutTimer;

		// Token: 0x04003675 RID: 13941
		public string StatusText;

		// Token: 0x04003676 RID: 13942
		public int StatusCount;

		// Token: 0x04003677 RID: 13943
		public int StatusMax;
	}
}
