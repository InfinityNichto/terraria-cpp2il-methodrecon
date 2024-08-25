using System;

namespace System.Net
{
	// Token: 0x0200021E RID: 542
	public interface IWebProxy
	{
		// Token: 0x06000D98 RID: 3480
		global::System.Uri GetProxy(global::System.Uri destination);

		// Token: 0x06000D99 RID: 3481
		bool IsBypassed(global::System.Uri host);

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000D9A RID: 3482
		// (set) Token: 0x06000D9B RID: 3483
		ICredentials Credentials { get; set; }
	}
}
