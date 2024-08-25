using System;
using Microsoft.Xna.Framework;

// Token: 0x020001FD RID: 509
public class Logo_Layout : LayoutDefinition
{
	// Token: 0x06000C9A RID: 3226 RVA: 0x0003DF64 File Offset: 0x0003C164
	private void Awake()
	{
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x0003DF74 File Offset: 0x0003C174
	public Logo_Layout()
	{
		if (17146 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x040012A0 RID: 4768
	public static Logo_Layout Instance;

	// Token: 0x040012A1 RID: 4769
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x040012A2 RID: 4770
	public LayoutCalculator.AnchorType Anchor = LayoutCalculator.AnchorType.BottomLeft;

	// Token: 0x040012A3 RID: 4771
	public Vector2 Location = 17146;

	// Token: 0x040012A4 RID: 4772
	public float Scale = (float)16256;
}
