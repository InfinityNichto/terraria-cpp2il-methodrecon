using System;
using System.Collections.Generic;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	// Token: 0x02000229 RID: 553
	internal static class DebuggerSupport
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00028354 File Offset: 0x00026554
		public static bool LoggingOn
		{
			get
			{
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00028364 File Offset: 0x00026564
		public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext)
		{
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00028374 File Offset: 0x00026574
		public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status)
		{
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00028384 File Offset: 0x00026584
		public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation)
		{
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00028394 File Offset: 0x00026594
		public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work)
		{
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x000283A4 File Offset: 0x000265A4
		public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x000283B4 File Offset: 0x000265B4
		public static void AddToActiveTasks(Task task)
		{
			if (!true)
			{
			}
			if (true)
			{
				DebuggerSupport.AddToActiveTasksNonInlined(task);
				return;
			}
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000283D0 File Offset: 0x000265D0
		private static void AddToActiveTasksNonInlined(Task task)
		{
			int id = task.Id;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00028404 File Offset: 0x00026604
		public static void RemoveFromActiveTasks(Task task)
		{
			if (!true)
			{
			}
			if (true)
			{
				DebuggerSupport.RemoveFromActiveTasksNonInlined(task);
				return;
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00028420 File Offset: 0x00026620
		private static void RemoveFromActiveTasksNonInlined(Task task)
		{
			int id = task.Id;
			long num = 0L;
			Monitor.Exit(task);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00028464 File Offset: 0x00026664
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerSupport()
		{
		}

		// Token: 0x04000A3C RID: 2620
		private static readonly LowLevelDictionary<int, Task> s_activeTasks;

		// Token: 0x04000A3D RID: 2621
		private static readonly object s_activeTasksLock;
	}
}
