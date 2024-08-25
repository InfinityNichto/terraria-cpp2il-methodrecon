using System;
using System.Globalization;

namespace System
{
	// Token: 0x020000BB RID: 187
	internal struct ParsingInfo
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x00011B44 File Offset: 0x0000FD44
		internal void Init()
		{
		}

		// Token: 0x04000303 RID: 771
		internal Calendar calendar;

		// Token: 0x04000304 RID: 772
		internal int dayOfWeek;

		// Token: 0x04000305 RID: 773
		internal DateTimeParse.TM timeMark;

		// Token: 0x04000306 RID: 774
		internal bool fUseHour12;

		// Token: 0x04000307 RID: 775
		internal bool fUseTwoDigitYear;

		// Token: 0x04000308 RID: 776
		internal bool fAllowInnerWhite;

		// Token: 0x04000309 RID: 777
		internal bool fAllowTrailingWhite;

		// Token: 0x0400030A RID: 778
		internal bool fCustomNumberParser;

		// Token: 0x0400030B RID: 779
		internal DateTimeParse.MatchNumberDelegate parseNumberDelegate;
	}
}
