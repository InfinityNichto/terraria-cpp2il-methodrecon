using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics;
using Terraria.Localization;

// Token: 0x0200026A RID: 618
public class GUIMultiplayerLobby
{
	// Token: 0x06000DDE RID: 3550 RVA: 0x00042B4C File Offset: 0x00040D4C
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/ButtonFavoriteActive");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/ButtonFavoriteInactive");
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00042B74 File Offset: 0x00040D74
	private GUIContollerTransactionButtonList MultiplayerLobbyOptionsController
	{
		get
		{
			throw new ArrayTypeMismatchException();
		}
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00042B88 File Offset: 0x00040D88
	public void Draw()
	{
		if (!true)
		{
		}
		GUIControllerMultiplayerLobby controllerInput = this._controllerInput;
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00042C18 File Offset: 0x00040E18
	private void DrawPlatformFriends()
	{
		GUIMultiplayerLobby.ItemSelection currentSelection = this.CurrentSelection;
		if (currentSelection != GUIMultiplayerLobby.ItemSelection.Local)
		{
			this.selectedServer = (int)currentSelection;
		}
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00042C38 File Offset: 0x00040E38
	private void DrawCategoryButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		GUIMultiplayerLobby.ItemSelection currentSelection = this.CurrentSelection;
		GUIControllerMultiplayerLobby controllerInput = this._controllerInput;
		this.CurrentSelection = currentSelection;
		controllerInput.Activate();
		if (currentSelection == GUIMultiplayerLobby.ItemSelection.Local)
		{
		}
		GUIMultiplayerLobby.ItemSelection currentSelection2 = this.CurrentSelection;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		if (currentSelection == GUIMultiplayerLobby.ItemSelection.Local)
		{
		}
		GUIMultiplayerLobby.ItemSelection currentSelection3 = this.CurrentSelection;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			int num = 1;
			this.CurrentSelection = (GUIMultiplayerLobby.ItemSelection)num;
		}
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00042CAC File Offset: 0x00040EAC
	public void Startup()
	{
		if (!true)
		{
		}
		ServerAutoFinder.StartSearching();
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00042CC4 File Offset: 0x00040EC4
	public void Shutdown()
	{
		if (!true)
		{
		}
		ServerAutoFinder.StopSearching();
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00042CDC File Offset: 0x00040EDC
	private void DrawLocal()
	{
		this.RefreshLocalServers();
		if (this.NoPlatformFriends)
		{
			string textValue = Language.GetTextValue("Mobile.StadiaNoFriends");
			return;
		}
		string textValue2 = Language.GetTextValue("Mobile.StadiaSearchingFriendGames");
		if ("Mobile.StadiaSearchingFriendGames" == null)
		{
		}
		if ("Mobile.StadiaSearchingFriendGames" == null)
		{
		}
		if (6899 == 0)
		{
		}
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		SpriteBatchItem.DisabledClipping();
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00042D50 File Offset: 0x00040F50
	private void DrawOptions()
	{
		GUIMultiplayerLobby.ItemSelection currentSelection = this.CurrentSelection;
		Rectangle rectangle = this.fullClipRegion;
		int width = this.fullClipRegion.Width;
		Rectangle rectangle2 = this.dragClipRegion;
		int width2 = this.dragClipRegion.Width;
		ControlAnchor.SetGridItemRegion(rectangle);
		int num = this.selectedServer;
		int size = this.serverList._size;
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00042E48 File Offset: 0x00041048
	private void DrawDedicated()
	{
		this.RefreshDedicatedServers();
		int size = this.serverList._size;
		this.dragClipRegion.X = (int)0f;
		Rectangle rectangle = this.fullClipRegion;
		int width = this.fullClipRegion.Width;
		Rectangle rectangle2 = this.dragClipRegion;
		int width2 = this.dragClipRegion.Width;
		bool flag = this.serverJoinAvailable;
		GUITransactionButton.InputState inputState;
		GUIControllerMultiplayerLobby controllerInput;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			controllerInput = this._controllerInput;
		}
		SpriteBatchItem.DisabledClipping();
		if (controllerInput == null)
		{
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshLocalServers()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshDedicatedServers()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00042ECC File Offset: 0x000410CC
	private Texture2D GetIcon(GUIMultiplayerLobby.ServerInformation serverData)
	{
		bool isHardMode = serverData.IsHardMode;
		if (!serverData.HasCorruption)
		{
		}
		string text;
		return TextureManager.Load(text);
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00042EF0 File Offset: 0x000410F0
	private void DrawServer(GUIMultiplayerLobby.ServerInformation serverData)
	{
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x00042F04 File Offset: 0x00041104
	private void JoinServerCheck()
	{
		List<GUIMultiplayerLobby.ServerInformation> list = this.serverList;
		int num = this.selectedServer;
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x00042F28 File Offset: 0x00041128
	public Vector2 ServerItemSize(int index)
	{
		/*
An exception occurred when decompiling this method (06000DED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 GUIMultiplayerLobby::ServerItemSize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIMultiplayerLobby::selectedServer, ldloc:GUIMultiplayerLobby(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00042F3C File Offset: 0x0004113C
	private void ServerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = this.selectedServer;
		int num2 = this.selectedServer;
		int num3 = this.serverOver;
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00043170 File Offset: 0x00041370
	private void OpenPlatformInvite()
	{
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00043180 File Offset: 0x00041380
	private void DrawMainButtons()
	{
		int num = 1;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int num2 = this.selectedServer;
		int size = this.serverList._size;
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x000431D8 File Offset: 0x000413D8
	private void Back()
	{
		GUIControllerMultiplayerLobby controllerInput = this._controllerInput;
		Main.menuMode = 1;
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x000021DB File Offset: 0x000003DB
	private float ServerScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x000431F4 File Offset: 0x000413F4
	private void ServerOver(int index)
	{
		this.serverOver = index;
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00043208 File Offset: 0x00041408
	public GUIMultiplayerLobby.ServerInformation ActiveServer()
	{
		List<GUIMultiplayerLobby.ServerInformation> list = this.serverList;
		int num = this.selectedServer;
		return 1;
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00043224 File Offset: 0x00041424
	private void JoinServer()
	{
		List<GUIMultiplayerLobby.ServerInformation> list = this.serverList;
		int num = this.selectedServer;
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00043260 File Offset: 0x00041460
	public void StartNewServer()
	{
		GUIMultiplayerLobby.ItemSelection currentSelection = this.CurrentSelection;
		Main.LoadWorlds();
		Main.menuMode = 6;
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00043284 File Offset: 0x00041484
	private void AddDedicatedServer()
	{
		if (!true)
		{
		}
		Main.menuMode = 449;
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x000432A0 File Offset: 0x000414A0
	private int SortEntry(GUIMultiplayerLobby.ServerInformation a, GUIMultiplayerLobby.ServerInformation b)
	{
		bool favorite = a.Favorite;
		bool favorite2 = b.Favorite;
		return 1;
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x000432C0 File Offset: 0x000414C0
	public int CompareNatural(string strA, string strB)
	{
		if (!true)
		{
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		int num;
		return num;
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x000432DC File Offset: 0x000414DC
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		long num2;
		for (;;)
		{
			int stringLength = strB._stringLength;
			int stringLength2 = strA._stringLength;
			long num = 0L;
			num2 = 0L;
			char c = strA[(int)num];
			if (stringLength2 == 0)
			{
			}
			bool flag = char.IsDigit(c);
			bool flag2 = char.IsDigit(strB[(int)num2]);
			char c2 = strA[(int)num];
			char c3 = strA[(int)num];
			if (stringLength2 == 0)
			{
			}
			double numericValue = char.GetNumericValue(c3);
			char c4 = strB[(int)num2];
			double numericValue2 = char.GetNumericValue(strB[(int)num2]);
			int stringLength3 = strA._stringLength;
			char c5 = strA[(int)num];
			int stringLength4 = strA._stringLength;
			int stringLength5 = strB._stringLength;
			char c6 = strB[(int)num2];
			int stringLength6 = strB._stringLength;
			int stringLength7 = strA._stringLength;
			char c7 = strA[(int)num];
			if (stringLength2 == 0)
			{
			}
			bool flag3 = char.IsDigit(c7);
			long num3 = 0L;
			int stringLength8 = strB._stringLength;
			char c8 = strB[(int)num2];
			if (stringLength2 == 0)
			{
			}
			bool flag4 = char.IsDigit(c8);
			if (num3 != 0L)
			{
				goto IL_00EF;
			}
			if (c4 != '\0')
			{
				goto IL_010F;
			}
			long num4;
			if (num3 == 0L)
			{
				num4 = 0L;
				while (num3 == 0L)
				{
				}
				goto IL_00EF;
			}
			goto IL_0130;
			IL_0139:
			string text5;
			if (num4 != 0L)
			{
				char c9 = strB[(int)num2];
				int num5 = 1;
				int stringLength9 = strA._stringLength;
				char c10 = strA[(int)num];
				if (stringLength9 == 0)
				{
				}
				bool flag5 = char.IsDigit(c10);
				int stringLength10 = strB._stringLength;
				char c11 = strB[(int)num2];
				if (stringLength9 == 0)
				{
				}
				bool flag6 = char.IsDigit(c11);
				int stringLength11 = strB._stringLength;
				if (num4 == 0L)
				{
					goto IL_01EA;
				}
				string text = strA.Substring((int)num, num5);
				string text2 = strB.Substring((int)num3, (int)c11);
				string text3 = text + "1";
				string text4 = text2 + "2";
				text5 = text + "2";
				string text6 = text2 + "1";
			}
			if (text5 != null)
			{
				continue;
			}
			IL_01EA:
			int stringLength12 = strB._stringLength;
			int stringLength13 = strA._stringLength;
			if (stringLength12 != 0)
			{
				break;
			}
			continue;
			IL_010F:
			char c12 = strB[(int)num2];
			int num6;
			if (num6 == 0)
			{
			}
			double numericValue3 = char.GetNumericValue(c12);
			if (num3 == 0L)
			{
				goto IL_0139;
			}
			IL_0130:
			char c13 = strA[(int)num];
			goto IL_0139;
			IL_00EF:
			char c14 = strA[(int)num];
			if (stringLength2 == 0)
			{
			}
			double numericValue4 = char.GetNumericValue(c14);
			num6 = 32768;
			while (num4 == 0L)
			{
			}
			goto IL_010F;
		}
		while (num2 == 0L)
		{
		}
		return 1;
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x000434F0 File Offset: 0x000416F0
	public GUIMultiplayerLobby()
	{
		long num = 1065353216L;
		this.NewScale = (float)num;
		base..ctor();
	}

	// Token: 0x0400197E RID: 6526
	public GUIMultiplayerLobby.ItemSelection CurrentSelection;

	// Token: 0x0400197F RID: 6527
	public bool NoPlatformFriends;

	// Token: 0x04001980 RID: 6528
	private float localScale;

	// Token: 0x04001981 RID: 6529
	private float dedicatedScale;

	// Token: 0x04001982 RID: 6530
	private float joinButtonScale;

	// Token: 0x04001983 RID: 6531
	private float backButtonScale;

	// Token: 0x04001984 RID: 6532
	private float NewScale;

	// Token: 0x04001985 RID: 6533
	private float TitleScale;

	// Token: 0x04001986 RID: 6534
	private float DeleteScale;

	// Token: 0x04001987 RID: 6535
	public int previousMenu;

	// Token: 0x04001988 RID: 6536
	private DateTime LastSelectTime;

	// Token: 0x04001989 RID: 6537
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x0400198A RID: 6538
	public float ScrollOffset;

	// Token: 0x0400198B RID: 6539
	private float ScrollMomentum;

	// Token: 0x0400198C RID: 6540
	private int ScrollDragging;

	// Token: 0x0400198D RID: 6541
	private Vector2 DragOffset;

	// Token: 0x0400198E RID: 6542
	private Rectangle SelectedItemRegion;

	// Token: 0x0400198F RID: 6543
	private bool serverJoinAvailable;

	// Token: 0x04001990 RID: 6544
	public int SelectedServerRealID;

	// Token: 0x04001991 RID: 6545
	private static Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x04001992 RID: 6546
	private static Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x04001993 RID: 6547
	private GUIControllerMultiplayerLobby _controllerInput;

	// Token: 0x04001994 RID: 6548
	private GUIContollerTransactionButtonList _multiplayerLobbyOptionsController;

	// Token: 0x04001995 RID: 6549
	public int selectedServer;

	// Token: 0x04001996 RID: 6550
	public List<GUIMultiplayerLobby.ServerInformation> serverList;

	// Token: 0x04001997 RID: 6551
	private Rectangle fullClipRegion;

	// Token: 0x04001998 RID: 6552
	private Rectangle dragClipRegion;

	// Token: 0x04001999 RID: 6553
	private int serverOver;

	// Token: 0x0200026B RID: 619
	public enum ItemSelection
	{
		// Token: 0x0400199B RID: 6555
		Local,
		// Token: 0x0400199C RID: 6556
		Dedicated
	}

	// Token: 0x0200026C RID: 620
	public struct ServerInformation
	{
		// Token: 0x06000DFC RID: 3580 RVA: 0x0004351C File Offset: 0x0004171C
		public ServerInformation(string worldName, string hostName, string serverIPText, int port, int players, int maxPlayers, int worldWidth, bool corruption, short gameMode, bool hardMode, bool active = true, bool favorite = false, int realID = 0, [Optional] MPSession existingSession)
		{
			this.WorldName = worldName;
			this.CurrentPlayers = players;
			this.WorldWidth = maxPlayers;
			this.WorldWidth = worldWidth;
			this.ServerIPText = serverIPText;
			this.ServerPort = port;
			this.HostName = hostName;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00043560 File Offset: 0x00041760
		public string WorldSize
		{
			get
			{
				int worldWidth = this.WorldWidth;
				string text;
				return text;
			}
		}

		// Token: 0x0400199D RID: 6557
		public int RealID;

		// Token: 0x0400199E RID: 6558
		public string WorldName;

		// Token: 0x0400199F RID: 6559
		public int CurrentPlayers;

		// Token: 0x040019A0 RID: 6560
		public int MaxPlayers;

		// Token: 0x040019A1 RID: 6561
		public int WorldWidth;

		// Token: 0x040019A2 RID: 6562
		public bool HasCorruption;

		// Token: 0x040019A3 RID: 6563
		public short GameMode;

		// Token: 0x040019A4 RID: 6564
		public bool IsHardMode;

		// Token: 0x040019A5 RID: 6565
		public string ServerIPText;

		// Token: 0x040019A6 RID: 6566
		public int ServerPort;

		// Token: 0x040019A7 RID: 6567
		public string HostName;

		// Token: 0x040019A8 RID: 6568
		public bool Active;

		// Token: 0x040019A9 RID: 6569
		public bool Favorite;

		// Token: 0x040019AA RID: 6570
		public MPSession ExistingSession;
	}
}
