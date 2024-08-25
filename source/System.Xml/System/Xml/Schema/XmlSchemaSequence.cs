using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000150 RID: 336
	public class XmlSchemaSequence : XmlSchemaGroupBase
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0001E734 File Offset: 0x0001C934
		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		public override XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0001E748 File Offset: 0x0001C948
		public XmlSchemaSequence()
		{
		}

		// Token: 0x040005A9 RID: 1449
		private XmlSchemaObjectCollection items;
	}
}
