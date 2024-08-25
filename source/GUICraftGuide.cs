using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x02000136 RID: 310
public class GUICraftGuide
{
	// Token: 0x0600080B RID: 2059 RVA: 0x0001FBD0 File Offset: 0x0001DDD0
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x0600080C RID: 2060 RVA: 0x0001FBEC File Offset: 0x0001DDEC
	public bool Collapsed
	{
		get
		{
			if (!true)
			{
			}
			return InterfaceStyles_Layout.Active.IsCollapsed(GUIPageIcons.Category.CraftingGuide);
		}
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x0001FC0C File Offset: 0x0001DE0C
	public void Reset()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x0600080E RID: 2062 RVA: 0x0001FC20 File Offset: 0x0001DE20
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x0600080F RID: 2063 RVA: 0x0001FC38 File Offset: 0x0001DE38
	public Item guideItem
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600080F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUICraftGuide::get_guideItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:class [mscorlib]System.Collections.Generic.List`1<int32>(var_2_11, ldfld:class [mscorlib]System.Collections.Generic.List`1<int32>(GUICraftGuide::_materialItems, ldloc:GUICraftGuide(this)))
	stloc:int32(var_3_18, ldfld:int32(GUICraftGuide::_selectedItem, ldloc:GUICraftGuide(this)))
	stloc:int32(var_4_1F, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<int32>[exp:List`1](var_2_11)))
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

	// Token: 0x06000810 RID: 2064 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshItems()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x0001FC68 File Offset: 0x0001DE68
	public void DrawGuideList()
	{
		int type = this.guideItem.type;
		bool material = this.guideItem.material;
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x0001FD48 File Offset: 0x0001DF48
	public float GuideItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000812)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUICraftGuide::GuideItemScale(System.Int32)

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

	// Token: 0x06000813 RID: 2067 RVA: 0x0001FD5C File Offset: 0x0001DF5C
	public void GuideItemOver(int index)
	{
		this.cursorOver = index;
		int size = this._materialItems._size;
		if (size == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		List<int> materialItems = this._materialItems;
		if (size == 0)
		{
		}
		ItemSlot.UpdateTooltipContext(7, index);
		bool mouseLeft = Main.mouseLeft;
		if (size == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int selectedItem = this._selectedItem;
		this._selectedItem = index;
		GUIControllerCraftingGuide guicontrollerCraftingGuide;
		if (guicontrollerCraftingGuide != null)
		{
			GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
			guicontrollerDynamicGridNavigator.Activate(index);
		}
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0001FDD0 File Offset: 0x0001DFD0
	public void GuideItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (!true)
		{
		}
		Main.inventoryScale = scale;
		int num = this.cursorOver;
		if (!true)
		{
		}
		int size = this._materialItems._size;
		bool controllerModeLocked = XNAUnityRunner.ControllerModeLocked;
		int selectedItem = this._selectedItem;
		int num2 = this.cursorOver;
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0001FEAC File Offset: 0x0001E0AC
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int num2 = 255;
		!0 instance = PageControllerLayoutDefinition.Instance;
		string textValue = Language.GetTextValue("NPCName.Guide");
		if (num2 == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		if (Main.npcShop != 0)
		{
			Main.InGuideCraftMenu = false;
			int myPlayer2 = Main.myPlayer;
			Recipe.FindRecipes(false);
			return;
		}
		int myPlayer3 = Main.myPlayer;
		bool inReforgeMenu = Main.InReforgeMenu;
		Item item;
		int type = item.type;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		int itemCount = draggableItemGrid_Layout.ItemCount;
		if (num2 == 0)
		{
		}
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		!0 instance5 = PageControllerLayoutDefinition.Instance;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0001FF68 File Offset: 0x0001E168
	public GUICraftGuide()
	{
	}

	// Token: 0x040006D7 RID: 1751
	public float craftScrollOffset;

	// Token: 0x040006D8 RID: 1752
	private float craftScrollMomentum;

	// Token: 0x040006D9 RID: 1753
	private int craftScrollDragging;

	// Token: 0x040006DA RID: 1754
	private Vector2 craftDragOffset;

	// Token: 0x040006DB RID: 1755
	private int cursorOver = 1;

	// Token: 0x040006DC RID: 1756
	public bool menuTogglePressed;

	// Token: 0x040006DD RID: 1757
	public bool materialsGridActive;

	// Token: 0x040006DE RID: 1758
	private DateTime NavigationTick;

	// Token: 0x040006DF RID: 1759
	private GUIControllerCraftingMaterials materialController;

	// Token: 0x040006E0 RID: 1760
	private List<string> _requiredObjecsForCraftingText;

	// Token: 0x040006E1 RID: 1761
	public List<int> _materialItems;

	// Token: 0x040006E2 RID: 1762
	private Item _defaultItem;

	// Token: 0x040006E3 RID: 1763
	private int _selectedItem;
}
