using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000355 RID: 853
	public sealed class CancelEventHandler : MulticastDelegate
	{
		// Token: 0x06001656 RID: 5718 RVA: 0x00041510 File Offset: 0x0003F710
		public CancelEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00041570 File Offset: 0x0003F770
		public void Invoke(object sender, CancelEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, CancelEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00041594 File Offset: 0x0003F794
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
