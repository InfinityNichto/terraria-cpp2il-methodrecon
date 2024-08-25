using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200037F RID: 895
	[ComVisible(true)]
	public interface IChannelSender : IChannel
	{
		// Token: 0x06001D48 RID: 7496
		IMessageSink CreateMessageSink(string url, object remoteChannelData, [Out] string objectURI);
	}
}
