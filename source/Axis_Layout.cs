using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x020001A9 RID: 425
[Serializable]
public class Axis_Layout
{
	// Token: 0x06000B77 RID: 2935 RVA: 0x0003A2D8 File Offset: 0x000384D8
	public Axis_Layout()
	{
		if (17096 == 0)
		{
		}
		this.Color = 17096;
		this.DisabledColor = 17096;
		this.AlternativeColor = 17096;
		this.BackingColor = 17096;
		this.DisabledBackingColor = 17096;
		this.IconColor = 17096;
		this.DisabledIconColor = 17096;
		this.RecentreOnTouch = 257 != 0;
		this.Draggable = true;
		this.IconMaxSizeInset = 10;
		this.ClampInside = true;
		base..ctor();
	}

	// Token: 0x04000DD4 RID: 3540
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000DD5 RID: 3541
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x04000DD6 RID: 3542
	public Microsoft.Xna.Framework.Vector2 CentreLocation = 17096;

	// Token: 0x04000DD7 RID: 3543
	public float Scale = (float)16256;

	// Token: 0x04000DD8 RID: 3544
	public Microsoft.Xna.Framework.Graphics.Color Color;

	// Token: 0x04000DD9 RID: 3545
	public Microsoft.Xna.Framework.Graphics.Color DisabledColor;

	// Token: 0x04000DDA RID: 3546
	public Microsoft.Xna.Framework.Graphics.Color AlternativeColor;

	// Token: 0x04000DDB RID: 3547
	public Microsoft.Xna.Framework.Graphics.Color BackingColor;

	// Token: 0x04000DDC RID: 3548
	public Microsoft.Xna.Framework.Graphics.Color DisabledBackingColor;

	// Token: 0x04000DDD RID: 3549
	public Microsoft.Xna.Framework.Graphics.Color IconColor;

	// Token: 0x04000DDE RID: 3550
	public Microsoft.Xna.Framework.Graphics.Color DisabledIconColor;

	// Token: 0x04000DDF RID: 3551
	public bool UseCirclePickingRegion;

	// Token: 0x04000DE0 RID: 3552
	public Microsoft.Xna.Framework.Vector2 PickSize;

	// Token: 0x04000DE1 RID: 3553
	public Microsoft.Xna.Framework.Vector2 DeadZone;

	// Token: 0x04000DE2 RID: 3554
	public AnimationCurve AxisFalloff;

	// Token: 0x04000DE3 RID: 3555
	public bool RecentreOnTouch;

	// Token: 0x04000DE4 RID: 3556
	public bool RecentreInputOnly;

	// Token: 0x04000DE5 RID: 3557
	public Microsoft.Xna.Framework.Vector2 NubbinPickSize;

	// Token: 0x04000DE6 RID: 3558
	public bool Draggable;

	// Token: 0x04000DE7 RID: 3559
	public bool UseCircleDeadZone;

	// Token: 0x04000DE8 RID: 3560
	public int IconMaxSizeInset;

	// Token: 0x04000DE9 RID: 3561
	public bool ClampInside;

	// Token: 0x04000DEA RID: 3562
	public Texture_Layout Backing;

	// Token: 0x04000DEB RID: 3563
	public Texture_Layout Inner;

	// Token: 0x04000DEC RID: 3564
	public Texture_Layout AlternativeInner;
}
