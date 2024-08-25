using System;
using System.Threading;
using Cpp2IlInjected;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000065 RID: 101
	internal sealed class RuntimeThread
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00008300 File Offset: 0x00006500
		private RuntimeThread(Thread t)
		{
			this.thread = t;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000207A File Offset: 0x0000027A
		public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700003D RID: 61
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000831C File Offset: 0x0000651C
		public bool IsBackground
		{
			set
			{
				this.thread.IsBackground = value;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00008338 File Offset: 0x00006538
		public void Start(object state)
		{
			this.thread.Start(state);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00008354 File Offset: 0x00006554
		public static void Sleep(int millisecondsTimeout)
		{
			Thread.Sleep(millisecondsTimeout);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00008368 File Offset: 0x00006568
		public static bool Yield()
		{
			return Thread.Yield();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000837C File Offset: 0x0000657C
		public static bool SpinWait(int iterations)
		{
			return true;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000838C File Offset: 0x0000658C
		public static int GetCurrentProcessorId()
		{
			return 1;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000839C File Offset: 0x0000659C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeThread()
		{
		}

		// Token: 0x04000196 RID: 406
		internal static readonly int OptimalMaxSpinWaitsPerSpinIteration;

		// Token: 0x04000197 RID: 407
		private readonly Thread thread;
	}
}
