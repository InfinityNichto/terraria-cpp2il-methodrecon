using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000237 RID: 567
	internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
	{
		// Token: 0x060013EC RID: 5100 RVA: 0x00029D2C File Offset: 0x00027F2C
		internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
		{
			this.m_action = action;
			this.m_completingTask = completingTask;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00029D50 File Offset: 0x00027F50
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			ITaskCompletionAction action = this.m_action;
			Task completingTask = this.m_completingTask;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00029D6C File Offset: 0x00027F6C
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x04000A7D RID: 2685
		private readonly ITaskCompletionAction m_action;

		// Token: 0x04000A7E RID: 2686
		private readonly Task m_completingTask;
	}
}
