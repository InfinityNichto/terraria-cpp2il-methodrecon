using System;

namespace System.Threading
{
	// Token: 0x02000206 RID: 518
	internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x00026E54 File Offset: 0x00025054
		internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, StackCrawlMark stackMark)
		{
			this.callback = waitCallback;
			this.state = stateObj;
			if (!true)
			{
			}
			bool flag = ExecutionContext.IsFlowSuppressed();
			if (!true)
			{
			}
			ExecutionContext executionContext = ExecutionContext.Capture(stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx | ExecutionContext.CaptureOptions.OptimizeDefaultCase);
			this.context = executionContext;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00026E94 File Offset: 0x00025094
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			if (this.context != null)
			{
				if (!true)
				{
				}
				return;
			}
			WaitCallback waitCallback = this.callback;
			object obj = this.state;
			IntPtr invoke_impl = waitCallback.invoke_impl;
			IntPtr method_code = waitCallback.method_code;
			IntPtr method = waitCallback.method;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00026ED4 File Offset: 0x000250D4
		void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
		{
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00026EE4 File Offset: 0x000250E4
		private static void WaitCallback_Context(object state)
		{
			if (state != null)
			{
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00026EFC File Offset: 0x000250FC
		// Note: this type is marked as 'beforefieldinit'.
		static QueueUserWorkItemCallback()
		{
		}

		// Token: 0x040009C9 RID: 2505
		private WaitCallback callback;

		// Token: 0x040009CA RID: 2506
		private ExecutionContext context;

		// Token: 0x040009CB RID: 2507
		private object state;

		// Token: 0x040009CC RID: 2508
		internal static ContextCallback ccb;
	}
}
