using System;

namespace System.Xml.Serialization
{
	// Token: 0x020000BB RID: 187
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlAttributeAttribute : Attribute
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x00019AE8 File Offset: 0x00017CE8
		public XmlAttributeAttribute(string attributeName)
		{
			this.attributeName = attributeName;
		}

		// Token: 0x04000408 RID: 1032
		private string attributeName;
	}
}
