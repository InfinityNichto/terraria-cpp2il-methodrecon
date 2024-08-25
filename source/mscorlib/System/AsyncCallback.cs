using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200008C RID: 140
	[Serializable]
	public sealed class AsyncCallback : MulticastDelegate
	{
		// Token: 0x06000402 RID: 1026 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		public AsyncCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000C654 File Offset: 0x0000A854
		public void Invoke(IAsyncResult ar)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000207A File Offset: 0x0000027A
		public IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000C678 File Offset: 0x0000A878
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
