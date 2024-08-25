using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x02000370 RID: 880
	[ComVisible(true)]
	public interface IContributeEnvoySink
	{
		// Token: 0x06001D17 RID: 7447
		IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);
	}
}
