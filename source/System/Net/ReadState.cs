using System;

namespace System.Net
{
	// Token: 0x0200027F RID: 639
	internal enum ReadState
	{
		// Token: 0x04000D95 RID: 3477
		None,
		// Token: 0x04000D96 RID: 3478
		Status,
		// Token: 0x04000D97 RID: 3479
		Headers,
		// Token: 0x04000D98 RID: 3480
		Content,
		// Token: 0x04000D99 RID: 3481
		Aborted
	}
}
