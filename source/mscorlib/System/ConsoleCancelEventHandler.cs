using System;

namespace System
{
	// Token: 0x02000126 RID: 294
	public sealed class ConsoleCancelEventHandler : MulticastDelegate
	{
		// Token: 0x06000B94 RID: 2964 RVA: 0x0001A094 File Offset: 0x00018294
		public ConsoleCancelEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0001A0F4 File Offset: 0x000182F4
		public void Invoke(object sender, ConsoleCancelEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
