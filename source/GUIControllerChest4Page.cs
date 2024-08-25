using System;
using Controller;
using Microsoft.Xna.Framework;

// Token: 0x020000B7 RID: 183
public class GUIControllerChest4Page : GUIControllerChest
{
	// Token: 0x06000458 RID: 1112 RVA: 0x0000DF14 File Offset: 0x0000C114
	private ItemGrid_Layout GetGrid()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		ItemGrid_Layout itemGrid_Layout;
		return itemGrid_Layout;
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x0000DF28 File Offset: 0x0000C128
	private float GetItemScale()
	{
		/*
An exception occurred when decompiling this method (06000459)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerChest4Page::GetItemScale()

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

	// Token: 0x0600045A RID: 1114 RVA: 0x0000DF3C File Offset: 0x0000C13C
	public override bool IsInMenu()
	{
		return this.GridNav.InMenu;
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x0000DF54 File Offset: 0x0000C154
	private int GetMenuItemCount()
	{
		return 4;
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x0000DF64 File Offset: 0x0000C164
	private int GetDisplayItemCount()
	{
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000DF74 File Offset: 0x0000C174
	public GUIControllerStaticGridNavigator GridNav
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600045D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerStaticGridNavigator GUIControllerChest4Page::get_GridNav()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerStaticGridNavigator[exp:bool](GUIControllerChest4Page::_gridNav, ldloc:GUIControllerChest4Page(this)))
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

	// Token: 0x0600045E RID: 1118 RVA: 0x0000DF88 File Offset: 0x0000C188
	public override int GetNavigationOutDirs()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetNavigationOutDirs();
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
	public override void Activate()
	{
		long num = 0L;
		base.LoadPageAnchor();
		this.GridNav.Activate((int)num);
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x0000DFCC File Offset: 0x0000C1CC
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		base.LoadPageAnchor();
		GUIControllerStaticGridNavigator gridNav = this.GridNav;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x0000DFE8 File Offset: 0x0000C1E8
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
		GUIControllerStaticGridNavigator guicontrollerStaticGridNavigator;
		return guicontrollerStaticGridNavigator.GetSelectedItemRegion();
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x0000E014 File Offset: 0x0000C214
	public override void NavigateInto(int column, int row)
	{
		base.LoadPageAnchor();
		this.GridNav.NavigateInto(column, row);
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x0000E034 File Offset: 0x0000C234
	public GUIControllerChest4Page()
		: base(GUIPageIcons.Category.Chest)
	{
	}

	// Token: 0x0400043D RID: 1085
	private GUIControllerStaticGridNavigator _gridNav;
}
