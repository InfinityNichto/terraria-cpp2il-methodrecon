using System;

namespace System.Collections
{
	// Token: 0x020005E3 RID: 1507
	public interface ICollection : IEnumerable
	{
		// Token: 0x06002DA3 RID: 11683
		void CopyTo(Array array, int index);

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002DA4 RID: 11684
		int Count { get; }

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002DA5 RID: 11685
		object SyncRoot { get; }

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002DA6 RID: 11686
		bool IsSynchronized { get; }
	}
}
