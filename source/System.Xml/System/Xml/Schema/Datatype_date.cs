using System;

namespace System.Xml.Schema
{
	// Token: 0x020000F3 RID: 243
	internal class Datatype_date : Datatype_dateTimeBase
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0001B724 File Offset: 0x00019924
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Date;
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0001B734 File Offset: 0x00019934
		internal Datatype_date()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.Date);
		}
	}
}
