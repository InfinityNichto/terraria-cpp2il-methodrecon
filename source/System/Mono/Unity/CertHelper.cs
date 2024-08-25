using System;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Unity
{
	// Token: 0x0200000E RID: 14
	internal static class CertHelper
	{
		// Token: 0x06000039 RID: 57 RVA: 0x0000243C File Offset: 0x0000063C
		public unsafe static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState)
		{
			global::System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator enumerator = certificates.GetEnumerator();
			bool flag = enumerator.MoveNext();
			X509Certificate x509Certificate = enumerator.Current;
			CertHelper.AddCertificateToNativeChain(nativeCertificateChain, x509Certificate, errorState);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000248C File Offset: 0x0000068C
		public unsafe static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState)
		{
			if (certificate != null)
			{
				byte[] lazyCertHash = certificate.lazyCertHash;
				return;
			}
			UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der = UnityTls.NativeInterface.unitytls_x509list_append_der;
			byte[] lazyCertHash2 = certificate.lazyCertHash;
			IntPtr method_code = unitytls_x509list_append_der.method_code;
			IntPtr invoke_impl = unitytls_x509list_append_der.invoke_impl;
			IntPtr method = unitytls_x509list_append_der.method;
			if (certificate.impl != null)
			{
			}
		}
	}
}
