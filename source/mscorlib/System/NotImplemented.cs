using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000124 RID: 292
	internal static class NotImplemented
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Exception ByDesign
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
