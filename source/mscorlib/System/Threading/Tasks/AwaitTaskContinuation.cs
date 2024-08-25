using System;
using Cpp2IlInjected;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x0200024A RID: 586
	internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
	{
		// Token: 0x06001417 RID: 5143 RVA: 0x0002A378 File Offset: 0x00028578
		internal AwaitTaskContinuation(Action action, bool flowExecutionContext)
		{
			this.m_action = action;
			ExecutionContext executionContext = ExecutionContext.Capture();
			this.m_capturedContext = executionContext;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0000207A File Offset: 0x0000027A
		protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0002A3A4 File Offset: 0x000285A4
		internal override void Run(Task ignored, bool canInlineContinuationTask)
		{
			bool isValidLocationForInlining = AwaitTaskContinuation.IsValidLocationForInlining;
			Action action = this.m_action;
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0002A3C4 File Offset: 0x000285C4
		internal static bool IsValidLocationForInlining
		{
			get
			{
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null)
				{
					Type type;
					bool flag = synchronizationContext.GetType() != type;
				}
				if (TaskScheduler.InternalCurrent == null || !true)
				{
				}
				return true;
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0002A3F8 File Offset: 0x000285F8
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			Action action;
			if (this.m_capturedContext != null)
			{
				action = this.m_action;
				return;
			}
			IntPtr invoke_impl = action.invoke_impl;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0002A420 File Offset: 0x00028620
		private static void InvokeAction(object state)
		{
			if (state != null)
			{
			}
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0002A438 File Offset: 0x00028638
		protected static ContextCallback GetInvokeActionCallback()
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0002A448 File Offset: 0x00028648
		protected void RunCallback(ContextCallback callback, object state, Task currentTask)
		{
			SynchronizationContext currentExplicit = SynchronizationContext.CurrentExplicit;
			IntPtr method_code = callback.method_code;
			IntPtr invoke_impl = callback.invoke_impl;
			IntPtr method = callback.method;
			long num = 0L;
			SynchronizationContext.SetSynchronizationContext(currentExplicit);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0002A4AC File Offset: 0x000286AC
		internal static void RunOrScheduleAction(Action action, bool allowInlining, Task currentTask)
		{
			bool isValidLocationForInlining = AwaitTaskContinuation.IsValidLocationForInlining;
			IntPtr method_code = action.method_code;
			IntPtr method = action.method;
			IntPtr invoke_impl = action.invoke_impl;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0002A4FC File Offset: 0x000286FC
		internal static void UnsafeScheduleAction(Action action)
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0002A50C File Offset: 0x0002870C
		protected static void ThrowAsyncIfNecessary(Exception exc)
		{
			if (!true)
			{
			}
			RuntimeAugments.ReportUnhandledException(exc);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0002A524 File Offset: 0x00028724
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x04000AB1 RID: 2737
		private readonly ExecutionContext m_capturedContext;

		// Token: 0x04000AB2 RID: 2738
		protected readonly Action m_action;

		// Token: 0x04000AB3 RID: 2739
		private static ContextCallback s_invokeActionCallback;
	}
}
