using System;

namespace System.Threading
{
	// Token: 0x020001BE RID: 446
	public sealed class ParameterizedThreadStart : MulticastDelegate
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x000236D8 File Offset: 0x000218D8
		public ParameterizedThreadStart(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00023738 File Offset: 0x00021938
		public void Invoke(object obj)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
