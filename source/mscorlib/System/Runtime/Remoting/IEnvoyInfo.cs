using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x0200033D RID: 829
	[ComVisible(true)]
	public interface IEnvoyInfo
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001BBC RID: 7100
		IMessageSink EnvoySinks { get; }
	}
}
