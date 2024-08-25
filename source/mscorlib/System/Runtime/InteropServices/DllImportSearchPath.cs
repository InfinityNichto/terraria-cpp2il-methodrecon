using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000447 RID: 1095
	[Flags]
	public enum DllImportSearchPath
	{
		// Token: 0x0400125F RID: 4703
		UseDllDirectoryForDependencies = 256,
		// Token: 0x04001260 RID: 4704
		ApplicationDirectory = 512,
		// Token: 0x04001261 RID: 4705
		UserDirectories = 1024,
		// Token: 0x04001262 RID: 4706
		System32 = 2048,
		// Token: 0x04001263 RID: 4707
		SafeDirectories = 4096,
		// Token: 0x04001264 RID: 4708
		AssemblyDirectory = 2,
		// Token: 0x04001265 RID: 4709
		LegacyBehavior = 0
	}
}
