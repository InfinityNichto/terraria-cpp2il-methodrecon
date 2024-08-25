using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000172 RID: 370
	public sealed class DownloadDataCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060009C9 RID: 2505 RVA: 0x00021A6C File Offset: 0x0001FC6C
		public DownloadDataCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00021ACC File Offset: 0x0001FCCC
		public void Invoke(object sender, DownloadDataCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, DownloadDataCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00021AF0 File Offset: 0x0001FCF0
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
