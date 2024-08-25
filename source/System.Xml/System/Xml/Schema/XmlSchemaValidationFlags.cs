using System;

namespace System.Xml.Schema
{
	// Token: 0x02000158 RID: 344
	[Flags]
	public enum XmlSchemaValidationFlags
	{
		// Token: 0x040005C3 RID: 1475
		None = 0,
		// Token: 0x040005C4 RID: 1476
		ProcessInlineSchema = 1,
		// Token: 0x040005C5 RID: 1477
		ProcessSchemaLocation = 2,
		// Token: 0x040005C6 RID: 1478
		ReportValidationWarnings = 4,
		// Token: 0x040005C7 RID: 1479
		ProcessIdentityConstraints = 8,
		// Token: 0x040005C8 RID: 1480
		AllowXmlAttributes = 16
	}
}
