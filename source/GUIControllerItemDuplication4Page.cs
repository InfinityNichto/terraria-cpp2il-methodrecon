using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000CF RID: 207
public class GUIControllerItemDuplication4Page : GUIControllerItemDuplication
{
	// Token: 0x06000522 RID: 1314 RVA: 0x0000FF4C File Offset: 0x0000E14C
	private DraggableItemGrid_Layout GetGrid()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		return draggableItemGrid_Layout;
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x000021DB File Offset: 0x000003DB
	private int GetCollectionCount()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x0000FF60 File Offset: 0x0000E160
	private float GetItemScale()
	{
		/*
An exception occurred when decompiling this method (06000524)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerItemDuplication4Page::GetItemScale()

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

	// Token: 0x06000525 RID: 1317 RVA: 0x000021DB File Offset: 0x000003DB
	private float GetScrollOffset()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0000FF74 File Offset: 0x0000E174
	private void SetScrollOffset(float offset)
	{
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0000FF84 File Offset: 0x0000E184
	public override bool IsInMenu()
	{
		/*
An exception occurred when decompiling this method (06000527)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerItemDuplication4Page::IsInMenu()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIControllerDynamicGridNavigator(var_0_06, callgetter:GUIControllerDynamicGridNavigator(GUIControllerItemDuplication4Page::get_GridNav, ldloc:GUIControllerItemDuplication4Page(this)))
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

	// Token: 0x06000528 RID: 1320 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
	private int GetMenuItemCount()
	{
		if (!true)
		{
		}
		int gameMode = Main.GameMode;
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		InterfaceProfile_Layout active2 = InterfaceStyles_Layout.Active;
		long num = 0L;
		GUIPageIconGrouping categoryGrouping = active2.GetCategoryGrouping(GUIPageIcons.Category.Duplicate, num != 0L);
		GUIPageIconGrouping guipageIconGrouping;
		if (guipageIconGrouping == null || categoryGrouping != null)
		{
		}
		return 2;
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0000FFEC File Offset: 0x0000E1EC
	private int GetDisplayItemCount()
	{
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000FFFC File Offset: 0x0000E1FC
	public GUIControllerDynamicGridNavigator GridNav
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600052A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerDynamicGridNavigator GUIControllerItemDuplication4Page::get_GridNav()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerDynamicGridNavigator[exp:bool](GUIControllerItemDuplication4Page::_gridNav, ldloc:GUIControllerItemDuplication4Page(this)))
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

	// Token: 0x0600052B RID: 1323 RVA: 0x00010010 File Offset: 0x0000E210
	public override void Activate()
	{
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00010024 File Offset: 0x0000E224
	public override int GetNavigationOutDirs()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetNavigationOutDirs();
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00010044 File Offset: 0x0000E244
	public override void RefreshScrollOffset()
	{
		this.GridNav.RefreshScrollOffset();
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0001005C File Offset: 0x0000E25C
	protected override void UpdateScroll()
	{
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0001006C File Offset: 0x0000E26C
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		base.LoadPageAnchor();
		return this.GridNav.Navigate(navigationVector);
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0001008C File Offset: 0x0000E28C
	protected override void ClampPosition()
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0001009C File Offset: 0x0000E29C
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetSelectedItemRegion();
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x000100BC File Offset: 0x0000E2BC
	public override void NavigateInto(int column, int row)
	{
		this.GridNav.NavigateInto(column, row);
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x000100D8 File Offset: 0x0000E2D8
	public GUIControllerItemDuplication4Page()
	{
	}

	// Token: 0x04000478 RID: 1144
	private GUIControllerDynamicGridNavigator _gridNav;
}
