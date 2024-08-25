using System;

namespace System.Xml
{
	// Token: 0x0200002E RID: 46
	public enum ValidationType
	{
		// Token: 0x04000076 RID: 118
		None,
		// Token: 0x04000077 RID: 119
		[Obsolete("Validation type should be specified as DTD or Schema.")]
		Auto,
		// Token: 0x04000078 RID: 120
		DTD,
		// Token: 0x04000079 RID: 121
		[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
		XDR,
		// Token: 0x0400007A RID: 122
		Schema
	}
}
