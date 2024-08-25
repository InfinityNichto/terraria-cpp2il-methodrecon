using System;
using System.Security.Authentication;

namespace System.Net
{
	// Token: 0x0200012E RID: 302
	internal static class SecurityProtocol
	{
		// Token: 0x04000595 RID: 1429
		public const global::System.Security.Authentication.SslProtocols DefaultSecurityProtocols = global::System.Security.Authentication.SslProtocols.Tls | global::System.Security.Authentication.SslProtocols.Tls11 | global::System.Security.Authentication.SslProtocols.Tls12;

		// Token: 0x04000596 RID: 1430
		public const global::System.Security.Authentication.SslProtocols SystemDefaultSecurityProtocols = global::System.Security.Authentication.SslProtocols.None;
	}
}
