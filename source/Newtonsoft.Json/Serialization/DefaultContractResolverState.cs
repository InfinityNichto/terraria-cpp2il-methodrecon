using System;
using System.Collections.Generic;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000089 RID: 137
	[Preserve]
	internal class DefaultContractResolverState
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		public DefaultContractResolverState()
		{
		}

		// Token: 0x04000225 RID: 549
		public Dictionary<ResolverContractKey, JsonContract> ContractCache;

		// Token: 0x04000226 RID: 550
		public PropertyNameTable NameTable;
	}
}
