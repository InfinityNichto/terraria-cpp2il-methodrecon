using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000F9 RID: 249
	[Flags]
	public enum X500DistinguishedNameFlags
	{
		// Token: 0x04000487 RID: 1159
		None = 0,
		// Token: 0x04000488 RID: 1160
		Reversed = 1,
		// Token: 0x04000489 RID: 1161
		UseSemicolons = 16,
		// Token: 0x0400048A RID: 1162
		DoNotUsePlusSign = 32,
		// Token: 0x0400048B RID: 1163
		DoNotUseQuotes = 64,
		// Token: 0x0400048C RID: 1164
		UseCommas = 128,
		// Token: 0x0400048D RID: 1165
		UseNewLines = 256,
		// Token: 0x0400048E RID: 1166
		UseUTF8Encoding = 4096,
		// Token: 0x0400048F RID: 1167
		UseT61Encoding = 8192,
		// Token: 0x04000490 RID: 1168
		ForceUTF8Encoding = 16384
	}
}
