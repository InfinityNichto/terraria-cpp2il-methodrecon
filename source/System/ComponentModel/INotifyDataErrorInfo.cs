using System;
using System.Collections;

namespace System.ComponentModel
{
	// Token: 0x020003CD RID: 973
	public interface INotifyDataErrorInfo
	{
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060019C6 RID: 6598
		bool HasErrors { get; }

		// Token: 0x060019C7 RID: 6599
		IEnumerable GetErrors(string propertyName);

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060019C8 RID: 6600
		// (remove) Token: 0x060019C9 RID: 6601
		event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
	}
}
