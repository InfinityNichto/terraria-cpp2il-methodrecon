using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200023E RID: 574
	internal interface ITaskCompletionAction
	{
		// Token: 0x060013F2 RID: 5106
		void Invoke(Task completingTask);

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060013F3 RID: 5107
		bool InvokeMayRunArbitraryCode { get; }
	}
}
