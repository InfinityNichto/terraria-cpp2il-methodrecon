using System;

namespace System.Net.Sockets
{
	// Token: 0x020002FE RID: 766
	public enum SocketAsyncOperation
	{
		// Token: 0x0400104B RID: 4171
		None,
		// Token: 0x0400104C RID: 4172
		Accept,
		// Token: 0x0400104D RID: 4173
		Connect,
		// Token: 0x0400104E RID: 4174
		Disconnect,
		// Token: 0x0400104F RID: 4175
		Receive,
		// Token: 0x04001050 RID: 4176
		ReceiveFrom,
		// Token: 0x04001051 RID: 4177
		ReceiveMessageFrom,
		// Token: 0x04001052 RID: 4178
		Send,
		// Token: 0x04001053 RID: 4179
		SendPackets,
		// Token: 0x04001054 RID: 4180
		SendTo
	}
}
