using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001BA RID: 442
[Serializable]
public class Slider_Layout
{
	// Token: 0x06000BCF RID: 3023 RVA: 0x0003ACFC File Offset: 0x00038EFC
	public Slider_Layout()
	{
		if (!true)
		{
		}
		this.BackingColour = 1;
		this.NotchColour = 1;
		this.BackingHighlightColour = 1;
		this.NotchScale = (float)16256;
		this.NotchHighlightColour = 1;
		this.Anchor = LayoutCalculator.AnchorType.CentreBoth;
		this.PickBorder = 1;
		if (!true)
		{
		}
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x0003AD50 File Offset: 0x00038F50
	public Slider_Layout(string backingTexture, string notchTexture)
	{
		if (!true)
		{
		}
		this.BackingColour = 1;
		this.NotchColour = 1;
		this.BackingHighlightColour = 1;
		this.NotchScale = (float)16256;
		this.NotchHighlightColour = 1;
		this.Anchor = LayoutCalculator.AnchorType.CentreBoth;
		this.PickBorder = 1;
		if (!true)
		{
		}
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000EA5 RID: 3749
	public Texture_Layout Backing;

	// Token: 0x04000EA6 RID: 3750
	public Color BackingColour;

	// Token: 0x04000EA7 RID: 3751
	public Texture_Layout Notch;

	// Token: 0x04000EA8 RID: 3752
	public Color NotchColour;

	// Token: 0x04000EA9 RID: 3753
	public Texture_Layout BackingHighlight;

	// Token: 0x04000EAA RID: 3754
	public Color BackingHighlightColour;

	// Token: 0x04000EAB RID: 3755
	public Texture_Layout NotchHighlight;

	// Token: 0x04000EAC RID: 3756
	public Color NotchHighlightColour;

	// Token: 0x04000EAD RID: 3757
	public float SliderEndCap;

	// Token: 0x04000EAE RID: 3758
	public float BackingScale;

	// Token: 0x04000EAF RID: 3759
	public float NotchScale;

	// Token: 0x04000EB0 RID: 3760
	public Vector2 PickBorder;

	// Token: 0x04000EB1 RID: 3761
	public bool Vertical;

	// Token: 0x04000EB2 RID: 3762
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000EB3 RID: 3763
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x04000EB4 RID: 3764
	public Vector2 Location;
}
