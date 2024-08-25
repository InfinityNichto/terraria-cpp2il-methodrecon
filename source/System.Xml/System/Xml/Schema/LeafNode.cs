using System;

namespace System.Xml.Schema
{
	// Token: 0x020000C9 RID: 201
	internal class LeafNode : SyntaxTreeNode
	{
		// Token: 0x06000826 RID: 2086 RVA: 0x0001A0C4 File Offset: 0x000182C4
		public LeafNode(int pos)
		{
			this.pos = pos;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0001A0E0 File Offset: 0x000182E0
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x0001A0F4 File Offset: 0x000182F4
		public int Pos
		{
			get
			{
				return this.pos;
			}
			set
			{
				this.pos = value;
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0001A108 File Offset: 0x00018308
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0001A118 File Offset: 0x00018318
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			int num = this.pos;
			uint[] bits = firstpos.bits;
			int num2 = this.pos;
			uint[] bits2 = lastpos.bits;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x0001A144 File Offset: 0x00018344
		public override bool IsNullable
		{
			get
			{
			}
		}

		// Token: 0x04000423 RID: 1059
		private int pos;
	}
}
