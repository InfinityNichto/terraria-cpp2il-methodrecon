using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2IlInjected;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x0200005F RID: 95
	internal abstract class MobileTlsContext : IDisposable
	{
		// Token: 0x0600012F RID: 303 RVA: 0x000050FC File Offset: 0x000032FC
		protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
		{
			this.<Options>k__BackingField = options;
			this.Parent = parent;
			this.<EnabledProtocols>k__BackingField = options;
			this.LocalServerCertificate = options;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00005190 File Offset: 0x00003390
		internal MobileAuthenticatedStream Parent
		{
			[CompilerGenerated]
			get
			{
				return this.<Parent>k__BackingField;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		public MonoTlsSettings Settings
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000132 RID: 306
		public abstract bool IsAuthenticated { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000051A4 File Offset: 0x000033A4
		public bool IsServer
		{
			[CompilerGenerated]
			get
			{
				return this.<IsServer>k__BackingField;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000051B8 File Offset: 0x000033B8
		internal string TargetHost
		{
			[CompilerGenerated]
			get
			{
				return this.<TargetHost>k__BackingField;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000051CC File Offset: 0x000033CC
		protected string ServerName
		{
			[CompilerGenerated]
			get
			{
				return this.<ServerName>k__BackingField;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000051E0 File Offset: 0x000033E0
		protected bool AskForClientCertificate
		{
			[CompilerGenerated]
			get
			{
				return this.<AskForClientCertificate>k__BackingField;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000051F4 File Offset: 0x000033F4
		protected global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
		{
			[CompilerGenerated]
			get
			{
				return this.<ClientCertificates>k__BackingField;
			}
		}

		// Token: 0x06000138 RID: 312
		public abstract void StartHandshake();

		// Token: 0x06000139 RID: 313
		public abstract bool ProcessHandshake();

		// Token: 0x0600013A RID: 314
		public abstract void FinishHandshake();

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00005208 File Offset: 0x00003408
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000521C File Offset: 0x0000341C
		internal X509Certificate LocalServerCertificate
		{
			[CompilerGenerated]
			get
			{
				return this.<LocalServerCertificate>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<LocalServerCertificate>k__BackingField = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600013D RID: 317
		internal abstract X509Certificate LocalClientCertificate { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600013E RID: 318
		public abstract global::System.Security.Cryptography.X509Certificates.X509Certificate2 RemoteCertificate { get; }

		// Token: 0x0600013F RID: 319
		public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

		// Token: 0x06000140 RID: 320
		public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

		// Token: 0x06000141 RID: 321
		public abstract void Shutdown();

		// Token: 0x06000142 RID: 322
		public abstract bool PendingRenegotiation();

		// Token: 0x06000143 RID: 323 RVA: 0x00005230 File Offset: 0x00003430
		protected bool ValidateCertificate(global::System.Security.Cryptography.X509Certificates.X509Certificate2 leaf, global::System.Security.Cryptography.X509Certificates.X509Chain chain)
		{
			ValidationResult validationResult;
			do
			{
				ChainValidationHelper chainValidationHelper = this.certificateValidator;
				string text = this.<TargetHost>k__BackingField;
				bool flag = this.<IsServer>k__BackingField;
				validationResult = chainValidationHelper.ValidateCertificate(text, flag, leaf, chain);
			}
			while (validationResult == null);
			if (validationResult.trusted)
			{
				bool user_denied = validationResult.user_denied;
				return;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005274 File Offset: 0x00003474
		protected X509Certificate SelectClientCertificate(string[] acceptableIssuers)
		{
			if (true)
			{
			}
			if (this != null)
			{
				ChainValidationHelper chainValidationHelper = this.certificateValidator;
				string text = this.<TargetHost>k__BackingField;
				global::System.Security.Cryptography.X509Certificates.X509CertificateCollection x509CertificateCollection = this.<ClientCertificates>k__BackingField;
				global::System.Net.Security.LocalCertSelectionCallback certSelectionCallback = chainValidationHelper.certSelectionCallback;
				if (certSelectionCallback != null)
				{
					IntPtr invoke_impl = certSelectionCallback.invoke_impl;
					IntPtr method_code = certSelectionCallback.method_code;
					IntPtr method = certSelectionCallback.method;
				}
				global::System.Security.Cryptography.X509Certificates.X509CertificateCollection x509CertificateCollection2 = this.<ClientCertificates>k__BackingField;
				if (x509CertificateCollection2 != null && x509CertificateCollection2.Count != 0)
				{
					if (acceptableIssuers != null && certSelectionCallback != null)
					{
						int count = this.<ClientCertificates>k__BackingField.Count;
						long num = 0L;
						long num3;
						if (this.<ClientCertificates>k__BackingField[(int)num] != null)
						{
							global::System.Security.Cryptography.X509Certificates.X509ChainElementCollection x509ChainElementCollection;
							if (x509ChainElementCollection.Count != 0)
							{
								long num2 = 0L;
								global::System.Security.Cryptography.X509Certificates.X509ChainElementCollection x509ChainElementCollection2;
								int count2 = x509ChainElementCollection2.Count;
								global::System.Security.Cryptography.X509Certificates.X509ChainElementCollection x509ChainElementCollection3;
								string issuer = x509ChainElementCollection3[(int)num2].certificate.Issuer;
								num3 = 0L;
							}
							long num4 = 0L;
							int num5 = 15;
							if (num3 != 0L)
							{
							}
							if (num4 != 0L)
							{
								goto IL_00F5;
							}
							if (num5 != 0)
							{
								goto IL_00E0;
							}
						}
						int count3 = this.<ClientCertificates>k__BackingField.Count;
						while (num3 != 0L)
						{
						}
					}
				}
				IL_00E0:
				global::System.Security.Cryptography.X509Certificates.X509CertificateCollection x509CertificateCollection3 = this.<ClientCertificates>k__BackingField;
				long num6 = 0L;
				return x509CertificateCollection3[(int)num6];
			}
			IL_00F5:
			throw new OutOfMemoryException();
		}

		// Token: 0x06000145 RID: 325
		public abstract void Renegotiate();

		// Token: 0x06000146 RID: 326 RVA: 0x00005390 File Offset: 0x00003590
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000053A4 File Offset: 0x000035A4
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000053B4 File Offset: 0x000035B4
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x04000109 RID: 265
		private ChainValidationHelper certificateValidator;

		// Token: 0x0400010A RID: 266
		[CompilerGenerated]
		private readonly MonoSslAuthenticationOptions <Options>k__BackingField;

		// Token: 0x0400010B RID: 267
		[CompilerGenerated]
		private readonly MobileAuthenticatedStream <Parent>k__BackingField;

		// Token: 0x0400010C RID: 268
		[CompilerGenerated]
		private readonly bool <IsServer>k__BackingField;

		// Token: 0x0400010D RID: 269
		[CompilerGenerated]
		private readonly string <TargetHost>k__BackingField;

		// Token: 0x0400010E RID: 270
		[CompilerGenerated]
		private readonly string <ServerName>k__BackingField;

		// Token: 0x0400010F RID: 271
		[CompilerGenerated]
		private readonly bool <AskForClientCertificate>k__BackingField;

		// Token: 0x04000110 RID: 272
		[CompilerGenerated]
		private readonly global::System.Security.Authentication.SslProtocols <EnabledProtocols>k__BackingField;

		// Token: 0x04000111 RID: 273
		[CompilerGenerated]
		private readonly global::System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;

		// Token: 0x04000112 RID: 274
		[CompilerGenerated]
		private X509Certificate <LocalServerCertificate>k__BackingField;
	}
}
