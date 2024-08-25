using System;

namespace System.Xml.Schema
{
	// Token: 0x020000F7 RID: 247
	internal class Datatype_day : Datatype_dateTimeBase
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0001B7C4 File Offset: 0x000199C4
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GDay;
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001B7D4 File Offset: 0x000199D4
		internal Datatype_day()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.GDay);
		}
	}
}
