using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Net.Security
{
	// Token: 0x02000061 RID: 97
	internal abstract class MonoSslAuthenticationOptions
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600014C RID: 332
		public abstract bool ServerMode { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600014D RID: 333
		// (set) Token: 0x0600014E RID: 334
		public abstract global::System.Security.Authentication.SslProtocols EnabledSslProtocols { get; set; }

		// Token: 0x1700003F RID: 63
		// (set) Token: 0x0600014F RID: 335
		public abstract global::System.Net.Security.EncryptionPolicy EncryptionPolicy { set; }

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x06000150 RID: 336
		public abstract global::System.Security.Cryptography.X509Certificates.X509RevocationMode CertificateRevocationCheckMode { set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000151 RID: 337
		// (set) Token: 0x06000152 RID: 338
		public abstract string TargetHost { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000153 RID: 339
		// (set) Token: 0x06000154 RID: 340
		public abstract X509Certificate ServerCertificate { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000155 RID: 341
		// (set) Token: 0x06000156 RID: 342
		public abstract global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000157 RID: 343
		// (set) Token: 0x06000158 RID: 344
		public abstract bool ClientCertificateRequired { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000053FC File Offset: 0x000035FC
		internal global::System.Net.Security.ServerCertSelectionCallback ServerCertSelectionDelegate
		{
			[CompilerGenerated]
			get
			{
				return this.<ServerCertSelectionDelegate>k__BackingField;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005410 File Offset: 0x00003610
		protected MonoSslAuthenticationOptions()
		{
		}

		// Token: 0x04000113 RID: 275
		[CompilerGenerated]
		private global::System.Net.Security.ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;
	}
}
