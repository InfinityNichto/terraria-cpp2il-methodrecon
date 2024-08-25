using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200007C RID: 124
	internal static class NotImplemented
	{
		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		internal static Exception ByDesignWithMessage(string message)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
