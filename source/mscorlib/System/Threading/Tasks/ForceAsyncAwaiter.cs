using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Threading.Tasks
{
	// Token: 0x02000226 RID: 550
	internal readonly struct ForceAsyncAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x06001318 RID: 4888 RVA: 0x000281D0 File Offset: 0x000263D0
		internal ForceAsyncAwaiter(Task task)
		{
			this._task = task;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0000207A File Offset: 0x0000027A
		public ForceAsyncAwaiter GetAwaiter()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x000281E4 File Offset: 0x000263E4
		public bool IsCompleted
		{
			get
			{
			}
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x000281F4 File Offset: 0x000263F4
		public void GetResult()
		{
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00028204 File Offset: 0x00026404
		public void UnsafeOnCompleted(Action action)
		{
		}

		// Token: 0x04000A35 RID: 2613
		private readonly Task _task;
	}
}
