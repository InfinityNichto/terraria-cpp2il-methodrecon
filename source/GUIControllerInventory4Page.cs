using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000CD RID: 205
public class GUIControllerInventory4Page : GUIControllerInventory
{
	// Token: 0x0600050E RID: 1294 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
	private ItemGrid_Layout GetInfoGrid()
	{
		return BuilderAccToggles_Layout.Instance.ToggleOptionsGrid;
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0000FBDC File Offset: 0x0000DDDC
	private int GetInfoCollectionCount()
	{
		int num;
		return num;
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x000021DB File Offset: 0x000003DB
	private float GetInfoItemScale()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x0000FBEC File Offset: 0x0000DDEC
	public override int GetNavigationOutDirs()
	{
		/*
An exception occurred when decompiling this method (06000511)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerInventory4Page::GetNavigationOutDirs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerInventory::itemRow, ldloc:GUIControllerInventory4Page[exp:GUIControllerInventory](this)))
	stloc:int32(var_1_0D, ldfld:int32(GUIControllerInventory::toolRow, ldloc:GUIControllerInventory4Page[exp:GUIControllerInventory](this)))
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

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000FC08 File Offset: 0x0000DE08
	private GUIControllerPageMenuPopupGridNavigator BuilderToolNav
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000512)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerPageMenuPopupGridNavigator GUIControllerInventory4Page::get_BuilderToolNav()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GUIControllerPageMenuPopupGridNavigator[exp:bool](GUIControllerInventory4Page::_accessoryNav, ldloc:GUIControllerInventory4Page(this)))
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

	// Token: 0x06000513 RID: 1299 RVA: 0x0000FC1C File Offset: 0x0000DE1C
	public override void Activate()
	{
		GUIControllerPageMenuPopupGridNavigator builderToolNav = this.BuilderToolNav;
		long num = 0L;
		builderToolNav.Activate((int)num);
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0000FC44 File Offset: 0x0000DE44
	public override void NavigateToItem(int item)
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0000FC74 File Offset: 0x0000DE74
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		base.LoadPageAnchor();
		GUIControllerPageMenuPopupGridNavigator builderToolNav = this.BuilderToolNav;
		int itemColumn = this.itemColumn;
		int itemRow = this.itemRow;
		this.itemColumn = itemColumn;
		int num = 4;
		this.itemRow = num;
		int itemColumn2 = this.itemColumn;
		int itemRow2 = this.itemRow;
		GUIControllerPageGroup menuController = base.ParentGrouping.MenuController;
		int itemRow3 = this.itemRow;
		menuController.MenuRow = itemRow3;
		GUIControllerPageGroup menuController2 = base.ParentGrouping.MenuController;
		int itemRow4 = this.itemRow;
		this.itemColumn = itemColumn2;
		int num2 = 4;
		this.itemRow = num2;
		int itemRow5 = this.itemRow;
		int itemRow6 = this.itemRow;
		int itemColumn3 = this.itemColumn;
		this.itemRow = itemRow5;
		GUIPageIconGrouping parentGrouping = base.ParentGrouping;
		int itemColumn4 = this.itemColumn;
		return parentGrouping.NavigateDown(itemColumn4);
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0000FD40 File Offset: 0x0000DF40
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
		GUIControllerPageMenuPopupGridNavigator guicontrollerPageMenuPopupGridNavigator;
		return guicontrollerPageMenuPopupGridNavigator.GetSelectedItemRegion();
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0000FDAC File Offset: 0x0000DFAC
	public GUIControllerInventory4Page()
	{
	}

	// Token: 0x04000474 RID: 1140
	private GUIControllerPageMenuPopupGridNavigator _accessoryNav;
}
