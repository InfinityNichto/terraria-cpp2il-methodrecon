using System;

namespace System.Xml.Schema
{
	// Token: 0x02000100 RID: 256
	internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0001BBC8 File Offset: 0x00019DC8
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Token;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0001BBD8 File Offset: 0x00019DD8
		public Datatype_tokenV1Compat()
		{
		}
	}
}
