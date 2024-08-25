using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B4 RID: 436
[Serializable]
public class PopoutMenu_Layout
{
	// Token: 0x06000BC0 RID: 3008 RVA: 0x0003A9CC File Offset: 0x00038BCC
	public PopoutMenu_Layout()
	{
	}

	// Token: 0x04000E5D RID: 3677
	public QuickActionButton_Layout MenuButton;

	// Token: 0x04000E5E RID: 3678
	public PopoutMenu_Layout.ReorderStyle Reorder;

	// Token: 0x04000E5F RID: 3679
	public String_Layout ElementLayout;

	// Token: 0x04000E60 RID: 3680
	public float ElementSpacing = (float)16384;

	// Token: 0x04000E61 RID: 3681
	public Vector2 BackingTLOffset;

	// Token: 0x04000E62 RID: 3682
	public Vector2 BackingBROffset;

	// Token: 0x04000E63 RID: 3683
	public Color BackingColor = "RB";

	// Token: 0x020001B5 RID: 437
	public enum ReorderStyle
	{
		// Token: 0x04000E65 RID: 3685
		None,
		// Token: 0x04000E66 RID: 3686
		Reverse
	}
}
