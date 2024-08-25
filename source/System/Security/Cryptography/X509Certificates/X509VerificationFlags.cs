using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000101 RID: 257
	[Flags]
	public enum X509VerificationFlags
	{
		// Token: 0x040004DB RID: 1243
		NoFlag = 0,
		// Token: 0x040004DC RID: 1244
		IgnoreNotTimeValid = 1,
		// Token: 0x040004DD RID: 1245
		IgnoreCtlNotTimeValid = 2,
		// Token: 0x040004DE RID: 1246
		IgnoreNotTimeNested = 4,
		// Token: 0x040004DF RID: 1247
		IgnoreInvalidBasicConstraints = 8,
		// Token: 0x040004E0 RID: 1248
		AllowUnknownCertificateAuthority = 16,
		// Token: 0x040004E1 RID: 1249
		IgnoreWrongUsage = 32,
		// Token: 0x040004E2 RID: 1250
		IgnoreInvalidName = 64,
		// Token: 0x040004E3 RID: 1251
		IgnoreInvalidPolicy = 128,
		// Token: 0x040004E4 RID: 1252
		IgnoreEndRevocationUnknown = 256,
		// Token: 0x040004E5 RID: 1253
		IgnoreCtlSignerRevocationUnknown = 512,
		// Token: 0x040004E6 RID: 1254
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		// Token: 0x040004E7 RID: 1255
		IgnoreRootRevocationUnknown = 2048,
		// Token: 0x040004E8 RID: 1256
		AllFlags = 4095
	}
}
