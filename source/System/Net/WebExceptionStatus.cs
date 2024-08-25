using System;

namespace System.Net
{
	// Token: 0x020001CA RID: 458
	public enum WebExceptionStatus
	{
		// Token: 0x0400099E RID: 2462
		Success,
		// Token: 0x0400099F RID: 2463
		NameResolutionFailure,
		// Token: 0x040009A0 RID: 2464
		ConnectFailure,
		// Token: 0x040009A1 RID: 2465
		ReceiveFailure,
		// Token: 0x040009A2 RID: 2466
		SendFailure,
		// Token: 0x040009A3 RID: 2467
		PipelineFailure,
		// Token: 0x040009A4 RID: 2468
		RequestCanceled,
		// Token: 0x040009A5 RID: 2469
		ProtocolError,
		// Token: 0x040009A6 RID: 2470
		ConnectionClosed,
		// Token: 0x040009A7 RID: 2471
		TrustFailure,
		// Token: 0x040009A8 RID: 2472
		SecureChannelFailure,
		// Token: 0x040009A9 RID: 2473
		ServerProtocolViolation,
		// Token: 0x040009AA RID: 2474
		KeepAliveFailure,
		// Token: 0x040009AB RID: 2475
		Pending,
		// Token: 0x040009AC RID: 2476
		Timeout,
		// Token: 0x040009AD RID: 2477
		ProxyNameResolutionFailure,
		// Token: 0x040009AE RID: 2478
		UnknownError,
		// Token: 0x040009AF RID: 2479
		MessageLengthLimitExceeded,
		// Token: 0x040009B0 RID: 2480
		CacheEntryNotFound,
		// Token: 0x040009B1 RID: 2481
		RequestProhibitedByCachePolicy,
		// Token: 0x040009B2 RID: 2482
		RequestProhibitedByProxy
	}
}
