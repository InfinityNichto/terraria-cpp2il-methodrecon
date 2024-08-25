using System;
using System.IO;
using System.Runtime.CompilerServices;
using Terraria.DataStructures;

namespace Terraria.Net
{
	// Token: 0x020006A7 RID: 1703
	public struct NetPacket
	{
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x00226260 File Offset: 0x00224460
		// (set) Token: 0x060038A4 RID: 14500 RVA: 0x00226274 File Offset: 0x00224474
		public int Length
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Length>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Length>k__BackingField = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x00226288 File Offset: 0x00224488
		public BinaryWriter Writer
		{
			get
			{
				return this.Buffer.Writer;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x002262A0 File Offset: 0x002244A0
		public BinaryReader Reader
		{
			get
			{
				return this.Buffer.Reader;
			}
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x002262B8 File Offset: 0x002244B8
		public NetPacket(ushort id, int size)
		{
			int num = 1;
			this.Id = id;
			if (num == 0)
			{
			}
			CachedBuffer cachedBuffer = BufferPool.Request(size);
			this.Buffer = cachedBuffer;
			this.Length = size;
			BinaryWriter writer = cachedBuffer.Writer;
			BinaryWriter writer2 = this.Buffer.Writer;
			BinaryWriter writer3 = this.Buffer.Writer;
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x00226308 File Offset: 0x00224508
		public void Recycle()
		{
			this.Buffer.Recycle();
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x00226320 File Offset: 0x00224520
		public void ShrinkToFit()
		{
			CachedBuffer buffer = this.Buffer;
			int num = this.<Length>k__BackingField;
			BinaryWriter writer = buffer.Writer;
		}

		// Token: 0x0400794E RID: 31054
		private const int HEADER_SIZE = 5;

		// Token: 0x0400794F RID: 31055
		public readonly ushort Id;

		// Token: 0x04007950 RID: 31056
		[CompilerGenerated]
		private int <Length>k__BackingField;

		// Token: 0x04007951 RID: 31057
		public readonly CachedBuffer Buffer;
	}
}
