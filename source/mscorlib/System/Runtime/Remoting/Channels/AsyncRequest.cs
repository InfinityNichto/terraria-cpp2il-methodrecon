using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200037B RID: 891
	internal class AsyncRequest
	{
		// Token: 0x06001D43 RID: 7491 RVA: 0x00040018 File Offset: 0x0003E218
		public AsyncRequest(IMessage msgRequest, IMessageSink replySink)
		{
			this.ReplySink = replySink;
			this.MsgRequest = msgRequest;
		}

		// Token: 0x04000EC4 RID: 3780
		internal IMessageSink ReplySink;

		// Token: 0x04000EC5 RID: 3781
		internal IMessage MsgRequest;
	}
}
