using System;

namespace System.Xml
{
	// Token: 0x02000085 RID: 133
	internal struct LineInfo
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x000149F4 File Offset: 0x00012BF4
		public LineInfo(int lineNo, int linePos)
		{
			this.lineNo = lineNo;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00014A08 File Offset: 0x00012C08
		public void Set(int lineNo, int linePos)
		{
			this.lineNo = lineNo;
		}

		// Token: 0x040002FF RID: 767
		internal int lineNo;

		// Token: 0x04000300 RID: 768
		internal int linePos;
	}
}
