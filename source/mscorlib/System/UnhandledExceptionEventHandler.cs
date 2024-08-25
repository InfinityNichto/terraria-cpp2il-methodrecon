using System;

namespace System
{
	// Token: 0x02000119 RID: 281
	[Serializable]
	public sealed class UnhandledExceptionEventHandler : MulticastDelegate
	{
		// Token: 0x06000B08 RID: 2824 RVA: 0x00018920 File Offset: 0x00016B20
		public UnhandledExceptionEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00018980 File Offset: 0x00016B80
		public void Invoke(object sender, UnhandledExceptionEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
