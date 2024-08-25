using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000231 RID: 561
	public enum TaskStatus
	{
		// Token: 0x04000A51 RID: 2641
		Created,
		// Token: 0x04000A52 RID: 2642
		WaitingForActivation,
		// Token: 0x04000A53 RID: 2643
		WaitingToRun,
		// Token: 0x04000A54 RID: 2644
		Running,
		// Token: 0x04000A55 RID: 2645
		WaitingForChildrenToComplete,
		// Token: 0x04000A56 RID: 2646
		RanToCompletion,
		// Token: 0x04000A57 RID: 2647
		Canceled,
		// Token: 0x04000A58 RID: 2648
		Faulted
	}
}
