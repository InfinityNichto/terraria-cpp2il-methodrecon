using System;

namespace System.ComponentModel
{
	// Token: 0x020003CA RID: 970
	public interface IEditableObject
	{
		// Token: 0x060019C0 RID: 6592
		void BeginEdit();

		// Token: 0x060019C1 RID: 6593
		void EndEdit();

		// Token: 0x060019C2 RID: 6594
		void CancelEdit();
	}
}
