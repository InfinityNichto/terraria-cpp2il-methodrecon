using System;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000068 RID: 104
	internal static class SystemCertificateValidator
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00005AC4 File Offset: 0x00003CC4
		static SystemCertificateValidator()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005AD4 File Offset: 0x00003CD4
		internal static bool NeedsChain(MonoTlsSettings settings)
		{
		}

		// Token: 0x0400012D RID: 301
		private static bool is_macosx;

		// Token: 0x0400012E RID: 302
		private static global::System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags;
	}
}
