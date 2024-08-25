using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000EB RID: 235
public class GUIControllerStaticGridNavigator
{
	// Token: 0x06000629 RID: 1577 RVA: 0x00013AFC File Offset: 0x00011CFC
	public GUIControllerStaticGridNavigator(GUIPageContentController controller, GUIControllerStaticGridNavigator.GetGrid grid, GUIControllerStaticGridNavigator.GetItemScale itemScale, GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount, GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount)
	{
		this._grid = grid;
		this._itemScale = itemScale;
		this._displayItemCount = displayItemCount;
		this._menuItemCount = menuItemCount;
		this._controller = controller;
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x0600062A RID: 1578 RVA: 0x00013B34 File Offset: 0x00011D34
	private ItemGrid_Layout GridLayout
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600062A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ItemGrid_Layout GUIControllerStaticGridNavigator::get_GridLayout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_0_06, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_0_06)))
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

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x0600062B RID: 1579 RVA: 0x00013B5C File Offset: 0x00011D5C
	private float itemScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600062B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerStaticGridNavigator::get_itemScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetItemScale(var_0_06, ldfld:GetItemScale(GUIControllerStaticGridNavigator::_itemScale, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetItemScale[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetItemScale[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetItemScale[exp:Delegate](var_0_06)))
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

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x0600062C RID: 1580 RVA: 0x00013B84 File Offset: 0x00011D84
	private int MenuItemCount
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600062C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerStaticGridNavigator::get_MenuItemCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerStaticGridNavigator::_menuItemCount, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
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

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x0600062D RID: 1581 RVA: 0x00013BAC File Offset: 0x00011DAC
	private int DisplayItemCount
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600062D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerStaticGridNavigator::get_DisplayItemCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerStaticGridNavigator::_displayItemCount, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
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

	// Token: 0x0600062E RID: 1582 RVA: 0x00013BD4 File Offset: 0x00011DD4
	public void Activate(int itemIndex = -1)
	{
		GUIControllerStaticGridNavigator.GetGrid grid = this._grid;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		GUIControllerStaticGridNavigator.GetGrid grid2 = this._grid;
		this.itemRow = (int)method;
		IntPtr invoke_impl2 = grid2.invoke_impl;
		IntPtr method_code2 = grid2.method_code;
		IntPtr method2 = grid2.method;
		this.itemColumn = (int)invoke_impl2;
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00013C30 File Offset: 0x00011E30
	public int GetNavigationOutDirs()
	{
		/*
An exception occurred when decompiling this method (0600062F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerStaticGridNavigator::GetNavigationOutDirs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004F:
	stloc:bool(var_8_55, callgetter:bool(GUIControllerStaticGridNavigator::get_LeftSideController, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:int32(var_9_5D, ldfld:int32(GUIControllerStaticGridNavigator::itemColumn, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:GetGrid(var_10_65, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_11_6E, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_10_65)))
	stloc:native int(var_12_77, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_10_65)))
	stloc:native int(var_13_80, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_10_65)))
	stloc:bool(var_14_88, callgetter:bool(GUIControllerStaticGridNavigator::get_LeftSideController, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:GetGrid(var_15_90, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:int32(var_16_98, ldfld:int32(GUIControllerStaticGridNavigator::itemColumn, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_17_A1, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_15_90)))
	stloc:native int(var_18_AA, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_15_90)))
	stloc:native int(var_19_B3, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_15_90)))
	stloc:bool(var_20_BB, callgetter:bool(GUIControllerStaticGridNavigator::get_LeftSideController, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:GetCollectionCount(var_21_C3, ldfld:GetCollectionCount(GUIControllerStaticGridNavigator::_menuItemCount, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_23_CF, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_21_C3)))
	stloc:native int(var_24_D8, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_21_C3)))
	stloc:native int(var_25_E1, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_21_C3)))
	stloc:int32(var_26_E9, ldfld:int32(GUIControllerStaticGridNavigator::menuRow, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:int32(var_27_F1, ldfld:int32(GUIControllerStaticGridNavigator::itemRow, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:GetGrid(var_28_F9, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_29_102, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_28_F9)))
	stloc:native int(var_30_10B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_28_F9)))
	stloc:native int(var_31_114, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_28_F9)))
	stloc:bool(var_32_11C, callgetter:bool(GUIControllerStaticGridNavigator::get_LeftSideController, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:int32(var_33_124, ldfld:int32(GUIControllerStaticGridNavigator::itemRow, ldloc:GUIControllerStaticGridNavigator(this)))
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

	// Token: 0x06000630 RID: 1584 RVA: 0x00013D64 File Offset: 0x00011F64
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		bool leftSideController = this.LeftSideController;
		return this.NavigateHorizontal(navigationVector);
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000631 RID: 1585 RVA: 0x00013D80 File Offset: 0x00011F80
	private int MenuColumn
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000631)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerStaticGridNavigator::get_MenuColumn()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_0_06, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_0_06)))
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

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000632 RID: 1586 RVA: 0x00013DA8 File Offset: 0x00011FA8
	private bool LeftSideController
	{
		get
		{
			return this._controller.ParentGrouping == null || this._controller.ParentGrouping.LeftSideGrouping;
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000633 RID: 1587 RVA: 0x00013DD4 File Offset: 0x00011FD4
	private bool HasMenu
	{
		get
		{
			GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
			IntPtr invoke_impl = menuItemCount.invoke_impl;
			IntPtr method_code = menuItemCount.method_code;
			IntPtr method = menuItemCount.method;
			return true;
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000634 RID: 1588 RVA: 0x00013E24 File Offset: 0x00012024
	public bool InMenu
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000634)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerStaticGridNavigator::get_InMenu()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_0_06, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:int32(var_1_0D, ldfld:int32(GUIControllerStaticGridNavigator::itemColumn, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_4_22, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_0_06)))
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

	// Token: 0x06000635 RID: 1589 RVA: 0x00013E54 File Offset: 0x00012054
	private void ClampMenu(bool preferUp = true)
	{
		GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
		int num = this.menuRow;
		IntPtr invoke_impl = menuItemCount.invoke_impl;
		IntPtr method_code = menuItemCount.method_code;
		IntPtr method = menuItemCount.method;
		GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount = this._displayItemCount;
		int num2 = this.menuRow;
		IntPtr invoke_impl2 = displayItemCount.invoke_impl;
		IntPtr method_code2 = displayItemCount.method_code;
		IntPtr method2 = displayItemCount.method;
		GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount2 = this._displayItemCount;
		IntPtr invoke_impl3 = displayItemCount2.invoke_impl;
		IntPtr method_code3 = displayItemCount2.method_code;
		IntPtr method3 = displayItemCount2.method;
		if (method_code3 != 0)
		{
			GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount3 = this._displayItemCount;
			IntPtr invoke_impl4 = displayItemCount3.invoke_impl;
			IntPtr method_code4 = displayItemCount3.method_code;
			IntPtr method4 = displayItemCount3.method;
			return;
		}
		GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount2 = this._menuItemCount;
		IntPtr invoke_impl5 = menuItemCount2.invoke_impl;
		IntPtr method_code5 = menuItemCount2.method_code;
		IntPtr method5 = menuItemCount2.method;
		this.menuRow = menuItemCount2;
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00013F2C File Offset: 0x0001212C
	private GUIControllerItem NavigateMenuOutOfGrid()
	{
		/*
An exception occurred when decompiling this method (06000636)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerStaticGridNavigator::NavigateMenuOutOfGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIControllerPageGroup(var_0_1D, callgetter:GUIControllerPageGroup(GUIPageIconGrouping::get_MenuController, callgetter:GUIPageIconGrouping(GUIPageContentController::get_ParentGrouping, ldfld:GUIPageContentController(GUIControllerStaticGridNavigator::_controller, ldloc:GUIControllerStaticGridNavigator(this)))))
	stloc:int32(var_1_24, ldfld:int32(GUIControllerStaticGridNavigator::itemRow, ldloc:GUIControllerStaticGridNavigator(this)))
	stfld:int32(GUIControllerPageGroup::MenuRow, ldloc:GUIControllerPageGroup(var_0_1D), ldloc:int32(var_1_24))
	stloc:GUIControllerPageGroup(var_2_3C, callgetter:GUIControllerPageGroup(GUIPageIconGrouping::get_MenuController, callgetter:GUIPageIconGrouping(GUIPageContentController::get_ParentGrouping, ldfld:GUIPageContentController(GUIControllerStaticGridNavigator::_controller, ldloc:GUIControllerStaticGridNavigator(this)))))
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

	// Token: 0x06000637 RID: 1591 RVA: 0x00013F78 File Offset: 0x00012178
	private GUIControllerItem NavigateUpOutOfGrid()
	{
		/*
An exception occurred when decompiling this method (06000637)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerStaticGridNavigator::NavigateUpOutOfGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIPageContentController(var_2_22, ldfld:GUIPageContentController(GUIControllerStaticGridNavigator::_controller, ldloc:GUIControllerStaticGridNavigator(this)))
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

	// Token: 0x06000638 RID: 1592 RVA: 0x00013FA8 File Offset: 0x000121A8
	private GUIControllerItem NavigateDownOutOfGrid()
	{
		/*
An exception occurred when decompiling this method (06000638)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerStaticGridNavigator::NavigateDownOutOfGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIPageContentController(var_2_22, ldfld:GUIPageContentController(GUIControllerStaticGridNavigator::_controller, ldloc:GUIControllerStaticGridNavigator(this)))
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

	// Token: 0x06000639 RID: 1593 RVA: 0x00013FD8 File Offset: 0x000121D8
	private GUIControllerItem NavigateInnerOutOfGrid()
	{
		GUIControllerItem guicontrollerItem;
		do
		{
			GUIControllerStaticGridNavigator.GetGrid grid = this._grid;
			int num = this.itemColumn;
			IntPtr invoke_impl = grid.invoke_impl;
			IntPtr method_code = grid.method_code;
			IntPtr method = grid.method;
			GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
			IntPtr invoke_impl2 = menuItemCount.invoke_impl;
			IntPtr method_code2 = menuItemCount.method_code;
			IntPtr method2 = menuItemCount.method;
			GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount = this._displayItemCount;
			IntPtr invoke_impl3 = displayItemCount.invoke_impl;
			IntPtr method_code3 = displayItemCount.method_code;
			IntPtr method3 = displayItemCount.method;
			GUIControllerStaticGridNavigator.GetGrid grid2 = this._grid;
			IntPtr invoke_impl4 = grid2.invoke_impl;
			IntPtr method_code4 = grid2.method_code;
			IntPtr method4 = grid2.method;
			int num2 = this.itemRow;
			this.itemColumn = grid2;
			this.ClampMenu(true);
			GUIControllerStaticGridNavigator.GetGrid grid3 = this._grid;
			int num3 = this.itemRow;
			int num4 = this.menuRow;
			IntPtr invoke_impl5 = grid3.invoke_impl;
			IntPtr method_code5 = grid3.method_code;
			IntPtr method5 = grid3.method;
			int num5 = this.menuRow;
			bool leftSideController = this.LeftSideController;
			guicontrollerItem = this._controller.ParentGrouping.NavigateRight(num5);
		}
		while (guicontrollerItem != null);
		return guicontrollerItem;
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x000140F8 File Offset: 0x000122F8
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		int num = this.itemColumn;
		GUIControllerStaticGridNavigator.GetGrid grid = this._grid;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		int num2 = this.menuRow;
		this.itemRow = num2;
		int num3 = this.itemColumn;
		GUIControllerStaticGridNavigator.GetGrid grid2 = this._grid;
		int num4 = this.itemColumn;
		IntPtr invoke_impl2 = grid2.invoke_impl;
		IntPtr method_code2 = grid2.method_code;
		IntPtr method2 = grid2.method;
		GUIControllerStaticGridNavigator.GetGrid grid3 = this._grid;
		int num5 = this.itemColumn;
		IntPtr invoke_impl3 = grid3.invoke_impl;
		IntPtr method_code3 = grid3.method_code;
		IntPtr method3 = grid3.method;
		int num6 = this.menuRow;
		this.itemRow = num6;
		int num7 = this.itemColumn;
		this.itemColumn = num7;
		GUIControllerStaticGridNavigator.GetGrid grid4 = this._grid;
		int num8 = this.itemColumn;
		IntPtr invoke_impl4 = grid4.invoke_impl;
		IntPtr method_code4 = grid4.method_code;
		IntPtr method4 = grid4.method;
		int num9 = this.menuRow;
		GUIControllerStaticGridNavigator.GetGrid grid5 = this._grid;
		int num10 = this.itemColumn;
		IntPtr invoke_impl5 = grid5.invoke_impl;
		IntPtr method_code5 = grid5.method_code;
		IntPtr method5 = grid5.method;
		GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
		IntPtr invoke_impl6 = menuItemCount.invoke_impl;
		IntPtr method_code6 = menuItemCount.method_code;
		IntPtr method6 = menuItemCount.method;
		GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount = this._displayItemCount;
		IntPtr method_code7 = displayItemCount.method_code;
		IntPtr invoke_impl7 = displayItemCount.invoke_impl;
		IntPtr method7 = displayItemCount.method;
		int num11 = this.menuRow;
		long num12 = 0L;
		this.menuRow = num11;
		this.ClampMenu(num12 != 0L);
		int num13 = this.itemRow;
		GUIControllerItem guicontrollerItem = this.NavigateUpOutOfGrid();
		if (guicontrollerItem == null)
		{
			return guicontrollerItem;
		}
		GUIPageContentController controller = this._controller;
		GUIControllerItem guicontrollerItem2;
		return guicontrollerItem2;
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x000142E4 File Offset: 0x000124E4
	protected void ClampPosition()
	{
		GUIControllerStaticGridNavigator.GetGrid grid = this._grid;
		int num = this.itemColumn;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		int num2 = 1;
		this.ClampMenu(num2 != 0);
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x0001438C File Offset: 0x0001258C
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (0600063C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerStaticGridNavigator::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00CD:
	stloc:bool(var_26_D3, callgetter:bool(GUIControllerStaticGridNavigator::get_LeftSideController, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:GetGrid(var_27_DB, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:int32(var_28_E3, ldfld:int32(GUIControllerStaticGridNavigator::itemColumn, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_29_EC, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_27_DB)))
	stloc:native int(var_30_F5, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_27_DB)))
	stloc:native int(var_31_FE, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_27_DB)))
	stloc:GetGrid(var_32_106, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_33_10F, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_32_106)))
	stloc:native int(var_34_118, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_32_106)))
	stloc:native int(var_35_121, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_32_106)))
	stloc:GetGrid(var_36_129, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:int32(var_37_131, ldfld:int32(GUIControllerStaticGridNavigator::itemColumn, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_38_13A, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_36_129)))
	stloc:native int(var_39_143, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_36_129)))
	stloc:native int(var_40_14C, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_36_129)))
	stloc:GetGrid(var_41_154, ldfld:GetGrid(GUIControllerStaticGridNavigator::_grid, ldloc:GUIControllerStaticGridNavigator(this)))
	stloc:native int(var_42_15D, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_41_154)))
	stloc:native int(var_43_166, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_41_154)))
	stloc:native int(var_44_16F, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_41_154)))
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

	// Token: 0x0600063D RID: 1597 RVA: 0x0001450C File Offset: 0x0001270C
	public void NavigateInto(int column, int row)
	{
		GUIControllerStaticGridNavigator.GetGrid grid = this._grid;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		GUIControllerStaticGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
		IntPtr invoke_impl2 = menuItemCount.invoke_impl;
		IntPtr method_code2 = menuItemCount.method_code;
		IntPtr method2 = menuItemCount.method;
		GUIControllerStaticGridNavigator.GetCollectionCount displayItemCount = this._displayItemCount;
		IntPtr invoke_impl3 = displayItemCount.invoke_impl;
		IntPtr method_code3 = displayItemCount.method_code;
		IntPtr method3 = displayItemCount.method;
		GUIControllerStaticGridNavigator.GetGrid grid2 = this._grid;
		IntPtr invoke_impl4 = grid2.invoke_impl;
		IntPtr method_code4 = grid2.method_code;
		IntPtr method4 = grid2.method;
		this.menuRow = grid2;
		this.ClampPosition();
	}

	// Token: 0x040004CF RID: 1231
	private readonly GUIControllerStaticGridNavigator.GetGrid _grid;

	// Token: 0x040004D0 RID: 1232
	private readonly GUIControllerStaticGridNavigator.GetItemScale _itemScale;

	// Token: 0x040004D1 RID: 1233
	private readonly GUIPageContentController _controller;

	// Token: 0x040004D2 RID: 1234
	private readonly GUIControllerStaticGridNavigator.GetCollectionCount _displayItemCount;

	// Token: 0x040004D3 RID: 1235
	private readonly GUIControllerStaticGridNavigator.GetCollectionCount _menuItemCount;

	// Token: 0x040004D4 RID: 1236
	public int itemRow;

	// Token: 0x040004D5 RID: 1237
	public int itemColumn;

	// Token: 0x040004D6 RID: 1238
	public int menuRow;

	// Token: 0x020000EC RID: 236
	public sealed class GetGrid : MulticastDelegate
	{
		// Token: 0x0600063E RID: 1598 RVA: 0x000145B0 File Offset: 0x000127B0
		public GetGrid(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.method_code = this;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000145F4 File Offset: 0x000127F4
		public ItemGrid_Layout Invoke()
		{
			/*
An exception occurred when decompiling this method (0600063F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ItemGrid_Layout GUIControllerStaticGridNavigator/GetGrid::Invoke()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](this)))
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

		// Token: 0x06000640 RID: 1600 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000021DB File Offset: 0x000003DB
		public ItemGrid_Layout EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x020000ED RID: 237
	public sealed class GetCollectionCount : MulticastDelegate
	{
		// Token: 0x06000642 RID: 1602 RVA: 0x00014618 File Offset: 0x00012818
		public GetCollectionCount(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001466C File Offset: 0x0001286C
		public int Invoke()
		{
			/*
An exception occurred when decompiling this method (06000643)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerStaticGridNavigator/GetCollectionCount::Invoke()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](this)))
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

		// Token: 0x06000644 RID: 1604 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000021DB File Offset: 0x000003DB
		public int EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x020000EE RID: 238
	public sealed class GetItemScale : MulticastDelegate
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x00014690 File Offset: 0x00012890
		public GetItemScale(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x000146E4 File Offset: 0x000128E4
		public float Invoke()
		{
			/*
An exception occurred when decompiling this method (06000647)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerStaticGridNavigator/GetItemScale::Invoke()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:GetItemScale[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetItemScale[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:GetItemScale[exp:Delegate](this)))
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

		// Token: 0x06000648 RID: 1608 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x000021DB File Offset: 0x000003DB
		public float EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
