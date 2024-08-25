using System;
using Cpp2IlInjected;
using Internal.Runtime.Augments;

namespace Internal.Threading.Tasks.Tracing
{
	// Token: 0x02000060 RID: 96
	internal static class TaskTrace
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool Enabled
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00008270 File Offset: 0x00006470
		public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00008280 File Offset: 0x00006480
		public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008290 File Offset: 0x00006490
		public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000082A0 File Offset: 0x000064A0
		public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions)
		{
		}

		// Token: 0x0400018F RID: 399
		private static TaskTraceCallbacks s_callbacks;
	}
}
