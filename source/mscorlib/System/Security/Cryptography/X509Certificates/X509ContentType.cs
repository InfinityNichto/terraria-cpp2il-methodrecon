using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000320 RID: 800
	public enum X509ContentType
	{
		// Token: 0x04000DC5 RID: 3525
		Unknown,
		// Token: 0x04000DC6 RID: 3526
		Cert,
		// Token: 0x04000DC7 RID: 3527
		SerializedCert,
		// Token: 0x04000DC8 RID: 3528
		Pfx,
		// Token: 0x04000DC9 RID: 3529
		Pkcs12 = 3,
		// Token: 0x04000DCA RID: 3530
		SerializedStore,
		// Token: 0x04000DCB RID: 3531
		Pkcs7,
		// Token: 0x04000DCC RID: 3532
		Authenticode
	}
}
