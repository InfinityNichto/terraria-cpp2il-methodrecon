using System;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200049E RID: 1182
	internal static class JitHelpers
	{
		// Token: 0x0600228E RID: 8846 RVA: 0x0000207A File Offset: 0x0000027A
		internal static T UnsafeCast<T>(object o) where T : class
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0000207A File Offset: 0x0000027A
		internal static int UnsafeEnumCast<T>(T val) where T : struct
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0004DB14 File Offset: 0x0004BD14
		internal static long UnsafeEnumCastLong<T>(T val) where T : struct
		{
			return 0L;
		}
	}
}
