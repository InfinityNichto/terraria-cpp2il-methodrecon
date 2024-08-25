using System;
using System.Collections;

namespace System.ComponentModel
{
	// Token: 0x0200037C RID: 892
	public interface IBindingList : IList, ICollection, IEnumerable
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001763 RID: 5987
		bool AllowNew { get; }

		// Token: 0x06001764 RID: 5988
		object AddNew();

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001765 RID: 5989
		bool AllowEdit { get; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001766 RID: 5990
		bool AllowRemove { get; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001767 RID: 5991
		bool SupportsChangeNotification { get; }

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001768 RID: 5992
		bool SupportsSearching { get; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001769 RID: 5993
		bool SupportsSorting { get; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600176A RID: 5994
		bool IsSorted { get; }

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600176B RID: 5995
		PropertyDescriptor SortProperty { get; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600176C RID: 5996
		ListSortDirection SortDirection { get; }

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600176D RID: 5997
		// (remove) Token: 0x0600176E RID: 5998
		event ListChangedEventHandler ListChanged;

		// Token: 0x0600176F RID: 5999
		void AddIndex(PropertyDescriptor property);

		// Token: 0x06001770 RID: 6000
		void ApplySort(PropertyDescriptor property, ListSortDirection direction);

		// Token: 0x06001771 RID: 6001
		int Find(PropertyDescriptor property, object key);

		// Token: 0x06001772 RID: 6002
		void RemoveIndex(PropertyDescriptor property);

		// Token: 0x06001773 RID: 6003
		void RemoveSort();
	}
}
