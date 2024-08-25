using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x020000DC RID: 220
	internal class RestrictionFacets
	{
		// Token: 0x04000463 RID: 1123
		internal int Length;

		// Token: 0x04000464 RID: 1124
		internal int MinLength;

		// Token: 0x04000465 RID: 1125
		internal int MaxLength;

		// Token: 0x04000466 RID: 1126
		internal ArrayList Patterns;

		// Token: 0x04000467 RID: 1127
		internal ArrayList Enumeration;

		// Token: 0x04000468 RID: 1128
		internal XmlSchemaWhiteSpace WhiteSpace;

		// Token: 0x04000469 RID: 1129
		internal object MaxInclusive;

		// Token: 0x0400046A RID: 1130
		internal object MaxExclusive;

		// Token: 0x0400046B RID: 1131
		internal object MinInclusive;

		// Token: 0x0400046C RID: 1132
		internal object MinExclusive;

		// Token: 0x0400046D RID: 1133
		internal int TotalDigits;

		// Token: 0x0400046E RID: 1134
		internal int FractionDigits;

		// Token: 0x0400046F RID: 1135
		internal RestrictionFlags Flags;
	}
}
