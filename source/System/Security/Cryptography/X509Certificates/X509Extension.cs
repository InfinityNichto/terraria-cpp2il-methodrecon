using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000117 RID: 279
	public class X509Extension : AsnEncodedData
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x00018608 File Offset: 0x00016808
		protected X509Extension()
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001861C File Offset: 0x0001681C
		public X509Extension(string oid, byte[] rawData, bool critical)
			: base(oid, rawData)
		{
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00018634 File Offset: 0x00016834
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00018648 File Offset: 0x00016848
		public bool Critical
		{
			get
			{
				return this._critical;
			}
			set
			{
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00018658 File Offset: 0x00016858
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			while (asnEncodedData == null)
			{
			}
			base.CopyFrom(asnEncodedData);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001867C File Offset: 0x0001687C
		internal string FormatUnkownData(byte[] data)
		{
			for (;;)
			{
				int num = 1;
				if (data != null && num != 0)
				{
					return;
				}
			}
		}

		// Token: 0x0400052B RID: 1323
		private bool _critical;
	}
}
