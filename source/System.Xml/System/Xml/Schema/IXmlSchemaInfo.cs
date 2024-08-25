using System;

namespace System.Xml.Schema
{
	// Token: 0x0200012A RID: 298
	public interface IXmlSchemaInfo
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000A10 RID: 2576
		XmlSchemaValidity Validity { get; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000A11 RID: 2577
		bool IsDefault { get; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000A12 RID: 2578
		bool IsNil { get; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000A13 RID: 2579
		XmlSchemaSimpleType MemberType { get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000A14 RID: 2580
		XmlSchemaType SchemaType { get; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000A15 RID: 2581
		XmlSchemaElement SchemaElement { get; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000A16 RID: 2582
		XmlSchemaAttribute SchemaAttribute { get; }
	}
}
