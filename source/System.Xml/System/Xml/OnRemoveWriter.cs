using System;

namespace System.Xml
{
	// Token: 0x0200001F RID: 31
	internal sealed class OnRemoveWriter : MulticastDelegate
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000399C File Offset: 0x00001B9C
		public OnRemoveWriter(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000039FC File Offset: 0x00001BFC
		public void Invoke(XmlRawWriter writer)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}
	}
}
