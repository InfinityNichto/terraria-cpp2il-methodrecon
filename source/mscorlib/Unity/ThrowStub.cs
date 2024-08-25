using System;
using Cpp2IlInjected;

namespace Unity
{
	// Token: 0x020006A8 RID: 1704
	internal sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x060031ED RID: 12781 RVA: 0x0000207A File Offset: 0x0000027A
		public static void ThrowNotSupportedException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
