using System;

namespace System.Threading
{
	// Token: 0x02000205 RID: 517
	internal static class _ThreadPoolWaitCallback
	{
		// Token: 0x06001255 RID: 4693 RVA: 0x00026E3C File Offset: 0x0002503C
		internal static bool PerformWaitCallback()
		{
			if (!true)
			{
			}
			return ThreadPoolWorkQueue.Dispatch();
		}
	}
}
