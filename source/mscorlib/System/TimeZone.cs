using System;
using System.Globalization;
using System.Threading;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000108 RID: 264
	[Obsolete("System.TimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo instead.")]
	[Serializable]
	public abstract class TimeZone
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0000207A File Offset: 0x0000027A
		private static object InternalSyncObject
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00017598 File Offset: 0x00015798
		protected TimeZone()
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x000175AC File Offset: 0x000157AC
		public static TimeZone CurrentTimeZone
		{
			get
			{
				object internalSyncObject = TimeZone.InternalSyncObject;
				long num = 0L;
				Monitor.Exit(internalSyncObject);
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x060009DA RID: 2522
		public abstract TimeSpan GetUtcOffset(DateTime time);

		// Token: 0x060009DB RID: 2523
		public abstract DaylightTime GetDaylightChanges(int year);

		// Token: 0x060009DC RID: 2524 RVA: 0x000175E8 File Offset: 0x000157E8
		internal static TimeSpan CalculateUtcOffset(DateTime time, DaylightTime daylightTimes)
		{
			if (daylightTimes != null)
			{
			}
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x040003CA RID: 970
		private static TimeZone currentTimeZone;

		// Token: 0x040003CB RID: 971
		private static object s_InternalSyncObject;
	}
}
