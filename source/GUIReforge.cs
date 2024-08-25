using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.UI;

// Token: 0x02000167 RID: 359
public class GUIReforge
{
	// Token: 0x06000A10 RID: 2576 RVA: 0x0002FE58 File Offset: 0x0002E058
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0002FE74 File Offset: 0x0002E074
	public bool Collapsed
	{
		get
		{
			if (!true)
			{
			}
			return InterfaceStyles_Layout.Active.IsCollapsed(GUIPageIcons.Category.Reforge);
		}
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x0002FE94 File Offset: 0x0002E094
	public int ReforgeCost()
	{
		int type = this.ReforgeItem.type;
		Item reforgeItem = this.ReforgeItem;
		int value = this.ReforgeItem.value;
		long num = 0L;
		this.refCost = (int)num;
		if (num == 0L)
		{
		}
		int myPlayer = Main.myPlayer;
		int num2 = this.refCost;
		long num3;
		if (num != 0L)
		{
			num3 = 32752L;
			this.refCost = num2;
		}
		if (num3 == 0L)
		{
		}
		int myPlayer2 = Main.myPlayer;
		this.refCost = myPlayer2;
		return myPlayer2;
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x0002FF0C File Offset: 0x0002E10C
	public void Reset()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		this.reforgeDragOffset = 1;
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshItems()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0002FF28 File Offset: 0x0002E128
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x0002FF40 File Offset: 0x0002E140
	public void DrawReforge()
	{
		int type = this.ReforgeItem.type;
		Item reforgeItem = this.ReforgeItem;
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00030008 File Offset: 0x0002E208
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (num == 0)
		{
		}
		if (Main.npcShop != 0)
		{
			if (num == 0)
			{
			}
			Main.InReforgeMenu = false;
			int myPlayer2 = Main.myPlayer;
			long num2 = 0L;
			Recipe.FindRecipes(num2 != 0L);
			return;
		}
		int myPlayer3 = Main.myPlayer;
		bool inGuideCraftMenu = Main.InGuideCraftMenu;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		int itemCount = draggableItemGrid_Layout.ItemCount;
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
		GUIControllerReforge guicontrollerReforge;
		long num3;
		if (guicontrollerReforge != null)
		{
			num3 = 0L;
			GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
			guicontrollerDynamicGridNavigator.DisableScrollUntilChange();
		}
		Item item;
		int type = item.type;
		Item item2;
		bool flag = item2.Prefix((int)num3);
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
		!0 instance7 = PageControllerLayoutDefinition.Instance;
		!0 instance8 = PageControllerLayoutDefinition.Instance;
		!0 instance9 = PageControllerLayoutDefinition.Instance;
		!0 instance10 = PageControllerLayoutDefinition.Instance;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
		!0 instance11 = PageControllerLayoutDefinition.Instance;
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00030110 File Offset: 0x0002E310
	public Item ReforgeItem
	{
		get
		{
			List<Item> reforgeItems = this._reforgeItems;
			int selectedItem = this._selectedItem;
			int size = reforgeItems._size;
			return this._defaultItem;
		}
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00030138 File Offset: 0x0002E338
	public float ReforgeItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000A19)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIReforge::ReforgeItemScale(System.Int32)

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

	// Token: 0x06000A1A RID: 2586 RVA: 0x0003014C File Offset: 0x0002E34C
	public void ReforgeItemOver(int index)
	{
		this.cursorOver = index;
		int size = this._reforgeItems._size;
		ItemSlot.UpdateTooltipContext(42, index);
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int selectedItem = this._selectedItem;
		this._selectedItem = index;
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00030194 File Offset: 0x0002E394
	public void ReforgeItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (!true)
		{
		}
		Main.inventoryScale = scale;
		int num = this.cursorOver;
		if (!true)
		{
		}
		int size = this._reforgeItems._size;
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		int selectedItem = this._selectedItem;
		int num2 = this.cursorOver;
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00030278 File Offset: 0x0002E478
	public GUIReforge()
	{
	}

	// Token: 0x040009EF RID: 2543
	private int refCost;

	// Token: 0x040009F0 RID: 2544
	public List<Item> _reforgeItems;

	// Token: 0x040009F1 RID: 2545
	private Item _defaultItem;

	// Token: 0x040009F2 RID: 2546
	private int _selectedItem;

	// Token: 0x040009F3 RID: 2547
	public float reforgeScrollOffset;

	// Token: 0x040009F4 RID: 2548
	private float reforgeScrollMomentum;

	// Token: 0x040009F5 RID: 2549
	private int reforgeScrollDragging;

	// Token: 0x040009F6 RID: 2550
	private Vector2 reforgeDragOffset;

	// Token: 0x040009F7 RID: 2551
	private int cursorOver = 1;

	// Token: 0x040009F8 RID: 2552
	private float reforgeActionScale;
}
