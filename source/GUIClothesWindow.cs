using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;

// Token: 0x0200012C RID: 300
public class GUIClothesWindow
{
	// Token: 0x060007C6 RID: 1990 RVA: 0x0001DF9C File Offset: 0x0001C19C
	public int GetSelectedStyle()
	{
		int[] array = this.playerStyles;
		if (array == null)
		{
			return;
		}
		Player player = this.clonePlayer;
		if (player != null)
		{
			int skinVariant = player.skinVariant;
			return array;
		}
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
	public void LoadRegion()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0001DFDC File Offset: 0x0001C1DC
	public bool IsOverPanel(Vector2 cursorPosition)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		return true;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x0001DFF8 File Offset: 0x0001C1F8
	public string GetTitle()
	{
		/*
An exception occurred when decompiling this method (060007C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String GUIClothesWindow::GetTitle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004B:
	stloc:int32(var_16_53, callgetter:int32(Main::get_interactedDresserTopLeftX))
	stloc:int32(var_18_5D, callgetter:int32(Main::get_interactedDresserTopLeftY))
	stloc:int16(var_20_66, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_19)))
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

	// Token: 0x060007CA RID: 1994 RVA: 0x0001E06C File Offset: 0x0001C26C
	public string GetName()
	{
		/*
An exception occurred when decompiling this method (060007CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String GUIClothesWindow::GetName()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0052:
	stloc:int32(var_17_5A, callgetter:int32(Main::get_interactedDresserTopLeftX))
	stloc:int32(var_19_64, callgetter:int32(Main::get_interactedDresserTopLeftY))
	stloc:int16(var_21_6D, callgetter:int16(Tile::get_frameX, ldloc:Tile[exp:valuetype Terraria.Tile&](var_20)))
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

	// Token: 0x060007CB RID: 1995 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
	private void DrawPlayer()
	{
		Main.gameMenu = true;
		Player player = this.clonePlayer;
		float x = this.CharacterDrawOffset.X;
		float y = this.CharacterDrawOffset.Y;
		Main.gameMenu = false;
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x0001E124 File Offset: 0x0001C324
	public void Draw()
	{
		int num = 1;
		bool flag = Main.npcChatText != "";
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		if (Main.npcShop != 0)
		{
			Main.CancelClothesWindow(false);
			return;
		}
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (num == 0)
		{
		}
		bool inGuideCraftMenu = Main.InGuideCraftMenu;
		if (num == 0)
		{
		}
		int interactedDresserTopLeftX = Main.interactedDresserTopLeftX;
		int interactedDresserTopLeftY = Main.interactedDresserTopLeftY;
		Tile tile;
		ushort type = tile.type;
		GUIControllerDresser controller = this._controller;
		GUIControllerDresser controller2 = this._controller;
		Player localPlayer = Main.LocalPlayer;
		int interactedDresserTopLeftX2 = Main.interactedDresserTopLeftX;
		int interactedDresserTopLeftY2 = Main.interactedDresserTopLeftY;
		bool flag2 = localPlayer.IsInInteractionRangeToMultiTileHitbox(interactedDresserTopLeftX2, interactedDresserTopLeftY2);
		int interactedDresserTopLeftX3 = Main.interactedDresserTopLeftX;
		int interactedDresserTopLeftY3 = Main.interactedDresserTopLeftY;
		Tile tile2;
		bool flag3 = tile2.active();
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		this.ClonePlayer();
		if (Main.selClothes != 0)
		{
			this.DrawHSLSlider();
			return;
		}
		this.DrawStyles();
		this.DrawCategoryButtons();
		this.DrawChangeButton();
		this.DrawCancelButton();
		this.DrawPlayer();
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x0001E238 File Offset: 0x0001C438
	private void DrawButtons()
	{
		this.DrawChangeButton();
		this.DrawCancelButton();
	}

	// Token: 0x060007CE RID: 1998 RVA: 0x0001E254 File Offset: 0x0001C454
	private void DrawCancelButton()
	{
		string textValue = Language.GetTextValue("LegacyInterface.52");
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		Main.CancelClothesWindow(false);
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x0001E278 File Offset: 0x0001C478
	public void DrawPlayer(Player drawPlayer, Vector2 Position, float rotation, Vector2 rotationOrigin, float shadow = 0f)
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x0001E288 File Offset: 0x0001C488
	private void DrawSelectedPlayer(Vector2 position, float scale)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		Vector2 screenPosition = Main.screenPosition;
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (!true)
		{
		}
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x0001E2BC File Offset: 0x0001C4BC
	public void DrawChangeButton()
	{
		string textValue = Language.GetTextValue("GameUI.Change");
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		Main.SaveClothesWindow();
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x0001E2E0 File Offset: 0x0001C4E0
	private void DrawCategoryButtons()
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
		int num2 = 17096;
		this.TimeSinceItemChange = (float)num2;
		string textValue = Language.GetTextValue("Mobile.ControlsPageNext");
		Main.selClothes = Main.selClothes;
		int selClothes = Main.selClothes;
		Main.selClothes = 6;
		GUIControllerDresser controller = this._controller;
		int num3 = 7;
		controller.selectedControl = (GUIControllerDresser.Controls)num3;
		Main.selClothes = Main.selClothes;
		int selClothes2 = Main.selClothes;
		Main.selClothes = 0;
		GUIControllerDresser controller2 = this._controller;
		int num4 = 7;
		controller2.selectedControl = (GUIControllerDresser.Controls)num4;
		int myPlayer = Main.myPlayer;
		string textValue2 = Language.GetTextValue("LegacyMenu.127");
		int myPlayer2 = Main.myPlayer;
		int selClothes3 = Main.selClothes;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			if (-2147483648 == 0)
			{
			}
			Main.selClothes = 0;
		}
		string textValue3 = Language.GetTextValue("LegacyMenu.39");
		if (-2147483648 == 0)
		{
		}
		int myPlayer3 = Main.myPlayer;
		int selClothes4 = Main.selClothes;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			if (-2147483648 == 0)
			{
			}
			Main.selClothes = 1;
		}
		string textValue4 = Language.GetTextValue("LegacyMenu.40");
		if (-2147483648 == 0)
		{
		}
		int myPlayer4 = Main.myPlayer;
		int selClothes5 = Main.selClothes;
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			if (-2147483648 == 0)
			{
			}
			Main.selClothes = 2;
		}
		string textValue5 = Language.GetTextValue("LegacyMenu.33");
		if (-2147483648 == 0)
		{
		}
		int myPlayer5 = Main.myPlayer;
		int selClothes6 = Main.selClothes;
		GUITransactionButton.InputState inputState4;
		if (inputState4 == GUITransactionButton.InputState.Clicked)
		{
			if (-2147483648 == 0)
			{
			}
			Main.selClothes = 3;
		}
		string textValue6 = Language.GetTextValue("LegacyMenu.34");
		if (-2147483648 == 0)
		{
		}
		int myPlayer6 = Main.myPlayer;
		int selClothes7 = Main.selClothes;
		GUITransactionButton.InputState inputState5;
		if (inputState5 == GUITransactionButton.InputState.Clicked)
		{
			if (-2147483648 == 0)
			{
			}
			Main.selClothes = 4;
		}
		string textValue7 = Language.GetTextValue("LegacyMenu.35");
		if (-2147483648 == 0)
		{
		}
		int myPlayer7 = Main.myPlayer;
		int selClothes8 = Main.selClothes;
		GUITransactionButton.InputState inputState6;
		if (inputState6 == GUITransactionButton.InputState.Clicked)
		{
			if (-2147483648 == 0)
			{
			}
			Main.selClothes = 5;
		}
		string textValue8 = Language.GetTextValue("LegacyMenu.36");
		int myPlayer8 = Main.myPlayer;
		int selClothes9 = Main.selClothes;
		GUITransactionButton.InputState inputState7;
		if (inputState7 == GUITransactionButton.InputState.Clicked)
		{
			Main.selClothes = 6;
		}
		int selClothes10 = Main.selClothes;
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x0001E5A4 File Offset: 0x0001C7A4
	private void DrawHSLSlider()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int selClothes = Main.selClothes;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		int selClothes2 = Main.selClothes;
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (num == 0)
		{
		}
		int selClothes3 = Main.selClothes;
		if (num == 0)
		{
		}
		int myPlayer3 = Main.myPlayer;
		if (num == 0)
		{
		}
		int selClothes4 = Main.selClothes;
		if (num == 0)
		{
		}
		int myPlayer4 = Main.myPlayer;
		if (num == 0)
		{
		}
		int selClothes5 = Main.selClothes;
		if (num == 0)
		{
		}
		int myPlayer5 = Main.myPlayer;
		if (num == 0)
		{
		}
		int selClothes6 = Main.selClothes;
		if (num == 0)
		{
		}
		int myPlayer6 = Main.myPlayer;
		if (num == 0)
		{
		}
		Vector3 vector = Main.rgbToHsl(Main.selColor);
		float hBar = Main.hBar;
		if (num == 0)
		{
		}
		float sBar = Main.sBar;
		if (num == 0)
		{
		}
		float lBar = Main.lBar;
		if (num == 0)
		{
		}
		Main.hBar = lBar;
		Main.sBar = lBar;
		Main.lBar = lBar;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x0001EA20 File Offset: 0x0001CC20
	private void DrawStyles()
	{
		int myPlayer = Main.myPlayer;
		Main.gameMenu = true;
		Main.gameMenu = false;
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x000021DB File Offset: 0x000003DB
	private float StyleScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x0001EA44 File Offset: 0x0001CC44
	public void StyleOver(int index)
	{
		int[] array = this.playerStyles;
		this.styleOver = array;
		if (array == null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (array == null)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (array == null)
		{
		}
		Main.mouseLeftRelease = false;
		int myPlayer = Main.myPlayer;
		int[] array2 = this.playerStyles;
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x0001EAAC File Offset: 0x0001CCAC
	public void StyleDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int[] array = this.playerStyles;
		Player player = this.clonePlayer;
		int num = this.styleOver;
		int skinVariant = player.skinVariant;
		int[] array2 = this.playerStyles;
		Player player2 = this.clonePlayer;
		int skinVariant2 = player2.skinVariant;
		float x = player2.position.X;
		float y = player2.position.Y;
		int[] array3 = this.playerStyles;
		int num2 = this.styleOver;
		float x2 = player2.position.X;
		float y2 = player2.position.Y;
		int[] array4 = this.playerStyles;
		this.clonePlayer.skinVariant = array4;
		this.clonePlayer.skinVariant = skinVariant;
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x0001EB68 File Offset: 0x0001CD68
	private void ClonePlayer()
	{
		if (this.clonePlayer == null)
		{
		}
		int myPlayer = Main.myPlayer;
		Player player = this.clonePlayer;
		Player player2 = this.clonePlayer;
		Player player3 = this.clonePlayer;
		Player player4 = this.clonePlayer;
		Player player5 = this.clonePlayer;
		Player player6 = this.clonePlayer;
		Player player7 = this.clonePlayer;
		Player player8 = this.clonePlayer;
		Player player9 = this.clonePlayer;
		Item[] armor = player9.armor;
		player9.skinVariant = player8;
		long entityId = armor.entityId;
		Item blankItem = this._blankItem;
		if (blankItem == null || blankItem != null)
		{
			Player player10 = this.clonePlayer;
			Item[] armor2 = player10.armor;
			player10.PlayerFrame();
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0001EC18 File Offset: 0x0001CE18
	public GUIClothesWindow()
	{
	}

	// Token: 0x0400065A RID: 1626
	private float ChangeButtonScale = (float)16256;

	// Token: 0x0400065B RID: 1627
	private GUIControllerDresser _controller;

	// Token: 0x0400065C RID: 1628
	private int[] playerStyles;

	// Token: 0x0400065D RID: 1629
	private Vector2 CharacterDrawOffset = 16256;

	// Token: 0x0400065E RID: 1630
	private Player clonePlayer;

	// Token: 0x0400065F RID: 1631
	private Item _blankItem;

	// Token: 0x04000660 RID: 1632
	private float closeScale;

	// Token: 0x04000661 RID: 1633
	public float TimeSinceItemChange;

	// Token: 0x04000662 RID: 1634
	private float shirtButtonScale;

	// Token: 0x04000663 RID: 1635
	private float underShirtButtonScale;

	// Token: 0x04000664 RID: 1636
	private float pantsButtonScale;

	// Token: 0x04000665 RID: 1637
	private float shoesButtonScale;

	// Token: 0x04000666 RID: 1638
	private float eyesButtonScale;

	// Token: 0x04000667 RID: 1639
	private float skinButtonScale;

	// Token: 0x04000668 RID: 1640
	private float styleButtonScale;

	// Token: 0x04000669 RID: 1641
	private float TitleScale;

	// Token: 0x0400066A RID: 1642
	private GUISlider.DragState hueDragState;

	// Token: 0x0400066B RID: 1643
	private GUISlider.DragState satDragState;

	// Token: 0x0400066C RID: 1644
	private GUISlider.DragState lightDragState;

	// Token: 0x0400066D RID: 1645
	private int styleOver = 16256;
}
