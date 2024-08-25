using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	// Token: 0x0200023F RID: 575
	internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction
	{
		// Token: 0x060013F4 RID: 5108 RVA: 0x00029DDC File Offset: 0x00027FDC
		public UnwrapPromise(Task outerTask, bool lookForOce)
		{
			TaskCreationOptions creationOptions = outerTask.CreationOptions;
			if (!true)
			{
			}
			bool loggingOn = DebuggerSupport.LoggingOn;
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				if (!true)
				{
				}
				DebuggerSupport.AddToActiveTasksNonInlined(this);
			}
			bool isCompleted = outerTask.IsCompleted;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00029E24 File Offset: 0x00028024
		public void Invoke(Task completingTask)
		{
			if (!true)
			{
			}
			StackGuard currentStackGuard = Task.CurrentStackGuard;
			bool flag = currentStackGuard.TryBeginInliningScope();
			currentStackGuard.EndInliningScope();
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00029E6C File Offset: 0x0002806C
		private void InvokeCore(Task completingTask)
		{
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00029E7C File Offset: 0x0002807C
		private void InvokeCoreAsync(Task completingTask)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00029E90 File Offset: 0x00028090
		private void ProcessCompletedOuterTask(Task task)
		{
			TaskStatus status = task.Status;
			if (task != null)
			{
			}
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00029EB4 File Offset: 0x000280B4
		private bool TrySetFromTask(Task task, bool lookForOce)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool loggingOn = DebuggerSupport.LoggingOn;
			if (num == 0)
			{
			}
			TaskStatus status = task.Status;
			CancellationToken cancellationToken = task.CancellationToken;
			ExceptionDispatchInfo cancellationExceptionDispatchInfo = task.GetCancellationExceptionDispatchInfo();
			return base.TrySetCanceled(cancellationToken, cancellationExceptionDispatchInfo);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00029F54 File Offset: 0x00028154
		private void ProcessInnerTask(Task task)
		{
			if (task != null)
			{
				bool isCompleted = task.IsCompleted;
				return;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00029F70 File Offset: 0x00028170
		public bool InvokeMayRunArbitraryCode
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000AA0 RID: 2720
		private byte _state;

		// Token: 0x04000AA1 RID: 2721
		private readonly bool _lookForOce;

		// Token: 0x02000240 RID: 576
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060013FC RID: 5116 RVA: 0x00029F80 File Offset: 0x00028180
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060013FD RID: 5117 RVA: 0x00029F90 File Offset: 0x00028190
			public <>c()
			{
			}

			// Token: 0x060013FE RID: 5118 RVA: 0x00029FA4 File Offset: 0x000281A4
			internal void <InvokeCoreAsync>b__8_0(object state)
			{
				if (state != null)
				{
				}
			}

			// Token: 0x04000AA2 RID: 2722
			public static readonly UnwrapPromise<TResult>.<>c <>9;

			// Token: 0x04000AA3 RID: 2723
			public static WaitCallback <>9__8_0;
		}
	}
}
