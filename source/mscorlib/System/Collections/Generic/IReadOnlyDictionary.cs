using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Collections.Generic
{
	// Token: 0x02000635 RID: 1589
	[DefaultMember("Item")]
	public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x06003099 RID: 12441
		bool TryGetValue(TKey key, [Out] TValue value);
	}
}
