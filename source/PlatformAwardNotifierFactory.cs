using System;
using Cpp2IlInjected;

// Token: 0x020002AC RID: 684
public static class PlatformAwardNotifierFactory
{
	// Token: 0x06000FC6 RID: 4038 RVA: 0x000021DB File Offset: 0x000003DB
	public static IPlatformAwardNotifier CreateForActivePlatform()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
