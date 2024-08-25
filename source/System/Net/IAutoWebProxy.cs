using System;

namespace System.Net
{
	// Token: 0x020001F5 RID: 501
	internal interface IAutoWebProxy : IWebProxy
	{
		// Token: 0x06000C5C RID: 3164
		ProxyChain GetProxies(global::System.Uri destination);
	}
}
