using System;
using Cpp2IlInjected;

namespace System.ComponentModel
{
	// Token: 0x02000346 RID: 838
	public sealed class AddingNewEventHandler : MulticastDelegate
	{
		// Token: 0x060015C8 RID: 5576 RVA: 0x000408E0 File Offset: 0x0003EAE0
		public AddingNewEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00040940 File Offset: 0x0003EB40
		public void Invoke(object sender, AddingNewEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002050 File Offset: 0x00000250
		public IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object @object)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00040964 File Offset: 0x0003EB64
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
