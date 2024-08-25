using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000371 RID: 881
	[ComVisible(true)]
	public interface IContributeObjectSink
	{
		// Token: 0x06001D18 RID: 7448
		IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
	}
}
