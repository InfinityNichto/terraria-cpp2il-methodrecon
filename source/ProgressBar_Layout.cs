using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B6 RID: 438
[Serializable]
public class ProgressBar_Layout
{
	// Token: 0x06000BC1 RID: 3009 RVA: 0x0003A9F8 File Offset: 0x00038BF8
	public ProgressBar_Layout()
	{
		if (16256 == 0)
		{
		}
		if (true)
		{
			return;
		}
		this.Location = 18;
		if (true)
		{
			return;
		}
		this.FillingSize = 18;
		if (!true)
		{
		}
		this.FillingLocation = 1;
		if (!true)
		{
		}
		this.FillingColor = 1;
		this.FillingColorEmpty = 1;
		base..ctor();
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x0003AA58 File Offset: 0x00038C58
	public ProgressBar_Layout(string backingTexture)
	{
		if (16256 == 0)
		{
		}
		if (true)
		{
			return;
		}
		this.Location = 18;
		if (true)
		{
			return;
		}
		this.FillingSize = 18;
		if (!true)
		{
		}
		this.FillingLocation = 1;
		if (!true)
		{
		}
		this.FillingColor = 1;
		this.FillingColorEmpty = 1;
		base..ctor();
	}

	// Token: 0x04000E67 RID: 3687
	public Texture_Layout Backing;

	// Token: 0x04000E68 RID: 3688
	public float BackingScale = (float)16256;

	// Token: 0x04000E69 RID: 3689
	private bool Vertical;

	// Token: 0x04000E6A RID: 3690
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000E6B RID: 3691
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.CentreBoth;

	// Token: 0x04000E6C RID: 3692
	public Vector2 Location;

	// Token: 0x04000E6D RID: 3693
	public Vector2 FillingSize;

	// Token: 0x04000E6E RID: 3694
	public Vector2 FillingLocation;

	// Token: 0x04000E6F RID: 3695
	public Color FillingColor;

	// Token: 0x04000E70 RID: 3696
	public Color FillingColorEmpty;
}
