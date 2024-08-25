using System;

namespace System
{
	// Token: 0x0200008D RID: 141
	[Flags]
	public enum AttributeTargets
	{
		// Token: 0x040001E7 RID: 487
		Assembly = 1,
		// Token: 0x040001E8 RID: 488
		Module = 2,
		// Token: 0x040001E9 RID: 489
		Class = 4,
		// Token: 0x040001EA RID: 490
		Struct = 8,
		// Token: 0x040001EB RID: 491
		Enum = 16,
		// Token: 0x040001EC RID: 492
		Constructor = 32,
		// Token: 0x040001ED RID: 493
		Method = 64,
		// Token: 0x040001EE RID: 494
		Property = 128,
		// Token: 0x040001EF RID: 495
		Field = 256,
		// Token: 0x040001F0 RID: 496
		Event = 512,
		// Token: 0x040001F1 RID: 497
		Interface = 1024,
		// Token: 0x040001F2 RID: 498
		Parameter = 2048,
		// Token: 0x040001F3 RID: 499
		Delegate = 4096,
		// Token: 0x040001F4 RID: 500
		ReturnValue = 8192,
		// Token: 0x040001F5 RID: 501
		GenericParameter = 16384,
		// Token: 0x040001F6 RID: 502
		All = 32767
	}
}
