using System;

namespace System.Net
{
	// Token: 0x0200014E RID: 334
	internal enum FtpOperation
	{
		// Token: 0x0400069F RID: 1695
		DownloadFile,
		// Token: 0x040006A0 RID: 1696
		ListDirectory,
		// Token: 0x040006A1 RID: 1697
		ListDirectoryDetails,
		// Token: 0x040006A2 RID: 1698
		UploadFile,
		// Token: 0x040006A3 RID: 1699
		UploadFileUnique,
		// Token: 0x040006A4 RID: 1700
		AppendFile,
		// Token: 0x040006A5 RID: 1701
		DeleteFile,
		// Token: 0x040006A6 RID: 1702
		GetDateTimestamp,
		// Token: 0x040006A7 RID: 1703
		GetFileSize,
		// Token: 0x040006A8 RID: 1704
		Rename,
		// Token: 0x040006A9 RID: 1705
		MakeDirectory,
		// Token: 0x040006AA RID: 1706
		RemoveDirectory,
		// Token: 0x040006AB RID: 1707
		PrintWorkingDirectory,
		// Token: 0x040006AC RID: 1708
		Other
	}
}
