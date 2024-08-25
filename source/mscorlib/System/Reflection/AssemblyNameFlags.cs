using System;

namespace System.Reflection
{
	// Token: 0x020004C5 RID: 1221
	[Flags]
	public enum AssemblyNameFlags
	{
		// Token: 0x04001361 RID: 4961
		None = 0,
		// Token: 0x04001362 RID: 4962
		PublicKey = 1,
		// Token: 0x04001363 RID: 4963
		EnableJITcompileOptimizer = 16384,
		// Token: 0x04001364 RID: 4964
		EnableJITcompileTracking = 32768,
		// Token: 0x04001365 RID: 4965
		Retargetable = 256
	}
}
