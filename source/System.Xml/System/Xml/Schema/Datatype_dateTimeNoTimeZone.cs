using System;

namespace System.Xml.Schema
{
	// Token: 0x020000ED RID: 237
	internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x0001B684 File Offset: 0x00019884
		internal Datatype_dateTimeNoTimeZone()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.XdrDateTimeNoTz);
		}
	}
}
