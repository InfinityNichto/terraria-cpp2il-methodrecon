using System;

namespace System.Reflection
{
	// Token: 0x020004D2 RID: 1234
	[Flags]
	public enum ExceptionHandlingClauseOptions
	{
		// Token: 0x0400138F RID: 5007
		Clause = 0,
		// Token: 0x04001390 RID: 5008
		Filter = 1,
		// Token: 0x04001391 RID: 5009
		Finally = 2,
		// Token: 0x04001392 RID: 5010
		Fault = 4
	}
}
