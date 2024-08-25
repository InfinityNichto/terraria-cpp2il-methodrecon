using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001B5 RID: 437
	public sealed class HttpContinueDelegate : MulticastDelegate
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x000237E4 File Offset: 0x000219E4
		public HttpContinueDelegate(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00023838 File Offset: 0x00021A38
		public void Invoke(int StatusCode, WebHeaderCollection httpHeaders)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(int StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0002385C File Offset: 0x00021A5C
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
