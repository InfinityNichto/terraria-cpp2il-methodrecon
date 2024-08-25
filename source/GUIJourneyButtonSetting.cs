using System;
using Cpp2IlInjected;

// Token: 0x02000184 RID: 388
public class GUIJourneyButtonSetting : GUIOpenUIButtonSetting
{
	// Token: 0x06000AFE RID: 2814 RVA: 0x00037688 File Offset: 0x00035888
	public GUIJourneyButtonSetting(GUISettingID id)
		: base(id)
	{
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x0003769C File Offset: 0x0003589C
	public override void Draw()
	{
		int num = 1;
		base.Draw();
		GUISettingID id = this._id;
		if (num == 0)
		{
		}
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x000021DB File Offset: 0x000003DB
	protected override SettingsOverlayListOption_Layout GetLayout()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x04000B8D RID: 2957
	private float iconScale;
}
