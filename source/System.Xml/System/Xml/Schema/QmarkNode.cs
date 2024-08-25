using System;

namespace System.Xml.Schema
{
	// Token: 0x020000D0 RID: 208
	internal sealed class QmarkNode : InteriorNode
	{
		// Token: 0x06000845 RID: 2117 RVA: 0x0001A444 File Offset: 0x00018644
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			SyntaxTreeNode leftChild = this.leftChild;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0001A458 File Offset: 0x00018658
		public override bool IsNullable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0001A468 File Offset: 0x00018668
		public QmarkNode()
		{
		}
	}
}
