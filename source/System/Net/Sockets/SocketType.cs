using System;

namespace System.Net.Sockets
{
	// Token: 0x02000304 RID: 772
	public enum SocketType
	{
		// Token: 0x040010CA RID: 4298
		Stream = 1,
		// Token: 0x040010CB RID: 4299
		Dgram,
		// Token: 0x040010CC RID: 4300
		Raw,
		// Token: 0x040010CD RID: 4301
		Rdm,
		// Token: 0x040010CE RID: 4302
		Seqpacket,
		// Token: 0x040010CF RID: 4303
		Unknown = -1
	}
}
