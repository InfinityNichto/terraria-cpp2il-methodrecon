using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200011B RID: 283
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[UsedByNativeCode]
	public struct BatchCullingContext
	{
		// Token: 0x060005C9 RID: 1481 RVA: 0x0000A454 File Offset: 0x00008654
		internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane)
		{
			this.cullingPlanes = inCullingPlanes;
			this.batchVisibility = outVisibleIndices;
			this.batchVisibility.m_Length = outVisibleIndicesY;
			this.visibleIndices = inLodParameters;
			this.visibleIndices.m_Length = inCullingMatrix;
		}

		// Token: 0x040004BB RID: 1211
		public readonly NativeArray<Plane> cullingPlanes;

		// Token: 0x040004BC RID: 1212
		public NativeArray<BatchVisibility> batchVisibility;

		// Token: 0x040004BD RID: 1213
		public NativeArray<int> visibleIndices;

		// Token: 0x040004BE RID: 1214
		public NativeArray<int> visibleIndicesY;

		// Token: 0x040004BF RID: 1215
		public readonly LODParameters lodParameters;

		// Token: 0x040004C0 RID: 1216
		public readonly Matrix4x4 cullingMatrix;

		// Token: 0x040004C1 RID: 1217
		public readonly float nearPlane;
	}
}
