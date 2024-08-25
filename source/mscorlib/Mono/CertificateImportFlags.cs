using System;

namespace Mono
{
	// Token: 0x0200000E RID: 14
	[Flags]
	internal enum CertificateImportFlags
	{
		// Token: 0x04000085 RID: 133
		None = 0,
		// Token: 0x04000086 RID: 134
		DisableNativeBackend = 1,
		// Token: 0x04000087 RID: 135
		DisableAutomaticFallback = 2
	}
}
