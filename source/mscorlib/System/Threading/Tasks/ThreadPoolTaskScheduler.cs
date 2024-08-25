using System;
using System.Runtime.CompilerServices;
using Internal.Threading.Tasks.Tracing;

namespace System.Threading.Tasks
{
	// Token: 0x02000251 RID: 593
	internal sealed class ThreadPoolTaskScheduler : TaskScheduler
	{
		// Token: 0x0600144E RID: 5198 RVA: 0x0002AA6C File Offset: 0x00028C6C
		internal ThreadPoolTaskScheduler()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0002AA84 File Offset: 0x00028C84
		protected internal override void QueueTask(Task task)
		{
			bool enabled = TaskTrace.Enabled;
			if (!true)
			{
			}
			if (!true)
			{
			}
			Task parent = task.m_parent;
			int id = base.Id;
			int id2 = task.Id;
			if (parent != null)
			{
				int id3 = parent.Id;
			}
			TaskCreationOptions options = task.Options;
			TaskCreationOptions options2 = task.Options;
			TaskCreationOptions options3 = task.Options;
			int num;
			ThreadPool.UnsafeQueueCustomWorkItem(task, num != 0);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0002AAF4 File Offset: 0x00028CF4
		protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			bool flag = ThreadPool.TryPopCustomWorkItem(task);
			long num = 0L;
			bool flag2 = task.ExecuteEntry(num != 0L);
			if (false)
			{
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0002AB2C File Offset: 0x00028D2C
		protected internal override bool TryDequeue(Task task)
		{
			return ThreadPool.TryPopCustomWorkItem(task);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0002AB40 File Offset: 0x00028D40
		internal override void NotifyWorkItemProgress()
		{
			ThreadPool.EnsureVMInitialized();
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0002AB54 File Offset: 0x00028D54
		internal override bool RequiresAtomicStartTransition
		{
			get
			{
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0002AB64 File Offset: 0x00028D64
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolTaskScheduler()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000AC5 RID: 2757
		private static readonly ParameterizedThreadStart s_longRunningThreadWork;

		// Token: 0x02000252 RID: 594
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001455 RID: 5205 RVA: 0x0002AB74 File Offset: 0x00028D74
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001456 RID: 5206 RVA: 0x0002AB84 File Offset: 0x00028D84
			public <>c()
			{
			}

			// Token: 0x06001457 RID: 5207 RVA: 0x0002AB98 File Offset: 0x00028D98
			internal void <.cctor>b__10_0(object s)
			{
				if (s != null)
				{
				}
			}

			// Token: 0x04000AC6 RID: 2758
			public static readonly ThreadPoolTaskScheduler.<>c <>9;
		}
	}
}
