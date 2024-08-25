using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000244 RID: 580
	internal abstract class TaskContinuation
	{
		// Token: 0x06001405 RID: 5125
		internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

		// Token: 0x06001406 RID: 5126 RVA: 0x0002A0B8 File Offset: 0x000282B8
		protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection)
		{
			int num = 1;
			int num2 = 65;
			bool flag = task.AtomicStateUpdate(num, num2);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0002A10C File Offset: 0x0002830C
		protected TaskContinuation()
		{
		}
	}
}
