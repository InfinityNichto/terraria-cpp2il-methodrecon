using System;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x0200000D RID: 13
	public class ExtractProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000024D0 File Offset: 0x000006D0
		internal ExtractProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesExtracted, ZipEntry entry, string extractLocation)
		{
			this._entriesTotal = entriesTotal;
			this._latestEntry = entry;
			this._entriesExtracted = entriesExtracted;
			this._target = extractLocation;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000024FC File Offset: 0x000006FC
		internal ExtractProgressEventArgs(string archiveName, ZipProgressEventType flavor)
			: base(archiveName, flavor)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002514 File Offset: 0x00000714
		internal ExtractProgressEventArgs()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002122 File Offset: 0x00000322
		internal static ExtractProgressEventArgs BeforeExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002122 File Offset: 0x00000322
		internal static ExtractProgressEventArgs ExtractExisting(string archiveName, ZipEntry entry, string extractLocation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002122 File Offset: 0x00000322
		internal static ExtractProgressEventArgs AfterExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002122 File Offset: 0x00000322
		internal static ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002122 File Offset: 0x00000322
		internal static ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002122 File Offset: 0x00000322
		internal static ExtractProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesWritten, long totalBytes)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002528 File Offset: 0x00000728
		public int EntriesExtracted
		{
			get
			{
				return this._entriesExtracted;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000253C File Offset: 0x0000073C
		public string ExtractLocation
		{
			get
			{
				return this._target;
			}
		}

		// Token: 0x04000026 RID: 38
		private int _entriesExtracted;

		// Token: 0x04000027 RID: 39
		private string _target;
	}
}
