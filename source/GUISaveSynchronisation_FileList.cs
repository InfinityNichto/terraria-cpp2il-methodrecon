using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;

// Token: 0x02000299 RID: 665
public class GUISaveSynchronisation_FileList
{
	// Token: 0x06000F94 RID: 3988 RVA: 0x0004E1D0 File Offset: 0x0004C3D0
	public static void Draw()
	{
		if (!true)
		{
		}
		if (true)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x0004E1F0 File Offset: 0x0004C3F0
	private static void DrawCategories()
	{
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x0004E274 File Offset: 0x0004C474
	private static void Back()
	{
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x0004E284 File Offset: 0x0004C484
	private static void UpdateAnim(Player player, bool animated)
	{
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0004E2C4 File Offset: 0x0004C4C4
	private static void DrawPlayer(Player player, bool animated)
	{
		if (!true)
		{
		}
		GUISaveSynchronisation_FileList.UpdateAnim(player, animated);
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x0004E2E0 File Offset: 0x0004C4E0
	private static void DrawPlayers(List<PlayerFileData> playerFiles)
	{
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x000021DB File Offset: 0x000003DB
	private static float PlayerScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x0004E31C File Offset: 0x0004C51C
	private static void PlayerOver(int index)
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0004E33C File Offset: 0x0004C53C
	private static void PlayerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0004E494 File Offset: 0x0004C694
	private static void DrawWorlds(List<WorldFileData> worldFiles)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x000021DB File Offset: 0x000003DB
	private static float WorldScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x0004E4DC File Offset: 0x0004C6DC
	private static void WorldOver(int index)
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0004E4FC File Offset: 0x0004C6FC
	private static void DrawWorld(WorldFileData worldData)
	{
		Texture2D worldIcon = GUISaveSynchronisation_FileList.GetWorldIcon(worldData);
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x0004E518 File Offset: 0x0004C718
	private static Texture2D GetWorldIcon(WorldFileData worldData)
	{
		return "Images/UI/Icon";
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x0004E538 File Offset: 0x0004C738
	private static void WorldDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x0004E698 File Offset: 0x0004C898
	public GUISaveSynchronisation_FileList()
	{
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0004E6AC File Offset: 0x0004C8AC
	// Note: this type is marked as 'beforefieldinit'.
	static GUISaveSynchronisation_FileList()
	{
		if (2 == 0)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x04001C31 RID: 7217
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x04001C32 RID: 7218
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x04001C33 RID: 7219
	private static GUIControllerSaveSynchronisation_FileListWorld _worldController;

	// Token: 0x04001C34 RID: 7220
	private static GUIControllerSaveSynchronisation_FileListPlayer _playerController;

	// Token: 0x04001C35 RID: 7221
	private static GUISaveSynchronisation_FileList.Filter CurrentFilter;

	// Token: 0x04001C36 RID: 7222
	private static Vector2 CharacterOffset;

	// Token: 0x04001C37 RID: 7223
	private static int playerOver;

	// Token: 0x04001C38 RID: 7224
	public static List<PlayerFileData> SortedPlayerData;

	// Token: 0x04001C39 RID: 7225
	public static int SelectedPlayerItem;

	// Token: 0x04001C3A RID: 7226
	public static float ScrollOffset;

	// Token: 0x04001C3B RID: 7227
	private static float ScrollMomentum;

	// Token: 0x04001C3C RID: 7228
	private static int ScrollDragging;

	// Token: 0x04001C3D RID: 7229
	private static Vector2 DragOffset;

	// Token: 0x04001C3E RID: 7230
	private static int worldOver;

	// Token: 0x04001C3F RID: 7231
	public static List<WorldFileData> SortedWorldData;

	// Token: 0x04001C40 RID: 7232
	public static int SelectedWorldItem;

	// Token: 0x04001C41 RID: 7233
	private static DateTime LastSelectTime;

	// Token: 0x04001C42 RID: 7234
	private static DateTime LastTouchTime;

	// Token: 0x04001C43 RID: 7235
	private static Vector2 LastTouchMouse;

	// Token: 0x0200029A RID: 666
	private enum Filter
	{
		// Token: 0x04001C45 RID: 7237
		LocalPlayers,
		// Token: 0x04001C46 RID: 7238
		LocalWorlds,
		// Token: 0x04001C47 RID: 7239
		ServerPlayers,
		// Token: 0x04001C48 RID: 7240
		ServerWorlds
	}
}
