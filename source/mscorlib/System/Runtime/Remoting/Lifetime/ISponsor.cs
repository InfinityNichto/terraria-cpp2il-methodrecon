using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x0200035E RID: 862
	[ComVisible(true)]
	public interface ISponsor
	{
		// Token: 0x06001CB8 RID: 7352
		TimeSpan Renewal(ILease lease);
	}
}
