using System;

namespace System.Net
{
	// Token: 0x0200013D RID: 317
	public enum HttpStatusCode
	{
		// Token: 0x040005F3 RID: 1523
		Continue = 100,
		// Token: 0x040005F4 RID: 1524
		SwitchingProtocols,
		// Token: 0x040005F5 RID: 1525
		Processing,
		// Token: 0x040005F6 RID: 1526
		EarlyHints,
		// Token: 0x040005F7 RID: 1527
		OK = 200,
		// Token: 0x040005F8 RID: 1528
		Created,
		// Token: 0x040005F9 RID: 1529
		Accepted,
		// Token: 0x040005FA RID: 1530
		NonAuthoritativeInformation,
		// Token: 0x040005FB RID: 1531
		NoContent,
		// Token: 0x040005FC RID: 1532
		ResetContent,
		// Token: 0x040005FD RID: 1533
		PartialContent,
		// Token: 0x040005FE RID: 1534
		MultiStatus,
		// Token: 0x040005FF RID: 1535
		AlreadyReported,
		// Token: 0x04000600 RID: 1536
		IMUsed = 226,
		// Token: 0x04000601 RID: 1537
		MultipleChoices = 300,
		// Token: 0x04000602 RID: 1538
		Ambiguous = 300,
		// Token: 0x04000603 RID: 1539
		MovedPermanently,
		// Token: 0x04000604 RID: 1540
		Moved = 301,
		// Token: 0x04000605 RID: 1541
		Found,
		// Token: 0x04000606 RID: 1542
		Redirect = 302,
		// Token: 0x04000607 RID: 1543
		SeeOther,
		// Token: 0x04000608 RID: 1544
		RedirectMethod = 303,
		// Token: 0x04000609 RID: 1545
		NotModified,
		// Token: 0x0400060A RID: 1546
		UseProxy,
		// Token: 0x0400060B RID: 1547
		Unused,
		// Token: 0x0400060C RID: 1548
		TemporaryRedirect,
		// Token: 0x0400060D RID: 1549
		RedirectKeepVerb = 307,
		// Token: 0x0400060E RID: 1550
		PermanentRedirect,
		// Token: 0x0400060F RID: 1551
		BadRequest = 400,
		// Token: 0x04000610 RID: 1552
		Unauthorized,
		// Token: 0x04000611 RID: 1553
		PaymentRequired,
		// Token: 0x04000612 RID: 1554
		Forbidden,
		// Token: 0x04000613 RID: 1555
		NotFound,
		// Token: 0x04000614 RID: 1556
		MethodNotAllowed,
		// Token: 0x04000615 RID: 1557
		NotAcceptable,
		// Token: 0x04000616 RID: 1558
		ProxyAuthenticationRequired,
		// Token: 0x04000617 RID: 1559
		RequestTimeout,
		// Token: 0x04000618 RID: 1560
		Conflict,
		// Token: 0x04000619 RID: 1561
		Gone,
		// Token: 0x0400061A RID: 1562
		LengthRequired,
		// Token: 0x0400061B RID: 1563
		PreconditionFailed,
		// Token: 0x0400061C RID: 1564
		RequestEntityTooLarge,
		// Token: 0x0400061D RID: 1565
		RequestUriTooLong,
		// Token: 0x0400061E RID: 1566
		UnsupportedMediaType,
		// Token: 0x0400061F RID: 1567
		RequestedRangeNotSatisfiable,
		// Token: 0x04000620 RID: 1568
		ExpectationFailed,
		// Token: 0x04000621 RID: 1569
		MisdirectedRequest = 421,
		// Token: 0x04000622 RID: 1570
		UnprocessableEntity,
		// Token: 0x04000623 RID: 1571
		Locked,
		// Token: 0x04000624 RID: 1572
		FailedDependency,
		// Token: 0x04000625 RID: 1573
		UpgradeRequired = 426,
		// Token: 0x04000626 RID: 1574
		PreconditionRequired = 428,
		// Token: 0x04000627 RID: 1575
		TooManyRequests,
		// Token: 0x04000628 RID: 1576
		RequestHeaderFieldsTooLarge = 431,
		// Token: 0x04000629 RID: 1577
		UnavailableForLegalReasons = 451,
		// Token: 0x0400062A RID: 1578
		InternalServerError = 500,
		// Token: 0x0400062B RID: 1579
		NotImplemented,
		// Token: 0x0400062C RID: 1580
		BadGateway,
		// Token: 0x0400062D RID: 1581
		ServiceUnavailable,
		// Token: 0x0400062E RID: 1582
		GatewayTimeout,
		// Token: 0x0400062F RID: 1583
		HttpVersionNotSupported,
		// Token: 0x04000630 RID: 1584
		VariantAlsoNegotiates,
		// Token: 0x04000631 RID: 1585
		InsufficientStorage,
		// Token: 0x04000632 RID: 1586
		LoopDetected,
		// Token: 0x04000633 RID: 1587
		NotExtended = 510,
		// Token: 0x04000634 RID: 1588
		NetworkAuthenticationRequired
	}
}
