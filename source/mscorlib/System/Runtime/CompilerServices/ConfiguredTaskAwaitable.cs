using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000489 RID: 1161
	public readonly struct ConfiguredTaskAwaitable
	{
		// Token: 0x06002249 RID: 8777 RVA: 0x0004D344 File Offset: 0x0004B544
		internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
		{
			this.m_configuredTaskAwaiter = task;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0004D358 File Offset: 0x0004B558
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			return this.m_configuredTaskAwaiter;
		}

		// Token: 0x040012C1 RID: 4801
		private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		// Token: 0x0200048A RID: 1162
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x0600224B RID: 8779 RVA: 0x0004D36C File Offset: 0x0004B56C
			internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
			{
				this.m_task = task;
			}

			// Token: 0x17000475 RID: 1141
			// (get) Token: 0x0600224C RID: 8780 RVA: 0x0004D380 File Offset: 0x0004B580
			public bool IsCompleted
			{
				get
				{
					bool flag;
					return flag;
				}
			}

			// Token: 0x0600224D RID: 8781 RVA: 0x0004D390 File Offset: 0x0004B590
			public void OnCompleted(Action continuation)
			{
				bool continueOnCapturedContext = this.m_continueOnCapturedContext;
			}

			// Token: 0x0600224E RID: 8782 RVA: 0x0004D3A4 File Offset: 0x0004B5A4
			public void UnsafeOnCompleted(Action continuation)
			{
				bool continueOnCapturedContext = this.m_continueOnCapturedContext;
			}

			// Token: 0x0600224F RID: 8783 RVA: 0x0004D3B8 File Offset: 0x0004B5B8
			[StackTraceHidden]
			public void GetResult()
			{
			}

			// Token: 0x040012C2 RID: 4802
			internal readonly Task m_task;

			// Token: 0x040012C3 RID: 4803
			internal readonly bool m_continueOnCapturedContext;
		}
	}
}
