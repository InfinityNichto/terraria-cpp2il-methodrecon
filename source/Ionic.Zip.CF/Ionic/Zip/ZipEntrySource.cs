using System;

namespace Ionic.Zip
{
	// Token: 0x02000025 RID: 37
	public enum ZipEntrySource
	{
		// Token: 0x040000B1 RID: 177
		None,
		// Token: 0x040000B2 RID: 178
		FileSystem,
		// Token: 0x040000B3 RID: 179
		Stream,
		// Token: 0x040000B4 RID: 180
		ZipFile,
		// Token: 0x040000B5 RID: 181
		WriteDelegate,
		// Token: 0x040000B6 RID: 182
		JitStream,
		// Token: 0x040000B7 RID: 183
		ZipOutputStream
	}
}
