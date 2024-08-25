using System;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000060 RID: 96
	internal abstract class MobileTlsProvider : MonoTlsProvider
	{
		// Token: 0x06000149 RID: 329
		internal abstract MobileAuthenticatedStream CreateSslStream(global::System.Net.Security.SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

		// Token: 0x0600014A RID: 330
		internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors errors, int status11);

		// Token: 0x0600014B RID: 331 RVA: 0x000053E8 File Offset: 0x000035E8
		protected MobileTlsProvider()
		{
		}
	}
}
