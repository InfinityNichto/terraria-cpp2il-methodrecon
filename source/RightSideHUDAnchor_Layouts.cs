using System;
using Microsoft.Xna.Framework;

// Token: 0x02000238 RID: 568
public class RightSideHUDAnchor_Layouts : LayoutDefinition
{
	// Token: 0x06000D0C RID: 3340 RVA: 0x0003EAF0 File Offset: 0x0003CCF0
	private void Awake()
	{
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x0003EB00 File Offset: 0x0003CD00
	public RightSideHUDAnchor_Layouts()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001745 RID: 5957
	public static RightSideHUDAnchor_Layouts Instance;

	// Token: 0x04001746 RID: 5958
	public Anchor_Layout StartAnchor;

	// Token: 0x04001747 RID: 5959
	public Anchor_Layout StartAnchor2;

	// Token: 0x04001748 RID: 5960
	public Anchor_Layout StartAnchorHorizontalBars;

	// Token: 0x04001749 RID: 5961
	public Anchor_Layout StartAnchorHorizontalBars2;

	// Token: 0x0400174A RID: 5962
	public Vector2 NonMapSpacing;

	// Token: 0x0400174B RID: 5963
	public float MapSpacing;

	// Token: 0x0400174C RID: 5964
	public float MapSpacingLarge;

	// Token: 0x0400174D RID: 5965
	public float EvemtSpacing;

	// Token: 0x0400174E RID: 5966
	public float BossBarSpacing;

	// Token: 0x0400174F RID: 5967
	public float StatusIndicatorSpacing;

	// Token: 0x04001750 RID: 5968
	public bool AllowMapMovement;
}
