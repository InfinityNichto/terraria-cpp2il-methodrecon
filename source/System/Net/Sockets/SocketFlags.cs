using System;

namespace System.Net.Sockets
{
	// Token: 0x02000300 RID: 768
	[Flags]
	public enum SocketFlags
	{
		// Token: 0x04001086 RID: 4230
		None = 0,
		// Token: 0x04001087 RID: 4231
		OutOfBand = 1,
		// Token: 0x04001088 RID: 4232
		Peek = 2,
		// Token: 0x04001089 RID: 4233
		DontRoute = 4,
		// Token: 0x0400108A RID: 4234
		MaxIOVectorLength = 16,
		// Token: 0x0400108B RID: 4235
		Truncated = 256,
		// Token: 0x0400108C RID: 4236
		ControlDataTruncated = 512,
		// Token: 0x0400108D RID: 4237
		Broadcast = 1024,
		// Token: 0x0400108E RID: 4238
		Multicast = 2048,
		// Token: 0x0400108F RID: 4239
		Partial = 32768
	}
}
