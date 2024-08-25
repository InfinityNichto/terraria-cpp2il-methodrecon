using System;

namespace Ionic.BZip2
{
	// Token: 0x0200003A RID: 58
	internal static class BZip2
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		internal static T[][] InitRectangularArray<T>(int d1, int d2)
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		// Note: this type is marked as 'beforefieldinit'.
		static BZip2()
		{
		}

		// Token: 0x040001B8 RID: 440
		public static readonly int BlockSizeMultiple;

		// Token: 0x040001B9 RID: 441
		public static readonly int MinBlockSize;

		// Token: 0x040001BA RID: 442
		public static readonly int MaxBlockSize;

		// Token: 0x040001BB RID: 443
		public static readonly int MaxAlphaSize;

		// Token: 0x040001BC RID: 444
		public static readonly int MaxCodeLength;

		// Token: 0x040001BD RID: 445
		public static readonly char RUNA;

		// Token: 0x040001BE RID: 446
		public static readonly char RUNB;

		// Token: 0x040001BF RID: 447
		public static readonly int NGroups;

		// Token: 0x040001C0 RID: 448
		public static readonly int G_SIZE;

		// Token: 0x040001C1 RID: 449
		public static readonly int N_ITERS;

		// Token: 0x040001C2 RID: 450
		public static readonly int MaxSelectors;

		// Token: 0x040001C3 RID: 451
		public static readonly int NUM_OVERSHOOT_BYTES;

		// Token: 0x040001C4 RID: 452
		internal static readonly int QSORT_STACK_SIZE;
	}
}
