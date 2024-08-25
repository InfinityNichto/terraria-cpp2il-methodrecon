using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x02000166 RID: 358
public class GUIPVPIcons
{
	// Token: 0x17000104 RID: 260
	// (get) Token: 0x060009FA RID: 2554 RVA: 0x0002F3FC File Offset: 0x0002D5FC
	public bool Collapsed
	{
		get
		{
			if (!true)
			{
			}
			return InterfaceStyles_Layout.Active.IsCollapsed(GUIPageIcons.Category.PVP);
		}
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x0002F41C File Offset: 0x0002D61C
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x0002F438 File Offset: 0x0002D638
	public Rectangle GetRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0002F44C File Offset: 0x0002D64C
	public bool ShowTeamGrids()
	{
		return this.ShowTeamGrid;
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x060009FE RID: 2558 RVA: 0x0002F460 File Offset: 0x0002D660
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0002F478 File Offset: 0x0002D678
	public void DrawTeamGrid()
	{
		if (this.ShowTeamGrid)
		{
			Rectangle region = this.GetRegion();
			!0 instance = PageControllerLayoutDefinition.Instance;
			TransactionButton_Layout transactionButton_Layout;
			Rectangle region2 = GUITransactionButton.GetRegion(transactionButton_Layout);
			return;
		}
		if (this.pickingInterceptor != null)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		if (32640 == 0)
		{
		}
		GUIInputRegionExclusive guiinputRegionExclusive = this.pickingInterceptor;
		if (guiinputRegionExclusive != null)
		{
			int num = 1;
			guiinputRegionExclusive.Active = num != 0;
		}
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x0002F4E0 File Offset: 0x0002D6E0
	public bool IsOver(Vector2 cursorPosition)
	{
		if (this.DrawSelectedPlayerOverlay)
		{
		}
		if (this.TeamGridActive)
		{
			!0 instance = PageControllerLayoutDefinition.Instance;
			!0 instance2 = PageControllerLayoutDefinition.Instance;
			return true;
		}
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x0002F510 File Offset: 0x0002D710
	public void Draw()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		Main.FlushBatches();
		!0 instance = PageControllerLayoutDefinition.Instance;
		bool playerOver = this._playerOver;
		if (!playerOver)
		{
			this._lastPlayerOver = (playerOver ? 1 : 0);
		}
		if (!playerOver)
		{
		}
		if (!playerOver)
		{
		}
		int num = 255;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int myPlayer4 = Main.myPlayer;
		int num2 = 1936;
		if (num2 == 0)
		{
		}
		int teamCooldown = Main.teamCooldown;
		int teamCooldown2 = Main.teamCooldown;
		if (num2 == 0)
		{
		}
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x0002F870 File Offset: 0x0002DA70
	public void OnPlayerDisconected(int player)
	{
		if (this.DrawSelectedPlayerOverlay)
		{
			int selectedPlayer = this.SelectedPlayer;
		}
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x0002F88C File Offset: 0x0002DA8C
	private void DrawSelectedPlayerImage()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Main.gameMenu = true;
		if (!true)
		{
		}
		SpriteBatchItem.PopClippedImageRegion();
		Main.gameMenu = false;
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x0002F8B8 File Offset: 0x0002DAB8
	public void DrawSelectedPlayerPlatformControls()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		int[] connectedPlayers = this.ConnectedPlayers;
		string textValue = Language.GetTextValue("Mobile.VoiceMute");
		string textValue2 = Language.GetTextValue("Mobile.ViewPlayerProfile");
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			return;
		}
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x0002F948 File Offset: 0x0002DB48
	public void DrawSelectedPlayerTeamOnlyElements(bool sameTeam, bool isMyPlayer)
	{
		int num = 1;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (num == 0)
		{
		}
		int[] connectedPlayers = this.ConnectedPlayers;
		string textValue = Language.GetTextValue("GameUI.PlayerLifeMax");
		string text2;
		string text = text2 + textValue;
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0002FA80 File Offset: 0x0002DC80
	public void DrawSelectedPlayer()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		int num = 16256;
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		if (this.pickingInterceptor != null)
		{
		}
		this.DrawSelectedPlayerImage();
		if (!true)
		{
		}
		if (num == 0)
		{
		}
		int[] connectedPlayers = this.ConnectedPlayers;
		int[] connectedPlayers2 = this.ConnectedPlayers;
		string text;
		string textValue = Language.GetTextValue(text);
		if (connectedPlayers2 == null)
		{
		}
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int[] connectedPlayers3 = this.ConnectedPlayers;
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0002FB48 File Offset: 0x0002DD48
	private void RefreshPlayerList()
	{
		int num = 1;
		if (num == 0)
		{
		}
		bool gameMenu = Main.gameMenu;
		if (num == 0)
		{
		}
		if (num != 0)
		{
			if (num == 0)
			{
			}
			if (num != 0)
			{
				int[] connectedPlayers = this.ConnectedPlayers;
				int connectedPlayerCount = this.ConnectedPlayerCount;
				this.ConnectedPlayerCount = connectedPlayerCount;
			}
		}
		int selectedPlayer = this.SelectedPlayer;
		int connectedPlayerCount2 = this.ConnectedPlayerCount;
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x0002FB98 File Offset: 0x0002DD98
	public float TeamScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000A08)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIPVPIcons::TeamScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x06000A09 RID: 2569 RVA: 0x0002FBAC File Offset: 0x0002DDAC
	public void TeamOver(int index)
	{
		int num = 1;
		this.HoverTeam = index;
		if (num == 0)
		{
		}
		ItemSlot.UpdateTooltipContext(43, index);
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
	public void TeamDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		int myPlayer = Main.myPlayer;
		if (this.HoverTeam == 0)
		{
		}
		string text;
		string textValue = Language.GetTextValue("ControllerMappings.PVPTeam" + text);
		if ("ControllerMappings.PVPTeam" == null)
		{
		}
		int hoverTeam = this.HoverTeam;
		Cursor cursor;
		if (cursor != null)
		{
		}
		int myPlayer2 = Main.myPlayer;
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x0002FD04 File Offset: 0x0002DF04
	public float PlayerScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000A0B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIPVPIcons::PlayerScale(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!0(var_0_05, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x06000A0C RID: 2572 RVA: 0x0002FD18 File Offset: 0x0002DF18
	public void PlayerOver(int index)
	{
		int num = 38;
		ItemSlot.UpdateTooltipContext(num, index);
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x0002FD50 File Offset: 0x0002DF50
	public void PlayerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (this.ConnectedPlayerCount == 0)
		{
		}
		int[] connectedPlayers = this.ConnectedPlayers;
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x0002FE34 File Offset: 0x0002E034
	private void DrawPlayer(Player player, Vector2 position, Vector2 size, bool animated)
	{
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x0002FE44 File Offset: 0x0002E044
	public GUIPVPIcons()
	{
	}

	// Token: 0x040009D7 RID: 2519
	private int HoverPlayer;

	// Token: 0x040009D8 RID: 2520
	private int HoverTeam;

	// Token: 0x040009D9 RID: 2521
	private int SelectedPlayer;

	// Token: 0x040009DA RID: 2522
	private float PVPEnabledScale;

	// Token: 0x040009DB RID: 2523
	private float SelectedplayerScale;

	// Token: 0x040009DC RID: 2524
	public int ConnectedPlayerCount;

	// Token: 0x040009DD RID: 2525
	private int[] ConnectedPlayers;

	// Token: 0x040009DE RID: 2526
	public bool ShowTeamGrid;

	// Token: 0x040009DF RID: 2527
	public bool TeamGridActive;

	// Token: 0x040009E0 RID: 2528
	public float scrollOffset;

	// Token: 0x040009E1 RID: 2529
	private float scrollMomentum;

	// Token: 0x040009E2 RID: 2530
	private int scrollDragging;

	// Token: 0x040009E3 RID: 2531
	private Vector2 dragOffset;

	// Token: 0x040009E4 RID: 2532
	private float scrollDelay;

	// Token: 0x040009E5 RID: 2533
	public string playerString;

	// Token: 0x040009E6 RID: 2534
	private int _lastPlayerOver;

	// Token: 0x040009E7 RID: 2535
	private bool _playerOver;

	// Token: 0x040009E8 RID: 2536
	private GUIInputRegionExclusive pickingInterceptor;

	// Token: 0x040009E9 RID: 2537
	private Player clonePlayer;

	// Token: 0x040009EA RID: 2538
	private Vector2 CharacterDrawOffset;

	// Token: 0x040009EB RID: 2539
	public int DrawSelectedPlayerOverlayStart;

	// Token: 0x040009EC RID: 2540
	public bool DrawSelectedPlayerOverlay;

	// Token: 0x040009ED RID: 2541
	private string playerStringBanner;

	// Token: 0x040009EE RID: 2542
	private Player EmptyPlayer;
}
