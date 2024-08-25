using System;
using Cpp2IlInjected;

namespace Ionic.Zip
{
	// Token: 0x0200000E RID: 14
	public class ZipErrorEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002550 File Offset: 0x00000750
		private ZipErrorEventArgs()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002122 File Offset: 0x00000322
		internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002564 File Offset: 0x00000764
		public Exception Exception
		{
			get
			{
				return this._exc;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002578 File Offset: 0x00000778
		public string FileName
		{
			get
			{
				return this._latestEntry._LocalFileName;
			}
		}

		// Token: 0x04000028 RID: 40
		private Exception _exc;
	}
}
