using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000142 RID: 322
	public enum XmlSchemaContentProcessing
	{
		// Token: 0x0400057F RID: 1407
		[XmlIgnore]
		None,
		// Token: 0x04000580 RID: 1408
		[XmlEnum("skip")]
		Skip,
		// Token: 0x04000581 RID: 1409
		[XmlEnum("lax")]
		Lax,
		// Token: 0x04000582 RID: 1410
		[XmlEnum("strict")]
		Strict
	}
}
