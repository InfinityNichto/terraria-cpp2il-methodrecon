using System;
using Cpp2IlInjected;

namespace Microsoft.Win32
{
	// Token: 0x02000058 RID: 88
	internal static class Win32Native
	{
		// Token: 0x06000211 RID: 529 RVA: 0x00008098 File Offset: 0x00006298
		public static string GetMessage(int hr)
		{
			string text;
			return "Error " + text;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000207A File Offset: 0x0000027A
		public static int MakeHRFromErrorCode(int errorCode)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
