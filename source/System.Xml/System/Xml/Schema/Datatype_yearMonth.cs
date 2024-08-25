using System;

namespace System.Xml.Schema
{
	// Token: 0x020000F4 RID: 244
	internal class Datatype_yearMonth : Datatype_dateTimeBase
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0001B74C File Offset: 0x0001994C
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GYearMonth;
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0001B75C File Offset: 0x0001995C
		internal Datatype_yearMonth()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.GYearMonth);
		}
	}
}
