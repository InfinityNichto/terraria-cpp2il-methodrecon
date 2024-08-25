using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000248 RID: 584
	internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06001412 RID: 5138 RVA: 0x0002A2AC File Offset: 0x000284AC
		internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext)
		{
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0002A2C0 File Offset: 0x000284C0
		internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
		{
			int num = 1;
			TaskScheduler scheduler = this.m_scheduler;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			TaskScheduler internalCurrent = TaskScheduler.InternalCurrent;
			TaskScheduler scheduler2 = this.m_scheduler;
			bool isThreadPoolThread = Thread.CurrentThread.IsThreadPoolThread;
		}

		// Token: 0x04000AAE RID: 2734
		private readonly TaskScheduler m_scheduler = scheduler;

		// Token: 0x02000249 RID: 585
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001414 RID: 5140 RVA: 0x0002A338 File Offset: 0x00028538
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001415 RID: 5141 RVA: 0x0002A348 File Offset: 0x00028548
			public <>c()
			{
			}

			// Token: 0x06001416 RID: 5142 RVA: 0x0002A35C File Offset: 0x0002855C
			internal void <Run>b__2_0(object state)
			{
				if (state != null)
				{
				}
			}

			// Token: 0x04000AAF RID: 2735
			public static readonly TaskSchedulerAwaitTaskContinuation.<>c <>9;

			// Token: 0x04000AB0 RID: 2736
			public static Action<object> <>9__2_0;
		}
	}
}
