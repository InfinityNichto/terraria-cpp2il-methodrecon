using System;
using System.Collections;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005E RID: 94
	[Preserve]
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600033A RID: 826
		object UnderlyingCollection { get; }
	}
}
