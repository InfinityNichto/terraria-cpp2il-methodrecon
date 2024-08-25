using System;

namespace System.Threading
{
	// Token: 0x020001C3 RID: 451
	public sealed class ThreadStart : MulticastDelegate
	{
		// Token: 0x060010C3 RID: 4291 RVA: 0x0002386C File Offset: 0x00021A6C
		public ThreadStart(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000238C0 File Offset: 0x00021AC0
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
