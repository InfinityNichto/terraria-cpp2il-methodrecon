using System;

namespace System.Net
{
	// Token: 0x020001A8 RID: 424
	internal enum ContextAttribute
	{
		// Token: 0x0400089B RID: 2203
		Sizes,
		// Token: 0x0400089C RID: 2204
		Names,
		// Token: 0x0400089D RID: 2205
		Lifespan,
		// Token: 0x0400089E RID: 2206
		DceInfo,
		// Token: 0x0400089F RID: 2207
		StreamSizes,
		// Token: 0x040008A0 RID: 2208
		Authority = 6,
		// Token: 0x040008A1 RID: 2209
		PackageInfo = 10,
		// Token: 0x040008A2 RID: 2210
		NegotiationInfo = 12,
		// Token: 0x040008A3 RID: 2211
		UniqueBindings = 25,
		// Token: 0x040008A4 RID: 2212
		EndpointBindings,
		// Token: 0x040008A5 RID: 2213
		ClientSpecifiedSpn,
		// Token: 0x040008A6 RID: 2214
		RemoteCertificate = 83,
		// Token: 0x040008A7 RID: 2215
		LocalCertificate,
		// Token: 0x040008A8 RID: 2216
		RootStore,
		// Token: 0x040008A9 RID: 2217
		IssuerListInfoEx = 89,
		// Token: 0x040008AA RID: 2218
		ConnectionInfo,
		// Token: 0x040008AB RID: 2219
		UiInfo = 104
	}
}
