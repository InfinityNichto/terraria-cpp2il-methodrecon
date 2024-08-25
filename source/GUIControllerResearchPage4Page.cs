using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000DA RID: 218
public class GUIControllerResearchPage4Page : GUIPageContentController
{
	// Token: 0x0600059D RID: 1437 RVA: 0x00010E00 File Offset: 0x0000F000
	public GUIControllerResearchPage4Page()
	{
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00010E14 File Offset: 0x0000F014
	private DraggableItemGrid_Layout GetGrid()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		return draggableItemGrid_Layout;
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x000021DB File Offset: 0x000003DB
	private int GetCollectionCount()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00010E28 File Offset: 0x0000F028
	private float GetItemScale()
	{
		/*
An exception occurred when decompiling this method (060005A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerResearchPage4Page::GetItemScale()

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

	// Token: 0x060005A1 RID: 1441 RVA: 0x000021DB File Offset: 0x000003DB
	private float GetScrollOffset()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00010E3C File Offset: 0x0000F03C
	private void SetScrollOffset(float offset)
	{
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00010E4C File Offset: 0x0000F04C
	public bool IsInMenu()
	{
		/*
An exception occurred when decompiling this method (060005A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerResearchPage4Page::IsInMenu()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIControllerDynamicGridNavigator(var_0_06, callgetter:GUIControllerDynamicGridNavigator(GUIControllerResearchPage4Page::get_GridNav, ldloc:GUIControllerResearchPage4Page(this)))
	stloc:int32(var_1_0D, ldfld:int32(GUIControllerDynamicGridNavigator::itemColumn, ldloc:GUIControllerDynamicGridNavigator(var_0_06)))
	stloc:int32(var_2_14, callgetter:int32(GUIControllerDynamicGridNavigator::get_MenuColumn, ldloc:GUIControllerDynamicGridNavigator(var_0_06)))
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

	// Token: 0x060005A4 RID: 1444 RVA: 0x00010E70 File Offset: 0x0000F070
	private int GetMenuItemCount()
	{
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00010E80 File Offset: 0x0000F080
	private int GetDisplayItemCount()
	{
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00010E90 File Offset: 0x0000F090
	public GUIControllerDynamicGridNavigator GridNav
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerDynamicGridNavigator GUIControllerResearchPage4Page::get_GridNav()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerDynamicGridNavigator[exp:bool](GUIControllerResearchPage4Page::_gridNav, ldloc:GUIControllerResearchPage4Page(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00010EA4 File Offset: 0x0000F0A4
	public override void Activate()
	{
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00010EB8 File Offset: 0x0000F0B8
	public override int GetNavigationOutDirs()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetNavigationOutDirs();
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00010ED8 File Offset: 0x0000F0D8
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		base.LoadPageAnchor();
		return this.GridNav.Navigate(navigationVector);
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00010F00 File Offset: 0x0000F100
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		this.ResearchButton = 1;
		ControlAnchor.SetGridItemRegion(GUIPanel.Region(Research_Layout.Instance.Backing));
		int researchButton = this.ResearchButton;
		Research_Layout instance = Research_Layout.Instance;
		if (researchButton != 0)
		{
			TransactionButton_Layout close = instance.Close;
			GUIControllerDynamicGridNavigator guicontrollerDynamicGridNavigator;
			return guicontrollerDynamicGridNavigator.GetSelectedItemRegion();
		}
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00010F54 File Offset: 0x0000F154
	public override void NavigateInto(int column, int row)
	{
		this.GridNav.NavigateInto(column, row);
	}

	// Token: 0x040004B2 RID: 1202
	private GUIControllerDynamicGridNavigator _gridNav;
}
