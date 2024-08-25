using System;
using System.Threading;

namespace System.Runtime.InteropServices
{
	// Token: 0x020000A3 RID: 163
	public sealed class HandleCollector
	{
		// Token: 0x060002DA RID: 730 RVA: 0x0000AD9C File Offset: 0x00008F9C
		public HandleCollector(string name, int initialThreshold)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public HandleCollector(string name, int initialThreshold, int maximumThreshold)
		{
			if (name != null)
			{
				this.name = name;
				return;
			}
			this.initialThreshold = initialThreshold;
			this.threshold = maximumThreshold;
			this.threshold = initialThreshold;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000AE04 File Offset: 0x00009004
		public int Count
		{
			get
			{
				return this.handleCount;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000AE18 File Offset: 0x00009018
		public int InitialThreshold
		{
			get
			{
				return this.initialThreshold;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000AE2C File Offset: 0x0000902C
		public int MaximumThreshold
		{
			get
			{
				return this.maximumThreshold;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000AE40 File Offset: 0x00009040
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000AE54 File Offset: 0x00009054
		public void Add()
		{
			long num = 0L;
			int num2 = Interlocked.Increment(int.MinValue);
			int num3 = this.handleCount;
			int num4 = this.threshold;
			Monitor.Enter(this, num != 0L);
			int num5 = 26215;
			int num6 = this.gc_gen;
			long num7 = 0L;
			this.threshold = num3;
			this.gc_gen = num3;
			int num8 = 5;
			if (num3 != 0)
			{
				Monitor.Exit(this);
			}
			if (num7 == 0L)
			{
				if (num8 == 0)
				{
					int[] array;
					if (num6 != 0)
					{
						array = this.gc_counts;
						if (num5 == 0)
						{
						}
						int num9 = GC.CollectionCount(num6);
					}
					if (array == null)
					{
					}
					GC.Collect(num6);
					Thread.Sleep(num6);
					int[] array2 = this.gc_counts;
					if (array == null)
					{
					}
					int num10 = GC.CollectionCount(int.MinValue);
					array2.m_value = num10;
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000AF34 File Offset: 0x00009134
		public void Remove()
		{
			long num = 0L;
			int num2 = Interlocked.Decrement(int.MinValue);
			int num3 = this.handleCount;
			Monitor.Enter(this, num != 0L);
			int num4 = this.initialThreshold;
			long num5 = 0L;
			this.threshold = num4;
			int num6 = 5;
			if (num4 != 0)
			{
				Monitor.Exit(this);
			}
			if (num5 == 0L)
			{
				if (num6 == 0)
				{
					int[] array = this.gc_counts;
					if (num4 == 0)
					{
					}
					int num7 = GC.CollectionCount(int.MinValue);
					array.m_value = num7;
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04000278 RID: 632
		private const int deltaPercent = 10;

		// Token: 0x04000279 RID: 633
		private string name;

		// Token: 0x0400027A RID: 634
		private int initialThreshold;

		// Token: 0x0400027B RID: 635
		private int maximumThreshold;

		// Token: 0x0400027C RID: 636
		private int threshold;

		// Token: 0x0400027D RID: 637
		private int handleCount;

		// Token: 0x0400027E RID: 638
		private int[] gc_counts;

		// Token: 0x0400027F RID: 639
		private int gc_gen;
	}
}
