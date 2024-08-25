using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001A8 RID: 424
[Serializable]
public class AnimatedTexture_Layout
{
	// Token: 0x06000B76 RID: 2934 RVA: 0x0003A2A4 File Offset: 0x000384A4
	public AnimatedTexture_Layout()
	{
		if (!true)
		{
		}
		this.Color = 1;
		base..ctor();
	}

	// Token: 0x04000DC6 RID: 3526
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000DC7 RID: 3527
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.CentreBoth;

	// Token: 0x04000DC8 RID: 3528
	public Vector2 Location = 1;

	// Token: 0x04000DC9 RID: 3529
	public Vector2 Size;

	// Token: 0x04000DCA RID: 3530
	public bool AnchorForSize;

	// Token: 0x04000DCB RID: 3531
	public ControlAnchor.ControlId SizeAnchorControl;

	// Token: 0x04000DCC RID: 3532
	public LayoutCalculator.AnchorType SizeAnchor = LayoutCalculator.AnchorType.CentreBoth;

	// Token: 0x04000DCD RID: 3533
	public Vector2 SizeLocation;

	// Token: 0x04000DCE RID: 3534
	public Vector2 PickBorder;

	// Token: 0x04000DCF RID: 3535
	public Vector2 PickOffset;

	// Token: 0x04000DD0 RID: 3536
	public Color Color;

	// Token: 0x04000DD1 RID: 3537
	public Texture_Layout Texture;

	// Token: 0x04000DD2 RID: 3538
	public int NumXFrames;

	// Token: 0x04000DD3 RID: 3539
	public int NumYFrames;
}
