using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000359 RID: 857
	public sealed class CollectionChangeEventHandler : MulticastDelegate
	{
		// Token: 0x06001661 RID: 5729 RVA: 0x00041694 File Offset: 0x0003F894
		public CollectionChangeEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000416F4 File Offset: 0x0003F8F4
		public void Invoke(object sender, CollectionChangeEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00041718 File Offset: 0x0003F918
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
