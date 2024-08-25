using System;

namespace System.Globalization
{
	// Token: 0x0200058F RID: 1423
	[Serializable]
	public class DaylightTime
	{
		// Token: 0x06002B1A RID: 11034 RVA: 0x0005E418 File Offset: 0x0005C618
		public DaylightTime(DateTime start, DateTime end, TimeSpan delta)
		{
			this._start = start;
			this._end = end;
			this._delta = delta;
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x0005E440 File Offset: 0x0005C640
		public DateTime Start
		{
			get
			{
				DateTime start = this._start;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x0005E458 File Offset: 0x0005C658
		public DateTime End
		{
			get
			{
				DateTime end = this._end;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x0005E470 File Offset: 0x0005C670
		public TimeSpan Delta
		{
			get
			{
				TimeSpan delta = this._delta;
				TimeSpan timeSpan;
				return timeSpan;
			}
		}

		// Token: 0x04001770 RID: 6000
		private readonly DateTime _start;

		// Token: 0x04001771 RID: 6001
		private readonly DateTime _end;

		// Token: 0x04001772 RID: 6002
		private readonly TimeSpan _delta;
	}
}
