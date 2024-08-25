using System;

namespace Mono.Security.Interface
{
	// Token: 0x02000049 RID: 73
	[Flags]
	public enum MonoSslPolicyErrors
	{
		// Token: 0x04000229 RID: 553
		None = 0,
		// Token: 0x0400022A RID: 554
		RemoteCertificateNotAvailable = 1,
		// Token: 0x0400022B RID: 555
		RemoteCertificateNameMismatch = 2,
		// Token: 0x0400022C RID: 556
		RemoteCertificateChainErrors = 4
	}
}
