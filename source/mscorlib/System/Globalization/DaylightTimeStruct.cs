using System;

namespace System.Globalization
{
	// Token: 0x02000590 RID: 1424
	internal readonly struct DaylightTimeStruct
	{
		// Token: 0x06002B1E RID: 11038 RVA: 0x0005E488 File Offset: 0x0005C688
		public DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta)
		{
			this.Start = start;
			this.End = end;
			this.Delta = delta;
		}

		// Token: 0x04001773 RID: 6003
		public readonly DateTime Start;

		// Token: 0x04001774 RID: 6004
		public readonly DateTime End;

		// Token: 0x04001775 RID: 6005
		public readonly TimeSpan Delta;
	}
}
