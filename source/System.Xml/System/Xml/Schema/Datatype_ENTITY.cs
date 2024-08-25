using System;

namespace System.Xml.Schema
{
	// Token: 0x02000107 RID: 263
	internal class Datatype_ENTITY : Datatype_NCName
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0001BD08 File Offset: 0x00019F08
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Entity;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0001BD18 File Offset: 0x00019F18
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.ENTITY;
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0001BD28 File Offset: 0x00019F28
		public Datatype_ENTITY()
		{
		}
	}
}
