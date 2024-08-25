using System;

namespace System.Xml.Schema
{
	// Token: 0x020000D1 RID: 209
	internal sealed class StarNode : InteriorNode
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x0001A47C File Offset: 0x0001867C
		public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos)
		{
			SyntaxTreeNode leftChild = this.leftChild;
			int num2;
			int num = lastpos.NextSet(num2);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0001A498 File Offset: 0x00018698
		public override bool IsNullable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0001A4A8 File Offset: 0x000186A8
		public StarNode()
		{
		}
	}
}
