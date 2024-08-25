using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009A RID: 154
	[Preserve]
	public sealed class SerializationCallback : MulticastDelegate
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x0000DD0C File Offset: 0x0000BF0C
		public SerializationCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000DD6C File Offset: 0x0000BF6C
		public void Invoke(object o, StreamingContext context)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000DD90 File Offset: 0x0000BF90
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
