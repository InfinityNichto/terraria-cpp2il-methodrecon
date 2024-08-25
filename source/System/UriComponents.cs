using System;

namespace System
{
	// Token: 0x0200008B RID: 139
	[Flags]
	public enum UriComponents
	{
		// Token: 0x040001F2 RID: 498
		Scheme = 1,
		// Token: 0x040001F3 RID: 499
		UserInfo = 2,
		// Token: 0x040001F4 RID: 500
		Host = 4,
		// Token: 0x040001F5 RID: 501
		Port = 8,
		// Token: 0x040001F6 RID: 502
		Path = 16,
		// Token: 0x040001F7 RID: 503
		Query = 32,
		// Token: 0x040001F8 RID: 504
		Fragment = 64,
		// Token: 0x040001F9 RID: 505
		StrongPort = 128,
		// Token: 0x040001FA RID: 506
		NormalizedHost = 256,
		// Token: 0x040001FB RID: 507
		KeepDelimiter = 1073741824,
		// Token: 0x040001FC RID: 508
		SerializationInfoString = -2147483648,
		// Token: 0x040001FD RID: 509
		AbsoluteUri = 127,
		// Token: 0x040001FE RID: 510
		HostAndPort = 132,
		// Token: 0x040001FF RID: 511
		StrongAuthority = 134,
		// Token: 0x04000200 RID: 512
		SchemeAndServer = 13,
		// Token: 0x04000201 RID: 513
		HttpRequestUrl = 61,
		// Token: 0x04000202 RID: 514
		PathAndQuery = 48
	}
}
