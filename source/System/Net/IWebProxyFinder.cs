using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x0200019C RID: 412
	internal interface IWebProxyFinder : IDisposable
	{
		// Token: 0x06000A6D RID: 2669
		bool GetProxies(global::System.Uri destination, [Out] IList<string> proxyList);

		// Token: 0x06000A6E RID: 2670
		void Abort();

		// Token: 0x06000A6F RID: 2671
		void Reset();

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000A70 RID: 2672
		bool IsValid { get; }
	}
}
