using System;

namespace System.Threading
{
	// Token: 0x02000204 RID: 516
	internal sealed class ThreadPoolWorkQueueThreadLocals
	{
		// Token: 0x06001252 RID: 4690 RVA: 0x00026D78 File Offset: 0x00024F78
		public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
		{
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			base..ctor();
			this.workQueue = tpq;
			ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue = this.workStealingQueue;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00026DA8 File Offset: 0x00024FA8
		private void CleanUp()
		{
			if (this.workStealingQueue != null)
			{
				ThreadPoolWorkQueue threadPoolWorkQueue = this.workQueue;
				if (threadPoolWorkQueue != null)
				{
					ThreadPoolWorkQueue threadPoolWorkQueue2 = this.workQueue;
					ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue = this.workStealingQueue;
					return;
				}
				if (threadPoolWorkQueue == null)
				{
				}
				ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue2 = this.workStealingQueue;
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00026DE4 File Offset: 0x00024FE4
		protected override void Finalize()
		{
			bool hasShutdownStarted = Environment.HasShutdownStarted;
			bool flag = AppDomain.CurrentDomain.IsFinalizingForUnload();
			this.CleanUp();
			base.Finalize();
		}

		// Token: 0x040009C5 RID: 2501
		[ThreadStatic]
		public static ThreadPoolWorkQueueThreadLocals threadLocals;

		// Token: 0x040009C6 RID: 2502
		public readonly ThreadPoolWorkQueue workQueue;

		// Token: 0x040009C7 RID: 2503
		public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue;

		// Token: 0x040009C8 RID: 2504
		public readonly Random random;
	}
}
