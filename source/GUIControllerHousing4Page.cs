using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000CB RID: 203
public class GUIControllerHousing4Page : GUIControllerHousing
{
	// Token: 0x060004F4 RID: 1268 RVA: 0x0000F774 File Offset: 0x0000D974
	private DraggableItemGrid_Layout GetGrid()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		return draggableItemGrid_Layout;
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x000021DB File Offset: 0x000003DB
	private int GetCollectionCount()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x0000F788 File Offset: 0x0000D988
	private float GetItemScale()
	{
		/*
An exception occurred when decompiling this method (060004F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerHousing4Page::GetItemScale()

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

	// Token: 0x060004F7 RID: 1271 RVA: 0x000021DB File Offset: 0x000003DB
	private float GetScrollOffset()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0000F79C File Offset: 0x0000D99C
	private void SetScrollOffset(float offset)
	{
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x0000F7AC File Offset: 0x0000D9AC
	public override void NextItem()
	{
		base.LoadPageAnchor();
		this.GridNav.NextItem();
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x0000F7CC File Offset: 0x0000D9CC
	public override void PreviousItem()
	{
		base.LoadPageAnchor();
		this.GridNav.PreviousItem();
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x0000F7EC File Offset: 0x0000D9EC
	public override bool IsInMenu()
	{
		/*
An exception occurred when decompiling this method (060004FB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerHousing4Page::IsInMenu()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIControllerDynamicGridNavigator(var_0_06, callgetter:GUIControllerDynamicGridNavigator(GUIControllerHousing4Page::get_GridNav, ldloc:GUIControllerHousing4Page(this)))
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

	// Token: 0x060004FC RID: 1276 RVA: 0x0000F810 File Offset: 0x0000DA10
	private int GetMenuItemCount()
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0000F820 File Offset: 0x0000DA20
	private int GetDisplayItemCount()
	{
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060004FE RID: 1278 RVA: 0x0000F830 File Offset: 0x0000DA30
	public GUIControllerDynamicGridNavigator GridNav
	{
		get
		{
			/*
An exception occurred when decompiling this method (060004FE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerDynamicGridNavigator GUIControllerHousing4Page::get_GridNav()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerDynamicGridNavigator[exp:bool](GUIControllerHousing4Page::_gridNav, ldloc:GUIControllerHousing4Page(this)))
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

	// Token: 0x060004FF RID: 1279 RVA: 0x0000F844 File Offset: 0x0000DA44
	public override int GetNavigationOutDirs()
	{
		return this.GridNav.GetNavigationOutDirs();
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0000F85C File Offset: 0x0000DA5C
	public override void Activate()
	{
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0000F870 File Offset: 0x0000DA70
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		base.LoadPageAnchor();
		return this.GridNav.Navigate(navigationVector);
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x0000F890 File Offset: 0x0000DA90
	protected override void ClampPosition()
	{
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetSelectedItemRegion();
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0000F8C0 File Offset: 0x0000DAC0
	public override void NavigateInto(int column, int row)
	{
		base.LoadPageAnchor();
		this.GridNav.NavigateInto(column, row);
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
	public GUIControllerHousing4Page()
	{
		this.itemRow = 4;
		base..ctor();
	}

	// Token: 0x0400046F RID: 1135
	private GUIControllerDynamicGridNavigator _gridNav;
}
