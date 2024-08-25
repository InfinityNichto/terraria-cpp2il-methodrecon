using System;

namespace System.Reflection
{
	// Token: 0x020004E7 RID: 1255
	[Flags]
	public enum PropertyAttributes
	{
		// Token: 0x0400140A RID: 5130
		None = 0,
		// Token: 0x0400140B RID: 5131
		SpecialName = 512,
		// Token: 0x0400140C RID: 5132
		RTSpecialName = 1024,
		// Token: 0x0400140D RID: 5133
		HasDefault = 4096,
		// Token: 0x0400140E RID: 5134
		Reserved2 = 8192,
		// Token: 0x0400140F RID: 5135
		Reserved3 = 16384,
		// Token: 0x04001410 RID: 5136
		Reserved4 = 32768,
		// Token: 0x04001411 RID: 5137
		ReservedMask = 62464
	}
}
