using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000373 RID: 883
	[ComVisible(true)]
	public interface IDynamicMessageSink
	{
		// Token: 0x06001D1A RID: 7450
		void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

		// Token: 0x06001D1B RID: 7451
		void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
	}
}
