using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000174 RID: 372
	public sealed class UploadDataCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060009D1 RID: 2513 RVA: 0x00021B94 File Offset: 0x0001FD94
		public UploadDataCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00021BF4 File Offset: 0x0001FDF4
		public void Invoke(object sender, UploadDataCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, UploadDataCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00021C18 File Offset: 0x0001FE18
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
