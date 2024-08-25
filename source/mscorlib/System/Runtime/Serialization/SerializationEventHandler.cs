using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003CC RID: 972
	public sealed class SerializationEventHandler : MulticastDelegate
	{
		// Token: 0x06001ED8 RID: 7896 RVA: 0x000436CC File Offset: 0x000418CC
		public SerializationEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00043720 File Offset: 0x00041920
		public void Invoke(StreamingContext context)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
