using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000114 RID: 276
	public sealed class X509ChainPolicy
	{
		// Token: 0x0600067E RID: 1662 RVA: 0x00018258 File Offset: 0x00016458
		public X509ChainPolicy()
		{
			this.Reset();
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00018274 File Offset: 0x00016474
		public X509Certificate2Collection ExtraStore
		{
			get
			{
				for (;;)
				{
					if (this.store2 == null)
					{
						X509CertificateCollection x509CertificateCollection = this.store;
						if (x509CertificateCollection == null)
						{
							break;
						}
						X509CertificateCollection.X509CertificateEnumerator enumerator = x509CertificateCollection.GetEnumerator();
						bool flag = enumerator.MoveNext();
						X509Certificate x509Certificate = enumerator.Current;
						X509Certificate2Collection x509Certificate2Collection = this.store2;
						long num = 0L;
						int num2 = 3;
						if (enumerator != null)
						{
						}
						if (num != 0L)
						{
							goto IL_0047;
						}
						if (num2 == 0)
						{
							break;
						}
					}
				}
				return this.store2;
				IL_0047:
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x000182E0 File Offset: 0x000164E0
		public X509RevocationFlag RevocationFlag
		{
			get
			{
				return this.rflag;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000182F4 File Offset: 0x000164F4
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00018308 File Offset: 0x00016508
		public X509RevocationMode RevocationMode
		{
			get
			{
				return this.mode;
			}
			set
			{
				this.mode = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001831C File Offset: 0x0001651C
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00018330 File Offset: 0x00016530
		public X509VerificationFlags VerificationFlags
		{
			get
			{
				return this.vflags;
			}
			set
			{
				this.vflags = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00018344 File Offset: 0x00016544
		public DateTime VerificationTime
		{
			get
			{
				DateTime dateTime = this.vtime;
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001835C File Offset: 0x0001655C
		public void Reset()
		{
			DateTime now = DateTime.Now;
			this.vtime = now;
		}

		// Token: 0x0400051E RID: 1310
		private OidCollection apps;

		// Token: 0x0400051F RID: 1311
		private OidCollection cert;

		// Token: 0x04000520 RID: 1312
		private X509CertificateCollection store;

		// Token: 0x04000521 RID: 1313
		private X509Certificate2Collection store2;

		// Token: 0x04000522 RID: 1314
		private X509RevocationFlag rflag;

		// Token: 0x04000523 RID: 1315
		private X509RevocationMode mode;

		// Token: 0x04000524 RID: 1316
		private TimeSpan timeout;

		// Token: 0x04000525 RID: 1317
		private X509VerificationFlags vflags;

		// Token: 0x04000526 RID: 1318
		private DateTime vtime;
	}
}
