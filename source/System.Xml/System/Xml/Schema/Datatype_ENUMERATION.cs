using System;

namespace System.Xml.Schema
{
	// Token: 0x02000119 RID: 281
	internal class Datatype_ENUMERATION : Datatype_NMTOKEN
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0001C530 File Offset: 0x0001A730
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.ENUMERATION;
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0001C540 File Offset: 0x0001A740
		public Datatype_ENUMERATION()
		{
		}
	}
}
