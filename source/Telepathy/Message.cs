using System;

namespace Telepathy
{
	// Token: 0x02000315 RID: 789
	public struct Message
	{
		// Token: 0x0600126D RID: 4717 RVA: 0x00059A9C File Offset: 0x00057C9C
		public Message(int connectionId, EventType eventType, byte[] data)
		{
			this.connectionId = connectionId;
			this.data = eventType;
			this.data = data;
		}

		// Token: 0x04002205 RID: 8709
		public readonly int connectionId;

		// Token: 0x04002206 RID: 8710
		public readonly EventType eventType;

		// Token: 0x04002207 RID: 8711
		public readonly byte[] data;
	}
}
