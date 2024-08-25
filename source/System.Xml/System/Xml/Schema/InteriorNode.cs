using System;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x020000CB RID: 203
	internal abstract class InteriorNode : SyntaxTreeNode
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0001A200 File Offset: 0x00018400
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x0001A214 File Offset: 0x00018414
		public SyntaxTreeNode LeftChild
		{
			get
			{
				return this.leftChild;
			}
			set
			{
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0001A224 File Offset: 0x00018424
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x0001A238 File Offset: 0x00018438
		public SyntaxTreeNode RightChild
		{
			get
			{
				return this.rightChild;
			}
			set
			{
				this.rightChild = value;
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00003FFD File Offset: 0x000021FD
		protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0001A24C File Offset: 0x0001844C
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			SyntaxTreeNode syntaxTreeNode = this.leftChild;
			if (this.rightChild != null)
			{
				return;
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0001A26C File Offset: 0x0001846C
		protected InteriorNode()
		{
		}

		// Token: 0x04000426 RID: 1062
		private SyntaxTreeNode leftChild;

		// Token: 0x04000427 RID: 1063
		private SyntaxTreeNode rightChild;
	}
}
