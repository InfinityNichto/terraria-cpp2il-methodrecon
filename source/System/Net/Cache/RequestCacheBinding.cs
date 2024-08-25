using System;

namespace System.Net.Cache
{
	// Token: 0x020002E5 RID: 741
	internal class RequestCacheBinding
	{
		// Token: 0x060012F9 RID: 4857 RVA: 0x0003AC84 File Offset: 0x00038E84
		internal RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy)
		{
			this.m_RequestCache = requestCache;
			this.m_CacheValidator = cacheValidator;
			this.m_Policy = policy;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x0003ACAC File Offset: 0x00038EAC
		internal RequestCache Cache
		{
			get
			{
				return this.m_RequestCache;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0003ACC0 File Offset: 0x00038EC0
		internal RequestCacheValidator Validator
		{
			get
			{
				return this.m_CacheValidator;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x0003ACD4 File Offset: 0x00038ED4
		internal RequestCachePolicy Policy
		{
			get
			{
				return this.m_Policy;
			}
		}

		// Token: 0x04000F73 RID: 3955
		private RequestCache m_RequestCache;

		// Token: 0x04000F74 RID: 3956
		private RequestCacheValidator m_CacheValidator;

		// Token: 0x04000F75 RID: 3957
		private RequestCachePolicy m_Policy;
	}
}
