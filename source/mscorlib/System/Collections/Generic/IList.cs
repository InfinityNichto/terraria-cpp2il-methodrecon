using System;

namespace System.Collections.Generic
{
	// Token: 0x02000633 RID: 1587
	public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x170007D1 RID: 2001
		T this[int index] { get; set; }

		// Token: 0x06003095 RID: 12437
		int IndexOf(T item);

		// Token: 0x06003096 RID: 12438
		void Insert(int index, T item);

		// Token: 0x06003097 RID: 12439
		void RemoveAt(int index);
	}
}
