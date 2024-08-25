using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x0200037B RID: 891
	public sealed class HandledEventHandler : MulticastDelegate
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x00043588 File Offset: 0x00041788
		public HandledEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000435E8 File Offset: 0x000417E8
		public void Invoke(object sender, HandledEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, HandledEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0004360C File Offset: 0x0004180C
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
