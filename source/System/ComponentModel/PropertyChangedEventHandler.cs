using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003D1 RID: 977
	public sealed class PropertyChangedEventHandler : MulticastDelegate
	{
		// Token: 0x060019D0 RID: 6608 RVA: 0x00047A3C File Offset: 0x00045C3C
		public PropertyChangedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00047A9C File Offset: 0x00045C9C
		public void Invoke(object sender, PropertyChangedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00047AC0 File Offset: 0x00045CC0
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
