using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000152 RID: 338
	public class XmlSchemaSimpleType : XmlSchemaType
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x0001E7C0 File Offset: 0x0001C9C0
		public XmlSchemaSimpleType()
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x0001E7E8 File Offset: 0x0001C9E8
		[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
		[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
		[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
		public XmlSchemaSimpleTypeContent Content
		{
			get
			{
				return this.content;
			}
			set
			{
				this.content = value;
			}
		}

		// Token: 0x040005B5 RID: 1461
		private XmlSchemaSimpleTypeContent content;
	}
}
