using System;
using Cpp2IlInjected;

namespace System.Threading.Tasks
{
	// Token: 0x02000225 RID: 549
	internal static class TaskAwaiters
	{
		// Token: 0x06001317 RID: 4887 RVA: 0x0000207A File Offset: 0x0000027A
		public static ForceAsyncAwaiter ForceAsync(this Task task)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
