using System;

namespace System
{
	// Token: 0x02000073 RID: 115
	public sealed class Action : MulticastDelegate
	{
		// Token: 0x06000397 RID: 919 RVA: 0x0000B954 File Offset: 0x00009B54
		public Action(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
