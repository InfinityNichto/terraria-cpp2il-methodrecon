using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000474 RID: 1140
	public interface ICriticalNotifyCompletion
	{
		// Token: 0x0600221A RID: 8730
		void UnsafeOnCompleted(Action continuation);
	}
}
