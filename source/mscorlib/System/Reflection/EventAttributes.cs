using System;

namespace System.Reflection
{
	// Token: 0x020004CF RID: 1231
	[Flags]
	public enum EventAttributes
	{
		// Token: 0x04001389 RID: 5001
		None = 0,
		// Token: 0x0400138A RID: 5002
		SpecialName = 512,
		// Token: 0x0400138B RID: 5003
		RTSpecialName = 1024,
		// Token: 0x0400138C RID: 5004
		ReservedMask = 1024
	}
}
