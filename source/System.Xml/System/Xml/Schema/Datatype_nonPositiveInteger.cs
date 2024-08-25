using System;

namespace System.Xml.Schema
{
	// Token: 0x0200010A RID: 266
	internal class Datatype_nonPositiveInteger : Datatype_integer
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0001BE3C File Offset: 0x0001A03C
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0001BE50 File Offset: 0x0001A050
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NonPositiveInteger;
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0001BE60 File Offset: 0x0001A060
		public Datatype_nonPositiveInteger()
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0001BE74 File Offset: 0x0001A074
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_nonPositiveInteger()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040004EB RID: 1259
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
