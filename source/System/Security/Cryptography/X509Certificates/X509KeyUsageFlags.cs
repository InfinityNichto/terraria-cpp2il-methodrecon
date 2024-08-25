using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000FC RID: 252
	[Flags]
	public enum X509KeyUsageFlags
	{
		// Token: 0x040004BD RID: 1213
		None = 0,
		// Token: 0x040004BE RID: 1214
		EncipherOnly = 1,
		// Token: 0x040004BF RID: 1215
		CrlSign = 2,
		// Token: 0x040004C0 RID: 1216
		KeyCertSign = 4,
		// Token: 0x040004C1 RID: 1217
		KeyAgreement = 8,
		// Token: 0x040004C2 RID: 1218
		DataEncipherment = 16,
		// Token: 0x040004C3 RID: 1219
		KeyEncipherment = 32,
		// Token: 0x040004C4 RID: 1220
		NonRepudiation = 64,
		// Token: 0x040004C5 RID: 1221
		DigitalSignature = 128,
		// Token: 0x040004C6 RID: 1222
		DecipherOnly = 32768
	}
}
