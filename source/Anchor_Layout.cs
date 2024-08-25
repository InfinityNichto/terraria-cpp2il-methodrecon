using System;
using Microsoft.Xna.Framework;

// Token: 0x020001A7 RID: 423
[Serializable]
public class Anchor_Layout
{
	// Token: 0x06000B75 RID: 2933 RVA: 0x0003A288 File Offset: 0x00038488
	public Anchor_Layout()
	{
	}

	// Token: 0x04000DC3 RID: 3523
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x04000DC4 RID: 3524
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.TopRight;

	// Token: 0x04000DC5 RID: 3525
	public Vector2 Location;
}
