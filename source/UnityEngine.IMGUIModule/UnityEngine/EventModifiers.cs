using System;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[Flags]
	public enum EventModifiers
	{
		// Token: 0x04000048 RID: 72
		None = 0,
		// Token: 0x04000049 RID: 73
		Shift = 1,
		// Token: 0x0400004A RID: 74
		Control = 2,
		// Token: 0x0400004B RID: 75
		Alt = 4,
		// Token: 0x0400004C RID: 76
		Command = 8,
		// Token: 0x0400004D RID: 77
		Numeric = 16,
		// Token: 0x0400004E RID: 78
		CapsLock = 32,
		// Token: 0x0400004F RID: 79
		FunctionKey = 64
	}
}
