using System;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Flags]
	internal enum TextGenerationError
	{
		// Token: 0x04000007 RID: 7
		None = 0,
		// Token: 0x04000008 RID: 8
		CustomSizeOnNonDynamicFont = 1,
		// Token: 0x04000009 RID: 9
		CustomStyleOnNonDynamicFont = 2,
		// Token: 0x0400000A RID: 10
		NoFont = 4
	}
}
