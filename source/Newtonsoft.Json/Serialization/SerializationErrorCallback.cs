using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009B RID: 155
	[Preserve]
	public sealed class SerializationErrorCallback : MulticastDelegate
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		public SerializationErrorCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
		public void Invoke(object o, StreamingContext context, ErrorContext errorContext)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000DE14 File Offset: 0x0000C014
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
