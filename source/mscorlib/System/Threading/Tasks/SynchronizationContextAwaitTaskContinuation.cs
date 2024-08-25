using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000246 RID: 582
	internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x0600140A RID: 5130 RVA: 0x0002A1F0 File Offset: 0x000283F0
		internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext)
		{
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0002A204 File Offset: 0x00028404
		internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
		{
			SynchronizationContext syncContext = this.m_syncContext;
			SynchronizationContext synchronizationContext = SynchronizationContext.Current;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0002A234 File Offset: 0x00028434
		private static void PostAction(object state)
		{
			if (state != null)
			{
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0002A24C File Offset: 0x0002844C
		private static ContextCallback GetPostActionCallback()
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0002A260 File Offset: 0x00028460
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationContextAwaitTaskContinuation()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000AAA RID: 2730
		private static readonly SendOrPostCallback s_postCallback;

		// Token: 0x04000AAB RID: 2731
		private static ContextCallback s_postActionCallback;

		// Token: 0x04000AAC RID: 2732
		private readonly SynchronizationContext m_syncContext = context;

		// Token: 0x02000247 RID: 583
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600140F RID: 5135 RVA: 0x0002A270 File Offset: 0x00028470
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06001410 RID: 5136 RVA: 0x0002A280 File Offset: 0x00028480
			public <>c()
			{
			}

			// Token: 0x06001411 RID: 5137 RVA: 0x0002A294 File Offset: 0x00028494
			internal void <.cctor>b__7_0(object state)
			{
				if (state != null)
				{
				}
			}

			// Token: 0x04000AAD RID: 2733
			public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9;
		}
	}
}
