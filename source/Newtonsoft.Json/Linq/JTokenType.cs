using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000DF RID: 223
	[Preserve]
	public enum JTokenType
	{
		// Token: 0x04000372 RID: 882
		None,
		// Token: 0x04000373 RID: 883
		Object,
		// Token: 0x04000374 RID: 884
		Array,
		// Token: 0x04000375 RID: 885
		Constructor,
		// Token: 0x04000376 RID: 886
		Property,
		// Token: 0x04000377 RID: 887
		Comment,
		// Token: 0x04000378 RID: 888
		Integer,
		// Token: 0x04000379 RID: 889
		Float,
		// Token: 0x0400037A RID: 890
		String,
		// Token: 0x0400037B RID: 891
		Boolean,
		// Token: 0x0400037C RID: 892
		Null,
		// Token: 0x0400037D RID: 893
		Undefined,
		// Token: 0x0400037E RID: 894
		Date,
		// Token: 0x0400037F RID: 895
		Raw,
		// Token: 0x04000380 RID: 896
		Bytes,
		// Token: 0x04000381 RID: 897
		Guid,
		// Token: 0x04000382 RID: 898
		Uri,
		// Token: 0x04000383 RID: 899
		TimeSpan
	}
}
