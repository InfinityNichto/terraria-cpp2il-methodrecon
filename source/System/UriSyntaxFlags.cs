using System;

namespace System
{
	// Token: 0x02000097 RID: 151
	[Flags]
	internal enum UriSyntaxFlags
	{
		// Token: 0x04000247 RID: 583
		None = 0,
		// Token: 0x04000248 RID: 584
		MustHaveAuthority = 1,
		// Token: 0x04000249 RID: 585
		OptionalAuthority = 2,
		// Token: 0x0400024A RID: 586
		MayHaveUserInfo = 4,
		// Token: 0x0400024B RID: 587
		MayHavePort = 8,
		// Token: 0x0400024C RID: 588
		MayHavePath = 16,
		// Token: 0x0400024D RID: 589
		MayHaveQuery = 32,
		// Token: 0x0400024E RID: 590
		MayHaveFragment = 64,
		// Token: 0x0400024F RID: 591
		AllowEmptyHost = 128,
		// Token: 0x04000250 RID: 592
		AllowUncHost = 256,
		// Token: 0x04000251 RID: 593
		AllowDnsHost = 512,
		// Token: 0x04000252 RID: 594
		AllowIPv4Host = 1024,
		// Token: 0x04000253 RID: 595
		AllowIPv6Host = 2048,
		// Token: 0x04000254 RID: 596
		AllowAnInternetHost = 3584,
		// Token: 0x04000255 RID: 597
		AllowAnyOtherHost = 4096,
		// Token: 0x04000256 RID: 598
		FileLikeUri = 8192,
		// Token: 0x04000257 RID: 599
		MailToLikeUri = 16384,
		// Token: 0x04000258 RID: 600
		V1_UnknownUri = 65536,
		// Token: 0x04000259 RID: 601
		SimpleUserSyntax = 131072,
		// Token: 0x0400025A RID: 602
		BuiltInSyntax = 262144,
		// Token: 0x0400025B RID: 603
		ParserSchemeOnly = 524288,
		// Token: 0x0400025C RID: 604
		AllowDOSPath = 1048576,
		// Token: 0x0400025D RID: 605
		PathIsRooted = 2097152,
		// Token: 0x0400025E RID: 606
		ConvertPathSlashes = 4194304,
		// Token: 0x0400025F RID: 607
		CompressPath = 8388608,
		// Token: 0x04000260 RID: 608
		CanonicalizeAsFilePath = 16777216,
		// Token: 0x04000261 RID: 609
		UnEscapeDotsAndSlashes = 33554432,
		// Token: 0x04000262 RID: 610
		AllowIdn = 67108864,
		// Token: 0x04000263 RID: 611
		AllowIriParsing = 268435456
	}
}
