using System;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x0200000A RID: 10
	public class ReadProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002414 File Offset: 0x00000614
		internal ReadProgressEventArgs()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002428 File Offset: 0x00000628
		private ReadProgressEventArgs(string archiveName, ZipProgressEventType flavor)
			: base(archiveName, flavor)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002122 File Offset: 0x00000322
		internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002122 File Offset: 0x00000322
		internal static ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002122 File Offset: 0x00000322
		internal static ReadProgressEventArgs Started(string archiveName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002122 File Offset: 0x00000322
		internal static ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002122 File Offset: 0x00000322
		internal static ReadProgressEventArgs Completed(string archiveName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
