using System;

namespace UnityEngine.Events
{
	// Token: 0x02000170 RID: 368
	public sealed class UnityAction : MulticastDelegate
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x0000C448 File Offset: 0x0000A648
		public UnityAction(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0000C49C File Offset: 0x0000A69C
		public void Invoke()
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
