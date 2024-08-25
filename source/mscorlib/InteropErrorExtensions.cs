using System;
using Cpp2IlInjected;

// Token: 0x0200000B RID: 11
internal static class InteropErrorExtensions
{
	// Token: 0x0600002D RID: 45 RVA: 0x0000207A File Offset: 0x0000027A
	public static Interop.ErrorInfo Info(this Interop.Error error)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
