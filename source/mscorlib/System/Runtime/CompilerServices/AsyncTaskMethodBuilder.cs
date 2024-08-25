using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200048F RID: 1167
	public struct AsyncTaskMethodBuilder
	{
		// Token: 0x0600225F RID: 8799 RVA: 0x0000207A File Offset: 0x0000027A
		public static AsyncTaskMethodBuilder Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0004D588 File Offset: 0x0004B788
		[DebuggerStepThrough]
		public void Start<TStateMachine>(TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			RuntimeHelpers.PrepareConstrainedRegions();
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0004D5B0 File Offset: 0x0004B7B0
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0004D5C0 File Offset: 0x0004B7C0
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(TAwaiter awaiter, TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x0000207A File Offset: 0x0000027A
		public Task Task
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0004D5D0 File Offset: 0x0004B7D0
		public void SetResult()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
		public void SetException(Exception exception)
		{
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0004D5F0 File Offset: 0x0004B7F0
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskMethodBuilder()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040012CA RID: 4810
		private static readonly Task<VoidTaskResult> s_cachedCompleted;

		// Token: 0x040012CB RID: 4811
		private AsyncTaskMethodBuilder<VoidTaskResult> m_builder;
	}
}
