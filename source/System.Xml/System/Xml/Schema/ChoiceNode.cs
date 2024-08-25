using System;

namespace System.Xml.Schema
{
	// Token: 0x020000CE RID: 206
	internal sealed class ChoiceNode : InteriorNode
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x0001A36C File Offset: 0x0001856C
		private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			int count = firstpos.count;
			int count2 = lastpos.count;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0001A388 File Offset: 0x00018588
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			int count = firstpos.count;
			int count2 = lastpos.count;
			SyntaxTreeNode rightChild = this.rightChild;
			SyntaxTreeNode leftChild = this.leftChild;
			while (this != null)
			{
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0001A3B4 File Offset: 0x000185B4
		public override bool IsNullable
		{
			get
			{
				SyntaxTreeNode rightChild = this.rightChild;
				SyntaxTreeNode leftChild = this.leftChild;
				while (this != null)
				{
				}
				return true;
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0001A3D4 File Offset: 0x000185D4
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			base.ExpandTreeNoRecursive(parent, symbols, positions);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0001A3EC File Offset: 0x000185EC
		public ChoiceNode()
		{
		}
	}
}
