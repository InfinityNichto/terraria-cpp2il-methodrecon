using System;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x0200025A RID: 602
	public interface IValueTaskSource
	{
		// Token: 0x0600145D RID: 5213
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x0600145E RID: 5214
		void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x0600145F RID: 5215
		void GetResult(short token);
	}
}
