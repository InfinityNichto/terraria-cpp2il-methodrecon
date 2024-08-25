using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000488 RID: 1160
	public readonly struct TaskAwaiter<TResult> : ICriticalNotifyCompletion
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x0004D310 File Offset: 0x0004B510
		internal TaskAwaiter(Task<TResult> task)
		{
			this.m_task = task;
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x0004D324 File Offset: 0x0004B524
		public bool IsCompleted
		{
			get
			{
				bool flag;
				return flag;
			}
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0004D334 File Offset: 0x0004B534
		public void UnsafeOnCompleted(Action continuation)
		{
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0000207A File Offset: 0x0000027A
		[StackTraceHidden]
		public TResult GetResult()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040012C0 RID: 4800
		private readonly Task<TResult> m_task;
	}
}
