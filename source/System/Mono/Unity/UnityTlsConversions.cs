using System;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;
using Mono.Security.Interface;

namespace Mono.Unity
{
	// Token: 0x02000045 RID: 69
	internal static class UnityTlsConversions
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00003508 File Offset: 0x00001708
		public static UnityTls.unitytls_protocol GetMinProtocol(global::System.Security.Authentication.SslProtocols protocols)
		{
			return (UnityTls.unitytls_protocol)1;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000351C File Offset: 0x0000171C
		public static UnityTls.unitytls_protocol GetMaxProtocol(global::System.Security.Authentication.SslProtocols protocols)
		{
			return (UnityTls.unitytls_protocol)2;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003534 File Offset: 0x00001734
		public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003544 File Offset: 0x00001744
		public static global::System.Net.Security.SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult)
		{
			return global::System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003554 File Offset: 0x00001754
		public static global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult)
		{
			return global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.UntrustedRoot;
		}
	}
}
