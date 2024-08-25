using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001DC RID: 476
	[ReflectionBlocked]
	public struct LockHolder : IDisposable
	{
		// Token: 0x0600113B RID: 4411 RVA: 0x0000207A File Offset: 0x0000027A
		public static LockHolder Hold(Lock l)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0002466C File Offset: 0x0002286C
		public void Dispose()
		{
		}

		// Token: 0x0400094B RID: 2379
		private Lock _lock;
	}
}
