using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003ED RID: 1005
	public sealed class RunWorkerCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x06001ADD RID: 6877 RVA: 0x0004AD88 File Offset: 0x00048F88
		public RunWorkerCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0004ADE8 File Offset: 0x00048FE8
		public void Invoke(object sender, RunWorkerCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, RunWorkerCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0004AE0C File Offset: 0x0004900C
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
