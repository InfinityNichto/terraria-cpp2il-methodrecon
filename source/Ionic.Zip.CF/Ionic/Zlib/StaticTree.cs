using System;

namespace Ionic.Zlib
{
	// Token: 0x02000054 RID: 84
	internal sealed class StaticTree
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x0000E594 File Offset: 0x0000C794
		private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)
		{
			this.treeCodes = treeCodes;
			this.extraBits = extraBits;
			this.extraBase = extraBase;
			this.maxLength = elems;
			this.maxLength = maxLength;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		static StaticTree()
		{
		}

		// Token: 0x040002DA RID: 730
		internal static readonly short[] lengthAndLiteralsTreeCodes;

		// Token: 0x040002DB RID: 731
		internal static readonly short[] distTreeCodes;

		// Token: 0x040002DC RID: 732
		internal static readonly StaticTree Literals;

		// Token: 0x040002DD RID: 733
		internal static readonly StaticTree Distances;

		// Token: 0x040002DE RID: 734
		internal static readonly StaticTree BitLengths;

		// Token: 0x040002DF RID: 735
		internal short[] treeCodes;

		// Token: 0x040002E0 RID: 736
		internal int[] extraBits;

		// Token: 0x040002E1 RID: 737
		internal int extraBase;

		// Token: 0x040002E2 RID: 738
		internal int elems;

		// Token: 0x040002E3 RID: 739
		internal int maxLength;
	}
}
