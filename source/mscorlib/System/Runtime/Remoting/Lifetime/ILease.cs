using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x0200035D RID: 861
	[ComVisible(true)]
	public interface ILease
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001CB4 RID: 7348
		TimeSpan CurrentLeaseTime { get; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001CB5 RID: 7349
		LeaseState CurrentState { get; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001CB6 RID: 7350
		TimeSpan RenewOnCallTime { get; }

		// Token: 0x06001CB7 RID: 7351
		TimeSpan Renew(TimeSpan renewalTime);
	}
}
