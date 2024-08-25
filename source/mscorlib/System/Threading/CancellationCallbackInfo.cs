using System;

namespace System.Threading
{
	// Token: 0x020001D7 RID: 471
	internal class CancellationCallbackInfo
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x00024508 File Offset: 0x00022708
		internal CancellationCallbackInfo(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
		{
			this.Callback = callback;
			this.StateForCallback = stateForCallback;
			this.TargetExecutionContext = targetExecutionContext;
			this.CancellationTokenSource = cancellationTokenSource;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00024538 File Offset: 0x00022738
		internal void ExecuteCallback()
		{
			if (this.TargetExecutionContext != null)
			{
				ExecutionContext targetExecutionContext = this.TargetExecutionContext;
				return;
			}
			CancellationCallbackInfo.ExecutionContextCallback(this);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00024560 File Offset: 0x00022760
		private static void ExecutionContextCallback(object obj)
		{
		}

		// Token: 0x0400093D RID: 2365
		internal readonly Action<object> Callback;

		// Token: 0x0400093E RID: 2366
		internal readonly object StateForCallback;

		// Token: 0x0400093F RID: 2367
		internal readonly ExecutionContext TargetExecutionContext;

		// Token: 0x04000940 RID: 2368
		internal readonly CancellationTokenSource CancellationTokenSource;

		// Token: 0x04000941 RID: 2369
		private static ContextCallback s_executionContextCallback;

		// Token: 0x020001D8 RID: 472
		internal sealed class WithSyncContext : CancellationCallbackInfo
		{
			// Token: 0x0600112E RID: 4398 RVA: 0x00024570 File Offset: 0x00022770
			internal WithSyncContext(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext)
			{
				this.Callback = callback;
				this.StateForCallback = stateForCallback;
				this.TargetExecutionContext = targetExecutionContext;
				this.CancellationTokenSource = cancellationTokenSource;
				this.TargetSyncContext = targetSyncContext;
			}

			// Token: 0x04000942 RID: 2370
			internal readonly SynchronizationContext TargetSyncContext;
		}
	}
}
