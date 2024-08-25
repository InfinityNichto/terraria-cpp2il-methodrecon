using System;

namespace System.Xml.Schema
{
	// Token: 0x0200010B RID: 267
	internal class Datatype_negativeInteger : Datatype_nonPositiveInteger
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0001BE84 File Offset: 0x0001A084
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0001BE98 File Offset: 0x0001A098
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NegativeInteger;
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		public Datatype_negativeInteger()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_negativeInteger()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040004EC RID: 1260
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
