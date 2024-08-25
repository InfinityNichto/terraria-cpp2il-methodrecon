using System;

namespace System.Net
{
	// Token: 0x020001DB RID: 475
	public static class WebRequestMethods
	{
		// Token: 0x020001DC RID: 476
		public static class Ftp
		{
			// Token: 0x04000A07 RID: 2567
			public const string DownloadFile = "RETR";

			// Token: 0x04000A08 RID: 2568
			public const string ListDirectory = "NLST";

			// Token: 0x04000A09 RID: 2569
			public const string UploadFile = "STOR";

			// Token: 0x04000A0A RID: 2570
			public const string DeleteFile = "DELE";

			// Token: 0x04000A0B RID: 2571
			public const string AppendFile = "APPE";

			// Token: 0x04000A0C RID: 2572
			public const string GetFileSize = "SIZE";

			// Token: 0x04000A0D RID: 2573
			public const string UploadFileWithUniqueName = "STOU";

			// Token: 0x04000A0E RID: 2574
			public const string MakeDirectory = "MKD";

			// Token: 0x04000A0F RID: 2575
			public const string RemoveDirectory = "RMD";

			// Token: 0x04000A10 RID: 2576
			public const string ListDirectoryDetails = "LIST";

			// Token: 0x04000A11 RID: 2577
			public const string GetDateTimestamp = "MDTM";

			// Token: 0x04000A12 RID: 2578
			public const string PrintWorkingDirectory = "PWD";

			// Token: 0x04000A13 RID: 2579
			public const string Rename = "RENAME";
		}

		// Token: 0x020001DD RID: 477
		public static class Http
		{
			// Token: 0x04000A14 RID: 2580
			public const string Get = "GET";

			// Token: 0x04000A15 RID: 2581
			public const string Connect = "CONNECT";

			// Token: 0x04000A16 RID: 2582
			public const string Head = "HEAD";

			// Token: 0x04000A17 RID: 2583
			public const string Put = "PUT";

			// Token: 0x04000A18 RID: 2584
			public const string Post = "POST";

			// Token: 0x04000A19 RID: 2585
			public const string MkCol = "MKCOL";
		}

		// Token: 0x020001DE RID: 478
		public static class File
		{
			// Token: 0x04000A1A RID: 2586
			public const string DownloadFile = "GET";

			// Token: 0x04000A1B RID: 2587
			public const string UploadFile = "PUT";
		}
	}
}
