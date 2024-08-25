using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200012B RID: 299
	[Preserve]
	internal enum BsonType : sbyte
	{
		// Token: 0x0400045A RID: 1114
		Number = 1,
		// Token: 0x0400045B RID: 1115
		String,
		// Token: 0x0400045C RID: 1116
		Object,
		// Token: 0x0400045D RID: 1117
		Array,
		// Token: 0x0400045E RID: 1118
		Binary,
		// Token: 0x0400045F RID: 1119
		Undefined,
		// Token: 0x04000460 RID: 1120
		Oid,
		// Token: 0x04000461 RID: 1121
		Boolean,
		// Token: 0x04000462 RID: 1122
		Date,
		// Token: 0x04000463 RID: 1123
		Null,
		// Token: 0x04000464 RID: 1124
		Regex,
		// Token: 0x04000465 RID: 1125
		Reference,
		// Token: 0x04000466 RID: 1126
		Code,
		// Token: 0x04000467 RID: 1127
		Symbol,
		// Token: 0x04000468 RID: 1128
		CodeWScope,
		// Token: 0x04000469 RID: 1129
		Integer,
		// Token: 0x0400046A RID: 1130
		TimeStamp,
		// Token: 0x0400046B RID: 1131
		Long,
		// Token: 0x0400046C RID: 1132
		MinKey = -1,
		// Token: 0x0400046D RID: 1133
		MaxKey = 127
	}
}
