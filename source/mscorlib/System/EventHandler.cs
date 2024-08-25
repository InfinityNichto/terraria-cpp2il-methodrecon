using System;

namespace System
{
	// Token: 0x020000A4 RID: 164
	public sealed class EventHandler : MulticastDelegate
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x0000F920 File Offset: 0x0000DB20
		public EventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000F980 File Offset: 0x0000DB80
		public void Invoke(object sender, EventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
