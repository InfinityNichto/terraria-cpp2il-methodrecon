using System;

namespace System.Reflection
{
	// Token: 0x020004DB RID: 1243
	[Flags]
	public enum MemberTypes
	{
		// Token: 0x040013B4 RID: 5044
		Constructor = 1,
		// Token: 0x040013B5 RID: 5045
		Event = 2,
		// Token: 0x040013B6 RID: 5046
		Field = 4,
		// Token: 0x040013B7 RID: 5047
		Method = 8,
		// Token: 0x040013B8 RID: 5048
		Property = 16,
		// Token: 0x040013B9 RID: 5049
		TypeInfo = 32,
		// Token: 0x040013BA RID: 5050
		Custom = 64,
		// Token: 0x040013BB RID: 5051
		NestedType = 128,
		// Token: 0x040013BC RID: 5052
		All = 191
	}
}
