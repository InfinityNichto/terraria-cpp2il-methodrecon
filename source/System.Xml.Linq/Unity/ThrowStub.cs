using System;
using Cpp2IlInjected;

namespace Unity
{
	// Token: 0x02000020 RID: 32
	internal sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00002367 File Offset: 0x00000567
		public static void ThrowNotSupportedException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
