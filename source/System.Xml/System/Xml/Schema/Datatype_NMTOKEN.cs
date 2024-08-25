using System;

namespace System.Xml.Schema
{
	// Token: 0x02000102 RID: 258
	internal class Datatype_NMTOKEN : Datatype_token
	{
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0001BC10 File Offset: 0x00019E10
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NmToken;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0001BC20 File Offset: 0x00019E20
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.NMTOKEN;
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0001BC30 File Offset: 0x00019E30
		public Datatype_NMTOKEN()
		{
		}
	}
}
