using System;
using Cpp2IlInjected;

// Token: 0x02000188 RID: 392
public class GUIJourneyToggleSetting : GUIToggleSetting
{
	// Token: 0x06000B0F RID: 2831 RVA: 0x00037F78 File Offset: 0x00036178
	public GUIJourneyToggleSetting(GUISettingID id)
		: base(id)
	{
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00037F8C File Offset: 0x0003618C
	public override void Draw()
	{
		int num = 1;
		base.Draw();
		if (num == 0)
		{
		}
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x000021DB File Offset: 0x000003DB
	protected override SettingsOverlayToggle_Layout GetLayout()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x04000B96 RID: 2966
	private float iconScale;
}
