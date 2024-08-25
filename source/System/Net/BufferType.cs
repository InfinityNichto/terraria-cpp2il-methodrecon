using System;

namespace System.Net
{
	// Token: 0x020001AB RID: 427
	internal enum BufferType
	{
		// Token: 0x040008B4 RID: 2228
		Empty,
		// Token: 0x040008B5 RID: 2229
		Data,
		// Token: 0x040008B6 RID: 2230
		Token,
		// Token: 0x040008B7 RID: 2231
		Parameters,
		// Token: 0x040008B8 RID: 2232
		Missing,
		// Token: 0x040008B9 RID: 2233
		Extra,
		// Token: 0x040008BA RID: 2234
		Trailer,
		// Token: 0x040008BB RID: 2235
		Header,
		// Token: 0x040008BC RID: 2236
		Padding = 9,
		// Token: 0x040008BD RID: 2237
		Stream,
		// Token: 0x040008BE RID: 2238
		ChannelBindings = 14,
		// Token: 0x040008BF RID: 2239
		TargetHost = 16,
		// Token: 0x040008C0 RID: 2240
		ReadOnlyFlag = -2147483648,
		// Token: 0x040008C1 RID: 2241
		ReadOnlyWithChecksum = 268435456
	}
}
