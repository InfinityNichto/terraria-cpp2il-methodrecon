using System;
using Cpp2IlInjected;

namespace Unity
{
	// Token: 0x0200000F RID: 15
	internal sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000022A2 File Offset: 0x000004A2
		public static void ThrowNotSupportedException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
