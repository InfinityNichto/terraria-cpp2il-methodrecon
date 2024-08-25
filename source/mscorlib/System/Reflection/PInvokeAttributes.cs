using System;

namespace System.Reflection
{
	// Token: 0x020004FD RID: 1277
	[Flags]
	[Serializable]
	internal enum PInvokeAttributes
	{
		// Token: 0x04001490 RID: 5264
		NoMangle = 1,
		// Token: 0x04001491 RID: 5265
		CharSetMask = 6,
		// Token: 0x04001492 RID: 5266
		CharSetNotSpec = 0,
		// Token: 0x04001493 RID: 5267
		CharSetAnsi = 2,
		// Token: 0x04001494 RID: 5268
		CharSetUnicode = 4,
		// Token: 0x04001495 RID: 5269
		CharSetAuto = 6,
		// Token: 0x04001496 RID: 5270
		BestFitUseAssem = 0,
		// Token: 0x04001497 RID: 5271
		BestFitEnabled = 16,
		// Token: 0x04001498 RID: 5272
		BestFitDisabled = 32,
		// Token: 0x04001499 RID: 5273
		BestFitMask = 48,
		// Token: 0x0400149A RID: 5274
		ThrowOnUnmappableCharUseAssem = 0,
		// Token: 0x0400149B RID: 5275
		ThrowOnUnmappableCharEnabled = 4096,
		// Token: 0x0400149C RID: 5276
		ThrowOnUnmappableCharDisabled = 8192,
		// Token: 0x0400149D RID: 5277
		ThrowOnUnmappableCharMask = 12288,
		// Token: 0x0400149E RID: 5278
		SupportsLastError = 64,
		// Token: 0x0400149F RID: 5279
		CallConvMask = 1792,
		// Token: 0x040014A0 RID: 5280
		CallConvWinapi = 256,
		// Token: 0x040014A1 RID: 5281
		CallConvCdecl = 512,
		// Token: 0x040014A2 RID: 5282
		CallConvStdcall = 768,
		// Token: 0x040014A3 RID: 5283
		CallConvThiscall = 1024,
		// Token: 0x040014A4 RID: 5284
		CallConvFastcall = 1280,
		// Token: 0x040014A5 RID: 5285
		MaxValue = 65535
	}
}
