using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x0200039B RID: 923
	public sealed class ListChangedEventHandler : MulticastDelegate
	{
		// Token: 0x06001800 RID: 6144 RVA: 0x00043E90 File Offset: 0x00042090
		public ListChangedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00043EF0 File Offset: 0x000420F0
		public void Invoke(object sender, ListChangedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00043F14 File Offset: 0x00042114
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
