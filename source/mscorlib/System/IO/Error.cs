using System;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x02000531 RID: 1329
	internal static class Error
	{
		// Token: 0x06002732 RID: 10034 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Exception GetStreamIsClosed()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Exception GetEndOfFile()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Exception GetReadNotSupported()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0000207A File Offset: 0x0000027A
		internal static Exception GetWriteNotSupported()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
