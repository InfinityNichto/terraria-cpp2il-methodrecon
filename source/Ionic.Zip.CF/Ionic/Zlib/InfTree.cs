using System;

namespace Ionic.Zlib
{
	// Token: 0x0200004B RID: 75
	internal sealed class InfTree
	{
		// Token: 0x06000393 RID: 915 RVA: 0x0000E030 File Offset: 0x0000C230
		private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
		{
			int[] array = this.c;
			int[] array2 = this.x;
			int[] array3 = this.u;
			if (s != 0)
			{
				if (array != null)
				{
					int[] array4 = this.c;
					int[] array5 = this.u;
					int[] array6 = this.x;
					int[] array7 = this.r;
					int num = 3;
					long num2 = 0L;
					Array.Copy(array7, (int)num2, t, n, num);
					return array7;
				}
				int[] array8 = this.c;
				int[] array9;
				return array9;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000E12C File Offset: 0x0000C32C
		internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
		{
			this.initWorkArea(19);
			int[] array = this.hn;
			int[] array2 = this.v;
			int num;
			return num;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000E168 File Offset: 0x0000C368
		internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
		{
			int num = 288;
			this.initWorkArea(num);
			int[] array = this.hn;
			int[] array2 = this.hn;
			int[] array3 = this.v;
			int num2;
			int num4;
			if (num2 == 0 && array2 != null)
			{
				int num3 = 288;
				this.initWorkArea(num3);
				if (array2 == null)
				{
				}
				int[] array4 = this.hn;
				int[] array5 = this.v;
				return num4;
			}
			return num4;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)
		{
			if (9 == 0)
			{
			}
			if ((9 == 0 || 9 != 0) && (bd == null || bd != null))
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000E200 File Offset: 0x0000C400
		private void initWorkArea(int vsize)
		{
			if (this.hn != null)
			{
				int[] array = this.v;
				int[] array2 = this.c;
				long num = 0L;
				Array.Clear(array2, (int)num, 16);
				int[] array3 = this.r;
				long num2 = 0L;
				Array.Clear(this.u, (int)num2, 15);
				int[] array4 = this.x;
				long num3 = 0L;
				Array.Clear(array4, (int)num3, 16);
				return;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000E260 File Offset: 0x0000C460
		public InfTree()
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000E274 File Offset: 0x0000C474
		// Note: this type is marked as 'beforefieldinit'.
		static InfTree()
		{
		}

		// Token: 0x0400028E RID: 654
		private const int MANY = 1440;

		// Token: 0x0400028F RID: 655
		private const int Z_OK = 0;

		// Token: 0x04000290 RID: 656
		private const int Z_STREAM_END = 1;

		// Token: 0x04000291 RID: 657
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000292 RID: 658
		private const int Z_ERRNO = -1;

		// Token: 0x04000293 RID: 659
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x04000294 RID: 660
		private const int Z_DATA_ERROR = -3;

		// Token: 0x04000295 RID: 661
		private const int Z_MEM_ERROR = -4;

		// Token: 0x04000296 RID: 662
		private const int Z_BUF_ERROR = -5;

		// Token: 0x04000297 RID: 663
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x04000298 RID: 664
		internal const int fixed_bl = 9;

		// Token: 0x04000299 RID: 665
		internal const int fixed_bd = 5;

		// Token: 0x0400029A RID: 666
		internal const int BMAX = 15;

		// Token: 0x0400029B RID: 667
		internal static readonly int[] fixed_tl;

		// Token: 0x0400029C RID: 668
		internal static readonly int[] fixed_td;

		// Token: 0x0400029D RID: 669
		internal static readonly int[] cplens;

		// Token: 0x0400029E RID: 670
		internal static readonly int[] cplext;

		// Token: 0x0400029F RID: 671
		internal static readonly int[] cpdist;

		// Token: 0x040002A0 RID: 672
		internal static readonly int[] cpdext;

		// Token: 0x040002A1 RID: 673
		internal int[] hn;

		// Token: 0x040002A2 RID: 674
		internal int[] v;

		// Token: 0x040002A3 RID: 675
		internal int[] c;

		// Token: 0x040002A4 RID: 676
		internal int[] r;

		// Token: 0x040002A5 RID: 677
		internal int[] u;

		// Token: 0x040002A6 RID: 678
		internal int[] x;
	}
}
