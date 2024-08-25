using System;

namespace System.Xml.Schema
{
	// Token: 0x02000137 RID: 311
	public sealed class ValidationEventHandler : MulticastDelegate
	{
		// Token: 0x06000A9E RID: 2718 RVA: 0x0001D9D8 File Offset: 0x0001BBD8
		public ValidationEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0001DA38 File Offset: 0x0001BC38
		public void Invoke(object sender, ValidationEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
