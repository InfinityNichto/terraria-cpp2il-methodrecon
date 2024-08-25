using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x02000172 RID: 370
public class GUIShop
{
	// Token: 0x06000A78 RID: 2680 RVA: 0x00032B1C File Offset: 0x00030D1C
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (48 == 0)
		{
		}
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00032B3C File Offset: 0x00030D3C
	public Item SelectedItem
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000A79)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIShop::get_SelectedItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_2_0A, callgetter:int32(Main::get_npcShop))
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

	// Token: 0x06000A7A RID: 2682 RVA: 0x00032B54 File Offset: 0x00030D54
	private void PurchasePressedAndHeld(bool delayedPurchase = false)
	{
		if (!true)
		{
		}
		int stackSplit = Main.stackSplit;
		Item item;
		int type = item.type;
		if (type == 0)
		{
		}
		Item item2;
		bool flag = Main.mouseItem.IsTheSameAs(item2);
		if (type == 0)
		{
		}
		if (Main.mouseItem.type == 0)
		{
			int num = 20;
			if (num == 0)
			{
			}
			int num2 = 1;
			Main.preventStackSplitReset = num2 != 0;
			int superFastStack = Main.superFastStack;
			if (num == 0)
			{
			}
			int stack = Main.mouseItem.stack;
			if (Main.mouseItem.maxStack == 0)
			{
			}
			if (Main.mouseItem.type == 0)
			{
				return;
			}
		}
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x00032D68 File Offset: 0x00030F68
	public void DrawPurchaseButton()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (Main.npcShop == 0)
		{
			return;
		}
		if (num == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		Item selectedItem = this.SelectedItem;
		int type = this.SelectedItem.type;
		int stack = this.SelectedItem.stack;
		if (stack == 0)
		{
		}
		int myPlayer2 = Main.myPlayer;
		if (!this._pendingPurchase)
		{
		}
		int shopSpecialCurrency = this.SelectedItem.shopSpecialCurrency;
		if (stack == 0)
		{
		}
		Item mouseItem = Main.mouseItem;
		Item selectedItem2 = this.SelectedItem;
		bool flag = mouseItem.IsTheSameAs(selectedItem2);
		if (stack == 0)
		{
		}
		if (Main.mouseItem.type != 0)
		{
			return;
		}
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00033034 File Offset: 0x00031234
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int npcShop = Main.npcShop;
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
		long num2 = 0L;
		Main.npcShop = (int)num2;
		if (num == 0)
		{
		}
		int npcShop2 = Main.npcShop;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int num3 = 255;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (num3 == 0)
		{
		}
		if (num3 == 0)
		{
		}
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		if (num3 == 0)
		{
		}
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		!0 instance7 = PageControllerLayoutDefinition.Instance;
		!0 instance8 = PageControllerLayoutDefinition.Instance;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
		!0 instance9 = PageControllerLayoutDefinition.Instance;
		string textValue = Language.GetTextValue("Mobile.Savings");
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x000330F0 File Offset: 0x000312F0
	public float ItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000A7D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIShop::ItemScale(System.Int32)

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

	// Token: 0x06000A7E RID: 2686 RVA: 0x00033104 File Offset: 0x00031304
	public void PurchasePendingItems()
	{
		bool pendingPurchase = this._pendingPurchase;
		if (pendingPurchase)
		{
			if (!pendingPurchase)
			{
			}
			int myPlayer = Main.myPlayer;
		}
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x00033128 File Offset: 0x00031328
	public void CancelPendingItems()
	{
		if (this._pendingPurchase)
		{
			return;
		}
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00033140 File Offset: 0x00031340
	public void ItemOver(int index)
	{
		this.cursorOver = index;
		this.itemOver = index;
		this._selectedItem = index;
		Item mouseItem = Main.mouseItem;
		int npcShop = Main.npcShop;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		int num = this.itemDragStart;
		this.itemOver = index;
		if (this._selectedItem == 0)
		{
		}
		if (Main.mouseItem.type == 0)
		{
		}
		Item mouseItem2 = Main.mouseItem;
		int npcShop2 = Main.npcShop;
		long num2 = 0L;
		this.PurchasePressedAndHeld(num2 != 0L);
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00033264 File Offset: 0x00031464
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x0003327C File Offset: 0x0003147C
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = this.cursorOver;
		if (!true)
		{
		}
		int num2 = this.itemOver;
		if (this._selectedItem == 0)
		{
		}
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
		if (instance == null)
		{
		}
		Main.inventoryScale = scale;
		int npcShop = Main.npcShop;
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x000332D4 File Offset: 0x000314D4
	private void DrawSlots(SpriteBatch spriteBatch)
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (48 == 0)
		{
		}
		int num = this.itemDragStart;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		if (Main.mouseItem != null)
		{
			if (num == 0)
			{
			}
			if (Main.mouseItem.type != 0)
			{
				goto IL_0061;
			}
		}
		int num2 = this.itemDragStart;
		int num3 = this.itemOver;
		long num4 = 0L;
		this.PurchasePressedAndHeld(num4 != 0L);
		if (num2 == 0)
		{
		}
		Recipe.FindRecipes(false);
		IL_0061:
		this.itemDragStart = num2;
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x0003334C File Offset: 0x0003154C
	public GUIShop()
	{
	}

	// Token: 0x04000A67 RID: 2663
	private int cursorOver;

	// Token: 0x04000A68 RID: 2664
	private int itemOver;

	// Token: 0x04000A69 RID: 2665
	private int itemDragStart;

	// Token: 0x04000A6A RID: 2666
	private DateTime itemPurchaseDelayStart;

	// Token: 0x04000A6B RID: 2667
	private int _selectedItem;

	// Token: 0x04000A6C RID: 2668
	private float buyButtonScale = (float)16256;

	// Token: 0x04000A6D RID: 2669
	private bool _pendingPurchase;

	// Token: 0x04000A6E RID: 2670
	private int _pendingCost;

	// Token: 0x04000A6F RID: 2671
	private int multibuyDelay;

	// Token: 0x04000A70 RID: 2672
	public float hoverCraftDelay;

	// Token: 0x04000A71 RID: 2673
	public GUITransactionButton.InputState lastState = GUITransactionButton.InputState.None;
}
