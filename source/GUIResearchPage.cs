using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.UI;

// Token: 0x0200016C RID: 364
public class GUIResearchPage
{
	// Token: 0x06000A44 RID: 2628 RVA: 0x000313C8 File Offset: 0x0002F5C8
	public void LoadPageRegion()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		ControlAnchor.PageContentRegion = rectangle;
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000A45 RID: 2629 RVA: 0x000313E4 File Offset: 0x0002F5E4
	public bool Collapsed
	{
		get
		{
			if (!true)
			{
			}
			return InterfaceStyles_Layout.Active.IsCollapsed(GUIPageIcons.Category.Research);
		}
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00031404 File Offset: 0x0002F604
	public int ReforgeCost()
	{
		return this.refCost;
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00031418 File Offset: 0x0002F618
	public void Reset()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		this.dragOffset = 1;
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x000021DB File Offset: 0x000003DB
	private void RefreshItems()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00031434 File Offset: 0x0002F634
	public bool HasFocus
	{
		get
		{
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			return true;
		}
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x0003144C File Offset: 0x0002F64C
	public void DrawResearch()
	{
		Item researchItem = this.ResearchItem;
		string textValue = Language.GetTextValue("Mobile.Research");
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x0003151C File Offset: 0x0002F71C
	public void Draw()
	{
		int num = 1;
		this.RefreshItems();
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		int num2 = 255;
		!0 instance = PageControllerLayoutDefinition.Instance;
		string textValue = Language.GetTextValue("Mobile.Research");
		if (num2 == 0)
		{
		}
		List<int> researchItems = this._researchItems;
		int selectedItem = this._selectedItem;
		int size = researchItems._size;
		this.cursorOver = size;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		if (selectedItem == 0)
		{
		}
		Rectangle rectangle;
		if (rectangle == null)
		{
		}
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		int size2 = this._researchItems._size;
		if (PageControllerLayoutDefinition.Instance == null)
		{
		}
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		if (draggableItemGrid_Layout != null)
		{
			GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
			guicontrollerDynamicGridNavigator.DisableScrollUntilChange();
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000A4C RID: 2636 RVA: 0x000315C4 File Offset: 0x0002F7C4
	public Item ResearchItem
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000A4C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Item GUIResearchPage::get_ResearchItem()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_1_0A, callgetter:int32(Main::get_myPlayer))
	stloc:class [mscorlib]System.Collections.Generic.List`1<int32>(var_2_11, ldfld:class [mscorlib]System.Collections.Generic.List`1<int32>(GUIResearchPage::_researchItems, ldloc:GUIResearchPage(this)))
	stloc:int32(var_3_18, ldfld:int32(GUIResearchPage::_selectedItem, ldloc:GUIResearchPage(this)))
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

	// Token: 0x06000A4D RID: 2637 RVA: 0x000315F4 File Offset: 0x0002F7F4
	public float ResearchItemScale(int index)
	{
		/*
An exception occurred when decompiling this method (06000A4D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIResearchPage::ResearchItemScale(System.Int32)

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

	// Token: 0x06000A4E RID: 2638 RVA: 0x00031608 File Offset: 0x0002F808
	public void ResearchItemOver(int index)
	{
		this.cursorOver = index;
		int size = this._researchItems._size;
		if (size == 0)
		{
		}
		int myPlayer = Main.myPlayer;
		List<int> researchItems = this._researchItems;
		if (size == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (size == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		int selectedItem = this._selectedItem;
		this._selectedItem = index;
		if (index != 0)
		{
			int selectedItem2 = this._selectedItem;
			GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
			guicontrollerDynamicGridNavigator.Activate(selectedItem2);
		}
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0003167C File Offset: 0x0002F87C
	public void ResearchItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (!true)
		{
		}
		Main.inventoryScale = scale;
		int num = this.cursorOver;
		if (!true)
		{
		}
		int size = this._researchItems._size;
		int selectedItem = this._selectedItem;
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemSlot.SetSelectHighlight(true, scale);
		if (instance == null)
		{
		}
		int myPlayer = Main.myPlayer;
		List<int> researchItems = this._researchItems;
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x00031738 File Offset: 0x0002F938
	public GUIResearchPage()
	{
	}

	// Token: 0x04000A27 RID: 2599
	private float researchScale = (float)16256;

	// Token: 0x04000A28 RID: 2600
	private int refCost;

	// Token: 0x04000A29 RID: 2601
	public List<int> _researchItems;

	// Token: 0x04000A2A RID: 2602
	private Item _defaultItem;

	// Token: 0x04000A2B RID: 2603
	public int _selectedItem;

	// Token: 0x04000A2C RID: 2604
	public float scrollOffset;

	// Token: 0x04000A2D RID: 2605
	private float scrollMomentum;

	// Token: 0x04000A2E RID: 2606
	private int scrollDragging;

	// Token: 0x04000A2F RID: 2607
	private Vector2 dragOffset;

	// Token: 0x04000A30 RID: 2608
	private int cursorOver = 16256;

	// Token: 0x04000A31 RID: 2609
	private float reforgeActionScale;
}
