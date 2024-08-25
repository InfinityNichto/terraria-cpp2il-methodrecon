using System;

namespace System.Xml.Schema
{
	// Token: 0x020000C8 RID: 200
	internal abstract class SyntaxTreeNode
	{
		// Token: 0x06000821 RID: 2081
		public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

		// Token: 0x06000822 RID: 2082
		public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000823 RID: 2083
		public abstract bool IsNullable { get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0001A0A0 File Offset: 0x000182A0
		public virtual bool IsRangeNode
		{
			get
			{
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0001A0B0 File Offset: 0x000182B0
		protected SyntaxTreeNode()
		{
		}
	}
}
