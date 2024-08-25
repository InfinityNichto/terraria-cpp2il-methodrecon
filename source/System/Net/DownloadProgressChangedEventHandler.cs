using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000177 RID: 375
	public sealed class DownloadProgressChangedEventHandler : MulticastDelegate
	{
		// Token: 0x060009DD RID: 2525 RVA: 0x00021D40 File Offset: 0x0001FF40
		public DownloadProgressChangedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00021DA0 File Offset: 0x0001FFA0
		public void Invoke(object sender, DownloadProgressChangedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, DownloadProgressChangedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00021DC4 File Offset: 0x0001FFC4
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
