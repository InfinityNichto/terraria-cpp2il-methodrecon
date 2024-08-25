using System;

namespace System.Net
{
	// Token: 0x02000130 RID: 304
	internal enum SecurityStatusPalErrorCode
	{
		// Token: 0x0400059A RID: 1434
		NotSet,
		// Token: 0x0400059B RID: 1435
		OK,
		// Token: 0x0400059C RID: 1436
		ContinueNeeded,
		// Token: 0x0400059D RID: 1437
		CompleteNeeded,
		// Token: 0x0400059E RID: 1438
		CompAndContinue,
		// Token: 0x0400059F RID: 1439
		ContextExpired,
		// Token: 0x040005A0 RID: 1440
		CredentialsNeeded,
		// Token: 0x040005A1 RID: 1441
		Renegotiate,
		// Token: 0x040005A2 RID: 1442
		OutOfMemory,
		// Token: 0x040005A3 RID: 1443
		InvalidHandle,
		// Token: 0x040005A4 RID: 1444
		Unsupported,
		// Token: 0x040005A5 RID: 1445
		TargetUnknown,
		// Token: 0x040005A6 RID: 1446
		InternalError,
		// Token: 0x040005A7 RID: 1447
		PackageNotFound,
		// Token: 0x040005A8 RID: 1448
		NotOwner,
		// Token: 0x040005A9 RID: 1449
		CannotInstall,
		// Token: 0x040005AA RID: 1450
		InvalidToken,
		// Token: 0x040005AB RID: 1451
		CannotPack,
		// Token: 0x040005AC RID: 1452
		QopNotSupported,
		// Token: 0x040005AD RID: 1453
		NoImpersonation,
		// Token: 0x040005AE RID: 1454
		LogonDenied,
		// Token: 0x040005AF RID: 1455
		UnknownCredentials,
		// Token: 0x040005B0 RID: 1456
		NoCredentials,
		// Token: 0x040005B1 RID: 1457
		MessageAltered,
		// Token: 0x040005B2 RID: 1458
		OutOfSequence,
		// Token: 0x040005B3 RID: 1459
		NoAuthenticatingAuthority,
		// Token: 0x040005B4 RID: 1460
		IncompleteMessage,
		// Token: 0x040005B5 RID: 1461
		IncompleteCredentials,
		// Token: 0x040005B6 RID: 1462
		BufferNotEnough,
		// Token: 0x040005B7 RID: 1463
		WrongPrincipal,
		// Token: 0x040005B8 RID: 1464
		TimeSkew,
		// Token: 0x040005B9 RID: 1465
		UntrustedRoot,
		// Token: 0x040005BA RID: 1466
		IllegalMessage,
		// Token: 0x040005BB RID: 1467
		CertUnknown,
		// Token: 0x040005BC RID: 1468
		CertExpired,
		// Token: 0x040005BD RID: 1469
		AlgorithmMismatch,
		// Token: 0x040005BE RID: 1470
		SecurityQosFailed,
		// Token: 0x040005BF RID: 1471
		SmartcardLogonRequired,
		// Token: 0x040005C0 RID: 1472
		UnsupportedPreauth,
		// Token: 0x040005C1 RID: 1473
		BadBinding,
		// Token: 0x040005C2 RID: 1474
		DowngradeDetected,
		// Token: 0x040005C3 RID: 1475
		ApplicationProtocolMismatch
	}
}
