using System;

namespace System.Net
{
	// Token: 0x020001C0 RID: 448
	internal class SplitWritesState
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x000239A8 File Offset: 0x00021BA8
		internal SplitWritesState(BufferOffsetSize[] buffers)
		{
			this._UserBuffers = buffers;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x000239C4 File Offset: 0x00021BC4
		internal bool IsDone
		{
			get
			{
				if (this._LastBufferConsumed != 0)
				{
					return;
				}
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000239DC File Offset: 0x00021BDC
		internal BufferOffsetSize[] GetNextBuffers()
		{
			int num = 1;
			if (num != 0 || num != 0)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400097B RID: 2427
		private const int c_SplitEncryptedBuffersSize = 65536;

		// Token: 0x0400097C RID: 2428
		private BufferOffsetSize[] _UserBuffers;

		// Token: 0x0400097D RID: 2429
		private int _Index;

		// Token: 0x0400097E RID: 2430
		private int _LastBufferConsumed;

		// Token: 0x0400097F RID: 2431
		private BufferOffsetSize[] _RealBuffers;
	}
}
