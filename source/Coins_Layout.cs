using System;
using UnityEngine;

// Token: 0x0200019D RID: 413
public class Coins_Layout : PageControllerLayoutDefinition<Coins_Layout>
{
	// Token: 0x06000B67 RID: 2919 RVA: 0x000396B8 File Offset: 0x000378B8
	public Coins_Layout()
	{
	}

	// Token: 0x04000D05 RID: 3333
	public String_Layout Title;

	// Token: 0x04000D06 RID: 3334
	public float ItemScale;

	// Token: 0x04000D07 RID: 3335
	public float ItemHighlightScale;

	// Token: 0x04000D08 RID: 3336
	public ItemGrid_Layout CoinGrid;

	// Token: 0x04000D09 RID: 3337
	public float ItemScale_Collapsed;

	// Token: 0x04000D0A RID: 3338
	public float ItemHighlightScale_Collapsed;

	// Token: 0x04000D0B RID: 3339
	public ItemGrid_Layout CoinGrid_Collapsed;

	// Token: 0x04000D0C RID: 3340
	public AnimationCurve ItemDragPulseScale;
}
