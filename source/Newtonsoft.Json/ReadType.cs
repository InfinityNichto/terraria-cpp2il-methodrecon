using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000028 RID: 40
	[Preserve]
	internal enum ReadType
	{
		// Token: 0x04000097 RID: 151
		Read,
		// Token: 0x04000098 RID: 152
		ReadAsInt32,
		// Token: 0x04000099 RID: 153
		ReadAsBytes,
		// Token: 0x0400009A RID: 154
		ReadAsString,
		// Token: 0x0400009B RID: 155
		ReadAsDecimal,
		// Token: 0x0400009C RID: 156
		ReadAsDateTime,
		// Token: 0x0400009D RID: 157
		ReadAsDateTimeOffset,
		// Token: 0x0400009E RID: 158
		ReadAsDouble,
		// Token: 0x0400009F RID: 159
		ReadAsBoolean
	}
}
