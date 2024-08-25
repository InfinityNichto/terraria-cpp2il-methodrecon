using System;

namespace System.Reflection
{
	// Token: 0x020004EA RID: 1258
	[Flags]
	public enum ResourceLocation
	{
		// Token: 0x04001415 RID: 5141
		ContainedInAnotherAssembly = 2,
		// Token: 0x04001416 RID: 5142
		ContainedInManifestFile = 4,
		// Token: 0x04001417 RID: 5143
		Embedded = 1
	}
}
