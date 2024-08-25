using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000155 RID: 341
	public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
	{
		// Token: 0x1700032E RID: 814
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x0001E86C File Offset: 0x0001CA6C
		[XmlAttribute("base")]
		public XmlQualifiedName BaseTypeName
		{
			set
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				this.baseTypeName = value;
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0001E888 File Offset: 0x0001CA88
		public XmlSchemaSimpleTypeRestriction()
		{
			if (!true)
			{
			}
			this.baseTypeName = 1;
			base..ctor();
		}

		// Token: 0x040005B9 RID: 1465
		private XmlQualifiedName baseTypeName;

		// Token: 0x040005BA RID: 1466
		private XmlSchemaObjectCollection facets;
	}
}
