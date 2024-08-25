using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003E1 RID: 993
	public sealed class DoWorkEventHandler : MulticastDelegate
	{
		// Token: 0x06001A3D RID: 6717 RVA: 0x0004893C File Offset: 0x00046B3C
		public DoWorkEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0004899C File Offset: 0x00046B9C
		public void Invoke(object sender, DoWorkEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, DoWorkEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000489C0 File Offset: 0x00046BC0
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
