using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

// Token: 0x02000129 RID: 297
public class GUIChest
{
	// Token: 0x060007AB RID: 1963 RVA: 0x0001D3D8 File Offset: 0x0001B5D8
	public GUIChest()
	{
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x0001D408 File Offset: 0x0001B608
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		GUIItemGrid.GetItemScaleHandler getItemScaleHandler = this.itemScaleHandler;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x0001D428 File Offset: 0x0001B628
	public Item GetSelectedItem()
	{
		/*
An exception occurred when decompiling this method (060007AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIChest::GetSelectedItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
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

	// Token: 0x060007AE RID: 1966 RVA: 0x0001D440 File Offset: 0x0001B640
	public void EquipChestItem()
	{
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x0001D478 File Offset: 0x0001B678
	public void UpdateSelectedItem()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		bool netClient = Main.NetClient;
		int num = this.itemSelected;
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
	public bool collapsed
	{
		get
		{
		}
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0001D4B4 File Offset: 0x0001B6B4
	public void RefreshLangStrings()
	{
		int num = this.lastLang;
		int legacyId = Language.ActiveCulture.LegacyId;
		int legacyId2 = Language.ActiveCulture.LegacyId;
		this.lastLang = legacyId2;
		string text;
		string text2;
		string text3;
		string text4;
		string text5;
		if ((text == null || text != null) && (text2 == null || text2 != null) && (text3 == null || text3 != null) && (text4 == null || text4 != null) && (text5 == null || text5 != null))
		{
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0001D51C File Offset: 0x0001B71C
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x0001D534 File Offset: 0x0001B734
	public void Draw()
	{
		int myPlayer = Main.myPlayer;
		int myPlayer2 = Main.myPlayer;
		int myPlayer3 = Main.myPlayer;
		Tile tile;
		ushort type = tile.type;
		int myPlayer4 = Main.myPlayer;
		Recipe.FindRecipes(false);
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0001D580 File Offset: 0x0001B780
	public string GetName()
	{
		return Lang.GetItemNameValue(48);
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0001D60C File Offset: 0x0001B80C
	public string GetTitle()
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		Tile tile;
		ushort type = tile.type;
		if ("BuffName.ChesterPet" == null)
		{
		}
		return Lang.GetItemNameValue(3813);
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x0001D668 File Offset: 0x0001B868
	private void DrawName(SpriteBatch spritebatch)
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x0001D68C File Offset: 0x0001B88C
	private void DrawButtons(SpriteBatch spritebatch)
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0001D69C File Offset: 0x0001B89C
	public float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (060007B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIChest::ItemScale(System.Int32)

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

	// Token: 0x060007B9 RID: 1977 RVA: 0x0001D6B0 File Offset: 0x0001B8B0
	public void ItemOver(int index)
	{
		int num = 1;
		this.cursorOver = index;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x0001D918 File Offset: 0x0001BB18
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		if (!true)
		{
		}
		int myPlayer = Main.myPlayer;
		if (this.dummySlots == null)
		{
			Item[] array = this.dummySlots;
			return;
		}
		int num = this.cursorOver;
		if (!true)
		{
		}
		if (this.itemOver == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x0001D99C File Offset: 0x0001BB9C
	private void DrawSlots(SpriteBatch spriteBatch)
	{
		float num = this.doubleClickTimer;
		float deltaTime = Time.deltaTime;
	}

	// Token: 0x04000633 RID: 1587
	public float scrollOffset;

	// Token: 0x04000634 RID: 1588
	private float scrollMomentum;

	// Token: 0x04000635 RID: 1589
	private int scrollDragging;

	// Token: 0x04000636 RID: 1590
	private Microsoft.Xna.Framework.Vector2 dragOffset;

	// Token: 0x04000637 RID: 1591
	public int itemSelected;

	// Token: 0x04000638 RID: 1592
	private int itemOver;

	// Token: 0x04000639 RID: 1593
	private int itemDragStart;

	// Token: 0x0400063A RID: 1594
	private int cursorOver;

	// Token: 0x0400063B RID: 1595
	private int lastLang;

	// Token: 0x0400063C RID: 1596
	public string[] options;

	// Token: 0x0400063D RID: 1597
	private int lastItemClicked = 1;

	// Token: 0x0400063E RID: 1598
	private float doubleClickTimer;

	// Token: 0x0400063F RID: 1599
	private bool rightClickHeld;

	// Token: 0x04000640 RID: 1600
	private float LootButtonScale = (float)16256;

	// Token: 0x04000641 RID: 1601
	private bool canLoot;

	// Token: 0x04000642 RID: 1602
	private bool canLootAll;

	// Token: 0x04000643 RID: 1603
	private bool canDepositAll;

	// Token: 0x04000644 RID: 1604
	public bool menuOpen;

	// Token: 0x04000645 RID: 1605
	private float menuButtonScale = (float)16256;

	// Token: 0x04000646 RID: 1606
	private float[] buttonScale;

	// Token: 0x04000647 RID: 1607
	private Rectangle menuRegion;

	// Token: 0x04000648 RID: 1608
	private Item[] dummySlots;

	// Token: 0x04000649 RID: 1609
	private GUIItemGrid.GetItemScaleHandler itemScaleHandler;

	// Token: 0x0400064A RID: 1610
	private GUIItemGrid.CursorOver itemOverHandler;

	// Token: 0x0400064B RID: 1611
	private GUIItemGrid.DrawItemHandler itemDrawHandler;
}
