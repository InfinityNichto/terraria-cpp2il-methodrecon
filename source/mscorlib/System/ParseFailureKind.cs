using System;

namespace System
{
	// Token: 0x020000B8 RID: 184
	internal enum ParseFailureKind
	{
		// Token: 0x040002D9 RID: 729
		None,
		// Token: 0x040002DA RID: 730
		ArgumentNull,
		// Token: 0x040002DB RID: 731
		Format,
		// Token: 0x040002DC RID: 732
		FormatWithParameter,
		// Token: 0x040002DD RID: 733
		FormatWithOriginalDateTime,
		// Token: 0x040002DE RID: 734
		FormatWithFormatSpecifier,
		// Token: 0x040002DF RID: 735
		FormatWithOriginalDateTimeAndParameter,
		// Token: 0x040002E0 RID: 736
		FormatBadDateTimeCalendar
	}
}
