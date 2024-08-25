using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020005D8 RID: 1496
	[Flags]
	public enum EventKeywords : long
	{
		// Token: 0x0400197D RID: 6525
		None = 0L,
		// Token: 0x0400197E RID: 6526
		All = -1L,
		// Token: 0x0400197F RID: 6527
		MicrosoftTelemetry = 562949953421312L,
		// Token: 0x04001980 RID: 6528
		WdiContext = 562949953421312L,
		// Token: 0x04001981 RID: 6529
		WdiDiagnostic = 1125899906842624L,
		// Token: 0x04001982 RID: 6530
		Sqm = 2251799813685248L,
		// Token: 0x04001983 RID: 6531
		AuditFailure = 4503599627370496L,
		// Token: 0x04001984 RID: 6532
		AuditSuccess = 9007199254740992L,
		// Token: 0x04001985 RID: 6533
		CorrelationHint = 4503599627370496L,
		// Token: 0x04001986 RID: 6534
		EventLogClassic = 36028797018963968L
	}
}
