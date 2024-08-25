using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000AF RID: 175
	[Preserve]
	public class JsonStringContract : JsonPrimitiveContract
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		public JsonStringContract(Type underlyingType)
		{
			if (!true)
			{
			}
			base..ctor(underlyingType);
			this.ContractType = JsonContractType.String;
		}
	}
}
