using System;

namespace System
{
	// Token: 0x0200009A RID: 154
	internal sealed class IOAsyncCallback : MulticastDelegate
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		public IOAsyncCallback(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000A944 File Offset: 0x00008B44
		public void Invoke(global::System.IOAsyncResult ioares)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
