using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000171 RID: 369
	public sealed class DownloadStringCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060009C5 RID: 2501 RVA: 0x000219D8 File Offset: 0x0001FBD8
		public DownloadStringCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00021A38 File Offset: 0x0001FC38
		public void Invoke(object sender, DownloadStringCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, DownloadStringCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00021A5C File Offset: 0x0001FC5C
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
