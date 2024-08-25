using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2IlInjected;
using Microsoft.Win32.SafeHandles;
using Mono.Security;

namespace Mono
{
	// Token: 0x0200000C RID: 12
	internal abstract class X509PalImpl
	{
		// Token: 0x0600002D RID: 45
		public abstract X509CertificateImpl Import(byte[] data);

		// Token: 0x0600002E RID: 46
		public abstract global::System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags);

		// Token: 0x0600002F RID: 47
		public abstract global::System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(X509Certificate cert);

		// Token: 0x06000030 RID: 48 RVA: 0x000022C8 File Offset: 0x000004C8
		private static byte[] PEM(string type, byte[] data)
		{
			Encoding ascii = Encoding.ASCII;
			string text = string.Format("-----BEGIN {0}-----", type);
			string text2 = string.Format("-----END {0}-----", type);
			int stringLength = text._stringLength;
			byte[] array;
			return array;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002300 File Offset: 0x00000500
		protected static byte[] ConvertData(byte[] data)
		{
			byte[] array;
			if (true)
			{
				array = X509PalImpl.PEM("CERTIFICATE", data);
			}
			return array;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002320 File Offset: 0x00000520
		internal global::System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data)
		{
			if (!true)
			{
			}
			byte[] array = X509PalImpl.ConvertData(data);
			long num = 0L;
			if (data != null)
			{
				byte value = data.m_value;
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		internal global::System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002374 File Offset: 0x00000574
		public bool SupportsLegacyBasicConstraintsExtension
		{
			get
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002384 File Offset: 0x00000584
		public X509ContentType GetCertContentType(byte[] rawData)
		{
			int num = 1;
			if (rawData == null || num == 0)
			{
				return;
			}
			ASN1 asn;
			byte nTag = asn.m_nTag;
			ASN1 asn2;
			byte nTag2 = asn2.m_nTag;
			ASN1 asn3;
			byte nTag3 = asn3.m_nTag;
			ASN1 asn4;
			byte nTag4 = asn4.m_nTag;
			ASN1 asn5;
			byte nTag5 = asn5.m_nTag;
			ASN1 asn6;
			byte nTag6 = asn6.m_nTag;
			Encoding ascii = Encoding.ASCII;
			ASN1 asn7;
			if (asn7.m_nTag == 0)
			{
				return;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002404 File Offset: 0x00000604
		protected X509PalImpl()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002418 File Offset: 0x00000618
		// Note: this type is marked as 'beforefieldinit'.
		static X509PalImpl()
		{
		}

		// Token: 0x0400002D RID: 45
		private static byte[] signedData;
	}
}
