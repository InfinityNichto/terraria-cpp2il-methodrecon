using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200011F RID: 287
	[Flags]
	public enum ShaderPropertyFlags
	{
		// Token: 0x040004CF RID: 1231
		None = 0,
		// Token: 0x040004D0 RID: 1232
		HideInInspector = 1,
		// Token: 0x040004D1 RID: 1233
		PerRendererData = 2,
		// Token: 0x040004D2 RID: 1234
		NoScaleOffset = 4,
		// Token: 0x040004D3 RID: 1235
		Normal = 8,
		// Token: 0x040004D4 RID: 1236
		HDR = 16,
		// Token: 0x040004D5 RID: 1237
		Gamma = 32,
		// Token: 0x040004D6 RID: 1238
		NonModifiableTextureData = 64,
		// Token: 0x040004D7 RID: 1239
		MainTexture = 128,
		// Token: 0x040004D8 RID: 1240
		MainColor = 256
	}
}
