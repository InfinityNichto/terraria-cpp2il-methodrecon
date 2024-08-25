using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000242 RID: 578
	internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task
	{
		// Token: 0x06001401 RID: 5121 RVA: 0x0002A048 File Offset: 0x00028248
		public ContinuationTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
			Task task = Task.InternalCurrentIfAttached(creationOptions);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0002A060 File Offset: 0x00028260
		internal override void InnerInvoke()
		{
			long num = 0L;
			bool flag = base.NotifyDebuggerOfWaitCompletionIfNecessary();
			if (num != 0L)
			{
				return;
			}
			if (num != 0L)
			{
				return;
			}
		}

		// Token: 0x04000AA5 RID: 2725
		private Task<TAntecedentResult> m_antecedent;
	}
}
