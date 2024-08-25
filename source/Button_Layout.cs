using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NaughtyAttributes;

// Token: 0x020001AB RID: 427
[Serializable]
public class Button_Layout
{
	// Token: 0x06000B7B RID: 2939 RVA: 0x0003A3C4 File Offset: 0x000385C4
	public Button_Layout()
	{
		if (17146 == 0)
		{
		}
		this.Color = 17146;
		base..ctor();
	}

	// Token: 0x04000DED RID: 3565
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000DEE RID: 3566
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000DEF RID: 3567
	public Vector2 Location = 17146;

	// Token: 0x04000DF0 RID: 3568
	[BoxGroup("Normal", -1, null, null)]
	public float Scale = (float)16256;

	// Token: 0x04000DF1 RID: 3569
	[BoxGroup("Picking", -1, "Style", null)]
	public Vector2 PickBorder;

	// Token: 0x04000DF2 RID: 3570
	[BoxGroup("Picking", -1, null, null)]
	public Vector2 PickOffset;

	// Token: 0x04000DF3 RID: 3571
	[BoxGroup("Normal", -1, null, null)]
	public Color Color;

	// Token: 0x04000DF4 RID: 3572
	[BoxGroup("Picking", -1, null, null)]
	public bool UseCirclePickingRegion;
}
