using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B8 RID: 184
	internal sealed class RegexCode
	{
		// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		public RegexCode(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix? fcPrefix, int anchors, bool rightToLeft)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		public static bool OpcodeBacktracks(int Op)
		{
		}

		// Token: 0x040002EF RID: 751
		public const int Onerep = 0;

		// Token: 0x040002F0 RID: 752
		public const int Notonerep = 1;

		// Token: 0x040002F1 RID: 753
		public const int Setrep = 2;

		// Token: 0x040002F2 RID: 754
		public const int Oneloop = 3;

		// Token: 0x040002F3 RID: 755
		public const int Notoneloop = 4;

		// Token: 0x040002F4 RID: 756
		public const int Setloop = 5;

		// Token: 0x040002F5 RID: 757
		public const int Onelazy = 6;

		// Token: 0x040002F6 RID: 758
		public const int Notonelazy = 7;

		// Token: 0x040002F7 RID: 759
		public const int Setlazy = 8;

		// Token: 0x040002F8 RID: 760
		public const int One = 9;

		// Token: 0x040002F9 RID: 761
		public const int Notone = 10;

		// Token: 0x040002FA RID: 762
		public const int Set = 11;

		// Token: 0x040002FB RID: 763
		public const int Multi = 12;

		// Token: 0x040002FC RID: 764
		public const int Ref = 13;

		// Token: 0x040002FD RID: 765
		public const int Bol = 14;

		// Token: 0x040002FE RID: 766
		public const int Eol = 15;

		// Token: 0x040002FF RID: 767
		public const int Boundary = 16;

		// Token: 0x04000300 RID: 768
		public const int Nonboundary = 17;

		// Token: 0x04000301 RID: 769
		public const int Beginning = 18;

		// Token: 0x04000302 RID: 770
		public const int Start = 19;

		// Token: 0x04000303 RID: 771
		public const int EndZ = 20;

		// Token: 0x04000304 RID: 772
		public const int End = 21;

		// Token: 0x04000305 RID: 773
		public const int Nothing = 22;

		// Token: 0x04000306 RID: 774
		public const int Lazybranch = 23;

		// Token: 0x04000307 RID: 775
		public const int Branchmark = 24;

		// Token: 0x04000308 RID: 776
		public const int Lazybranchmark = 25;

		// Token: 0x04000309 RID: 777
		public const int Nullcount = 26;

		// Token: 0x0400030A RID: 778
		public const int Setcount = 27;

		// Token: 0x0400030B RID: 779
		public const int Branchcount = 28;

		// Token: 0x0400030C RID: 780
		public const int Lazybranchcount = 29;

		// Token: 0x0400030D RID: 781
		public const int Nullmark = 30;

		// Token: 0x0400030E RID: 782
		public const int Setmark = 31;

		// Token: 0x0400030F RID: 783
		public const int Capturemark = 32;

		// Token: 0x04000310 RID: 784
		public const int Getmark = 33;

		// Token: 0x04000311 RID: 785
		public const int Setjump = 34;

		// Token: 0x04000312 RID: 786
		public const int Backjump = 35;

		// Token: 0x04000313 RID: 787
		public const int Forejump = 36;

		// Token: 0x04000314 RID: 788
		public const int Testref = 37;

		// Token: 0x04000315 RID: 789
		public const int Goto = 38;

		// Token: 0x04000316 RID: 790
		public const int Prune = 39;

		// Token: 0x04000317 RID: 791
		public const int Stop = 40;

		// Token: 0x04000318 RID: 792
		public const int ECMABoundary = 41;

		// Token: 0x04000319 RID: 793
		public const int NonECMABoundary = 42;

		// Token: 0x0400031A RID: 794
		public const int Mask = 63;

		// Token: 0x0400031B RID: 795
		public const int Rtl = 64;

		// Token: 0x0400031C RID: 796
		public const int Back = 128;

		// Token: 0x0400031D RID: 797
		public const int Back2 = 256;

		// Token: 0x0400031E RID: 798
		public const int Ci = 512;

		// Token: 0x0400031F RID: 799
		public readonly int[] Codes;

		// Token: 0x04000320 RID: 800
		public readonly string[] Strings;

		// Token: 0x04000321 RID: 801
		public readonly int TrackCount;

		// Token: 0x04000322 RID: 802
		public readonly Hashtable Caps;

		// Token: 0x04000323 RID: 803
		public readonly int CapSize;

		// Token: 0x04000324 RID: 804
		public readonly RegexPrefix? FCPrefix;

		// Token: 0x04000325 RID: 805
		public readonly RegexBoyerMoore BMPrefix;

		// Token: 0x04000326 RID: 806
		public readonly int Anchors;

		// Token: 0x04000327 RID: 807
		public readonly bool RightToLeft;
	}
}
