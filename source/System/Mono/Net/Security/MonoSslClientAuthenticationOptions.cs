using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;

namespace Mono.Net.Security
{
	// Token: 0x02000062 RID: 98
	internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00005424 File Offset: 0x00003624
		public global::System.Net.Security.SslClientAuthenticationOptions Options
		{
			[CompilerGenerated]
			get
			{
				return this.<Options>k__BackingField;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00005438 File Offset: 0x00003638
		public override bool ServerMode
		{
			get
			{
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005448 File Offset: 0x00003648
		public MonoSslClientAuthenticationOptions()
		{
		}

		// Token: 0x17000048 RID: 72
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000545C File Offset: 0x0000365C
		public override global::System.Security.Cryptography.X509Certificates.X509RevocationMode CertificateRevocationCheckMode
		{
			set
			{
				this.<Options>k__BackingField.CertificateRevocationCheckMode = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00005478 File Offset: 0x00003678
		public override global::System.Net.Security.EncryptionPolicy EncryptionPolicy
		{
			set
			{
				this.<Options>k__BackingField.EncryptionPolicy = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00005494 File Offset: 0x00003694
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000054AC File Offset: 0x000036AC
		public override global::System.Security.Authentication.SslProtocols EnabledSslProtocols
		{
			get
			{
				return this.<Options>k__BackingField._enabledSslProtocols;
			}
			set
			{
				this.<Options>k__BackingField._enabledSslProtocols = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000054C8 File Offset: 0x000036C8
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000054E0 File Offset: 0x000036E0
		public override string TargetHost
		{
			get
			{
				return this.<Options>k__BackingField.<TargetHost>k__BackingField;
			}
			set
			{
				this.<Options>k__BackingField.<TargetHost>k__BackingField = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		public override bool ClientCertificateRequired
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000054FC File Offset: 0x000036FC
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00005514 File Offset: 0x00003714
		public override global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
		{
			get
			{
				return this.<Options>k__BackingField.<ClientCertificates>k__BackingField;
			}
			set
			{
				this.<Options>k__BackingField.<ClientCertificates>k__BackingField = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		public override X509Certificate ServerCertificate
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x04000114 RID: 276
		[CompilerGenerated]
		private readonly global::System.Net.Security.SslClientAuthenticationOptions <Options>k__BackingField;
	}
}
