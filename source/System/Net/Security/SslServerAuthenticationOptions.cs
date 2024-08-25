using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security
{
	// Token: 0x0200031A RID: 794
	public class SslServerAuthenticationOptions
	{
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0003EAD4 File Offset: 0x0003CCD4
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0003EAE8 File Offset: 0x0003CCE8
		public bool ClientCertificateRequired
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientCertificateRequired>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0003EAF8 File Offset: 0x0003CCF8
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0003EB0C File Offset: 0x0003CD0C
		public X509Certificate ServerCertificate
		{
			[CompilerGenerated]
			get
			{
				return this.<ServerCertificate>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<ServerCertificate>k__BackingField = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0003EB20 File Offset: 0x0003CD20
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0003EB34 File Offset: 0x0003CD34
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

		// Token: 0x170004B4 RID: 1204
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x0003EB48 File Offset: 0x0003CD48
		public global::System.Security.Cryptography.X509Certificates.X509RevocationMode CertificateRevocationCheckMode
		{
			set
			{
				this._checkCertificateRevocation = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x0003EB6C File Offset: 0x0003CD6C
		public EncryptionPolicy EncryptionPolicy
		{
			set
			{
				this._encryptionPolicy = value;
			}
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0003EB90 File Offset: 0x0003CD90
		public SslServerAuthenticationOptions()
		{
		}

		// Token: 0x0400113F RID: 4415
		private global::System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;

		// Token: 0x04001140 RID: 4416
		private global::System.Security.Authentication.SslProtocols _enabledSslProtocols;

		// Token: 0x04001141 RID: 4417
		private EncryptionPolicy _encryptionPolicy;

		// Token: 0x04001142 RID: 4418
		private bool _allowRenegotiation = true;

		// Token: 0x04001143 RID: 4419
		[CompilerGenerated]
		private bool <ClientCertificateRequired>k__BackingField;

		// Token: 0x04001144 RID: 4420
		[CompilerGenerated]
		private X509Certificate <ServerCertificate>k__BackingField;
	}
}
