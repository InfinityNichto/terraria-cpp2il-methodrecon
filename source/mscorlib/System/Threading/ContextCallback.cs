using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x020001EA RID: 490
	[ComVisible(true)]
	public sealed class ContextCallback : MulticastDelegate
	{
		// Token: 0x0600117E RID: 4478 RVA: 0x00025380 File Offset: 0x00023580
		public ContextCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x000253E0 File Offset: 0x000235E0
		public void Invoke(object state)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
