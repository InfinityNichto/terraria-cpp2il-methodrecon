using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001D0 RID: 464
public class Debug_Layout : LayoutDefinition
{
	// Token: 0x06000BFE RID: 3070 RVA: 0x0003BC28 File Offset: 0x00039E28
	private void Awake()
	{
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x0003BC38 File Offset: 0x00039E38
	public Debug_Layout()
	{
		if (17146 == 0)
		{
		}
		this.DebugIconColor = 17146;
		if (17146 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x04001041 RID: 4161
	public static Debug_Layout Instance;

	// Token: 0x04001042 RID: 4162
	public LayoutCalculator.AnchorType DebugAnchor = LayoutCalculator.AnchorType.BottomRight;

	// Token: 0x04001043 RID: 4163
	public Vector2 DebugIconLocation;

	// Token: 0x04001044 RID: 4164
	public float DebugIconScale = (float)16384;

	// Token: 0x04001045 RID: 4165
	public Vector2 DebugIconPickBorder = 17146;

	// Token: 0x04001046 RID: 4166
	public Color DebugIconColor;

	// Token: 0x04001047 RID: 4167
	public Panel_Layout Backing;

	// Token: 0x04001048 RID: 4168
	public TransactionButton_Layout Text;

	// Token: 0x04001049 RID: 4169
	public TransactionButton_Layout Send;

	// Token: 0x0400104A RID: 4170
	public TransactionButton_Layout Close;
}
