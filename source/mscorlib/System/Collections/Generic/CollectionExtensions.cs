using System;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000643 RID: 1603
	public static class CollectionExtensions
	{
		// Token: 0x06003102 RID: 12546 RVA: 0x0000207A File Offset: 0x0000027A
		public static TValue GetValueOrDefault<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x0000207A File Offset: 0x0000027A
		public static TValue GetValueOrDefault<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
