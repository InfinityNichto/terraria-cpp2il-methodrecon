using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003D3 RID: 979
	public sealed class PropertyChangingEventHandler : MulticastDelegate
	{
		// Token: 0x060019D6 RID: 6614 RVA: 0x00047B04 File Offset: 0x00045D04
		public PropertyChangingEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00047B64 File Offset: 0x00045D64
		public void Invoke(object sender, PropertyChangingEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00047B88 File Offset: 0x00045D88
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
