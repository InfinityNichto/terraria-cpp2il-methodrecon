using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200036B RID: 875
	[ComVisible(true)]
	public sealed class CrossContextDelegate : MulticastDelegate
	{
		// Token: 0x06001D0E RID: 7438 RVA: 0x0003F854 File Offset: 0x0003DA54
		public CrossContextDelegate(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0003F8A8 File Offset: 0x0003DAA8
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
