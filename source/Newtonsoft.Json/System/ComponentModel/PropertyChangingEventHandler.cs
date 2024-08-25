using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x0200000A RID: 10
	[Preserve]
	public sealed class PropertyChangingEventHandler : MulticastDelegate
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000244C File Offset: 0x0000064C
		public PropertyChangingEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000024AC File Offset: 0x000006AC
		public void Invoke(object sender, PropertyChangingEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024D0 File Offset: 0x000006D0
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
