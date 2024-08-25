using System;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000046 RID: 70
	internal class MD2Managed : MD2
	{
		// Token: 0x0600014E RID: 334 RVA: 0x000050AC File Offset: 0x000032AC
		private byte[] Padding(int nLength)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000050BC File Offset: 0x000032BC
		public MD2Managed()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000050DC File Offset: 0x000032DC
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

		// Token: 0x06000151 RID: 337 RVA: 0x0000513C File Offset: 0x0000333C
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			int num = this.count;
			int num2 = 16;
			this.count = num2;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000051C0 File Offset: 0x000033C0
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

		// Token: 0x06000153 RID: 339 RVA: 0x000051F4 File Offset: 0x000033F4
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index)
		{
			byte[] array = this.x;
			byte[] array2 = this.x;
			int num = 16;
			int num2 = 16;
			Buffer.BlockCopy(block, index, array2, num, num2);
			long num3 = 0L;
			byte[] array3 = this.x;
			byte[] array4 = this.x;
			if (num3 == 0L)
			{
			}
			byte[] array5 = this.x;
			int num4 = 16;
			long num5 = 0L;
			long num6 = 0L;
			Buffer.BlockCopy(array5, (int)num5, array2, (int)num6, num4);
			checksum.m_value = this;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005268 File Offset: 0x00003468
		// Note: this type is marked as 'beforefieldinit'.
		static MD2Managed()
		{
		}

		// Token: 0x04000148 RID: 328
		private byte[] state;

		// Token: 0x04000149 RID: 329
		private byte[] checksum;

		// Token: 0x0400014A RID: 330
		private byte[] buffer;

		// Token: 0x0400014B RID: 331
		private int count;

		// Token: 0x0400014C RID: 332
		private byte[] x;

		// Token: 0x0400014D RID: 333
		private static readonly byte[] PI_SUBST;
	}
}
