using System;

namespace System.Reflection
{
	// Token: 0x02000513 RID: 1299
	[Flags]
	internal enum PInfo
	{
		// Token: 0x04001507 RID: 5383
		Attributes = 1,
		// Token: 0x04001508 RID: 5384
		GetMethod = 2,
		// Token: 0x04001509 RID: 5385
		SetMethod = 4,
		// Token: 0x0400150A RID: 5386
		ReflectedType = 8,
		// Token: 0x0400150B RID: 5387
		DeclaringType = 16,
		// Token: 0x0400150C RID: 5388
		Name = 32
	}
}
