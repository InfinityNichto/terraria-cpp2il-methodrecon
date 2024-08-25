using System;

namespace System.Xml.Serialization
{
	// Token: 0x020000BC RID: 188
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	public class XmlElementAttribute : Attribute
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x00019B04 File Offset: 0x00017D04
		public XmlElementAttribute(string elementName, Type type)
		{
			this.type = type;
		}

		// Token: 0x04000409 RID: 1033
		private string elementName;

		// Token: 0x0400040A RID: 1034
		private Type type;

		// Token: 0x0400040B RID: 1035
		private int order;
	}
}
