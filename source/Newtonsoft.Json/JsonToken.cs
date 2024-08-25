using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200003A RID: 58
	[Preserve]
	public enum JsonToken
	{
		// Token: 0x0400011F RID: 287
		None,
		// Token: 0x04000120 RID: 288
		StartObject,
		// Token: 0x04000121 RID: 289
		StartArray,
		// Token: 0x04000122 RID: 290
		StartConstructor,
		// Token: 0x04000123 RID: 291
		PropertyName,
		// Token: 0x04000124 RID: 292
		Comment,
		// Token: 0x04000125 RID: 293
		Raw,
		// Token: 0x04000126 RID: 294
		Integer,
		// Token: 0x04000127 RID: 295
		Float,
		// Token: 0x04000128 RID: 296
		String,
		// Token: 0x04000129 RID: 297
		Boolean,
		// Token: 0x0400012A RID: 298
		Null,
		// Token: 0x0400012B RID: 299
		Undefined,
		// Token: 0x0400012C RID: 300
		EndObject,
		// Token: 0x0400012D RID: 301
		EndArray,
		// Token: 0x0400012E RID: 302
		EndConstructor,
		// Token: 0x0400012F RID: 303
		Date,
		// Token: 0x04000130 RID: 304
		Bytes
	}
}
