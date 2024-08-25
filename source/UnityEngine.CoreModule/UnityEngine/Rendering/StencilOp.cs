using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010C RID: 268
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum StencilOp
	{
		// Token: 0x04000465 RID: 1125
		Keep,
		// Token: 0x04000466 RID: 1126
		Zero,
		// Token: 0x04000467 RID: 1127
		Replace,
		// Token: 0x04000468 RID: 1128
		IncrementSaturate,
		// Token: 0x04000469 RID: 1129
		DecrementSaturate,
		// Token: 0x0400046A RID: 1130
		Invert,
		// Token: 0x0400046B RID: 1131
		IncrementWrap,
		// Token: 0x0400046C RID: 1132
		DecrementWrap
	}
}
