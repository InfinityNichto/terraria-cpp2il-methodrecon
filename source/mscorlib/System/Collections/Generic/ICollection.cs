using System;

namespace System.Collections.Generic
{
	// Token: 0x02000629 RID: 1577
	public interface ICollection<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600307F RID: 12415
		int Count { get; }

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06003080 RID: 12416
		bool IsReadOnly { get; }

		// Token: 0x06003081 RID: 12417
		void Add(T item);

		// Token: 0x06003082 RID: 12418
		void Clear();

		// Token: 0x06003083 RID: 12419
		bool Contains(T item);

		// Token: 0x06003084 RID: 12420
		void CopyTo(T[] array, int arrayIndex);

		// Token: 0x06003085 RID: 12421
		bool Remove(T item);
	}
}
