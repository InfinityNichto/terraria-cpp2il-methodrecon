using System;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x0200000C RID: 12
	public class SaveProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000246C File Offset: 0x0000066C
		internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry)
		{
			this._entriesTotal = entriesTotal;
			this._latestEntry = entry;
			this._entriesSaved = entriesSaved;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002490 File Offset: 0x00000690
		internal SaveProgressEventArgs()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000024A4 File Offset: 0x000006A4
		internal SaveProgressEventArgs(string archiveName, ZipProgressEventType flavor)
			: base(archiveName, flavor)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002122 File Offset: 0x00000322
		internal static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002122 File Offset: 0x00000322
		internal static SaveProgressEventArgs Started(string archiveName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002122 File Offset: 0x00000322
		internal static SaveProgressEventArgs Completed(string archiveName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000024BC File Offset: 0x000006BC
		public int EntriesSaved
		{
			get
			{
				return this._entriesSaved;
			}
		}

		// Token: 0x04000025 RID: 37
		private int _entriesSaved;
	}
}
