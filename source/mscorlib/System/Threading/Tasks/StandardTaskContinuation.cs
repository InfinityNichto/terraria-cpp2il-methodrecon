using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000245 RID: 581
	internal class StandardTaskContinuation : TaskContinuation
	{
		// Token: 0x06001408 RID: 5128 RVA: 0x0002A120 File Offset: 0x00028320
		internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
		{
			this.m_task = task;
			this.m_options = options;
			this.m_taskScheduler = scheduler;
			Task task2;
			if (!true)
			{
				task2 = this.m_task;
				if (!true)
				{
				}
			}
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				DebuggerSupport.AddToActiveTasksNonInlined(task2);
				return;
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0002A168 File Offset: 0x00028368
		internal override void Run(Task completedTask, bool bCanInlineContinuationTask)
		{
			TaskContinuationOptions options = this.m_options;
			int stateFlags = completedTask.m_stateFlags;
		}

		// Token: 0x04000AA7 RID: 2727
		internal readonly Task m_task;

		// Token: 0x04000AA8 RID: 2728
		internal readonly TaskContinuationOptions m_options;

		// Token: 0x04000AA9 RID: 2729
		private readonly TaskScheduler m_taskScheduler;
	}
}
