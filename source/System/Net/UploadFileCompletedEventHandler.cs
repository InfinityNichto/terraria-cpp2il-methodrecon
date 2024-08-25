using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000175 RID: 373
	public sealed class UploadFileCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060009D5 RID: 2517 RVA: 0x00021C28 File Offset: 0x0001FE28
		public UploadFileCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00021C88 File Offset: 0x0001FE88
		public void Invoke(object sender, UploadFileCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, UploadFileCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00021CAC File Offset: 0x0001FEAC
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
