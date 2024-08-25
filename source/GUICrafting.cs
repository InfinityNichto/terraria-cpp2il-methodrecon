using System;
using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.UI;

// Token: 0x02000138 RID: 312
public class GUICrafting
{
	// Token: 0x0600082C RID: 2092 RVA: 0x00020550 File Offset: 0x0001E750
	public void Reset()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x0600082D RID: 2093 RVA: 0x00020564 File Offset: 0x0001E764
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			GUIItemFilter filter = this.Filter;
			bool flag;
			return flag;
		}
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00020584 File Offset: 0x0001E784
	public void DrawCraftButton()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int focusRecipe = Main.focusRecipe;
		if (num == 0)
		{
		}
		int focusRecipe2 = Main.focusRecipe;
		int numAvailableRecipes = Main.numAvailableRecipes;
		int size = this.FilteredItems._size;
		if (this.Filter.Expanded)
		{
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x0600082F RID: 2095 RVA: 0x000206F4 File Offset: 0x0001E8F4
	public int SelectedNumMaterials
	{
		get
		{
			int num;
			int focusRecipe3;
			do
			{
				num = 1;
				if (num == 0)
				{
				}
				int focusRecipe = Main.focusRecipe;
				if (num == 0)
				{
				}
				int focusRecipe2 = Main.focusRecipe;
				int numAvailableRecipes = Main.numAvailableRecipes;
				if (num == 0)
				{
				}
				int[] availableRecipe = Main.availableRecipe;
				focusRecipe3 = Main.focusRecipe;
			}
			while (num == 0);
			return focusRecipe3;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000830 RID: 2096 RVA: 0x00020748 File Offset: 0x0001E948
	public int CraftHoverNumMaterials
	{
		get
		{
			Recipe craftHover = this.CraftHover;
			if (craftHover != null)
			{
				Item[] requiredItem = craftHover.requiredItem;
				return 15;
			}
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000831 RID: 2097 RVA: 0x0002076C File Offset: 0x0001E96C
	public bool Collapsed
	{
		get
		{
			if (!true)
			{
			}
			InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
			bool flag;
			return flag;
		}
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x00020788 File Offset: 0x0001E988
	public void DrawExpandButton()
	{
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00020798 File Offset: 0x0001E998
	public void DrawMaterialsGridTooltip(Vector2 position)
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		Recipe craftHover = this.CraftHover;
		Item[] requiredItem;
		if (craftHover != null)
		{
			requiredItem = craftHover.requiredItem;
			return;
		}
		if (requiredItem == null)
		{
		}
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x000021DB File Offset: 0x000003DB
	public void DrawMaterialsGrid()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x000207CC File Offset: 0x0001E9CC
	public void UpdateMaterialNavigation()
	{
		if (!this.Filter.Expanded)
		{
			bool hasFocus = this.HasFocus;
			DateTime now = DateTime.Now;
			DateTime lastActivated = this.materialController.LastActivated;
			double totalSeconds = (now - lastActivated).TotalSeconds;
			if (this.materialsGridActive)
			{
				float uitextAlpha = XNAUIInputLayer.UITextAlpha;
			}
			if (this.menuTogglePressed && !this.materialsGridActive)
			{
				GUIControllerCraftingMaterials guicontrollerCraftingMaterials = this.materialController;
				this.materialsGridActive = true;
				guicontrollerCraftingMaterials.Activate();
				return;
			}
		}
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x0002084C File Offset: 0x0001EA4C
	public void ResetFilters()
	{
		GUIItemFilter filter = this.Filter;
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x000021DB File Offset: 0x000003DB
	private void UpdateFilter(bool force = false)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00020860 File Offset: 0x0001EA60
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		int itemCount = draggableItemGrid_Layout.ItemCount;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00020888 File Offset: 0x0001EA88
	public void RefreshGridNav()
	{
		int num = 1;
		bool hasFocus = this.HasFocus;
		int num2 = 1;
		this.UpdateFilter(num2 != 0);
		if (num == 0)
		{
		}
		XNAUnityRunner.ForcedInputMode primaryInputMode = XNAUnityRunner.PrimaryInputMode;
		List<int> filteredItems = this.FilteredItems;
		int focusRecipe = Main.focusRecipe;
		GUIControllerCrafting guicontrollerCrafting;
		if (guicontrollerCrafting != null)
		{
		}
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x000208CC File Offset: 0x0001EACC
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		Recipe.GetThroughDelayedFindRecipes();
		this.UpdateMaterialNavigation();
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		long num2 = 0L;
		this.UpdateFilter(num2 != 0L);
		List<int> filteredItems = this.FilteredItems;
		int focusRecipe = Main.focusRecipe;
		int size = this.FilteredItems._size;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x0002098C File Offset: 0x0001EB8C
	public float CraftItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (0600083B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUICrafting::CraftItemScale(System.Int32)

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

	// Token: 0x0600083C RID: 2108 RVA: 0x000209A0 File Offset: 0x0001EBA0
	private void RefocusExistingRecipeIfStillAvailable()
	{
		int num = 1;
		int num2 = 1;
		this.UpdateFilter(num2 != 0);
		if (num == 0)
		{
		}
		int numAvailableRecipes = Main.numAvailableRecipes;
		if (num == 0)
		{
		}
		int[] availableRecipe = Main.availableRecipe;
		int num3 = this.multiCraftRecipe;
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x000209E8 File Offset: 0x0001EBE8
	public void CraftButtonOver(GUITransactionButton.InputState state)
	{
		if (!true)
		{
		}
		int focusRecipe = Main.focusRecipe;
		int focusRecipe2 = Main.focusRecipe;
		if (this.Filter.Expanded)
		{
			bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		}
		if (state == GUITransactionButton.InputState.Clicked)
		{
			int type = Main.mouseItem.type;
			if (type != 0)
			{
				if (type == 0)
				{
				}
				int stack = Main.mouseItem.stack;
				if (stack != 0)
				{
					if (stack == 0)
					{
					}
					Item mouseItem = Main.mouseItem;
					int[] availableRecipe = Main.availableRecipe;
				}
			}
		}
		int type2 = Main.mouseItem.type;
		int maxStack;
		if (type2 != 0)
		{
			if (type2 == 0)
			{
			}
			Item mouseItem2 = Main.mouseItem;
			int[] availableRecipe2 = Main.availableRecipe;
			int stack2 = Main.mouseItem.stack;
			int[] availableRecipe3 = Main.availableRecipe;
			maxStack = Main.mouseItem.maxStack;
			int num = this.multiCraftRecipe;
			if (maxStack == 0)
			{
			}
			int[] availableRecipe4 = Main.availableRecipe;
		}
		if (maxStack == 0)
		{
		}
		int myPlayer = Main.myPlayer;
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00020D6C File Offset: 0x0001EF6C
	public void CraftItemOver(int index)
	{
		List<int> filteredItems = this.FilteredItems;
		int num = 1;
		this.wasOverItem = num != 0;
		int size = filteredItems._size;
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00020E84 File Offset: 0x0001F084
	public void CraftItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int size = this.FilteredItems._size;
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00020F9C File Offset: 0x0001F19C
	public float MaterialItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000840)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUICrafting::MaterialItemScale(System.Int32)

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

	// Token: 0x06000841 RID: 2113 RVA: 0x00020FB0 File Offset: 0x0001F1B0
	public void MaterialItemTooltipOver(int index)
	{
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00020FC0 File Offset: 0x0001F1C0
	public void MaterialItemOver(int index)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int[] availableRecipe = Main.availableRecipe;
		int focusRecipe = Main.focusRecipe;
		if (num == 0)
		{
			return;
		}
		GUIItemFilter filter = this.Filter;
		if (filter != null)
		{
			if (filter == null)
			{
			}
			int[] availableRecipe2 = Main.availableRecipe;
			int focusRecipe2 = Main.focusRecipe;
			bool expanded = filter.Expanded;
			int[] availableRecipe3 = Main.availableRecipe;
			int focusRecipe3 = Main.focusRecipe;
			ItemSlot.UpdateTooltipContext(22, index);
			int[] availableRecipe4 = Main.availableRecipe;
			int focusRecipe4 = Main.focusRecipe;
			int[] availableRecipe5 = Main.availableRecipe;
			int focusRecipe5 = Main.focusRecipe;
			return;
		}
		int[] availableRecipe6 = Main.availableRecipe;
		int focusRecipe6 = Main.focusRecipe;
		int[] availableRecipe7 = Main.availableRecipe;
		int focusRecipe7 = Main.focusRecipe;
		int[] availableRecipe8 = Main.availableRecipe;
		int focusRecipe8 = Main.focusRecipe;
		int[] availableRecipe9 = Main.availableRecipe;
		int focusRecipe9 = Main.focusRecipe;
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00021268 File Offset: 0x0001F468
	public void MaterialItemTooltipDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Vector2 position2 = this.CraftHover.requiredItem.position;
		int myPlayer = Main.myPlayer;
		Item[] requiredItem = this.CraftHover.requiredItem;
		Vector2 position3 = requiredItem.position;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		if (requiredItem == null)
		{
			!0 instance3 = PageControllerLayoutDefinition.Instance;
			if (this.materialsGridActive)
			{
				int selectedItem = this.materialController.selectedItem;
				!0 instance4 = PageControllerLayoutDefinition.Instance;
				!0 instance5 = PageControllerLayoutDefinition.Instance;
			}
		}
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x0002139C File Offset: 0x0001F59C
	public void MaterialItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		int num = 1;
		if (num == 0)
		{
		}
		int[] availableRecipe = Main.availableRecipe;
		int focusRecipe = Main.focusRecipe;
		if (num != 0)
		{
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			int[] availableRecipe2 = Main.availableRecipe;
			int focusRecipe2 = Main.focusRecipe;
			!0 instance = PageControllerLayoutDefinition.Instance;
			!0 instance2 = PageControllerLayoutDefinition.Instance;
			!0 instance3 = PageControllerLayoutDefinition.Instance;
			if (this.materialsGridActive)
			{
				int selectedItem = this.materialController.selectedItem;
				this.MaterialItemOver(index);
				!0 instance4 = PageControllerLayoutDefinition.Instance;
				!0 instance5 = PageControllerLayoutDefinition.Instance;
			}
			return;
		}
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		!0 instance7 = PageControllerLayoutDefinition.Instance;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x000214E4 File Offset: 0x0001F6E4
	public GUICrafting()
	{
	}

	// Token: 0x04000707 RID: 1799
	private float CraftButtonScale = (float)16256;

	// Token: 0x04000708 RID: 1800
	private int Offset;

	// Token: 0x04000709 RID: 1801
	private int LastId;

	// Token: 0x0400070A RID: 1802
	private GUIItemFilter.CategoryFilter LastCategory;

	// Token: 0x0400070B RID: 1803
	private string LastSearch;

	// Token: 0x0400070C RID: 1804
	public GUIItemFilter Filter;

	// Token: 0x0400070D RID: 1805
	public List<int> FilteredItems;

	// Token: 0x0400070E RID: 1806
	public float craftScrollOffset;

	// Token: 0x0400070F RID: 1807
	private float craftScrollMomentum;

	// Token: 0x04000710 RID: 1808
	private int craftScrollDragging;

	// Token: 0x04000711 RID: 1809
	private Vector2 craftDragOffset;

	// Token: 0x04000712 RID: 1810
	private bool pendingCraft;

	// Token: 0x04000713 RID: 1811
	public float hoverCraftDelay;

	// Token: 0x04000714 RID: 1812
	public GUITransactionButton.InputState lastState;

	// Token: 0x04000715 RID: 1813
	private float ExpandButtonScale;

	// Token: 0x04000716 RID: 1814
	public bool menuTogglePressed;

	// Token: 0x04000717 RID: 1815
	public bool materialsGridActive;

	// Token: 0x04000718 RID: 1816
	private DateTime NavigationTick;

	// Token: 0x04000719 RID: 1817
	private GUIControllerCraftingMaterials materialController;

	// Token: 0x0400071A RID: 1818
	private int multiCraftDelay;

	// Token: 0x0400071B RID: 1819
	private int multiCraftRecipe;

	// Token: 0x0400071C RID: 1820
	private bool wasOverItem;

	// Token: 0x0400071D RID: 1821
	private int cursorOver;

	// Token: 0x0400071E RID: 1822
	private int HoverRecipe;

	// Token: 0x0400071F RID: 1823
	public Recipe CraftHover;

	// Token: 0x04000720 RID: 1824
	private Item blankItem;

	// Token: 0x04000721 RID: 1825
	private string materialHoverItemName;

	// Token: 0x04000722 RID: 1826
	private Item materialToolTip;
}
