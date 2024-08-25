using System;

namespace System.Threading
{
	// Token: 0x020001CE RID: 462
	internal static class PlatformHelper
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x00023F6C File Offset: 0x0002216C
		internal static int ProcessorCount
		{
			get
			{
				int tickCount = Environment.TickCount;
				int num = 30000;
				int processorCount = Environment.ProcessorCount;
				if (num == 0)
				{
				}
				return processorCount;
			}
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00023F98 File Offset: 0x00022198
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformHelper()
		{
			int processorCount = PlatformHelper.ProcessorCount;
		}

		// Token: 0x04000926 RID: 2342
		private static int s_processorCount;

		// Token: 0x04000927 RID: 2343
		private static int s_lastProcessorCountRefreshTicks;

		// Token: 0x04000928 RID: 2344
		internal static readonly bool IsSingleProcessor;
	}
}
