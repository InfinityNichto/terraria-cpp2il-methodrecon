using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000052 RID: 82
	[NativeHeader("Runtime/Camera/SharedLightData.h")]
	public struct LightBakingOutput
	{
		// Token: 0x04000214 RID: 532
		public int probeOcclusionLightIndex;

		// Token: 0x04000215 RID: 533
		public int occlusionMaskChannel;

		// Token: 0x04000216 RID: 534
		[NativeName("lightmapBakeMode.lightmapBakeType")]
		public LightmapBakeType lightmapBakeType;

		// Token: 0x04000217 RID: 535
		[NativeName("lightmapBakeMode.mixedLightingMode")]
		public MixedLightingMode mixedLightingMode;

		// Token: 0x04000218 RID: 536
		public bool isBaked;
	}
}
