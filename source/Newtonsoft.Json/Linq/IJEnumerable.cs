using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C0 RID: 192
	[Preserve]
	public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x17000156 RID: 342
		IJEnumerable<JToken> this[object key] { get; }
	}
}
