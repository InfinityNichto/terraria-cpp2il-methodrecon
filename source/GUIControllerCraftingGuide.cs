using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000BC RID: 188
public class GUIControllerCraftingGuide : GUIPageContentController
{
	// Token: 0x0600048C RID: 1164 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
	public GUIControllerCraftingGuide()
		: base(GUIPageIcons.Category.CraftingGuide)
	{
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x0000E5CC File Offset: 0x0000C7CC
	private DraggableItemGrid_Layout GetGrid()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		return draggableItemGrid_Layout;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x000021DB File Offset: 0x000003DB
	private int GetCollectionCount()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
	private float GetItemScale()
	{
		/*
An exception occurred when decompiling this method (0600048F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerCraftingGuide::GetItemScale()

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

	// Token: 0x06000490 RID: 1168 RVA: 0x000021DB File Offset: 0x000003DB
	private float GetScrollOffset()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x0000E5F4 File Offset: 0x0000C7F4
	private void SetScrollOffset(float offset)
	{
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x0000E604 File Offset: 0x0000C804
	public bool IsInMenu()
	{
		return this.GridNav.InMenu;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x0000E61C File Offset: 0x0000C81C
	private int GetMenuItemCount()
	{
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x0000E62C File Offset: 0x0000C82C
	private int GetDisplayItemCount()
	{
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000E63C File Offset: 0x0000C83C
	public GUIControllerDynamicGridNavigator GridNav
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000495)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerDynamicGridNavigator GUIControllerCraftingGuide::get_GridNav()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerDynamicGridNavigator[exp:bool](GUIControllerCraftingGuide::_gridNav, ldloc:GUIControllerCraftingGuide(this)))
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

	// Token: 0x06000496 RID: 1174 RVA: 0x0000E650 File Offset: 0x0000C850
	public override int GetNavigationOutDirs()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetNavigationOutDirs();
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x0000E670 File Offset: 0x0000C870
	public override void Activate()
	{
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x0000E684 File Offset: 0x0000C884
	public void RefreshScrollOffset()
	{
		base.LoadPageAnchor();
		this.GridNav.RefreshScrollOffset();
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x0000E6A4 File Offset: 0x0000C8A4
	protected void UpdateScroll()
	{
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		base.LoadPageAnchor();
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
	protected void ClampPosition()
	{
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetSelectedItemRegion();
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x0000E700 File Offset: 0x0000C900
	public override void NavigateInto(int column, int row)
	{
		base.LoadPageAnchor();
		this.GridNav.NavigateInto(column, row);
	}

	// Token: 0x04000443 RID: 1091
	private GUIControllerDynamicGridNavigator _gridNav;
}
