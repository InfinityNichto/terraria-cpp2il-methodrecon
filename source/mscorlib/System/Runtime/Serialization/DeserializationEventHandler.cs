using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003CB RID: 971
	internal sealed class DeserializationEventHandler : MulticastDelegate
	{
		// Token: 0x06001ED6 RID: 7894 RVA: 0x00043648 File Offset: 0x00041848
		public DeserializationEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000436A8 File Offset: 0x000418A8
		public void Invoke(object sender)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
