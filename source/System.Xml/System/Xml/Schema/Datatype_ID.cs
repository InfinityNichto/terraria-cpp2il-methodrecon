using System;

namespace System.Xml.Schema
{
	// Token: 0x02000105 RID: 261
	internal class Datatype_ID : Datatype_NCName
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0001BCA0 File Offset: 0x00019EA0
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Id;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0001BCB0 File Offset: 0x00019EB0
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.ID;
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		public Datatype_ID()
		{
		}
	}
}
