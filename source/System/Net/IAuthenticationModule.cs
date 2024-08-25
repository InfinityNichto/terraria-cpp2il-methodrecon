using System;

namespace System.Net
{
	// Token: 0x02000197 RID: 407
	public interface IAuthenticationModule
	{
		// Token: 0x06000A5F RID: 2655
		Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

		// Token: 0x06000A60 RID: 2656
		Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000A61 RID: 2657
		bool CanPreAuthenticate { get; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000A62 RID: 2658
		string AuthenticationType { get; }
	}
}
