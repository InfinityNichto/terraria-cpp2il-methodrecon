using System;

namespace System.ComponentModel
{
	// Token: 0x02000381 RID: 897
	public interface IDataErrorInfo
	{
		// Token: 0x1700055C RID: 1372
		string this[string columnName] { get; }

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001796 RID: 6038
		string Error { get; }
	}
}
