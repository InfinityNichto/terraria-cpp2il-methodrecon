using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using UnityEngine;

// Token: 0x02000161 RID: 353
public class GUIPageIcons
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
	public bool UseHorizontalPages
	{
		get
		{
			bool usingTouchUI = this.UsingTouchUI;
			return this.UseHorizontalInventory;
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x060009CA RID: 2506 RVA: 0x0002DED0 File Offset: 0x0002C0D0
	public bool UsingTouchUI
	{
		get
		{
			/*
An exception occurred when decompiling this method (060009CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageIcons::get_UsingTouchUI()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stloc:InterfaceProfile_Layout(var_2_12, callgetter:InterfaceProfile_Layout(InterfaceStyles_Layout::get_Active))
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
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x060009CB RID: 2507 RVA: 0x0002DEF4 File Offset: 0x0002C0F4
	public bool DisplayTouchOptions
	{
		get
		{
			bool flag;
			return flag;
		}
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x0002DF04 File Offset: 0x0002C104
	public static void LoadContent(ContentManager content)
	{
		if (!true)
		{
		}
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/PageIcons/ResearchIcon");
		if (texture2D == null || texture2D != null)
		{
			Microsoft.Xna.Framework.Graphics.Texture2D texture2D2 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/PageIcons/ResearchIconSelected");
			if (texture2D2 == null || texture2D2 != null)
			{
				return;
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0002E0B8 File Offset: 0x0002C2B8
	private static void LoadItemIcon(ContentManager content, int id)
	{
		if (306 == 0)
		{
		}
		string text2;
		string text = "Images/UI/PageIcons/Item_" + text2;
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(text);
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x0002E100 File Offset: 0x0002C300
	private static void LoadNPCIcon(ContentManager content, int id)
	{
		if (!true)
		{
		}
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/PageIcons/NPC_Uncollected_Head_3");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D2 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/PageIcons/NPC_Uncollected_Head_3Selected");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D3 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/PageIcons/NPC_Uncollected_Head_3Shimmered");
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D4 = content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Images/UI/PageIcons/NPC_Uncollected_Head_3ShimmeredSelected");
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0002E1B0 File Offset: 0x0002C3B0
	public Microsoft.Xna.Framework.Graphics.Texture2D GetCategoryTexture(GUIPageIcons.Category category, bool selected)
	{
		/*
An exception occurred when decompiling this method (060009CF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D GUIPageIcons::GetCategoryTexture(GUIPageIcons/Category,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_012B:
	stloc:int32(var_55_133, callgetter:int32(Main::get_myPlayer))
	stloc:int32(var_57_13D, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x060009D0 RID: 2512 RVA: 0x0002E2FC File Offset: 0x0002C4FC
	public bool IsPageSelected(GUIPageIcons.Category category)
	{
		if (this.UseConsoleStyle)
		{
			InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
			return active == null || active.IsPageSelected(category);
		}
		GUIPageIcons.Category selectedLeft = this._selectedLeft;
		return true;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x0002E338 File Offset: 0x0002C538
	public bool DrawRightPageHUD()
	{
		bool allowDraw;
		if (this.UseConsoleStyle)
		{
			RightSideHUDAnchorUpdator.Update();
			allowDraw = RightSideHUDAnchorUpdator.AllowDraw;
			return allowDraw;
		}
		return allowDraw;
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x0002E360 File Offset: 0x0002C560
	public bool CanAcceptItems(GUIPageIcons.Category category)
	{
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0002E370 File Offset: 0x0002C570
	// (set) Token: 0x060009D4 RID: 2516 RVA: 0x0002E384 File Offset: 0x0002C584
	public GUIPageIcons.Category selectedLeft
	{
		get
		{
			return this._selectedLeft;
		}
		set
		{
			GUIPageIcons.Category selectedLeft = this._selectedLeft;
			this.OnCategoryClosed(selectedLeft);
			this._selectedLeft = value;
			this.OnCategoryOpened(value);
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
	// (set) Token: 0x060009D6 RID: 2518 RVA: 0x0002E3C4 File Offset: 0x0002C5C4
	public GUIPageIcons.Category selectedRight
	{
		get
		{
			return this._selectedRight;
		}
		set
		{
			GUIPageIcons.Category selectedRight = this._selectedRight;
			this.OnCategoryClosed(selectedRight);
			this._selectedRight = value;
			this.OnCategoryOpened(value);
		}
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x0002E3F0 File Offset: 0x0002C5F0
	public void Close(bool hideChat = true)
	{
		GUIPageIcons.Category selectedLeft = this._selectedLeft;
		GUIPageIcons.Category selectedRight = this._selectedRight;
		if (this.UseConsoleStyle)
		{
			InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
			long num = 0L;
			active.Close(num != 0L);
		}
		Main.playerInventory = false;
		Main.InReforgeMenu = false;
		Main.InGuideCraftMenu = false;
		Main.CancelHairWindow();
		Main.CancelClothesWindow(false);
		Main.npcShop = 0;
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		this.RefreshRightItems();
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x0002E470 File Offset: 0x0002C670
	public void OpenUI(GUIPageIcons.Category left, GUIPageIcons.Category right)
	{
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshLeftItems()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshRightItems()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x0002E6DC File Offset: 0x0002C8DC
	private void RefreshAvailableItems()
	{
		int num = 1;
		if (num == 0)
		{
		}
		bool playerInventory = Main.playerInventory;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		Main.npcShop = 0;
		if (num == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (num == 0)
		{
		}
		int myPlayer3 = Main.myPlayer;
		int myPlayer4 = Main.myPlayer;
		Tile tile;
		ushort type = tile.type;
		int myPlayer5 = Main.myPlayer;
		Recipe.FindRecipes(false);
		bool inGuideCraftMenu = Main.InGuideCraftMenu;
		int myPlayer6 = Main.myPlayer;
		Main.InGuideCraftMenu = false;
		Recipe.FindRecipes(false);
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x0002E768 File Offset: 0x0002C968
	private void UpdatePageStates()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num != 0)
		{
			if (num == 0)
			{
			}
			bool flag = InterfaceStyles_Layout.Active.AnyOpen();
			long num2 = 0L;
			this.Close(num2 != 0L);
		}
		this.RefreshAvailableItems();
		bool useConsoleStyle = this.UseConsoleStyle;
		if (useConsoleStyle)
		{
			if (!useConsoleStyle)
			{
			}
			InterfaceStyles_Layout.Active.RefreshAllItems();
			return;
		}
		this.RefreshLeftItems();
		this.RefreshRightItems();
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x000021DB File Offset: 0x000003DB
	public float ExtendedScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x000021DB File Offset: 0x000003DB
	public float ItemScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x0002E7D4 File Offset: 0x0002C9D4
	public void OnCategoryClosed(GUIPageIcons.Category category)
	{
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x0002E864 File Offset: 0x0002CA64
	public void OnCategoryOpened(GUIPageIcons.Category category)
	{
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0002E918 File Offset: 0x0002CB18
	private void LeftOver(int index)
	{
		List<GUIPageIcons.Category> list = this.leftItems;
		GUIPageIcons.Category category = this.hoverLeft;
		List<GUIPageIcons.Category> list2 = this.leftItems;
		GUIPageIcons.Category category2 = this.lastHoverLeft;
		this.hoverLeft = list2;
		this.lastHoverLeft = list2;
		if (category2 == GUIPageIcons.Category.Crafting)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (category2 == GUIPageIcons.Category.Crafting)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (category2 == GUIPageIcons.Category.Crafting)
		{
		}
		bool mouseLeft2 = Main.mouseLeft;
		if (category2 == GUIPageIcons.Category.Crafting)
		{
		}
		if (Main.mouseItem != null)
		{
			if (category2 == GUIPageIcons.Category.Crafting)
			{
			}
			int type = Main.mouseItem.type;
		}
		if (this.leftMenuTogglePressed)
		{
			List<GUIPageIcons.Category> list3 = this.leftItems;
			GUIPageIcons.Category selectedLeft = this._selectedLeft;
		}
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x0002E9D8 File Offset: 0x0002CBD8
	private void InventoryDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		List<GUIPageIcons.Category> list = this.leftItems;
		GUIPageIcons.Category category = this.lastHoverLeft;
		List<GUIPageIcons.Category> list2 = this.leftItems;
		GUIPageIcons.Category category2 = this.hoverLeft;
		this.lastHoverLeft.value__ = (int)scale;
		List<GUIPageIcons.Category> list3 = this.leftItems;
		GUIPageIcons.Category selectedLeft = this._selectedLeft;
		List<GUIPageIcons.Category> list4 = this.leftItems;
		List<GUIPageIcons.Category> list5 = this.leftItems;
		float x = this.pageButtonRegionSize.X;
		float y = this.pageButtonRegionSize.Y;
		int size = this.leftItems._size;
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x0002EA64 File Offset: 0x0002CC64
	private void LeftDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		if (this.leftMenuTogglePressed)
		{
			this.LeftOver(index);
		}
		List<GUIPageIcons.Category> list = this.leftItems;
		GUIPageIcons.Category category = this.lastHoverLeft;
		List<GUIPageIcons.Category> list2 = this.leftItems;
		GUIPageIcons.Category category2 = this.hoverLeft;
		this.lastHoverLeft.value__ = (int)scale;
		List<GUIPageIcons.Category> list3 = this.leftItems;
		GUIPageIcons.Category selectedLeft = this._selectedLeft;
		List<GUIPageIcons.Category> list4 = this.leftItems;
		if (list4 == null)
		{
		}
		if (Main.mouseItem != null)
		{
			if (list4 == null)
			{
			}
			int type = Main.mouseItem.type;
			List<GUIPageIcons.Category> list5 = this.leftItems;
			if (!true)
			{
			}
			float mouseItemTime = Main.mouseItemTime;
			if (92 == 0)
			{
			}
		}
		if (92 == 0)
		{
		}
		Microsoft.Xna.Framework.Graphics.Texture2D texture2D;
		Microsoft.Xna.Framework.Vector2 vector = texture2D.Size();
		List<GUIPageIcons.Category> list6 = this.leftItems;
		GUIPageIcons.Category category3 = this.hoverLeft;
		GUIPageIcons.PageControlsType pageControls = this.PageControls;
		float timeSinceLeftChanged = this.TimeSinceLeftChanged;
		List<GUIPageIcons.Category> list7 = this.leftItems;
		GUIPageIcons.Category category4 = this.hoverLeft;
		float timeSinceLeftHoverChanged = this.TimeSinceLeftHoverChanged;
		float timeSinceLeftChanged2 = this.TimeSinceLeftChanged;
		List<GUIPageIcons.Category> list8 = this.leftItems;
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x0002EB68 File Offset: 0x0002CD68
	private void RightOver(int index)
	{
		List<GUIPageIcons.Category> list = this.rightItems;
		GUIPageIcons.Category category = this.hoverRight;
		List<GUIPageIcons.Category> list2 = this.rightItems;
		GUIPageIcons.Category category2 = this.lastHoverRight;
		this.hoverRight = list2;
		this.lastHoverRight = list2;
		if (category2 == GUIPageIcons.Category.Crafting)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (category2 == GUIPageIcons.Category.Crafting)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		List<GUIPageIcons.Category> list3 = this.rightItems;
		GUIPageIcons.Category selectedRight = this._selectedRight;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		List<GUIPageIcons.Category> list4 = this.rightItems;
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x0002EC70 File Offset: 0x0002CE70
	public bool AnyPageSelected()
	{
		bool flag = Main.npcChatText != "";
		bool editChest = Main.editChest;
		bool hairWindow = Main.hairWindow;
		bool clothesWindow = Main.clothesWindow;
		int myPlayer = Main.myPlayer;
		return Main.playerInventory;
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x0002ECC4 File Offset: 0x0002CEC4
	public bool IsLeftPageSelected()
	{
		/*
An exception occurred when decompiling this method (060009E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageIcons::IsLeftPageSelected()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Category(var_0_06, ldfld:Category(GUIPageIcons::_selectedLeft, ldloc:GUIPageIcons(this)))
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

	// Token: 0x060009E7 RID: 2535 RVA: 0x0002ECD8 File Offset: 0x0002CED8
	public bool IsRightPageSelected()
	{
		/*
An exception occurred when decompiling this method (060009E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIPageIcons::IsRightPageSelected()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Category(var_0_06, ldfld:Category(GUIPageIcons::_selectedRight, ldloc:GUIPageIcons(this)))
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

	// Token: 0x060009E8 RID: 2536 RVA: 0x0002ECEC File Offset: 0x0002CEEC
	public void LoadDrawColor(TransactionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Color color)
	{
		layout.Color = color;
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x0002ED00 File Offset: 0x0002CF00
	public void OverloadDrawColor(TransactionButton_Layout layout, GUIPageIcons.Category category, bool over, bool selected, [Out] Microsoft.Xna.Framework.Graphics.Color restoreCol)
	{
		Microsoft.Xna.Framework.Graphics.Color color = layout.Color;
		restoreCol.A = color;
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x0002ED48 File Offset: 0x0002CF48
	private void RightDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		if (this.rightMenuTogglePressed)
		{
			this.RightOver(index);
		}
		List<GUIPageIcons.Category> list = this.rightItems;
		GUIPageIcons.Category category = this.lastHoverRight;
		List<GUIPageIcons.Category> list2 = this.rightItems;
		GUIPageIcons.Category category2 = this.hoverRight;
		List<GUIPageIcons.Category> list3 = this.rightItems;
		GUIPageIcons.Category selectedRight = this._selectedRight;
		List<GUIPageIcons.Category> list4 = this.rightItems;
		if (list4 == null)
		{
		}
		int num2;
		if (Main.mouseItem != null)
		{
			if (list4 == null)
			{
			}
			int type = Main.mouseItem.type;
			List<GUIPageIcons.Category> list5 = this.rightItems;
			int num = 1;
			num2 = 92;
			if (num == 0)
			{
			}
			float mouseItemTime = Main.mouseItemTime;
			if (num2 == 0)
			{
			}
		}
		if (num2 == 0)
		{
		}
		List<GUIPageIcons.Category> list6 = this.rightItems;
		GUIPageIcons.Category category3 = this.hoverRight;
		GUIPageIcons.PageControlsType pageControls = this.PageControls;
		float timeSinceRightChanged = this.TimeSinceRightChanged;
		List<GUIPageIcons.Category> list7 = this.rightItems;
		GUIPageIcons.Category category4 = this.hoverRight;
		float timeSinceRightHoverChanged = this.TimeSinceRightHoverChanged;
		float timeSinceRightChanged2 = this.TimeSinceRightChanged;
		List<GUIPageIcons.Category> list8 = this.rightItems;
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x0002EE90 File Offset: 0x0002D090
	private void ActivateLeftController()
	{
		if (this._selectedLeft == GUIPageIcons.Category.Crafting)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
	public void DrawInventoryPage()
	{
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x0002EEC4 File Offset: 0x0002D0C4
	public void DrawInventoryItems()
	{
		if (this.UseConsoleStyle)
		{
		}
		bool flag = this.leftMenuOpen;
		List<GUIPageIcons.Category> list;
		if (flag)
		{
			this.hoverLeft = GUIPageIcons.Category.None;
			list = this.leftItems;
			float x = this.pageButtonRegionSize.X;
			float y = this.pageButtonRegionSize.Y;
			int size = list._size;
			if (!flag)
			{
			}
			return;
		}
		this.selectedLeft = GUIPageIcons.Category.None;
		if (list == null)
		{
		}
		Rectangle rectangle;
		ControlAnchor.SetLeftPageRegion(rectangle);
		if (list == null)
		{
		}
		if (16256 == 0)
		{
		}
		GUIPageIcons.Category selectedLeft = this._selectedLeft;
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002EF44 File Offset: 0x0002D144
	public bool PagePopupDisplayed
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x0002EF54 File Offset: 0x0002D154
	public bool ClickedOutOfRegion(Rectangle popupRegion, bool showDebug = false)
	{
		global::Cursor cursor;
		if (cursor != null)
		{
			float x = cursor.Position.x;
			float y = cursor.Position.y;
			if (!cursor.Down || cursor.WasDown)
			{
			}
		}
		string text;
		Debug.Log(text);
		return true;
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x0002EFA4 File Offset: 0x0002D1A4
	public void DrawLeftMenuButton()
	{
		if (64 == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		int num = 1;
		bool editChest = Main.editChest;
		long num2;
		int num3;
		if (num != 0)
		{
			if (true)
			{
				num2 = 0L;
				return;
			}
			num3 = 17096;
		}
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		if ((num3 != 0 && num3 == 0 && num3 == 0) || num3 == 0)
		{
		}
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		if (num2 != 0L)
		{
			return;
		}
		bool flag = InterfaceStyles_Layout.Active.AnyOpen();
		InterfaceStyles_Layout.Active.LeftRightPageController();
		InterfaceStyles_Layout.Active.Draw();
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0002F110 File Offset: 0x0002D310
	public bool LastActiveLeft
	{
		get
		{
			if (this.lastActive != null)
			{
				GUIControllerItem guicontrollerItem = this.lastActive;
				GUIControllerItem guicontrollerItem2 = this.lastActive;
				GUIControllerItem guicontrollerItem3 = this.lastActive;
				GUIControllerItem guicontrollerItem4 = this.lastActive;
				return true;
			}
			return true;
		}
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x0002F14C File Offset: 0x0002D34C
	public void Draw()
	{
		float timeSinceLeftChanged = this.TimeSinceLeftChanged;
		float deltaTime = Time.deltaTime;
		float timeSinceRightChanged = this.TimeSinceRightChanged;
		float deltaTime2 = Time.deltaTime;
		float timeSinceLeftHoverChanged = this.TimeSinceLeftHoverChanged;
		float deltaTime3 = Time.deltaTime;
		float timeSinceRightHoverChanged = this.TimeSinceRightHoverChanged;
		float deltaTime4 = Time.deltaTime;
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0002F234 File Offset: 0x0002D434
	public GUIPageIcons()
	{
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x0002F268 File Offset: 0x0002D468
	// Note: this type is marked as 'beforefieldinit'.
	static GUIPageIcons()
	{
	}

	// Token: 0x04000983 RID: 2435
	public GUIPageIcons.PageCollapseMode PageMode;

	// Token: 0x04000984 RID: 2436
	public GUIPageIcons.PageControlsType PageControls;

	// Token: 0x04000985 RID: 2437
	private static Microsoft.Xna.Framework.Graphics.Texture2D[] _categories;

	// Token: 0x04000986 RID: 2438
	private static Microsoft.Xna.Framework.Graphics.Texture2D[] _categoriesSelected;

	// Token: 0x04000987 RID: 2439
	private static Dictionary<int, Microsoft.Xna.Framework.Graphics.Texture2D> _npcIcons;

	// Token: 0x04000988 RID: 2440
	private static Dictionary<int, Microsoft.Xna.Framework.Graphics.Texture2D> _npcSelectedIcons;

	// Token: 0x04000989 RID: 2441
	private static Dictionary<int, Microsoft.Xna.Framework.Graphics.Texture2D> _npcShimmeredIcons;

	// Token: 0x0400098A RID: 2442
	private static Dictionary<int, Microsoft.Xna.Framework.Graphics.Texture2D> _npcShimmeredSelectedIcons;

	// Token: 0x0400098B RID: 2443
	private static Dictionary<int, Microsoft.Xna.Framework.Graphics.Texture2D> _itemIcons;

	// Token: 0x0400098C RID: 2444
	private static Dictionary<int, Microsoft.Xna.Framework.Graphics.Texture2D> _itemSelectedIcons;

	// Token: 0x0400098D RID: 2445
	private static Microsoft.Xna.Framework.Graphics.Texture2D _menuClosed;

	// Token: 0x0400098E RID: 2446
	public static Microsoft.Xna.Framework.Graphics.Texture2D _menuOpen;

	// Token: 0x0400098F RID: 2447
	private GUIPageIcons.Category lastHoverLeft;

	// Token: 0x04000990 RID: 2448
	private GUIPageIcons.Category hoverLeft;

	// Token: 0x04000991 RID: 2449
	private float TimeSinceLeftHoverChanged;

	// Token: 0x04000992 RID: 2450
	private float TimeSinceLeftChanged;

	// Token: 0x04000993 RID: 2451
	private float TimeSinceRightChanged = (float)17096;

	// Token: 0x04000994 RID: 2452
	private GUIPageIcons.Category lastHoverRight;

	// Token: 0x04000995 RID: 2453
	private GUIPageIcons.Category hoverRight;

	// Token: 0x04000996 RID: 2454
	private float TimeSinceRightHoverChanged = (float)17096;

	// Token: 0x04000997 RID: 2455
	public bool UseHorizontalInventory;

	// Token: 0x04000998 RID: 2456
	public bool UseConsoleStyle;

	// Token: 0x04000999 RID: 2457
	public bool EnableDoubleClick;

	// Token: 0x0400099A RID: 2458
	public bool UsePageLeftStyle;

	// Token: 0x0400099B RID: 2459
	public bool leftMenuOpen;

	// Token: 0x0400099C RID: 2460
	private bool leftMenuTogglePressed;

	// Token: 0x0400099D RID: 2461
	private DateTime LeftNavigationTick;

	// Token: 0x0400099E RID: 2462
	private float leftMenuButtonScale;

	// Token: 0x0400099F RID: 2463
	private GUIPageIcons.Category _selectedLeft;

	// Token: 0x040009A0 RID: 2464
	public bool excludeFocus;

	// Token: 0x040009A1 RID: 2465
	public List<GUIPageIcons.Category> leftItems;

	// Token: 0x040009A2 RID: 2466
	public List<GUIPageIcons.Category> craftItems;

	// Token: 0x040009A3 RID: 2467
	public List<GUIPageIcons.Category> interactionItems;

	// Token: 0x040009A4 RID: 2468
	public List<GUIPageIcons.Category> equipmentItems;

	// Token: 0x040009A5 RID: 2469
	public bool rightMenuOpen;

	// Token: 0x040009A6 RID: 2470
	private float rightMenuButtonScale = (float)16192;

	// Token: 0x040009A7 RID: 2471
	private GUIPageIcons.Category _selectedRight;

	// Token: 0x040009A8 RID: 2472
	private GUIPageIcons.Category _selectedCrafting;

	// Token: 0x040009A9 RID: 2473
	private GUIPageIcons.Category _selectedInteraction;

	// Token: 0x040009AA RID: 2474
	private GUIPageIcons.Category _selectedEquipment;

	// Token: 0x040009AB RID: 2475
	private bool rightMenuTogglePressed;

	// Token: 0x040009AC RID: 2476
	private DateTime RightNavigationTick;

	// Token: 0x040009AD RID: 2477
	public List<GUIPageIcons.Category> rightItems;

	// Token: 0x040009AE RID: 2478
	public bool rightUseDuplication;

	// Token: 0x040009AF RID: 2479
	public bool rightUseItemFilter;

	// Token: 0x040009B0 RID: 2480
	private Microsoft.Xna.Framework.Vector2 pageButtonRegionSize;

	// Token: 0x040009B1 RID: 2481
	public GUIControllerItem lastActive;

	// Token: 0x02000162 RID: 354
	public enum PageControlsType
	{
		// Token: 0x040009B3 RID: 2483
		Vertical,
		// Token: 0x040009B4 RID: 2484
		Bottom
	}

	// Token: 0x02000163 RID: 355
	public enum PageCollapseMode
	{
		// Token: 0x040009B6 RID: 2486
		CollapsedFullClosed,
		// Token: 0x040009B7 RID: 2487
		FullClosed,
		// Token: 0x040009B8 RID: 2488
		CollapsedFull,
		// Token: 0x040009B9 RID: 2489
		FullOnly
	}

	// Token: 0x02000164 RID: 356
	public enum Category
	{
		// Token: 0x040009BB RID: 2491
		Crafting,
		// Token: 0x040009BC RID: 2492
		CraftingGuide,
		// Token: 0x040009BD RID: 2493
		Inventory,
		// Token: 0x040009BE RID: 2494
		Chest,
		// Token: 0x040009BF RID: 2495
		Shop,
		// Token: 0x040009C0 RID: 2496
		Housing,
		// Token: 0x040009C1 RID: 2497
		Equipment,
		// Token: 0x040009C2 RID: 2498
		PVP,
		// Token: 0x040009C3 RID: 2499
		Map,
		// Token: 0x040009C4 RID: 2500
		Reforge,
		// Token: 0x040009C5 RID: 2501
		HairStylist,
		// Token: 0x040009C6 RID: 2502
		Dresser,
		// Token: 0x040009C7 RID: 2503
		GrandDesignSettings,
		// Token: 0x040009C8 RID: 2504
		JourneyModeSettings,
		// Token: 0x040009C9 RID: 2505
		Chat,
		// Token: 0x040009CA RID: 2506
		Duplicate,
		// Token: 0x040009CB RID: 2507
		DisplayDoll,
		// Token: 0x040009CC RID: 2508
		HatRack,
		// Token: 0x040009CD RID: 2509
		Research,
		// Token: 0x040009CE RID: 2510
		None,
		// Token: 0x040009CF RID: 2511
		Count
	}
}
