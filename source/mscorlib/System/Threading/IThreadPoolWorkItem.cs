using System;

namespace System.Threading
{
	// Token: 0x020001FC RID: 508
	internal interface IThreadPoolWorkItem
	{
		// Token: 0x06001232 RID: 4658
		void ExecuteWorkItem();

		// Token: 0x06001233 RID: 4659
		void MarkAborted(ThreadAbortException tae);
	}
}
