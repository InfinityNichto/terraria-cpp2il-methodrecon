using System;
using System.Collections.Generic;
using System.Text;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000108 RID: 264
	internal abstract class X509Certificate2Impl : X509CertificateImpl
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060005E1 RID: 1505
		public abstract IEnumerable<X509Extension> Extensions { get; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060005E2 RID: 1506
		public abstract X500DistinguishedName IssuerName { get; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060005E3 RID: 1507
		// (set) Token: 0x060005E4 RID: 1508
		public abstract AsymmetricAlgorithm PrivateKey { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060005E5 RID: 1509
		public abstract string SignatureAlgorithm { get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060005E6 RID: 1510
		public abstract X500DistinguishedName SubjectName { get; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060005E7 RID: 1511
		public abstract int Version { get; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060005E8 RID: 1512
		internal abstract X509CertificateImplCollection IntermediateCertificates { get; }

		// Token: 0x060005E9 RID: 1513
		public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

		// Token: 0x060005EA RID: 1514
		public abstract bool Verify(X509Certificate2 thisCertificate);

		// Token: 0x060005EB RID: 1515
		public abstract void AppendPrivateKeyInfo(StringBuilder sb);

		// Token: 0x060005EC RID: 1516 RVA: 0x00016B74 File Offset: 0x00014D74
		public sealed override X509CertificateImpl CopyWithPrivateKey(RSA privateKey)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00016B88 File Offset: 0x00014D88
		protected X509Certificate2Impl()
		{
		}
	}
}
