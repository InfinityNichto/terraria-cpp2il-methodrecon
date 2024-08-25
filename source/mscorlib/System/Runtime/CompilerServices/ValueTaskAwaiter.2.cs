using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000485 RID: 1157
	public readonly struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion
	{
		// Token: 0x06002236 RID: 8758 RVA: 0x0004D148 File Offset: 0x0004B348
		internal ValueTaskAwaiter(ValueTask<TResult> value)
		{
			this._value = value;
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x0000207A File Offset: 0x0000027A
		public bool IsCompleted
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0000207A File Offset: 0x0000027A
		[StackTraceHidden]
		public TResult GetResult()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0004D15C File Offset: 0x0004B35C
		public void UnsafeOnCompleted(Action continuation)
		{
		}

		// Token: 0x040012BC RID: 4796
		private readonly ValueTask<TResult> _value;
	}
}
