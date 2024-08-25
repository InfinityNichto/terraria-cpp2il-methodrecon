using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001B7 RID: 439
	internal sealed class UnlockConnectionDelegate : MulticastDelegate
	{
		// Token: 0x06000AAB RID: 2731 RVA: 0x0002386C File Offset: 0x00021A6C
		public UnlockConnectionDelegate(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000238C0 File Offset: 0x00021AC0
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000238E4 File Offset: 0x00021AE4
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
