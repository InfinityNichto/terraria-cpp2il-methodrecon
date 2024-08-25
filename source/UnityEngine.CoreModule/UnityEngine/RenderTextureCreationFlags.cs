using System;

namespace UnityEngine
{
	// Token: 0x0200006D RID: 109
	[Flags]
	public enum RenderTextureCreationFlags
	{
		// Token: 0x040002C7 RID: 711
		MipMap = 1,
		// Token: 0x040002C8 RID: 712
		AutoGenerateMips = 2,
		// Token: 0x040002C9 RID: 713
		SRGB = 4,
		// Token: 0x040002CA RID: 714
		EyeTexture = 8,
		// Token: 0x040002CB RID: 715
		EnableRandomWrite = 16,
		// Token: 0x040002CC RID: 716
		CreatedFromScript = 32,
		// Token: 0x040002CD RID: 717
		AllowVerticalFlip = 128,
		// Token: 0x040002CE RID: 718
		NoResolvedColorSurface = 256,
		// Token: 0x040002CF RID: 719
		DynamicallyScalable = 1024,
		// Token: 0x040002D0 RID: 720
		BindMS = 2048
	}
}
