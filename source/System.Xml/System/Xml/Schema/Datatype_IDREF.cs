using System;

namespace System.Xml.Schema
{
	// Token: 0x02000106 RID: 262
	internal class Datatype_IDREF : Datatype_NCName
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0001BCD4 File Offset: 0x00019ED4
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Idref;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0001BCE4 File Offset: 0x00019EE4
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.IDREF;
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001BCF4 File Offset: 0x00019EF4
		public Datatype_IDREF()
		{
		}
	}
}
