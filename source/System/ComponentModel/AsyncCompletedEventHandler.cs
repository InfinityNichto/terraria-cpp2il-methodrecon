using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003D6 RID: 982
	public sealed class AsyncCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060019E4 RID: 6628 RVA: 0x00047CB8 File Offset: 0x00045EB8
		public AsyncCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00047D18 File Offset: 0x00045F18
		public void Invoke(object sender, AsyncCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00047D3C File Offset: 0x00045F3C
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
