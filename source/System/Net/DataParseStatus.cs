using System;

namespace System.Net
{
	// Token: 0x020001E4 RID: 484
	internal enum DataParseStatus
	{
		// Token: 0x04000A34 RID: 2612
		NeedMoreData,
		// Token: 0x04000A35 RID: 2613
		ContinueParsing,
		// Token: 0x04000A36 RID: 2614
		Done,
		// Token: 0x04000A37 RID: 2615
		Invalid,
		// Token: 0x04000A38 RID: 2616
		DataTooBig
	}
}
