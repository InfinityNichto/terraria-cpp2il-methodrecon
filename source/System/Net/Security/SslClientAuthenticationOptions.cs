using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security
{
	// Token: 0x02000319 RID: 793
	public class SslClientAuthenticationOptions
	{
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0003E9F8 File Offset: 0x0003CBF8
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0003EA0C File Offset: 0x0003CC0C
		public string TargetHost
		{
			[CompilerGenerated]
			get
			{
				return this.<TargetHost>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<TargetHost>k__BackingField = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0003EA20 File Offset: 0x0003CC20
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x0003EA34 File Offset: 0x0003CC34
		public global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientCertificates>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ClientCertificates>k__BackingField = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0003EA48 File Offset: 0x0003CC48
		public global::System.Security.Cryptography.X509Certificates.X509RevocationMode CertificateRevocationCheckMode
		{
			set
			{
				this._checkCertificateRevocation = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0003EA6C File Offset: 0x0003CC6C
		public EncryptionPolicy EncryptionPolicy
		{
			set
			{
				this._encryptionPolicy = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0003EA90 File Offset: 0x0003CC90
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x0003EAA4 File Offset: 0x0003CCA4
		public global::System.Security.Authentication.SslProtocols EnabledSslProtocols
		{
			get
			{
				return this._enabledSslProtocols;
			}
			set
			{
				this._enabledSslProtocols = value;
			}
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0003EAB8 File Offset: 0x0003CCB8
		public SslClientAuthenticationOptions()
		{
		}

		// Token: 0x04001139 RID: 4409
		private EncryptionPolicy _encryptionPolicy;

		// Token: 0x0400113A RID: 4410
		private global::System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;

		// Token: 0x0400113B RID: 4411
		private global::System.Security.Authentication.SslProtocols _enabledSslProtocols;

		// Token: 0x0400113C RID: 4412
		private bool _allowRenegotiation = true;

		// Token: 0x0400113D RID: 4413
		[CompilerGenerated]
		private string <TargetHost>k__BackingField;

		// Token: 0x0400113E RID: 4414
		[CompilerGenerated]
		private global::System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;
	}
}
