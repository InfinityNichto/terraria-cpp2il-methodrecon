using System;

namespace System.Net
{
	// Token: 0x02000124 RID: 292
	[Flags]
	internal enum ContextFlagsPal
	{
		// Token: 0x04000550 RID: 1360
		None = 0,
		// Token: 0x04000551 RID: 1361
		Delegate = 1,
		// Token: 0x04000552 RID: 1362
		MutualAuth = 2,
		// Token: 0x04000553 RID: 1363
		ReplayDetect = 4,
		// Token: 0x04000554 RID: 1364
		SequenceDetect = 8,
		// Token: 0x04000555 RID: 1365
		Confidentiality = 16,
		// Token: 0x04000556 RID: 1366
		UseSessionKey = 32,
		// Token: 0x04000557 RID: 1367
		AllocateMemory = 256,
		// Token: 0x04000558 RID: 1368
		Connection = 2048,
		// Token: 0x04000559 RID: 1369
		InitExtendedError = 16384,
		// Token: 0x0400055A RID: 1370
		AcceptExtendedError = 32768,
		// Token: 0x0400055B RID: 1371
		InitStream = 32768,
		// Token: 0x0400055C RID: 1372
		AcceptStream = 65536,
		// Token: 0x0400055D RID: 1373
		InitIntegrity = 65536,
		// Token: 0x0400055E RID: 1374
		AcceptIntegrity = 131072,
		// Token: 0x0400055F RID: 1375
		InitManualCredValidation = 524288,
		// Token: 0x04000560 RID: 1376
		InitUseSuppliedCreds = 128,
		// Token: 0x04000561 RID: 1377
		InitIdentify = 131072,
		// Token: 0x04000562 RID: 1378
		AcceptIdentify = 524288,
		// Token: 0x04000563 RID: 1379
		ProxyBindings = 67108864,
		// Token: 0x04000564 RID: 1380
		AllowMissingBindings = 268435456,
		// Token: 0x04000565 RID: 1381
		UnverifiedTargetName = 536870912
	}
}
