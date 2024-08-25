using System;

namespace System
{
	// Token: 0x0200008B RID: 139
	[Serializable]
	public sealed class AssemblyLoadEventHandler : MulticastDelegate
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x0000C570 File Offset: 0x0000A770
		public AssemblyLoadEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		public void Invoke(object sender, AssemblyLoadEventArgs args)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
