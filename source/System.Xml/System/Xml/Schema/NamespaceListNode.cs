using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.Xml.Schema
{
	// Token: 0x020000CA RID: 202
	internal class NamespaceListNode : SyntaxTreeNode
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x0001A154 File Offset: 0x00018354
		public NamespaceListNode(NamespaceList namespaceList, object particle)
		{
			this.namespaceList = namespaceList;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0001A170 File Offset: 0x00018370
		public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols)
		{
			NamespaceList namespaceList = this.namespaceList;
			return symbols.GetNamespaceListSymbols(namespaceList);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0001A18C File Offset: 0x0001838C
		public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00003FFD File Offset: 0x000021FD
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00003FFD File Offset: 0x000021FD
		public override bool IsNullable
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x04000424 RID: 1060
		protected NamespaceList namespaceList;

		// Token: 0x04000425 RID: 1061
		protected object particle;
	}
}
