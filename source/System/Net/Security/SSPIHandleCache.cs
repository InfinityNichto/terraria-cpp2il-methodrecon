using System;
using System.Threading;

namespace System.Net.Security
{
	// Token: 0x02000311 RID: 785
	internal static class SSPIHandleCache
	{
		// Token: 0x06001484 RID: 5252 RVA: 0x0003E634 File Offset: 0x0003C834
		internal static void CacheCredential(SafeFreeCredentials newHandle)
		{
			int num = 1;
			if (SafeCredentialReference.CreateReference(newHandle) != null)
			{
				if (num == 0)
				{
				}
				if (Interlocked.Increment(42184592) != 0)
				{
				}
			}
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0003E67C File Offset: 0x0003C87C
		// Note: this type is marked as 'beforefieldinit'.
		static SSPIHandleCache()
		{
		}

		// Token: 0x04001118 RID: 4376
		private static SafeCredentialReference[] s_cacheSlots;

		// Token: 0x04001119 RID: 4377
		private static int s_current;
	}
}
