using System;

namespace System.ComponentModel
{
	// Token: 0x020003C9 RID: 969
	public interface IChangeTracking
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060019BE RID: 6590
		bool IsChanged { get; }

		// Token: 0x060019BF RID: 6591
		void AcceptChanges();
	}
}
