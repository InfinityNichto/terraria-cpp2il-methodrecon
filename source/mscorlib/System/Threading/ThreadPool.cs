using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x02000207 RID: 519
	public static class ThreadPool
	{
		// Token: 0x0600125B RID: 4699 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool SetMinThreads(int workerThreads, int completionPortThreads)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00026F0C File Offset: 0x0002510C
		public static void GetAvailableThreads([Out] int workerThreads, [Out] int completionPortThreads)
		{
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00026F1C File Offset: 0x0002511C
		private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, StackCrawlMark stackMark, bool compressStack)
		{
			while (waitObject == null)
			{
			}
			return "waitObject";
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00026F34 File Offset: 0x00025134
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			RegisteredWaitHandle registeredWaitHandle;
			return registeredWaitHandle;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00026F50 File Offset: 0x00025150
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			RegisteredWaitHandle registeredWaitHandle;
			return registeredWaitHandle;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00026F70 File Offset: 0x00025170
		public static bool QueueUserWorkItem(WaitCallback callBack, object state)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00026F80 File Offset: 0x00025180
		public static bool QueueUserWorkItem(WaitCallback callBack)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00026F90 File Offset: 0x00025190
		public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00026FA0 File Offset: 0x000251A0
		public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00026FB0 File Offset: 0x000251B0
		private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
		{
			ThreadPool.EnsureVMInitialized();
			return true;
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00026FC4 File Offset: 0x000251C4
		internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
			ThreadPool.EnsureVMInitialized();
			if (!true)
			{
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00026FDC File Offset: 0x000251DC
		internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool RequestWorkerThread()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00026FF4 File Offset: 0x000251F4
		private static void EnsureVMInitialized()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool SetMinThreadsNative(int workerThreads, int completionPortThreads)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0002700C File Offset: 0x0002520C
		private static void GetAvailableThreadsNative([Out] int workerThreads, [Out] int completionPortThreads)
		{
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool NotifyWorkItemComplete()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0002701C File Offset: 0x0002521C
		internal static void ReportThreadStatus(bool isWorking)
		{
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0002702C File Offset: 0x0002522C
		internal static void NotifyWorkItemProgress()
		{
			ThreadPool.EnsureVMInitialized();
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00027040 File Offset: 0x00025240
		internal static void NotifyWorkItemProgressNative()
		{
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00027050 File Offset: 0x00025250
		internal static void NotifyWorkItemQueued()
		{
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00027060 File Offset: 0x00025260
		private static void InitializeVMTp(bool enableWorkerTracking)
		{
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00027070 File Offset: 0x00025270
		internal static bool IsThreadPoolThread
		{
			get
			{
				return Thread.CurrentThread.IsThreadPoolThread;
			}
		}

		// Token: 0x02000208 RID: 520
		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0<TState>
		{
			// Token: 0x06001272 RID: 4722 RVA: 0x0002708C File Offset: 0x0002528C
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x06001273 RID: 4723 RVA: 0x000270A0 File Offset: 0x000252A0
			internal void <QueueUserWorkItem>b__0(object x)
			{
				Action action = this.callBack;
				if (x != null && x == null)
				{
					throw new InvalidCastException();
				}
			}

			// Token: 0x040009CD RID: 2509
			public Action<TState> callBack;
		}
	}
}
