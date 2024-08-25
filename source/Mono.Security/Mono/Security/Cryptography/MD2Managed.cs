using System;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000055 RID: 85
	public class MD2Managed : MD2
	{
		// Token: 0x06000244 RID: 580 RVA: 0x00009344 File Offset: 0x00007544
		private byte[] Padding(int nLength)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00009354 File Offset: 0x00007554
		public MD2Managed()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00009374 File Offset: 0x00007574
		public override void Initialize()
		{
			byte[] array = this.state;
			long num = 0L;
			Array.Clear(array, (int)num, 16);
			byte[] array2 = this.checksum;
			long num2 = 0L;
			Array.Clear(array2, (int)num2, 16);
			byte[] array3 = this.buffer;
			long num3 = 0L;
			Array.Clear(array3, (int)num3, 16);
			byte[] array4 = this.x;
			long num4 = 0L;
			Array.Clear(array4, (int)num4, 48);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000093D4 File Offset: 0x000075D4
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			int num = this.count;
			int num2 = 16;
			this.count = num2;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009458 File Offset: 0x00007658
		protected override byte[] HashFinal()
		{
			object obj;
			do
			{
				int num = this.count;
				byte[] array = this.checksum;
				byte[] array2 = this.state;
				if (obj == null)
				{
					return;
				}
			}
			while (obj != null);
			throw new InvalidCastException();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000948C File Offset: 0x0000768C
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index)
		{
			byte[] array = this.x;
			int num = 16;
			long num2 = 0L;
			long num3 = 0L;
			Buffer.BlockCopy(state, (int)num2, array, (int)num3, num);
			byte[] array2 = this.x;
			int num4 = 16;
			int num5 = 16;
			Buffer.BlockCopy(block, index, array2, num4, num5);
			long num6 = 0L;
			byte[] array3 = this.x;
			byte[] array4 = this.x;
			if (num6 == 0L)
			{
			}
			byte[] array5 = this.x;
			int num7 = 16;
			long num8 = 0L;
			long num9 = 0L;
			Buffer.BlockCopy(array5, (int)num8, state, (int)num9, num7);
			checksum.m_value = this;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00009518 File Offset: 0x00007718
		// Note: this type is marked as 'beforefieldinit'.
		static MD2Managed()
		{
		}

		// Token: 0x04000254 RID: 596
		private byte[] state;

		// Token: 0x04000255 RID: 597
		private byte[] checksum;

		// Token: 0x04000256 RID: 598
		private byte[] buffer;

		// Token: 0x04000257 RID: 599
		private int count;

		// Token: 0x04000258 RID: 600
		private byte[] x;

		// Token: 0x04000259 RID: 601
		private static readonly byte[] PI_SUBST;
	}
}
