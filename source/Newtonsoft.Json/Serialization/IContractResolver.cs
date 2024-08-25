using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000096 RID: 150
	[Preserve]
	public interface IContractResolver
	{
		// Token: 0x06000539 RID: 1337
		JsonContract ResolveContract(Type type);
	}
}
