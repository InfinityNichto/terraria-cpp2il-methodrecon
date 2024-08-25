using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x02000212 RID: 530
	[ComVisible(true)]
	public sealed class TimerCallback : MulticastDelegate
	{
		// Token: 0x060012C9 RID: 4809 RVA: 0x00027AF8 File Offset: 0x00025CF8
		public TimerCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00027B58 File Offset: 0x00025D58
		public void Invoke(object state)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
