using System;

namespace System.Net
{
	// Token: 0x020001E3 RID: 483
	internal class BufferOffsetSize
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x00026F7C File Offset: 0x0002517C
		internal BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer)
		{
			long num = 0L;
			this.Offset = (int)num;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00026F98 File Offset: 0x00025198
		internal BufferOffsetSize(byte[] buffer, bool copyBuffer)
		{
		}

		// Token: 0x04000A30 RID: 2608
		internal byte[] Buffer;

		// Token: 0x04000A31 RID: 2609
		internal int Offset;

		// Token: 0x04000A32 RID: 2610
		internal int Size;
	}
}
