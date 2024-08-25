using System;

namespace System.Xml
{
	// Token: 0x0200007B RID: 123
	public sealed class XmlNodeChangedEventHandler : MulticastDelegate
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x000144F0 File Offset: 0x000126F0
		public XmlNodeChangedEventHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00014550 File Offset: 0x00012750
		public void Invoke(object sender, XmlNodeChangedEventArgs e)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
