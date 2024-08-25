using System;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000062 RID: 98
	internal abstract class TaskTraceCallbacks
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600022A RID: 554
		public abstract bool Enabled { get; }

		// Token: 0x0600022B RID: 555
		public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x0600022C RID: 556
		public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x0600022D RID: 557
		public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x0600022E RID: 558
		public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
	}
}
