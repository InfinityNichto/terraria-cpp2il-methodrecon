using System;

namespace System.Security.Authentication
{
	// Token: 0x020000E5 RID: 229
	[Flags]
	public enum SslProtocols
	{
		// Token: 0x0400042E RID: 1070
		None = 0,
		// Token: 0x0400042F RID: 1071
		Ssl2 = 12,
		// Token: 0x04000430 RID: 1072
		Ssl3 = 48,
		// Token: 0x04000431 RID: 1073
		Tls = 192,
		// Token: 0x04000432 RID: 1074
		[MonoTODO("unsupported")]
		Tls11 = 768,
		// Token: 0x04000433 RID: 1075
		[MonoTODO("unsupported")]
		Tls12 = 3072,
		// Token: 0x04000434 RID: 1076
		Tls13 = 12288,
		// Token: 0x04000435 RID: 1077
		Default = 240
	}
}
