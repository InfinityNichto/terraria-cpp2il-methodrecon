using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000296 RID: 662
public class GUIToggleSetting : GUISettingEntry
{
	// Token: 0x06000F75 RID: 3957 RVA: 0x0004D8E4 File Offset: 0x0004BAE4
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/Settings_ToggleOn");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/Settings_ToggleOff");
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x0004D90C File Offset: 0x0004BB0C
	public GUIToggleSetting(GUISettingID id)
	{
		this._id = id;
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x000021DB File Offset: 0x000003DB
	protected virtual SettingsOverlayToggle_Layout GetLayout()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x000021DB File Offset: 0x000003DB
	protected virtual SettingsOverlayToggle_Layout GetDisabledLayout()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x0004D928 File Offset: 0x0004BB28
	public override void Draw()
	{
		if (!true)
		{
		}
		bool gameMenu = Main.gameMenu;
		GUISettingID id = this._id;
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x000021DB File Offset: 0x000003DB
	public override float GetElementHeight()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x0004D9A8 File Offset: 0x0004BBA8
	private string GetOptionOn()
	{
		return "Mobile.ToggleSetting60";
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x0004D9E8 File Offset: 0x0004BBE8
	private string GetOptionOff()
	{
		GUISettingID id = this._id;
		return "Mobile.ToggleSettingOff";
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x0004DA24 File Offset: 0x0004BC24
	private string GetOption()
	{
		GUISettingID id = this._id;
		return "Mobile.AutoSaveTitle";
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x0004DB64 File Offset: 0x0004BD64
	private bool GetSelected()
	{
		GUISettingID id = this._id;
		if (!false)
		{
		}
		return Main.autoSave;
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x0004DCF4 File Offset: 0x0004BEF4
	private void Toggle()
	{
		GUISettingID id = this._id;
	}

	// Token: 0x04001C23 RID: 7203
	private static Texture2D ToggleOff;

	// Token: 0x04001C24 RID: 7204
	private static Texture2D ToggleOn;

	// Token: 0x04001C25 RID: 7205
	private float scale;
}
