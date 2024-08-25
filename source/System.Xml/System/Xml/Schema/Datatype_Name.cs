using System;

namespace System.Xml.Schema
{
	// Token: 0x02000103 RID: 259
	internal class Datatype_Name : Datatype_token
	{
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0001BC44 File Offset: 0x00019E44
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Name;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0001BC54 File Offset: 0x00019E54
		public Datatype_Name()
		{
		}
	}
}
