using System;
using Cpp2IlInjected;

// Token: 0x02000293 RID: 659
public class GUISettingEntry
{
	// Token: 0x06000F66 RID: 3942 RVA: 0x0004D2B4 File Offset: 0x0004B4B4
	public GUISettingEntry(GUISettingID id)
	{
		this._id = id;
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x0004D2D0 File Offset: 0x0004B4D0
	public virtual void Draw()
	{
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x000021DB File Offset: 0x000003DB
	public virtual float GetElementHeight()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x0004D2E0 File Offset: 0x0004B4E0
	public virtual void DrawOverlay()
	{
	}

	// Token: 0x04001B7C RID: 7036
	public GUISettingID _id;

	// Token: 0x04001B7D RID: 7037
	public int _sortId;

	// Token: 0x04001B7E RID: 7038
	public SettingsOverlayOptionCategories_Layout.Category _category;
}
