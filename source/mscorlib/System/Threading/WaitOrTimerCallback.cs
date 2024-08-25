using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x020001FE RID: 510
	[ComVisible(true)]
	public sealed class WaitOrTimerCallback : MulticastDelegate
	{
		// Token: 0x06001236 RID: 4662 RVA: 0x00026784 File Offset: 0x00024984
		public WaitOrTimerCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000267DC File Offset: 0x000249DC
		public void Invoke(object state, bool timedOut)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
