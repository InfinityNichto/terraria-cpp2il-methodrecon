using System;

namespace System.Net
{
	// Token: 0x0200025E RID: 606
	public interface ICredentialPolicy
	{
		// Token: 0x06001058 RID: 4184
		bool ShouldSendCredential(global::System.Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authenticationModule);
	}
}
