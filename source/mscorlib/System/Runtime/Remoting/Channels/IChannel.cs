using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200037C RID: 892
	[ComVisible(true)]
	public interface IChannel
	{
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001D44 RID: 7492
		string ChannelName { get; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001D45 RID: 7493
		int ChannelPriority { get; }
	}
}
