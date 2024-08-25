using System;

namespace System.Net
{
	// Token: 0x0200019A RID: 410
	public interface ICredentialsByHost
	{
		// Token: 0x06000A65 RID: 2661
		NetworkCredential GetCredential(string host, int port, string authenticationType);
	}
}
