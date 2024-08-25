using System;

namespace System.Collections
{
	// Token: 0x020005E6 RID: 1510
	public interface IDictionaryEnumerator : IEnumerator
	{
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002DB3 RID: 11699
		object Key { get; }

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002DB4 RID: 11700
		object Value { get; }

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002DB5 RID: 11701
		DictionaryEntry Entry { get; }
	}
}
