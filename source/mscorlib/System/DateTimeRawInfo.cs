using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000B7 RID: 183
	internal struct DateTimeRawInfo
	{
		// Token: 0x0600071C RID: 1820 RVA: 0x00011A14 File Offset: 0x0000FC14
		internal unsafe void Init(int* numberBuffer)
		{
			this.num = numberBuffer;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00011A28 File Offset: 0x0000FC28
		internal void AddNumber(int value)
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0000207A File Offset: 0x0000027A
		internal int GetNumber(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040002CF RID: 719
		private unsafe int* num;

		// Token: 0x040002D0 RID: 720
		internal int numCount;

		// Token: 0x040002D1 RID: 721
		internal int month;

		// Token: 0x040002D2 RID: 722
		internal int year;

		// Token: 0x040002D3 RID: 723
		internal int dayOfWeek;

		// Token: 0x040002D4 RID: 724
		internal int era;

		// Token: 0x040002D5 RID: 725
		internal DateTimeParse.TM timeMark;

		// Token: 0x040002D6 RID: 726
		internal double fraction;

		// Token: 0x040002D7 RID: 727
		internal bool hasSameDateAndTimeSeparators;
	}
}
