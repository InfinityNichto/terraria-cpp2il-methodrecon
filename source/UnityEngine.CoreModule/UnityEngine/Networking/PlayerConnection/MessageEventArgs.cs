using System;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public class MessageEventArgs
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x0000986C File Offset: 0x00007A6C
		public MessageEventArgs()
		{
		}

		// Token: 0x04000423 RID: 1059
		public int playerId;

		// Token: 0x04000424 RID: 1060
		public byte[] data;
	}
}
