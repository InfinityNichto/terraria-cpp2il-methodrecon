using System;
using System.ComponentModel;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000179 RID: 377
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class WriteStreamClosedEventHandler : MulticastDelegate
	{
		// Token: 0x060009E5 RID: 2533 RVA: 0x00021E68 File Offset: 0x00020068
		public WriteStreamClosedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00021EC8 File Offset: 0x000200C8
		public void Invoke(object sender, WriteStreamClosedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, WriteStreamClosedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00021EEC File Offset: 0x000200EC
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
