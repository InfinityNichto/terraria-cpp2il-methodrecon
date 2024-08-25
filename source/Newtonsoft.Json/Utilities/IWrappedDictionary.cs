using System;
using System.Collections;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000061 RID: 97
	[Preserve]
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000376 RID: 886
		object UnderlyingDictionary { get; }
	}
}
