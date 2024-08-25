using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000178 RID: 376
	public sealed class UploadProgressChangedEventHandler : MulticastDelegate
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x00021DD4 File Offset: 0x0001FFD4
		public UploadProgressChangedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00021E34 File Offset: 0x00020034
		public void Invoke(object sender, UploadProgressChangedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, UploadProgressChangedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00021E58 File Offset: 0x00020058
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
