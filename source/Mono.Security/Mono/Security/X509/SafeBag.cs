using System;

namespace Mono.Security.X509
{
	// Token: 0x0200000D RID: 13
	internal class SafeBag
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002CAC File Offset: 0x00000EAC
		public SafeBag(string bagOID, ASN1 asn1)
		{
			this._bagOID = bagOID;
			this._asn1 = asn1;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002CD0 File Offset: 0x00000ED0
		public string BagOID
		{
			get
			{
				return this._bagOID;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public ASN1 ASN1
		{
			get
			{
				return this._asn1;
			}
		}

		// Token: 0x04000021 RID: 33
		private string _bagOID;

		// Token: 0x04000022 RID: 34
		private ASN1 _asn1;
	}
}
