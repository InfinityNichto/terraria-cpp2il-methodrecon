using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;

namespace Mono.Net.Security
{
	// Token: 0x02000063 RID: 99
	internal sealed class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00005530 File Offset: 0x00003730
		public global::System.Net.Security.SslServerAuthenticationOptions Options
		{
			[CompilerGenerated]
			get
			{
				return this.<Options>k__BackingField;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00005544 File Offset: 0x00003744
		public override bool ServerMode
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005554 File Offset: 0x00003754
		public MonoSslServerAuthenticationOptions()
		{
		}

		// Token: 0x17000051 RID: 81
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00005568 File Offset: 0x00003768
		public override global::System.Security.Cryptography.X509Certificates.X509RevocationMode CertificateRevocationCheckMode
		{
			set
			{
				this.<Options>k__BackingField.CertificateRevocationCheckMode = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00005584 File Offset: 0x00003784
		public override global::System.Net.Security.EncryptionPolicy EncryptionPolicy
		{
			set
			{
				this.<Options>k__BackingField.EncryptionPolicy = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000055A0 File Offset: 0x000037A0
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000055B8 File Offset: 0x000037B8
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000055D4 File Offset: 0x000037D4
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000055EC File Offset: 0x000037EC
		public override bool ClientCertificateRequired
		{
			get
			{
				return this.<Options>k__BackingField.<ClientCertificateRequired>k__BackingField;
			}
			set
			{
				global::System.Net.Security.SslServerAuthenticationOptions sslServerAuthenticationOptions = this.<Options>k__BackingField;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		public override string TargetHost
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00005600 File Offset: 0x00003800
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00005618 File Offset: 0x00003818
		public override X509Certificate ServerCertificate
		{
			get
			{
				return this.<Options>k__BackingField.<ServerCertificate>k__BackingField;
			}
			set
			{
				this.<Options>k__BackingField.<ServerCertificate>k__BackingField = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		public override global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
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

		// Token: 0x04000115 RID: 277
		[CompilerGenerated]
		private readonly global::System.Net.Security.SslServerAuthenticationOptions <Options>k__BackingField;
	}
}
