using System;

namespace System.Net.Security
{
	// Token: 0x02000320 RID: 800
	[Flags]
	public enum SslPolicyErrors
	{
		// Token: 0x04001150 RID: 4432
		None = 0,
		// Token: 0x04001151 RID: 4433
		RemoteCertificateNotAvailable = 1,
		// Token: 0x04001152 RID: 4434
		RemoteCertificateNameMismatch = 2,
		// Token: 0x04001153 RID: 4435
		RemoteCertificateChainErrors = 4
	}
}
