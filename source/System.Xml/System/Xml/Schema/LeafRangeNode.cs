using System;

namespace System.Xml.Schema
{
	// Token: 0x020000D2 RID: 210
	internal sealed class LeafRangeNode : LeafNode
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0001A4BC File Offset: 0x000186BC
		public decimal Max
		{
			get
			{
				decimal num = this.max;
				int lo = this.max.lo;
				return num;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0001A4E0 File Offset: 0x000186E0
		public decimal Min
		{
			get
			{
				decimal num = this.min;
				int lo = this.min.lo;
				return num;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0001A504 File Offset: 0x00018704
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0001A518 File Offset: 0x00018718
		public BitSet NextIteration
		{
			get
			{
				return this.nextIteration;
			}
			set
			{
				this.nextIteration = value;
			}
		}

		// Token: 0x0400042D RID: 1069
		private decimal min;

		// Token: 0x0400042E RID: 1070
		private decimal max;

		// Token: 0x0400042F RID: 1071
		private BitSet nextIteration;
	}
}
