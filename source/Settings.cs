using System;
using UnityEngine;

// Token: 0x0200029D RID: 669
public class Settings : LayoutDefinition
{
	// Token: 0x06000FB2 RID: 4018 RVA: 0x0004E8EC File Offset: 0x0004CAEC
	private void Awake()
	{
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0004E8FC File Offset: 0x0004CAFC
	public Settings()
	{
	}

	// Token: 0x04001C57 RID: 7255
	public static Settings Instance;

	// Token: 0x04001C58 RID: 7256
	public SettingsTooltips Tooltips;

	// Token: 0x04001C59 RID: 7257
	public int BannerTooltipItemWidth;

	// Token: 0x04001C5A RID: 7258
	public float DeselectedPageFade;

	// Token: 0x04001C5B RID: 7259
	public AnimationCurve SliderSpeed;

	// Token: 0x04001C5C RID: 7260
	public AnimationCurve AimCursorSpeed;

	// Token: 0x04001C5D RID: 7261
	public float MouseScrollSensitivity;

	// Token: 0x04001C5E RID: 7262
	public float GridScrollSpeed;
}
