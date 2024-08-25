using System;

namespace System.Net.Sockets
{
	// Token: 0x0200030D RID: 781
	internal enum SocketOperation
	{
		// Token: 0x0400110C RID: 4364
		Accept,
		// Token: 0x0400110D RID: 4365
		Connect,
		// Token: 0x0400110E RID: 4366
		Receive,
		// Token: 0x0400110F RID: 4367
		ReceiveFrom,
		// Token: 0x04001110 RID: 4368
		Send,
		// Token: 0x04001111 RID: 4369
		SendTo,
		// Token: 0x04001112 RID: 4370
		RecvJustCallback,
		// Token: 0x04001113 RID: 4371
		SendJustCallback,
		// Token: 0x04001114 RID: 4372
		Disconnect,
		// Token: 0x04001115 RID: 4373
		AcceptReceive,
		// Token: 0x04001116 RID: 4374
		ReceiveGeneric,
		// Token: 0x04001117 RID: 4375
		SendGeneric
	}
}
