using System;

namespace System
{
	// Token: 0x0200008E RID: 142
	internal enum ParsingError
	{
		// Token: 0x0400020C RID: 524
		None,
		// Token: 0x0400020D RID: 525
		BadFormat,
		// Token: 0x0400020E RID: 526
		BadScheme,
		// Token: 0x0400020F RID: 527
		BadAuthority,
		// Token: 0x04000210 RID: 528
		EmptyUriString,
		// Token: 0x04000211 RID: 529
		LastRelativeUriOkErrIndex = 4,
		// Token: 0x04000212 RID: 530
		SchemeLimit,
		// Token: 0x04000213 RID: 531
		SizeLimit,
		// Token: 0x04000214 RID: 532
		MustRootedPath,
		// Token: 0x04000215 RID: 533
		BadHostName,
		// Token: 0x04000216 RID: 534
		NonEmptyHost,
		// Token: 0x04000217 RID: 535
		BadPort,
		// Token: 0x04000218 RID: 536
		BadAuthorityTerminator,
		// Token: 0x04000219 RID: 537
		CannotCreateRelative
	}
}
