using System;
using Cpp2IlInjected;

namespace System.Buffers.Text
{
	// Token: 0x0200066C RID: 1644
	internal static class FormattingHelpers
	{
		// Token: 0x060031E9 RID: 12777 RVA: 0x0006BE1C File Offset: 0x0006A01C
		public static int CountDigits(ulong value)
		{
			return 15;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0000207A File Offset: 0x0000027A
		public static int CountDigits(uint value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x0000207A File Offset: 0x0000027A
		public static int CountHexDigits(ulong value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
