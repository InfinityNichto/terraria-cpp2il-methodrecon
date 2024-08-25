using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000021 RID: 33
	[Flags]
	[Preserve]
	public enum DefaultValueHandling
	{
		// Token: 0x04000050 RID: 80
		Include = 0,
		// Token: 0x04000051 RID: 81
		Ignore = 1,
		// Token: 0x04000052 RID: 82
		Populate = 2,
		// Token: 0x04000053 RID: 83
		IgnoreAndPopulate = 3
	}
}
