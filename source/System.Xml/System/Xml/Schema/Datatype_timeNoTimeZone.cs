using System;

namespace System.Xml.Schema
{
	// Token: 0x020000F0 RID: 240
	internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x060008F8 RID: 2296 RVA: 0x0001B6C8 File Offset: 0x000198C8
		internal Datatype_timeNoTimeZone()
		{
			if (!true)
			{
			}
			base..ctor(XsdDateTimeFlags.XdrTimeNoTz);
		}
	}
}
