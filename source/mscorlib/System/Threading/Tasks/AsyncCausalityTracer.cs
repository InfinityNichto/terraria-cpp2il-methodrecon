using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x02000257 RID: 599
	[FriendAccessAllowed]
	internal static class AsyncCausalityTracer
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0002ABB0 File Offset: 0x00028DB0
		[FriendAccessAllowed]
		internal static bool LoggingOn
		{
			[FriendAccessAllowed]
			get
			{
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0002ABC0 File Offset: 0x00028DC0
		[FriendAccessAllowed]
		internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0002ABD0 File Offset: 0x00028DD0
		[FriendAccessAllowed]
		internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0002ABE0 File Offset: 0x00028DE0
		internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
		{
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0002ABF0 File Offset: 0x00028DF0
		internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
		}
	}
}
