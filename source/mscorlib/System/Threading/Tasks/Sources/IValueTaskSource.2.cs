using System;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x0200025B RID: 603
	public interface IValueTaskSource<out TResult>
	{
		// Token: 0x06001460 RID: 5216
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x06001461 RID: 5217
		void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x06001462 RID: 5218
		TResult GetResult(short token);
	}
}
