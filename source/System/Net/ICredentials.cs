using System;

namespace System.Net
{
	// Token: 0x02000199 RID: 409
	public interface ICredentials
	{
		// Token: 0x06000A64 RID: 2660
		NetworkCredential GetCredential(global::System.Uri uri, string authType);
	}
}
