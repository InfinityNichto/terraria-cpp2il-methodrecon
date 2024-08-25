using System;
using System.Collections;

namespace System.ComponentModel
{
	// Token: 0x0200037D RID: 893
	public interface IBindingListView : IBindingList, IList, ICollection, IEnumerable
	{
		// Token: 0x06001774 RID: 6004
		void ApplySort(ListSortDescriptionCollection sorts);

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001775 RID: 6005
		// (set) Token: 0x06001776 RID: 6006
		string Filter { get; set; }

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001777 RID: 6007
		ListSortDescriptionCollection SortDescriptions { get; }

		// Token: 0x06001778 RID: 6008
		void RemoveFilter();

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001779 RID: 6009
		bool SupportsAdvancedSorting { get; }

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600177A RID: 6010
		bool SupportsFiltering { get; }
	}
}
