using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000154 RID: 340
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		// Token: 0x1700032C RID: 812
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x0001E810 File Offset: 0x0001CA10
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaSimpleType ItemType
		{
			set
			{
				this.itemType = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0001E824 File Offset: 0x0001CA24
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x0001E838 File Offset: 0x0001CA38
		[XmlIgnore]
		public XmlSchemaSimpleType BaseItemType
		{
			get
			{
				return this.baseItemType;
			}
			set
			{
				this.baseItemType = value;
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001E84C File Offset: 0x0001CA4C
		public XmlSchemaSimpleTypeList()
		{
			if (!true)
			{
			}
			this.itemTypeName = 1;
			base..ctor();
		}

		// Token: 0x040005B6 RID: 1462
		private XmlQualifiedName itemTypeName;

		// Token: 0x040005B7 RID: 1463
		private XmlSchemaSimpleType itemType;

		// Token: 0x040005B8 RID: 1464
		private XmlSchemaSimpleType baseItemType;
	}
}
