using System;

namespace System.ComponentModel
{
	// Token: 0x02000388 RID: 904
	public interface ISupportInitializeNotification : ISupportInitialize
	{
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600179F RID: 6047
		bool IsInitialized { get; }

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060017A0 RID: 6048
		// (remove) Token: 0x060017A1 RID: 6049
		event EventHandler Initialized;
	}
}
