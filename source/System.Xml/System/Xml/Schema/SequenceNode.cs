using System;

namespace System.Xml.Schema
{
	// Token: 0x020000CC RID: 204
	internal sealed class SequenceNode : InteriorNode
	{
		// Token: 0x06000838 RID: 2104 RVA: 0x0001A280 File Offset: 0x00018480
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			int count = lastpos.count;
			int count2 = lastpos.count;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0001A2DC File Offset: 0x000184DC
		public override bool IsNullable
		{
			get
			{
				SyntaxTreeNode rightChild = this.rightChild;
				if (this.rightChild != null)
				{
				}
				SyntaxTreeNode rightChild2 = this.rightChild;
				SyntaxTreeNode rightChild3 = this.rightChild;
				SyntaxTreeNode leftChild = this.leftChild;
				while (this != null)
				{
				}
				return true;
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0001A31C File Offset: 0x0001851C
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			base.ExpandTreeNoRecursive(parent, symbols, positions);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0001A334 File Offset: 0x00018534
		public SequenceNode()
		{
		}

		// Token: 0x020000CD RID: 205
		private struct SequenceConstructPosContext
		{
			// Token: 0x0600083C RID: 2108 RVA: 0x0001A348 File Offset: 0x00018548
			public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos)
			{
				this.this_ = node;
				this.firstpos = firstpos;
				this.lastpos = lastpos;
			}

			// Token: 0x04000428 RID: 1064
			public SequenceNode this_;

			// Token: 0x04000429 RID: 1065
			public BitSet firstpos;

			// Token: 0x0400042A RID: 1066
			public BitSet lastpos;

			// Token: 0x0400042B RID: 1067
			public BitSet lastposLeft;

			// Token: 0x0400042C RID: 1068
			public BitSet firstposRight;
		}
	}
}
