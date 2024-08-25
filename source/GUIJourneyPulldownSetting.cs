using System;
using Microsoft.Xna.Framework;

// Token: 0x02000185 RID: 389
public class GUIJourneyPulldownSetting : GUIPulldownSetting
{
	// Token: 0x06000B01 RID: 2817 RVA: 0x000376BC File Offset: 0x000358BC
	public GUIJourneyPulldownSetting(GUISettingID id)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x000376D4 File Offset: 0x000358D4
	public override void Draw()
	{
		base.Draw();
		GUISettingID id = this._id;
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x000376F0 File Offset: 0x000358F0
	private static void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x00037700 File Offset: 0x00035900
	private static void DeactivateOverlay()
	{
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00037710 File Offset: 0x00035910
	private static void RegisterOverlayJM(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}

	// Token: 0x04000B8E RID: 2958
	private float iconScale;
}
