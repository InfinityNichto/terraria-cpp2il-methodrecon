using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x020001FD RID: 509
	[ComVisible(true)]
	public sealed class WaitCallback : MulticastDelegate
	{
		// Token: 0x06001234 RID: 4660 RVA: 0x00026700 File Offset: 0x00024900
		public WaitCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00026760 File Offset: 0x00024960
		public void Invoke(object state)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
