using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003AD RID: 941
	[ComVisible(true)]
	public interface IMessageSink
	{
		// Token: 0x06001E10 RID: 7696
		IMessage SyncProcessMessage(IMessage msg);

		// Token: 0x06001E11 RID: 7697
		IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
	}
}
