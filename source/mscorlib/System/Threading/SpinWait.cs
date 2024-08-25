using System;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001CD RID: 461
	public struct SpinWait
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0000207A File Offset: 0x0000027A
		public int Count
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x00023EF0 File Offset: 0x000220F0
		public bool NextSpinWillYield
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00023F00 File Offset: 0x00022100
		public void SpinOnce()
		{
			this.SpinOnceCore(20);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00023F18 File Offset: 0x00022118
		public void SpinOnce(int sleep1Threshold)
		{
			this.SpinOnceCore(sleep1Threshold);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00023F2C File Offset: 0x0002212C
		private void SpinOnceCore(int sleep1Threshold)
		{
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00023F4C File Offset: 0x0002214C
		public void Reset()
		{
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00023F5C File Offset: 0x0002215C
		// Note: this type is marked as 'beforefieldinit'.
		static SpinWait()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000924 RID: 2340
		internal static readonly int SpinCountforSpinBeforeWait;

		// Token: 0x04000925 RID: 2341
		private int _count;
	}
}
