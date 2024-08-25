using System;

namespace System.Xml.Schema
{
	// Token: 0x020000F2 RID: 242
	internal class Datatype_time : Datatype_dateTimeBase
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0001B6FC File Offset: 0x000198FC
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Time;
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0001B70C File Offset: 0x0001990C
		internal Datatype_time()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.Time);
		}
	}
}
