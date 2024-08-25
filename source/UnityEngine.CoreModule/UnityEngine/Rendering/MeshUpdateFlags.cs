using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000107 RID: 263
	[Flags]
	public enum MeshUpdateFlags
	{
		// Token: 0x04000433 RID: 1075
		Default = 0,
		// Token: 0x04000434 RID: 1076
		DontValidateIndices = 1,
		// Token: 0x04000435 RID: 1077
		DontResetBoneBounds = 2,
		// Token: 0x04000436 RID: 1078
		DontNotifyMeshUsers = 4,
		// Token: 0x04000437 RID: 1079
		DontRecalculateBounds = 8
	}
}
