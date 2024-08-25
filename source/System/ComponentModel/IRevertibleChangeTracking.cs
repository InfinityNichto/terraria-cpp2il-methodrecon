using System;

namespace System.ComponentModel
{
	// Token: 0x020003CB RID: 971
	public interface IRevertibleChangeTracking : IChangeTracking
	{
		// Token: 0x060019C3 RID: 6595
		void RejectChanges();
	}
}
