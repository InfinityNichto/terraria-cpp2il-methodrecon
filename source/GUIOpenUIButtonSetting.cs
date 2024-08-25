using System;
using Cpp2IlInjected;
using Terraria;

// Token: 0x0200028E RID: 654
public class GUIOpenUIButtonSetting : GUISettingEntry
{
	// Token: 0x06000F41 RID: 3905 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
	public GUIOpenUIButtonSetting(GUISettingID id)
	{
		this._id = id;
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x000021DB File Offset: 0x000003DB
	protected virtual SettingsOverlayListOption_Layout GetLayout()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x0004C3BC File Offset: 0x0004A5BC
	public override void Draw()
	{
		GUISettingID id = this._id;
		GUISettingID id2 = this._id;
		string option = this.GetOption();
		bool flag = string.IsNullOrEmpty(this.GetButtonCaption());
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x000021DB File Offset: 0x000003DB
	public override float GetElementHeight()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x0004C41C File Offset: 0x0004A61C
	private string GetButtonCaption()
	{
		GUISettingID id = this._id;
		return "Mobile.ButtonActionReset";
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x0004C45C File Offset: 0x0004A65C
	private string GetOption()
	{
		GUISettingID id = this._id;
		return "Mobile.TimeMidnightTitle";
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x0004C4B0 File Offset: 0x0004A6B0
	private void OpenUI()
	{
		GUISettingID id = this._id;
		Main.menuMode = 889;
	}

	// Token: 0x04001B71 RID: 7025
	private float scale;
}
