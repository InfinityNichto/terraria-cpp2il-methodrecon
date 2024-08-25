using System;

namespace System.Xml.Schema
{
	// Token: 0x020000F6 RID: 246
	internal class Datatype_monthDay : Datatype_dateTimeBase
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0001B79C File Offset: 0x0001999C
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GMonthDay;
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0001B7AC File Offset: 0x000199AC
		internal Datatype_monthDay()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.GMonthDay);
		}
	}
}
