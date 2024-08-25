using System;

namespace System.Net
{
	// Token: 0x02000159 RID: 345
	[Flags]
	public enum SecurityProtocolType
	{
		// Token: 0x040006FC RID: 1788
		SystemDefault = 0,
		// Token: 0x040006FD RID: 1789
		Ssl3 = 48,
		// Token: 0x040006FE RID: 1790
		Tls = 192,
		// Token: 0x040006FF RID: 1791
		Tls11 = 768,
		// Token: 0x04000700 RID: 1792
		Tls12 = 3072,
		// Token: 0x04000701 RID: 1793
		Tls13 = 12288
	}
}
