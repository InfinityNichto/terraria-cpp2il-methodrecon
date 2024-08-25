using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001BB RID: 443
[Serializable]
public class Stretched_Layout
{
	// Token: 0x06000BD1 RID: 3025 RVA: 0x0003ADA4 File Offset: 0x00038FA4
	public Stretched_Layout()
	{
		if (17146 == 0)
		{
		}
		this.Color = 17146;
		base..ctor();
	}

	// Token: 0x04000EB5 RID: 3765
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000EB6 RID: 3766
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000EB7 RID: 3767
	public Vector2 Location = 17146;

	// Token: 0x04000EB8 RID: 3768
	public Color Color;

	// Token: 0x04000EB9 RID: 3769
	public float Size;

	// Token: 0x04000EBA RID: 3770
	public float Scale;

	// Token: 0x04000EBB RID: 3771
	public bool Vertical;

	// Token: 0x04000EBC RID: 3772
	public Texture_Layout Backing;
}
