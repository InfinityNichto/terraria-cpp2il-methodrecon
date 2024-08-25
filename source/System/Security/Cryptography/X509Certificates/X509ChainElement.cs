using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200010F RID: 271
	public class X509ChainElement
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x00017450 File Offset: 0x00015650
		internal X509ChainElement(X509Certificate2 certificate)
		{
			this.certificate = certificate;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0001746C File Offset: 0x0001566C
		public X509Certificate2 Certificate
		{
			get
			{
				return this.certificate;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00017480 File Offset: 0x00015680
		public X509ChainStatus[] ChainElementStatus
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00017494 File Offset: 0x00015694
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x000174A8 File Offset: 0x000156A8
		internal X509ChainStatusFlags StatusFlags
		{
			get
			{
				return this.compressed_status_flags;
			}
			set
			{
				this.compressed_status_flags = value;
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000174BC File Offset: 0x000156BC
		private int Count(X509ChainStatusFlags flags)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000174CC File Offset: 0x000156CC
		private void Set(X509ChainStatus[] status, int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask)
		{
			string information = X509ChainStatus.GetInformation(mask);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000174E4 File Offset: 0x000156E4
		internal void UncompressFlags()
		{
			if (this.compressed_status_flags != X509ChainStatusFlags.NoError)
			{
				X509Certificate2 x509Certificate = this.certificate;
				return;
			}
		}

		// Token: 0x04000508 RID: 1288
		private X509Certificate2 certificate;

		// Token: 0x04000509 RID: 1289
		private X509ChainStatus[] status;

		// Token: 0x0400050A RID: 1290
		private string info;

		// Token: 0x0400050B RID: 1291
		private X509ChainStatusFlags compressed_status_flags;
	}
}
