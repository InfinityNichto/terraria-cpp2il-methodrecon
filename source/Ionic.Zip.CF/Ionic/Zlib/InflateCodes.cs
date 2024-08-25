using System;

namespace Ionic.Zlib
{
	// Token: 0x02000048 RID: 72
	internal sealed class InflateCodes
	{
		// Token: 0x06000383 RID: 899 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		internal InflateCodes()
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
		{
			this.lbits = (byte)bl;
			this.dbits = (byte)bd;
			this.ltree = tl;
			this.ltree_index = tl_index;
			this.dtree = td;
			this.dtree_index = td_index;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		internal int Process(InflateBlocks blocks, int r)
		{
			ZlibCodec codec = blocks._codec;
			int readAt = blocks.readAt;
			int nextIn = codec.NextIn;
			long totalBytesIn = codec.TotalBytesIn;
			int bitk = blocks.bitk;
			int[] hufts = blocks.hufts;
			return "invalid distance code";
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000D830 File Offset: 0x0000BA30
		internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z)
		{
			int readAt = s.readAt;
			int bitk = s.bitk;
			int bitb = s.bitb;
			return "invalid distance code";
		}

		// Token: 0x0400025B RID: 603
		private const int START = 0;

		// Token: 0x0400025C RID: 604
		private const int LEN = 1;

		// Token: 0x0400025D RID: 605
		private const int LENEXT = 2;

		// Token: 0x0400025E RID: 606
		private const int DIST = 3;

		// Token: 0x0400025F RID: 607
		private const int DISTEXT = 4;

		// Token: 0x04000260 RID: 608
		private const int COPY = 5;

		// Token: 0x04000261 RID: 609
		private const int LIT = 6;

		// Token: 0x04000262 RID: 610
		private const int WASH = 7;

		// Token: 0x04000263 RID: 611
		private const int END = 8;

		// Token: 0x04000264 RID: 612
		private const int BADCODE = 9;

		// Token: 0x04000265 RID: 613
		internal int mode;

		// Token: 0x04000266 RID: 614
		internal int len;

		// Token: 0x04000267 RID: 615
		internal int[] tree;

		// Token: 0x04000268 RID: 616
		internal int tree_index;

		// Token: 0x04000269 RID: 617
		internal int need;

		// Token: 0x0400026A RID: 618
		internal int lit;

		// Token: 0x0400026B RID: 619
		internal int bitsToGet;

		// Token: 0x0400026C RID: 620
		internal int dist;

		// Token: 0x0400026D RID: 621
		internal byte lbits;

		// Token: 0x0400026E RID: 622
		internal byte dbits;

		// Token: 0x0400026F RID: 623
		internal int[] ltree;

		// Token: 0x04000270 RID: 624
		internal int ltree_index;

		// Token: 0x04000271 RID: 625
		internal int[] dtree;

		// Token: 0x04000272 RID: 626
		internal int dtree_index;
	}
}
