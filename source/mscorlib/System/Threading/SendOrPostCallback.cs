using System;

namespace System.Threading
{
	// Token: 0x020001C0 RID: 448
	public sealed class SendOrPostCallback : MulticastDelegate
	{
		// Token: 0x060010BE RID: 4286 RVA: 0x0002378C File Offset: 0x0002198C
		public SendOrPostCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000237EC File Offset: 0x000219EC
		public void Invoke(object state)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
