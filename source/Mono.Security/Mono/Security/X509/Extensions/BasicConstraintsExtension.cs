using System;
using System.Globalization;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x02000035 RID: 53
	public class BasicConstraintsExtension : X509Extension
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00007B68 File Offset: 0x00005D68
		public BasicConstraintsExtension(X509Extension extension)
			: base(extension)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007B7C File Offset: 0x00005D7C
		protected override void Decode()
		{
			ASN1 extnValue = this.extnValue;
			this.pathLenConstraint = 1;
			byte[] value = extnValue.Value;
			ASN1 asn;
			if (asn != null)
			{
				byte nTag = asn.m_nTag;
				byte[] value2 = asn.Value;
				this.cA = nTag != 0;
				ASN1 asn2;
				if (asn2 != null)
				{
					byte nTag2 = asn2.m_nTag;
					int num = ASN1Convert.ToInt32(asn2);
					this.pathLenConstraint = num;
				}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007BDC File Offset: 0x00005DDC
		protected override void Encode()
		{
			if (this.cA && this.cA)
			{
				ASN1 asn = ASN1Convert.FromInt32(this.pathLenConstraint);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00007C08 File Offset: 0x00005E08
		public bool CertificateAuthority
		{
			get
			{
				return this.cA;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00007C1C File Offset: 0x00005E1C
		public override string Name
		{
			get
			{
				return "Basic Constraints";
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007C30 File Offset: 0x00005E30
		public override string ToString()
		{
			bool flag = this.cA;
			string newLine = Environment.NewLine;
			int num = this.pathLenConstraint;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			return text;
		}

		// Token: 0x040000BE RID: 190
		private bool cA;

		// Token: 0x040000BF RID: 191
		private int pathLenConstraint;
	}
}
