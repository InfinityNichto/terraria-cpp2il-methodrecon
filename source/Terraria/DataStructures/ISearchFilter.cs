using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000627 RID: 1575
	public interface ISearchFilter<T> : IEntryFilter<T>
	{
		// Token: 0x060035F6 RID: 13814
		void SetSearch(string searchText);
	}
}
