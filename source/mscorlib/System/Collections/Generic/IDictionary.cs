using System;
using System.Runtime.InteropServices;

namespace System.Collections.Generic
{
	// Token: 0x0200062C RID: 1580
	public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		// Token: 0x170007CD RID: 1997
		TValue this[TKey key] { get; set; }

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06003089 RID: 12425
		ICollection<TKey> Keys { get; }

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600308A RID: 12426
		ICollection<TValue> Values { get; }

		// Token: 0x0600308B RID: 12427
		bool ContainsKey(TKey key);

		// Token: 0x0600308C RID: 12428
		void Add(TKey key, TValue value);

		// Token: 0x0600308D RID: 12429
		bool Remove(TKey key);

		// Token: 0x0600308E RID: 12430
		bool TryGetValue(TKey key, [Out] TValue value);
	}
}
