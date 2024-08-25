using System;

namespace System.Net
{
	// Token: 0x020001AF RID: 431
	internal enum CertificateEncoding
	{
		// Token: 0x040008DD RID: 2269
		Zero,
		// Token: 0x040008DE RID: 2270
		X509AsnEncoding,
		// Token: 0x040008DF RID: 2271
		X509NdrEncoding,
		// Token: 0x040008E0 RID: 2272
		Pkcs7AsnEncoding = 65536,
		// Token: 0x040008E1 RID: 2273
		Pkcs7NdrEncoding = 131072,
		// Token: 0x040008E2 RID: 2274
		AnyAsnEncoding = 65537
	}
}
