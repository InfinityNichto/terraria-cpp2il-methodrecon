using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200042C RID: 1068
	[Flags]
	[Serializable]
	internal enum MessageEnum
	{
		// Token: 0x040011DC RID: 4572
		NoArgs = 1,
		// Token: 0x040011DD RID: 4573
		ArgsInline = 2,
		// Token: 0x040011DE RID: 4574
		ArgsIsArray = 4,
		// Token: 0x040011DF RID: 4575
		ArgsInArray = 8,
		// Token: 0x040011E0 RID: 4576
		NoContext = 16,
		// Token: 0x040011E1 RID: 4577
		ContextInline = 32,
		// Token: 0x040011E2 RID: 4578
		ContextInArray = 64,
		// Token: 0x040011E3 RID: 4579
		MethodSignatureInArray = 128,
		// Token: 0x040011E4 RID: 4580
		PropertyInArray = 256,
		// Token: 0x040011E5 RID: 4581
		NoReturnValue = 512,
		// Token: 0x040011E6 RID: 4582
		ReturnValueVoid = 1024,
		// Token: 0x040011E7 RID: 4583
		ReturnValueInline = 2048,
		// Token: 0x040011E8 RID: 4584
		ReturnValueInArray = 4096,
		// Token: 0x040011E9 RID: 4585
		ExceptionInArray = 8192,
		// Token: 0x040011EA RID: 4586
		GenericMethod = 32768
	}
}
