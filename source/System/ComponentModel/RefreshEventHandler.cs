using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003B5 RID: 949
	public sealed class RefreshEventHandler : MulticastDelegate
	{
		// Token: 0x06001952 RID: 6482 RVA: 0x00046F1C File Offset: 0x0004511C
		public RefreshEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00046F7C File Offset: 0x0004517C
		public void Invoke(RefreshEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(RefreshEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00046FA0 File Offset: 0x000451A0
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
