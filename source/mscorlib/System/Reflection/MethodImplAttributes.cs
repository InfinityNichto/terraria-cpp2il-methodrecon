using System;

namespace System.Reflection
{
	// Token: 0x020004DE RID: 1246
	public enum MethodImplAttributes
	{
		// Token: 0x040013D7 RID: 5079
		CodeTypeMask = 3,
		// Token: 0x040013D8 RID: 5080
		IL = 0,
		// Token: 0x040013D9 RID: 5081
		Native,
		// Token: 0x040013DA RID: 5082
		OPTIL,
		// Token: 0x040013DB RID: 5083
		Runtime,
		// Token: 0x040013DC RID: 5084
		ManagedMask,
		// Token: 0x040013DD RID: 5085
		Unmanaged = 4,
		// Token: 0x040013DE RID: 5086
		Managed = 0,
		// Token: 0x040013DF RID: 5087
		ForwardRef = 16,
		// Token: 0x040013E0 RID: 5088
		PreserveSig = 128,
		// Token: 0x040013E1 RID: 5089
		InternalCall = 4096,
		// Token: 0x040013E2 RID: 5090
		Synchronized = 32,
		// Token: 0x040013E3 RID: 5091
		NoInlining = 8,
		// Token: 0x040013E4 RID: 5092
		AggressiveInlining = 256,
		// Token: 0x040013E5 RID: 5093
		NoOptimization = 64,
		// Token: 0x040013E6 RID: 5094
		MaxMethodImplVal = 65535,
		// Token: 0x040013E7 RID: 5095
		SecurityMitigations = 1024
	}
}
