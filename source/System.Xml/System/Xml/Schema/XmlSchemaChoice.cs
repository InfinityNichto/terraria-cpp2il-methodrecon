using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x0200013F RID: 319
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0001E010 File Offset: 0x0001C210
		[XmlElement("any", typeof(XmlSchemaAny))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("element", typeof(XmlSchemaElement))]
		public override XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x04000575 RID: 1397
		private XmlSchemaObjectCollection items;
	}
}
