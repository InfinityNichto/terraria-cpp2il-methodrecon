using System;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200016F RID: 367
	public sealed class OpenReadCompletedEventHandler : MulticastDelegate
	{
		// Token: 0x060009BD RID: 2493 RVA: 0x000218B0 File Offset: 0x0001FAB0
		public OpenReadCompletedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00021910 File Offset: 0x0001FB10
		public void Invoke(object sender, OpenReadCompletedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, OpenReadCompletedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00021934 File Offset: 0x0001FB34
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
