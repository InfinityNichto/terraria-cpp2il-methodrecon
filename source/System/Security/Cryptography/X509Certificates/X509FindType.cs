using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000FB RID: 251
	public enum X509FindType
	{
		// Token: 0x040004AD RID: 1197
		FindByThumbprint,
		// Token: 0x040004AE RID: 1198
		FindBySubjectName,
		// Token: 0x040004AF RID: 1199
		FindBySubjectDistinguishedName,
		// Token: 0x040004B0 RID: 1200
		FindByIssuerName,
		// Token: 0x040004B1 RID: 1201
		FindByIssuerDistinguishedName,
		// Token: 0x040004B2 RID: 1202
		FindBySerialNumber,
		// Token: 0x040004B3 RID: 1203
		FindByTimeValid,
		// Token: 0x040004B4 RID: 1204
		FindByTimeNotYetValid,
		// Token: 0x040004B5 RID: 1205
		FindByTimeExpired,
		// Token: 0x040004B6 RID: 1206
		FindByTemplateName,
		// Token: 0x040004B7 RID: 1207
		FindByApplicationPolicy,
		// Token: 0x040004B8 RID: 1208
		FindByCertificatePolicy,
		// Token: 0x040004B9 RID: 1209
		FindByExtension,
		// Token: 0x040004BA RID: 1210
		FindByKeyUsage,
		// Token: 0x040004BB RID: 1211
		FindBySubjectKeyIdentifier
	}
}
