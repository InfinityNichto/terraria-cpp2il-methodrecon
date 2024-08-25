using System;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000491 RID: 1169
	internal static class AsyncTaskCache
	{
		// Token: 0x06002271 RID: 8817 RVA: 0x0004D750 File Offset: 0x0004B950
		private static Task<int>[] CreateInt32Tasks()
		{
			if (!true)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Task<TResult> CreateCacheableTask<TResult>(TResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x0004D76C File Offset: 0x0004B96C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskCache()
		{
			Task<int>[] array = AsyncTaskCache.CreateInt32Tasks();
		}

		// Token: 0x040012CF RID: 4815
		internal static readonly Task<bool> TrueTask;

		// Token: 0x040012D0 RID: 4816
		internal static readonly Task<bool> FalseTask;

		// Token: 0x040012D1 RID: 4817
		internal static readonly Task<int>[] Int32Tasks;
	}
}
