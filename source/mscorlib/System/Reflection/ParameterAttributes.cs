using System;

namespace System.Reflection
{
	// Token: 0x020004E2 RID: 1250
	[Flags]
	public enum ParameterAttributes
	{
		// Token: 0x040013ED RID: 5101
		None = 0,
		// Token: 0x040013EE RID: 5102
		In = 1,
		// Token: 0x040013EF RID: 5103
		Out = 2,
		// Token: 0x040013F0 RID: 5104
		Lcid = 4,
		// Token: 0x040013F1 RID: 5105
		Retval = 8,
		// Token: 0x040013F2 RID: 5106
		Optional = 16,
		// Token: 0x040013F3 RID: 5107
		HasDefault = 4096,
		// Token: 0x040013F4 RID: 5108
		HasFieldMarshal = 8192,
		// Token: 0x040013F5 RID: 5109
		Reserved3 = 16384,
		// Token: 0x040013F6 RID: 5110
		Reserved4 = 32768,
		// Token: 0x040013F7 RID: 5111
		ReservedMask = 61440
	}
}
