using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000176 RID: 374
	public sealed class UploadValuesCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x00021CBC File Offset: 0x0001FEBC
		public UploadValuesCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00021D0C File Offset: 0x0001FF0C
		public void Invoke(object sender, UploadValuesCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, UploadValuesCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00021D30 File Offset: 0x0001FF30
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
