using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000059 RID: 89
	internal static class SafeHandleCache<T> where T : SafeHandle
	{
		// Token: 0x06000213 RID: 531 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsCachedInvalidHandle(SafeHandle handle)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400018E RID: 398
		private static T s_invalidHandle;
	}
}
