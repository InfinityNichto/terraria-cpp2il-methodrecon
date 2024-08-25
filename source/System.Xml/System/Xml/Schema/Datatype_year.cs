using System;

namespace System.Xml.Schema
{
	// Token: 0x020000F5 RID: 245
	internal class Datatype_year : Datatype_dateTimeBase
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0001B774 File Offset: 0x00019974
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GYear;
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001B784 File Offset: 0x00019984
		internal Datatype_year()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.GYear);
		}
	}
}
