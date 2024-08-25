using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000473 RID: 1139
	public interface IAsyncStateMachine
	{
		// Token: 0x06002218 RID: 8728
		void MoveNext();

		// Token: 0x06002219 RID: 8729
		void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
