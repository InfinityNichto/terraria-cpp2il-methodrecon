using System;

namespace System.Net
{
	// Token: 0x02000148 RID: 328
	internal class ReceiveState
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x0001BD98 File Offset: 0x00019F98
		internal ReceiveState(CommandStream connection)
		{
			this.Connection = connection;
		}

		// Token: 0x04000672 RID: 1650
		private const int bufferSize = 1024;

		// Token: 0x04000673 RID: 1651
		internal ResponseDescription Resp;

		// Token: 0x04000674 RID: 1652
		internal int ValidThrough;

		// Token: 0x04000675 RID: 1653
		internal byte[] Buffer;

		// Token: 0x04000676 RID: 1654
		internal CommandStream Connection;
	}
}
