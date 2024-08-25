using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000243 RID: 579
	internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult>
	{
		// Token: 0x06001403 RID: 5123 RVA: 0x0002A080 File Offset: 0x00028280
		public ContinuationResultTaskFromResultTask(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
			if (!true)
			{
			}
			Task task = Task.InternalCurrentIfAttached(creationOptions);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0002A098 File Offset: 0x00028298
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
			}
		}

		// Token: 0x04000AA6 RID: 2726
		private Task<TAntecedentResult> m_antecedent;
	}
}
