using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000173 RID: 371
	public sealed class UploadStringCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060009CD RID: 2509 RVA: 0x00021B00 File Offset: 0x0001FD00
		public UploadStringCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00021B60 File Offset: 0x0001FD60
		public void Invoke(object sender, UploadStringCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, UploadStringCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00021B84 File Offset: 0x0001FD84
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
