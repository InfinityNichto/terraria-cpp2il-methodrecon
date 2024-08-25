using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

// Token: 0x0200029B RID: 667
public class GUISaveSynchronisation_Lobby
{
	// Token: 0x06000FA5 RID: 4005 RVA: 0x0004E6C0 File Offset: 0x0004C8C0
	public static void Draw()
	{
		if (!true)
		{
		}
		int num = 1;
		if (num == 0)
		{
		}
		int value = num.m_value;
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x0004E700 File Offset: 0x0004C900
	public static void RefreshServers()
	{
		if (!true)
		{
		}
		SaveSynchronisationFinder.UpdateResults();
		if (!true)
		{
		}
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x0004E718 File Offset: 0x0004C918
	private static void DrawServers()
	{
		if (!true)
		{
		}
		GUISaveSynchronisation_Lobby.RefreshServers();
		int num = 255;
		string textValue = Language.GetTextValue("Mobile.SearchingSaveDevices");
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		if (6899 == 0)
		{
		}
		string textValue2 = Language.GetTextValue("Mobile.ConnectSaveServerIP");
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x000021DB File Offset: 0x000003DB
	private static float ServerScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x0004E770 File Offset: 0x0004C970
	private static void ServerOver(int index)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x0004E780 File Offset: 0x0004C980
	private static void ServerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (32640 == 0)
		{
		}
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x0004E81C File Offset: 0x0004CA1C
	private static void DrawServer(SaveSynchronisationFinder.SearchServerResult serverData)
	{
		DrPlatform.DrPlatformType platform = serverData.Platform;
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x0004E83C File Offset: 0x0004CA3C
	private static void Back()
	{
		GUISaveSynchronisation.Close();
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x0004E850 File Offset: 0x0004CA50
	private static void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x0004E894 File Offset: 0x0004CA94
	public GUISaveSynchronisation_Lobby()
	{
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x0004E8A8 File Offset: 0x0004CAA8
	// Note: this type is marked as 'beforefieldinit'.
	static GUISaveSynchronisation_Lobby()
	{
	}

	// Token: 0x04001C49 RID: 7241
	private static Rectangle SelectedItemRegion;

	// Token: 0x04001C4A RID: 7242
	public static float ScrollOffset;

	// Token: 0x04001C4B RID: 7243
	private static float ScrollMomentum;

	// Token: 0x04001C4C RID: 7244
	private static int ScrollDragging;

	// Token: 0x04001C4D RID: 7245
	private static Vector2 DragOffset;

	// Token: 0x04001C4E RID: 7246
	private static float TitleScale;

	// Token: 0x04001C4F RID: 7247
	private static float ConnectIPScale;

	// Token: 0x04001C50 RID: 7248
	private static float connectButtonScale;

	// Token: 0x04001C51 RID: 7249
	private static float backButtonScale;

	// Token: 0x04001C52 RID: 7250
	private static DateTime LastSelectTime;

	// Token: 0x04001C53 RID: 7251
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x04001C54 RID: 7252
	private static GUIControllerSaveSynchronisation_Lobby _controllerInput;

	// Token: 0x04001C55 RID: 7253
	public static int selectedServer;

	// Token: 0x04001C56 RID: 7254
	private static int serverOver;
}
