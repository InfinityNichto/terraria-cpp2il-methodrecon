using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000099 RID: 153
	[Preserve]
	internal enum JsonContractType
	{
		// Token: 0x0400025F RID: 607
		None,
		// Token: 0x04000260 RID: 608
		Object,
		// Token: 0x04000261 RID: 609
		Array,
		// Token: 0x04000262 RID: 610
		Primitive,
		// Token: 0x04000263 RID: 611
		String,
		// Token: 0x04000264 RID: 612
		Dictionary,
		// Token: 0x04000265 RID: 613
		Dynamic,
		// Token: 0x04000266 RID: 614
		Serializable,
		// Token: 0x04000267 RID: 615
		Linq
	}
}
