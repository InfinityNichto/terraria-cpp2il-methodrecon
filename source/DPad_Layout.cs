using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001AE RID: 430
[Serializable]
public class DPad_Layout
{
	// Token: 0x06000BBA RID: 3002 RVA: 0x0003A7D4 File Offset: 0x000389D4
	public DPad_Layout()
	{
		if (17224 == 0)
		{
		}
		this.Color = 17224;
		this.PickSize = 17096;
		base..ctor();
	}

	// Token: 0x04000E1D RID: 3613
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000E1E RID: 3614
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000E1F RID: 3615
	public Vector2 CentreLocation = 17224;

	// Token: 0x04000E20 RID: 3616
	public float Scale = (float)16384;

	// Token: 0x04000E21 RID: 3617
	public Vector2 LeftOffset;

	// Token: 0x04000E22 RID: 3618
	public Vector2 RightOffset;

	// Token: 0x04000E23 RID: 3619
	public Vector2 TopOffset;

	// Token: 0x04000E24 RID: 3620
	public Vector2 BottomOffset;

	// Token: 0x04000E25 RID: 3621
	public Color Color;

	// Token: 0x04000E26 RID: 3622
	public Vector2 PickSize;

	// Token: 0x04000E27 RID: 3623
	public Vector2 DeadZone;
}
