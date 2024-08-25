using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x0200010A RID: 266
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum CompareFunction
	{
		// Token: 0x04000455 RID: 1109
		Disabled,
		// Token: 0x04000456 RID: 1110
		Never,
		// Token: 0x04000457 RID: 1111
		Less,
		// Token: 0x04000458 RID: 1112
		Equal,
		// Token: 0x04000459 RID: 1113
		LessEqual,
		// Token: 0x0400045A RID: 1114
		Greater,
		// Token: 0x0400045B RID: 1115
		NotEqual,
		// Token: 0x0400045C RID: 1116
		GreaterEqual,
		// Token: 0x0400045D RID: 1117
		Always
	}
}
