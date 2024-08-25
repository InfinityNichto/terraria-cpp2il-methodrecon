using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200036F RID: 879
	[ComVisible(true)]
	public interface IContributeDynamicSink
	{
		// Token: 0x06001D16 RID: 7446
		IDynamicMessageSink GetDynamicSink();
	}
}
