using System;
using System.Diagnostics.Tracing;

namespace System.Collections.Concurrent
{
	// Token: 0x02000615 RID: 1557
	[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
	internal sealed class CDSCollectionETWBCLProvider : EventSource
	{
		// Token: 0x06002F77 RID: 12151 RVA: 0x00068864 File Offset: 0x00066A64
		private CDSCollectionETWBCLProvider()
		{
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x00068878 File Offset: 0x00066A78
		[Event(3, Level = EventLevel.Warning)]
		public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets)
		{
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00068888 File Offset: 0x00066A88
		// Note: this type is marked as 'beforefieldinit'.
		static CDSCollectionETWBCLProvider()
		{
		}

		// Token: 0x04001A2A RID: 6698
		public static CDSCollectionETWBCLProvider Log;
	}
}
