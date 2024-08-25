using System;

namespace Ionic.Zlib
{
	// Token: 0x0200005A RID: 90
	public static class ZlibConstants
	{
		// Token: 0x0400030F RID: 783
		public const int WindowBitsMax = 15;

		// Token: 0x04000310 RID: 784
		public const int WindowBitsDefault = 15;

		// Token: 0x04000311 RID: 785
		public const int Z_OK = 0;

		// Token: 0x04000312 RID: 786
		public const int Z_STREAM_END = 1;

		// Token: 0x04000313 RID: 787
		public const int Z_NEED_DICT = 2;

		// Token: 0x04000314 RID: 788
		public const int Z_STREAM_ERROR = -2;

		// Token: 0x04000315 RID: 789
		public const int Z_DATA_ERROR = -3;

		// Token: 0x04000316 RID: 790
		public const int Z_BUF_ERROR = -5;

		// Token: 0x04000317 RID: 791
		public const int WorkingBufferSizeDefault = 8192;

		// Token: 0x04000318 RID: 792
		public const int WorkingBufferSizeMin = 1024;
	}
}
