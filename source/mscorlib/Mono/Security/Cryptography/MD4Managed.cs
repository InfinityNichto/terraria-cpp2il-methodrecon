using System;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000048 RID: 72
	internal class MD4Managed : MD4
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00005298 File Offset: 0x00003498
		public MD4Managed()
		{
			this.HashSizeValue = 128;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000052B8 File Offset: 0x000034B8
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

		// Token: 0x06000159 RID: 345 RVA: 0x000052F8 File Offset: 0x000034F8
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			uint[] array2 = this.count;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005358 File Offset: 0x00003558
		protected override byte[] HashFinal()
		{
			uint[] array = this.count;
			uint[] array2 = this.count;
			byte[] array3 = this.digest;
			uint[] array4 = this.state;
			this.Encode(array3, array4);
			return this.digest;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005398 File Offset: 0x00003598
		private byte[] Padding(int nLength)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000207A File Offset: 0x0000027A
		private uint F(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000207A File Offset: 0x0000027A
		private uint G(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000207A File Offset: 0x0000027A
		private uint H(uint x, uint y, uint z)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000207A File Offset: 0x0000027A
		private uint ROL(uint x, byte n)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000053A8 File Offset: 0x000035A8
		private void FF(uint a, uint b, uint c, uint d, uint x, byte s)
		{
			long num = 0L;
			a.m_value = (uint)num;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000053C0 File Offset: 0x000035C0
		private void GG(uint a, uint b, uint c, uint d, uint x, byte s)
		{
			long num = 0L;
			a.m_value = (uint)num;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000053D8 File Offset: 0x000035D8
		private void HH(uint a, uint b, uint c, uint d, uint x, byte s)
		{
			long num = 0L;
			a.m_value = (uint)num;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000053F0 File Offset: 0x000035F0
		private void Encode(byte[] output, uint[] input)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00005400 File Offset: 0x00003600
		private void Decode(uint[] output, byte[] input, int index)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00005410 File Offset: 0x00003610
		private void MD4Transform(uint[] state, byte[] block, int index)
		{
			uint[] array = this.x;
			this.Decode(array, block, index);
			uint[] array2 = this.x;
		}

		// Token: 0x0400014E RID: 334
		private uint[] state;

		// Token: 0x0400014F RID: 335
		private byte[] buffer;

		// Token: 0x04000150 RID: 336
		private uint[] count;

		// Token: 0x04000151 RID: 337
		private uint[] x;

		// Token: 0x04000152 RID: 338
		private byte[] digest;
	}
}
