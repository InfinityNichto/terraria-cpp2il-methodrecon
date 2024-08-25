using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x020003E8 RID: 1000
	public sealed class ProgressChangedEventHandler : MulticastDelegate
	{
		// Token: 0x06001A76 RID: 6774 RVA: 0x000493DC File Offset: 0x000475DC
		public ProgressChangedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0004943C File Offset: 0x0004763C
		public void Invoke(object sender, ProgressChangedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, ProgressChangedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00049460 File Offset: 0x00047660
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
