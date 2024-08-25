using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000219 RID: 537
[Serializable]
public class SettingsOverlaySlider_Layout
{
	// Token: 0x06000CC9 RID: 3273 RVA: 0x0003E3F4 File Offset: 0x0003C5F4
	public SettingsOverlaySlider_Layout()
	{
	}

	// Token: 0x04001482 RID: 5250
	public TransactionButton_Layout Title;

	// Token: 0x04001483 RID: 5251
	public Slider_Layout Option;

	// Token: 0x04001484 RID: 5252
	public Slider_Layout HueOption;

	// Token: 0x04001485 RID: 5253
	public Slider_Layout SaturationOption;

	// Token: 0x04001486 RID: 5254
	public Slider_Layout LightOption;

	// Token: 0x04001487 RID: 5255
	public String_Layout Value;

	// Token: 0x04001488 RID: 5256
	public Color DisabledNotchColor;

	// Token: 0x04001489 RID: 5257
	public Color DisabledValueColor;

	// Token: 0x0400148A RID: 5258
	public float ElementSpacing;
}
