using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000372 RID: 882
	[ComVisible(true)]
	public interface IContributeServerContextSink
	{
		// Token: 0x06001D19 RID: 7449
		IMessageSink GetServerContextSink(IMessageSink nextSink);
	}
}
