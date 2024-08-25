using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200013C RID: 316
	public enum FormatUsage
	{
		// Token: 0x04000565 RID: 1381
		Sample,
		// Token: 0x04000566 RID: 1382
		Linear,
		// Token: 0x04000567 RID: 1383
		Sparse,
		// Token: 0x04000568 RID: 1384
		Render = 4,
		// Token: 0x04000569 RID: 1385
		Blend,
		// Token: 0x0400056A RID: 1386
		GetPixels,
		// Token: 0x0400056B RID: 1387
		SetPixels,
		// Token: 0x0400056C RID: 1388
		SetPixels32,
		// Token: 0x0400056D RID: 1389
		ReadPixels,
		// Token: 0x0400056E RID: 1390
		LoadStore,
		// Token: 0x0400056F RID: 1391
		MSAA2x,
		// Token: 0x04000570 RID: 1392
		MSAA4x,
		// Token: 0x04000571 RID: 1393
		MSAA8x,
		// Token: 0x04000572 RID: 1394
		StencilSampling = 16
	}
}
