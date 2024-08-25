using System;

namespace System
{
	// Token: 0x020001A9 RID: 425
	internal struct ConsoleScreenBufferInfo
	{
		// Token: 0x040008BB RID: 2235
		public Coord Size;

		// Token: 0x040008BC RID: 2236
		public Coord CursorPosition;

		// Token: 0x040008BD RID: 2237
		public short Attribute;

		// Token: 0x040008BE RID: 2238
		public SmallRect Window;

		// Token: 0x040008BF RID: 2239
		public Coord MaxWindowSize;
	}
}
