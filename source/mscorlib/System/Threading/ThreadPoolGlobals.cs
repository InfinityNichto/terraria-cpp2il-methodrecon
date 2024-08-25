using System;

namespace System.Threading
{
	// Token: 0x020001FF RID: 511
	internal static class ThreadPoolGlobals
	{
		// Token: 0x06001238 RID: 4664 RVA: 0x00026800 File Offset: 0x00024A00
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolGlobals()
		{
			int num = Environment.ProcessorCount;
		}

		// Token: 0x040009B4 RID: 2484
		public static int processorCount;

		// Token: 0x040009B5 RID: 2485
		public static bool vmTpInitialized;

		// Token: 0x040009B6 RID: 2486
		public static bool enableWorkerTracking;

		// Token: 0x040009B7 RID: 2487
		public static readonly ThreadPoolWorkQueue workQueue;
	}
}
