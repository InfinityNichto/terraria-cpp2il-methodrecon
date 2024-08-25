using System;

namespace System.Xml.Schema
{
	// Token: 0x020000F8 RID: 248
	internal class Datatype_month : Datatype_dateTimeBase
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0001B7EC File Offset: 0x000199EC
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GMonth;
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001B7FC File Offset: 0x000199FC
		internal Datatype_month()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.GMonth);
		}
	}
}
