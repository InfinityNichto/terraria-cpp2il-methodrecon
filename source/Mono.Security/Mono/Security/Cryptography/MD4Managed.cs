using System;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000057 RID: 87
	public class MD4Managed : MD4
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00009548 File Offset: 0x00007748
		public MD4Managed()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00009568 File Offset: 0x00007768
		public override void Initialize()
		{
			uint[] array = this.count;
			uint[] array2 = this.state;
			long num = 0L;
			Array.Clear(this.buffer, (int)num, 64);
			uint[] array3 = this.x;
			long num2 = 0L;
			Array.Clear(array3, (int)num2, 16);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000095A8 File Offset: 0x000077A8
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			uint[] array2 = this.count;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00009608 File Offset: 0x00007808
		protected override byte[] HashFinal()
		{
			uint[] array = this.count;
			uint[] array2 = this.count;
			byte[] array3 = this.digest;
			uint[] array4 = this.state;
			this.Encode(array3, array4);
			return this.digest;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00009648 File Offset: 0x00007848
		private byte[] Padding(int nLength)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		private uint F(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		private uint G(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		private uint H(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		private uint ROL(uint x, byte n)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00009658 File Offset: 0x00007858
		private void FF(uint a, uint b, uint c, uint d, uint x, byte s)
		{
			long num = 0L;
			a.m_value = (uint)num;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00009670 File Offset: 0x00007870
		private void GG(uint a, uint b, uint c, uint d, uint x, byte s)
		{
			long num = 0L;
			a.m_value = (uint)num;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009688 File Offset: 0x00007888
		private void HH(uint a, uint b, uint c, uint d, uint x, byte s)
		{
			long num = 0L;
			a.m_value = (uint)num;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000096A0 File Offset: 0x000078A0
		private void Encode(byte[] output, uint[] input)
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000096B0 File Offset: 0x000078B0
		private void Decode(uint[] output, byte[] input, int index)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000096C0 File Offset: 0x000078C0
		private void MD4Transform(uint[] state, byte[] block, int index)
		{
			uint[] array = this.x;
			this.Decode(array, block, index);
			uint[] array2 = this.x;
		}

		// Token: 0x0400025A RID: 602
		private uint[] state;

		// Token: 0x0400025B RID: 603
		private byte[] buffer;

		// Token: 0x0400025C RID: 604
		private uint[] count;

		// Token: 0x0400025D RID: 605
		private uint[] x;

		// Token: 0x0400025E RID: 606
		private byte[] digest;
	}
}
