using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000145 RID: 325
	[Flags]
	public enum XmlSchemaDerivationMethod
	{
		// Token: 0x04000589 RID: 1417
		[XmlEnum(null)]
		Empty = 0,
		// Token: 0x0400058A RID: 1418
		[XmlEnum("substitution")]
		Substitution = 1,
		// Token: 0x0400058B RID: 1419
		[XmlEnum("extension")]
		Extension = 2,
		// Token: 0x0400058C RID: 1420
		[XmlEnum("restriction")]
		Restriction = 4,
		// Token: 0x0400058D RID: 1421
		[XmlEnum("list")]
		List = 8,
		// Token: 0x0400058E RID: 1422
		[XmlEnum("union")]
		Union = 16,
		// Token: 0x0400058F RID: 1423
		[XmlEnum("#all")]
		All = 255,
		// Token: 0x04000590 RID: 1424
		[XmlIgnore]
		None = 256
	}
}
