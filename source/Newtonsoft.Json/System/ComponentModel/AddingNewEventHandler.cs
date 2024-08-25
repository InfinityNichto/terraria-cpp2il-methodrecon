using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000003 RID: 3
	[Preserve]
	public sealed class AddingNewEventHandler : MulticastDelegate
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000020A8 File Offset: 0x000002A8
		public AddingNewEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002108 File Offset: 0x00000308
		public void Invoke(object sender, AddingNewEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002138 File Offset: 0x00000338
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
