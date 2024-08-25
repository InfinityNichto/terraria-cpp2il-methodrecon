using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000008 RID: 8
	[Preserve]
	public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002378 File Offset: 0x00000578
		public NotifyCollectionChangedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000023D8 File Offset: 0x000005D8
		public void Invoke(object sender, NotifyCollectionChangedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000212A File Offset: 0x0000032A
		public IAsyncResult BeginInvoke(object sender, NotifyCollectionChangedEventArgs e, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000023FC File Offset: 0x000005FC
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
