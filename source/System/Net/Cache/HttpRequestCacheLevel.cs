using System;

namespace System.Net.Cache
{
	// Token: 0x020002E8 RID: 744
	public enum HttpRequestCacheLevel
	{
		// Token: 0x04000F80 RID: 3968
		Default,
		// Token: 0x04000F81 RID: 3969
		BypassCache,
		// Token: 0x04000F82 RID: 3970
		CacheOnly,
		// Token: 0x04000F83 RID: 3971
		CacheIfAvailable,
		// Token: 0x04000F84 RID: 3972
		Revalidate,
		// Token: 0x04000F85 RID: 3973
		Reload,
		// Token: 0x04000F86 RID: 3974
		NoCacheNoStore,
		// Token: 0x04000F87 RID: 3975
		CacheOrNextCacheOnly,
		// Token: 0x04000F88 RID: 3976
		Refresh
	}
}
