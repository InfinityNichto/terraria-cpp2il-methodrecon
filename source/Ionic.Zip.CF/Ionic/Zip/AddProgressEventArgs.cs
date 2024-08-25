using System;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x0200000B RID: 11
	public class AddProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002440 File Offset: 0x00000640
		internal AddProgressEventArgs()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002454 File Offset: 0x00000654
		private AddProgressEventArgs(string archiveName, ZipProgressEventType flavor)
			: base(archiveName, flavor)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002122 File Offset: 0x00000322
		internal static AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002122 File Offset: 0x00000322
		internal static AddProgressEventArgs Started(string archiveName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002122 File Offset: 0x00000322
		internal static AddProgressEventArgs Completed(string archiveName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
