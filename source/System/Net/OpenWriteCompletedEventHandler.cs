using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000170 RID: 368
	public sealed class OpenWriteCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060009C1 RID: 2497 RVA: 0x00021944 File Offset: 0x0001FB44
		public OpenWriteCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000219A4 File Offset: 0x0001FBA4
		public void Invoke(object sender, OpenWriteCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, OpenWriteCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000219C8 File Offset: 0x0001FBC8
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
