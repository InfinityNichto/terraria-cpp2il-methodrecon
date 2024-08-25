using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200001D RID: 29
	[Flags]
	[Preserve]
	public enum PreserveReferencesHandling
	{
		// Token: 0x04000041 RID: 65
		None = 0,
		// Token: 0x04000042 RID: 66
		Objects = 1,
		// Token: 0x04000043 RID: 67
		Arrays = 2,
		// Token: 0x04000044 RID: 68
		All = 3
	}
}
