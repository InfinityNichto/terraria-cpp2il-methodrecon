using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200003D RID: 61
	[Preserve]
	public enum WriteState
	{
		// Token: 0x0400014A RID: 330
		Error,
		// Token: 0x0400014B RID: 331
		Closed,
		// Token: 0x0400014C RID: 332
		Object,
		// Token: 0x0400014D RID: 333
		Array,
		// Token: 0x0400014E RID: 334
		Constructor,
		// Token: 0x0400014F RID: 335
		Property,
		// Token: 0x04000150 RID: 336
		Start
	}
}
