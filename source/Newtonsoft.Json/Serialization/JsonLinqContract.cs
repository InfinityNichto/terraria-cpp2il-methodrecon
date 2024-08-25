using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000083 RID: 131
	[Preserve]
	public class JsonLinqContract : JsonContract
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public JsonLinqContract(Type underlyingType)
			: base(underlyingType)
		{
			this.ContractType = JsonContractType.Linq;
		}
	}
}
