using System;

namespace System.Net.Cache
{
	// Token: 0x020002E6 RID: 742
	public enum RequestCacheLevel
	{
		// Token: 0x04000F77 RID: 3959
		Default,
		// Token: 0x04000F78 RID: 3960
		BypassCache,
		// Token: 0x04000F79 RID: 3961
		CacheOnly,
		// Token: 0x04000F7A RID: 3962
		CacheIfAvailable,
		// Token: 0x04000F7B RID: 3963
		Revalidate,
		// Token: 0x04000F7C RID: 3964
		Reload,
		// Token: 0x04000F7D RID: 3965
		NoCacheNoStore
	}
}
