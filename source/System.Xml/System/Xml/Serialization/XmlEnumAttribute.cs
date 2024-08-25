using System;

namespace System.Xml.Serialization
{
	// Token: 0x020000BD RID: 189
	[AttributeUsage(AttributeTargets.Field)]
	public class XmlEnumAttribute : Attribute
	{
		// Token: 0x060007F7 RID: 2039 RVA: 0x00019B20 File Offset: 0x00017D20
		public XmlEnumAttribute(string name)
		{
			this.name = name;
		}

		// Token: 0x0400040C RID: 1036
		private string name;
	}
}
