using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000039 RID: 57
	[Preserve]
	[Flags]
	public enum TypeNameHandling
	{
		// Token: 0x04000119 RID: 281
		None = 0,
		// Token: 0x0400011A RID: 282
		Objects = 1,
		// Token: 0x0400011B RID: 283
		Arrays = 2,
		// Token: 0x0400011C RID: 284
		All = 3,
		// Token: 0x0400011D RID: 285
		Auto = 4
	}
}
