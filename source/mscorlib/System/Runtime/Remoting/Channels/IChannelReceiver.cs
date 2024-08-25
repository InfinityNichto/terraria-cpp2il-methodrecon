using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200037E RID: 894
	[ComVisible(true)]
	public interface IChannelReceiver : IChannel
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001D46 RID: 7494
		object ChannelData { get; }

		// Token: 0x06001D47 RID: 7495
		void StartListening(object data);
	}
}
