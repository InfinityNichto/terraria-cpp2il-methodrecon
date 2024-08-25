using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200036E RID: 878
	[ComVisible(true)]
	public interface IContributeClientContextSink
	{
		// Token: 0x06001D15 RID: 7445
		IMessageSink GetClientContextSink(IMessageSink nextSink);
	}
}
