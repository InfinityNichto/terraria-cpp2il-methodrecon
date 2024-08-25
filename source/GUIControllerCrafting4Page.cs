using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000BB RID: 187
public class GUIControllerCrafting4Page : GUIControllerCrafting
{
	// Token: 0x0600047A RID: 1146 RVA: 0x0000E420 File Offset: 0x0000C620
	private DraggableItemGrid_Layout GetGrid()
	{
		!0 instance = PageControllerLayoutDefinition.Instance;
		DraggableItemGrid_Layout draggableItemGrid_Layout;
		return draggableItemGrid_Layout;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x000021DB File Offset: 0x000003DB
	private int GetCollectionCount()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x0000E434 File Offset: 0x0000C634
	private float GetItemScale()
	{
		/*
An exception occurred when decompiling this method (0600047C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerCrafting4Page::GetItemScale()

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

	// Token: 0x0600047D RID: 1149 RVA: 0x000021DB File Offset: 0x000003DB
	private float GetScrollOffset()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x0000E448 File Offset: 0x0000C648
	private void SetScrollOffset(float offset)
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x0000E458 File Offset: 0x0000C658
	public override bool IsInMenu()
	{
		return this.GridNav.InMenu;
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x0000E470 File Offset: 0x0000C670
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

	// Token: 0x06000481 RID: 1153 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
	private int GetDisplayItemCount()
	{
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000482 RID: 1154 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
	public GUIControllerDynamicGridNavigator GridNav
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000482)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerDynamicGridNavigator GUIControllerCrafting4Page::get_GridNav()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerDynamicGridNavigator[exp:bool](GUIControllerCrafting4Page::_gridNav, ldloc:GUIControllerCrafting4Page(this)))
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

	// Token: 0x06000483 RID: 1155 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
	public override int GetNavigationOutDirs()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetNavigationOutDirs();
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
	public override void Activate()
	{
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x0000E50C File Offset: 0x0000C70C
	public override void RefreshScrollOffset()
	{
		base.LoadPageAnchor();
		this.GridNav.RefreshScrollOffset();
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x0000E52C File Offset: 0x0000C72C
	protected override void UpdateScroll()
	{
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x0000E53C File Offset: 0x0000C73C
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		base.LoadPageAnchor();
		GUIControllerDynamicGridNavigator gridNav = this.GridNav;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x0000E558 File Offset: 0x0000C758
	protected override void ClampPosition()
	{
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x0000E568 File Offset: 0x0000C768
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		return this.GridNav.GetSelectedItemRegion();
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x0000E588 File Offset: 0x0000C788
	public override void NavigateInto(int column, int row)
	{
		base.LoadPageAnchor();
		this.GridNav.NavigateInto(column, row);
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
	public GUIControllerCrafting4Page()
	{
	}

	// Token: 0x04000442 RID: 1090
	private GUIControllerDynamicGridNavigator _gridNav;
}
