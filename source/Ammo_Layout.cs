using System;
using UnityEngine;

// Token: 0x02000190 RID: 400
public class Ammo_Layout : PageControllerLayoutDefinition<Ammo_Layout>
{
	// Token: 0x06000B4D RID: 2893 RVA: 0x000392B0 File Offset: 0x000374B0
	public Ammo_Layout()
	{
	}

	// Token: 0x04000C27 RID: 3111
	public String_Layout Title;

	// Token: 0x04000C28 RID: 3112
	public float ItemScale;

	// Token: 0x04000C29 RID: 3113
	public float ItemHighlightScale;

	// Token: 0x04000C2A RID: 3114
	public ItemGrid_Layout AmmoGrid;

	// Token: 0x04000C2B RID: 3115
	public float ItemScale_Collapsed;

	// Token: 0x04000C2C RID: 3116
	public float ItemHighlightScale_Collapsed;

	// Token: 0x04000C2D RID: 3117
	public ItemGrid_Layout AmmoGrid_Collapsed;

	// Token: 0x04000C2E RID: 3118
	public AnimationCurve ItemDragPulseScale;
}
