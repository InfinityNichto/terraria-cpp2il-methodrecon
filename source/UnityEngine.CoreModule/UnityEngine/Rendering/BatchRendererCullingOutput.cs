using System;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200011C RID: 284
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[UsedByNativeCode]
	internal struct BatchRendererCullingOutput
	{
		// Token: 0x040004C2 RID: 1218
		public JobHandle cullingJobsFence;

		// Token: 0x040004C3 RID: 1219
		public Matrix4x4 cullingMatrix;

		// Token: 0x040004C4 RID: 1220
		public unsafe Plane* cullingPlanes;

		// Token: 0x040004C5 RID: 1221
		public unsafe BatchVisibility* batchVisibility;

		// Token: 0x040004C6 RID: 1222
		public unsafe int* visibleIndices;

		// Token: 0x040004C7 RID: 1223
		public unsafe int* visibleIndicesY;

		// Token: 0x040004C8 RID: 1224
		public int cullingPlanesCount;

		// Token: 0x040004C9 RID: 1225
		public int batchVisibilityCount;

		// Token: 0x040004CA RID: 1226
		public int visibleIndicesCount;

		// Token: 0x040004CB RID: 1227
		public float nearPlane;
	}
}
