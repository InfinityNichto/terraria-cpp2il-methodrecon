using System;

namespace System.Collections
{
	// Token: 0x020005E5 RID: 1509
	public interface IDictionary : ICollection, IEnumerable
	{
		// Token: 0x170006F9 RID: 1785
		object this[object key] { get; set; }

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002DAA RID: 11690
		ICollection Keys { get; }

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002DAB RID: 11691
		ICollection Values { get; }

		// Token: 0x06002DAC RID: 11692
		bool Contains(object key);

		// Token: 0x06002DAD RID: 11693
		void Add(object key, object value);

		// Token: 0x06002DAE RID: 11694
		void Clear();

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002DAF RID: 11695
		bool IsReadOnly { get; }

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002DB0 RID: 11696
		bool IsFixedSize { get; }

		// Token: 0x06002DB1 RID: 11697
		IDictionaryEnumerator GetEnumerator();

		// Token: 0x06002DB2 RID: 11698
		void Remove(object key);
	}
}
