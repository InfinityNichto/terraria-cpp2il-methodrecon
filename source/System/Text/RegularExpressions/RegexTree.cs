using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000C4 RID: 196
	internal sealed class RegexTree
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x00012FF0 File Offset: 0x000111F0
		internal RegexTree(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options)
		{
			this.Root = root;
			this.Caps = caps;
			this.CapNumList = capNumList;
			this.CapTop = capTop;
			this.CapNames = capNames;
			this.CapsList = capsList;
			this.Options = options;
		}

		// Token: 0x0400037E RID: 894
		public readonly RegexNode Root;

		// Token: 0x0400037F RID: 895
		public readonly Hashtable Caps;

		// Token: 0x04000380 RID: 896
		public readonly int[] CapNumList;

		// Token: 0x04000381 RID: 897
		public readonly int CapTop;

		// Token: 0x04000382 RID: 898
		public readonly Hashtable CapNames;

		// Token: 0x04000383 RID: 899
		public readonly string[] CapsList;

		// Token: 0x04000384 RID: 900
		public readonly RegexOptions Options;
	}
}
