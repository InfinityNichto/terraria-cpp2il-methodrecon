using System;

namespace Mono.Security.X509
{
	// Token: 0x0200000B RID: 11
	public class PKCS5
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002C84 File Offset: 0x00000E84
		public PKCS5()
		{
		}

		// Token: 0x04000019 RID: 25
		public const string pbeWithMD2AndDESCBC = "1.2.840.113549.1.5.1";

		// Token: 0x0400001A RID: 26
		public const string pbeWithMD5AndDESCBC = "1.2.840.113549.1.5.3";

		// Token: 0x0400001B RID: 27
		public const string pbeWithMD2AndRC2CBC = "1.2.840.113549.1.5.4";

		// Token: 0x0400001C RID: 28
		public const string pbeWithMD5AndRC2CBC = "1.2.840.113549.1.5.6";

		// Token: 0x0400001D RID: 29
		public const string pbeWithSHA1AndDESCBC = "1.2.840.113549.1.5.10";

		// Token: 0x0400001E RID: 30
		public const string pbeWithSHA1AndRC2CBC = "1.2.840.113549.1.5.11";
	}
}
