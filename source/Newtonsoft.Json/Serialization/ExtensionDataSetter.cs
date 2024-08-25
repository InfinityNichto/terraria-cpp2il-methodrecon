using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009C RID: 156
	[Preserve]
	public sealed class ExtensionDataSetter : MulticastDelegate
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x0000DE24 File Offset: 0x0000C024
		public ExtensionDataSetter(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000DE84 File Offset: 0x0000C084
		public void Invoke(object o, string key, object value)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(object o, string key, object value, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
