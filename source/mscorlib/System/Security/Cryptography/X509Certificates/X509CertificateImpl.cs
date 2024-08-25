using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000323 RID: 803
	internal abstract class X509CertificateImpl : IDisposable
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001B2F RID: 6959
		public abstract bool IsValid { get; }

		// Token: 0x06001B30 RID: 6960 RVA: 0x0003A95C File Offset: 0x00038B5C
		protected void ThrowIfContextInvalid()
		{
		}

		// Token: 0x06001B31 RID: 6961
		public abstract X509CertificateImpl Clone();

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001B32 RID: 6962
		public abstract string Issuer { get; }

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001B33 RID: 6963
		public abstract string Subject { get; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001B34 RID: 6964
		public abstract byte[] RawData { get; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001B35 RID: 6965
		public abstract DateTime NotAfter { get; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001B36 RID: 6966
		public abstract DateTime NotBefore { get; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001B37 RID: 6967
		public abstract byte[] Thumbprint { get; }

		// Token: 0x06001B38 RID: 6968 RVA: 0x0003A970 File Offset: 0x00038B70
		public sealed override int GetHashCode()
		{
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001B39 RID: 6969
		public abstract string KeyAlgorithm { get; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001B3A RID: 6970
		public abstract byte[] KeyAlgorithmParameters { get; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001B3B RID: 6971
		public abstract byte[] PublicKeyValue { get; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001B3C RID: 6972
		public abstract byte[] SerialNumber { get; }

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001B3D RID: 6973
		public abstract bool HasPrivateKey { get; }

		// Token: 0x06001B3E RID: 6974
		public abstract RSA GetRSAPrivateKey();

		// Token: 0x06001B3F RID: 6975
		public abstract DSA GetDSAPrivateKey();

		// Token: 0x06001B40 RID: 6976
		public abstract X509CertificateImpl CopyWithPrivateKey(RSA privateKey);

		// Token: 0x06001B41 RID: 6977 RVA: 0x0003A984 File Offset: 0x00038B84
		public sealed override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0003A998 File Offset: 0x00038B98
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0003A9AC File Offset: 0x00038BAC
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0003A9BC File Offset: 0x00038BBC
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0003A9F0 File Offset: 0x00038BF0
		protected X509CertificateImpl()
		{
		}
	}
}
