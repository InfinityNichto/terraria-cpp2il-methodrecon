using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000364 RID: 868
	[ComVisible(true)]
	public sealed class LifetimeServices
	{
		// Token: 0x06001CD1 RID: 7377 RVA: 0x0003EDD8 File Offset: 0x0003CFD8
		static LifetimeServices()
		{
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0003EDF0 File Offset: 0x0003CFF0
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0003EE04 File Offset: 0x0003D004
		public static TimeSpan LeaseManagerPollTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0003EE14 File Offset: 0x0003D014
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0003EE28 File Offset: 0x0003D028
		public static TimeSpan LeaseTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0003EE38 File Offset: 0x0003D038
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0003EE4C File Offset: 0x0003D04C
		public static TimeSpan RenewOnCallTime
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0003EE5C File Offset: 0x0003D05C
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0003EE70 File Offset: 0x0003D070
		public static TimeSpan SponsorshipTimeout
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0003EE80 File Offset: 0x0003D080
		internal static void TrackLifetime(ServerIdentity identity)
		{
			if (!true)
			{
			}
		}

		// Token: 0x04000E9C RID: 3740
		private static TimeSpan _leaseManagerPollTime;

		// Token: 0x04000E9D RID: 3741
		private static TimeSpan _leaseTime;

		// Token: 0x04000E9E RID: 3742
		private static TimeSpan _renewOnCallTime;

		// Token: 0x04000E9F RID: 3743
		private static TimeSpan _sponsorshipTimeout;

		// Token: 0x04000EA0 RID: 3744
		private static LeaseManager _leaseManager;
	}
}
