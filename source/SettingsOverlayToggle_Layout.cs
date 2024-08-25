using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200021A RID: 538
[Serializable]
public class SettingsOverlayToggle_Layout
{
	// Token: 0x06000CCA RID: 3274 RVA: 0x0003E408 File Offset: 0x0003C608
	public SettingsOverlayToggle_Layout()
	{
	}

	// Token: 0x0400148B RID: 5259
	public TransactionButton_Layout ToggleButton;

	// Token: 0x0400148C RID: 5260
	public Panel_Layout Option1Enabled;

	// Token: 0x0400148D RID: 5261
	public Panel_Layout Option1Disabled;

	// Token: 0x0400148E RID: 5262
	public String_Layout Option1Label;

	// Token: 0x0400148F RID: 5263
	public Color Option1DisabledLabelColour;

	// Token: 0x04001490 RID: 5264
	public Panel_Layout Option2Enabled;

	// Token: 0x04001491 RID: 5265
	public Panel_Layout Option2Disabled;

	// Token: 0x04001492 RID: 5266
	public String_Layout Option2Label;

	// Token: 0x04001493 RID: 5267
	public Color Option2DisabledLabelColour;

	// Token: 0x04001494 RID: 5268
	public float ElementSpacing;
}
