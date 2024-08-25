using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200018C RID: 396
public class AccessoryInfo_Layout : LayoutDefinition
{
	// Token: 0x06000B45 RID: 2885 RVA: 0x000391A8 File Offset: 0x000373A8
	private void Awake()
	{
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x000391B8 File Offset: 0x000373B8
	public AccessoryInfo_Layout()
	{
		if (16256 == 0)
		{
		}
		this.IconColour = 16256;
		this.DisabledIconColour = 16256;
		if (16256 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x04000BEA RID: 3050
	public static AccessoryInfo_Layout Instance;

	// Token: 0x04000BEB RID: 3051
	public ItemGrid_Layout IconGrid;

	// Token: 0x04000BEC RID: 3052
	public ItemGrid_Layout IconGridSecondary;

	// Token: 0x04000BED RID: 3053
	public String_Layout ItemText;

	// Token: 0x04000BEE RID: 3054
	public String_Layout DisabledItemText;

	// Token: 0x04000BEF RID: 3055
	public String_Layout CritterItemText;

	// Token: 0x04000BF0 RID: 3056
	public float ItemScale = (float)16256;

	// Token: 0x04000BF1 RID: 3057
	public Color IconColour;

	// Token: 0x04000BF2 RID: 3058
	public Color DisabledIconColour;

	// Token: 0x04000BF3 RID: 3059
	public Panel_Layout Backing;

	// Token: 0x04000BF4 RID: 3060
	public Vector2 BackingTLOffset;

	// Token: 0x04000BF5 RID: 3061
	public Vector2 BackingBROffset;
}
