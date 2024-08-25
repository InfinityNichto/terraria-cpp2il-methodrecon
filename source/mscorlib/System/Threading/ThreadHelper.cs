using System;

namespace System.Threading
{
	// Token: 0x020001F7 RID: 503
	internal class ThreadHelper
	{
		// Token: 0x060011E1 RID: 4577 RVA: 0x00025F14 File Offset: 0x00024114
		internal ThreadHelper(Delegate start)
		{
			this._start = start;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00025F30 File Offset: 0x00024130
		internal void SetExecutionContextHelper(ExecutionContext ec)
		{
			this._executionContext = ec;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00025F44 File Offset: 0x00024144
		private static void ThreadStart_Context(object state)
		{
			if (state != null)
			{
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00025F5C File Offset: 0x0002415C
		internal void ThreadStart(object obj)
		{
			ExecutionContext executionContext = this._executionContext;
			this._startArg = obj;
			if (executionContext != null)
			{
				if (!true)
				{
				}
				return;
			}
			Delegate start = this._start;
			if (start != null)
			{
			}
			IntPtr method_code = start.method_code;
			IntPtr invoke_impl = start.invoke_impl;
			IntPtr method = start.method;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00025FA4 File Offset: 0x000241A4
		internal void ThreadStart()
		{
			if (this._executionContext != null)
			{
				if (!true)
				{
				}
				return;
			}
			Delegate start = this._start;
			if (start != null)
			{
			}
			IntPtr invoke_impl = start.invoke_impl;
			IntPtr method = start.method;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00025FDC File Offset: 0x000241DC
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadHelper()
		{
		}

		// Token: 0x0400099C RID: 2460
		private Delegate _start;

		// Token: 0x0400099D RID: 2461
		private object _startArg;

		// Token: 0x0400099E RID: 2462
		private ExecutionContext _executionContext;

		// Token: 0x0400099F RID: 2463
		internal static ContextCallback _ccb;
	}
}
