using System;

namespace Mono.Net.Security
{
	// Token: 0x0200004A RID: 74
	internal class BufferOffsetSize2 : BufferOffsetSize
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00003C8C File Offset: 0x00001E8C
		public BufferOffsetSize2(int size)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public void Reset()
		{
			int initialSize = this.InitialSize;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public void MakeRoom(int size)
		{
			byte[] buffer = this.Buffer;
			int offset = this.Offset;
			int totalBytes = this.TotalBytes;
			byte[] buffer2;
			if (offset != 0)
			{
				buffer2 = this.Buffer;
				return;
			}
			this.Buffer = buffer2;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003CE8 File Offset: 0x00001EE8
		public void AppendData(byte[] buffer, int offset, int size)
		{
			this.MakeRoom(size);
			int offset2 = this.Offset;
			int totalBytes = this.TotalBytes;
			byte[] buffer2 = this.Buffer;
			int size2 = this.Size;
			this.Size = size2;
		}

		// Token: 0x040000A0 RID: 160
		public readonly int InitialSize = size;
	}
}
