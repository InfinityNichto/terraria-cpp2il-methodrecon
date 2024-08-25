using System;

namespace System.Reflection
{
	// Token: 0x020004CB RID: 1227
	[Flags]
	public enum CallingConventions
	{
		// Token: 0x04001380 RID: 4992
		Standard = 1,
		// Token: 0x04001381 RID: 4993
		VarArgs = 2,
		// Token: 0x04001382 RID: 4994
		Any = 3,
		// Token: 0x04001383 RID: 4995
		HasThis = 32,
		// Token: 0x04001384 RID: 4996
		ExplicitThis = 64
	}
}
