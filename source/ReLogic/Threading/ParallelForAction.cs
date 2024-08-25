using System;
using Cpp2IlInjected;

namespace ReLogic.Threading
{
	// Token: 0x02000B10 RID: 2832
	public sealed class ParallelForAction : MulticastDelegate
	{
		// Token: 0x0600530D RID: 21261 RVA: 0x00283DF0 File Offset: 0x00281FF0
		public ParallelForAction(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00283E44 File Offset: 0x00282044
		public void Invoke(int fromInclusive, int toExclusive, object context)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(int fromInclusive, int toExclusive, object context, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00283E68 File Offset: 0x00282068
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
