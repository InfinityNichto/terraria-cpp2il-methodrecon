using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x020000E7 RID: 231
public class GUIControllerPageMenuPopupGridNavigator
{
	// Token: 0x0600060F RID: 1551 RVA: 0x000132F4 File Offset: 0x000114F4
	public GUIControllerPageMenuPopupGridNavigator(GUIPageContentController controller, GUIControllerPageMenuPopupGridNavigator.GetGrid grid, GUIControllerPageMenuPopupGridNavigator.GetCollectionCount collectionCount, GUIControllerPageMenuPopupGridNavigator.GetItemScale itemScale)
	{
		this._itemScale = itemScale;
		this._controller = controller;
		this._grid = grid;
		this._collectionCount = collectionCount;
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000610 RID: 1552 RVA: 0x00013324 File Offset: 0x00011524
	private ItemGrid_Layout GridLayout
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000610)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ItemGrid_Layout GUIControllerPageMenuPopupGridNavigator::get_GridLayout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_0_06, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
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

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001334C File Offset: 0x0001154C
	private int itemCount
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000611)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerPageMenuPopupGridNavigator::get_itemCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerPageMenuPopupGridNavigator::_collectionCount, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
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

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000612 RID: 1554 RVA: 0x00013374 File Offset: 0x00011574
	private float itemScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000612)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerPageMenuPopupGridNavigator::get_itemScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetItemScale(var_0_06, ldfld:GetItemScale(GUIControllerPageMenuPopupGridNavigator::_itemScale, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
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

	// Token: 0x06000613 RID: 1555 RVA: 0x0001339C File Offset: 0x0001159C
	public void Activate(int itemIndex = -1)
	{
		GUIControllerPageMenuPopupGridNavigator.GetGrid grid = this._grid;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		GUIControllerPageMenuPopupGridNavigator.GetGrid grid2 = this._grid;
		this.itemRow = grid;
		IntPtr invoke_impl2 = grid2.invoke_impl;
		IntPtr method_code2 = grid2.method_code;
		IntPtr method2 = grid2.method;
		this.itemColumn = (int)invoke_impl2;
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x000133F8 File Offset: 0x000115F8
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		bool leftSideGrouping = this._controller.ParentGrouping.LeftSideGrouping;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000615 RID: 1557 RVA: 0x00013418 File Offset: 0x00011618
	private int MaxRow_Horizontal
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000615)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerPageMenuPopupGridNavigator::get_MaxRow_Horizontal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerPageMenuPopupGridNavigator::_collectionCount, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_5_2B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_6_34, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_7_3D, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:GetGrid(var_8_45, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_9_4E, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_8_45)))
	stloc:native int(var_10_57, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_8_45)))
	stloc:native int(var_11_60, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_8_45)))
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

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000616 RID: 1558 RVA: 0x00013488 File Offset: 0x00011688
	private int MaxRowColumn_Horizontal
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000616)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerPageMenuPopupGridNavigator::get_MaxRowColumn_Horizontal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_8_49, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_9_52, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_8_49)))
	stloc:native int(var_10_5B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_8_49)))
	stloc:native int(var_11_64, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_8_49)))
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

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x000134FC File Offset: 0x000116FC
	private bool LeftSideController
	{
		get
		{
			return this._controller.ParentGrouping.LeftSideGrouping;
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001351C File Offset: 0x0001171C
	private int MaxScrollOffset_Horizontal
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000618)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerPageMenuPopupGridNavigator::get_MaxScrollOffset_Horizontal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerPageMenuPopupGridNavigator::_collectionCount, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_5_2B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_6_34, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_7_3D, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:GetGrid(var_8_45, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_9_4E, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_8_45)))
	stloc:native int(var_10_57, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_8_45)))
	stloc:native int(var_11_60, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_8_45)))
	stloc:GetGrid(var_12_68, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_13_71, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:native int(var_14_7A, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:native int(var_15_83, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:GetGrid(var_16_8B, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_17_94, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_16_8B)))
	stloc:native int(var_18_9D, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_16_8B)))
	stloc:native int(var_19_A6, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_16_8B)))
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

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000619 RID: 1561 RVA: 0x000135D0 File Offset: 0x000117D0
	private int MaxDisplayRow_Horizontal
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000619)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerPageMenuPopupGridNavigator::get_MaxDisplayRow_Horizontal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_0_06, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_5_2B, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_6_34, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_7_3D, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_4_22)))
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

	// Token: 0x0600061A RID: 1562 RVA: 0x0001361C File Offset: 0x0001181C
	private GUIControllerItem NavigateHorizontal(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (0600061A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerPageMenuPopupGridNavigator::NavigateHorizontal(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0109:
	stloc:int32(var_28_10F, callgetter:int32(GUIControllerPageMenuPopupGridNavigator::get_MaxRowColumn_Horizontal, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stfld:int32(GUIControllerPageMenuPopupGridNavigator::itemColumn, ldloc:GUIControllerPageMenuPopupGridNavigator(this), ldloc:int32(var_28_10F))
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

	// Token: 0x0600061B RID: 1563 RVA: 0x00013744 File Offset: 0x00011944
	protected void ClampPosition()
	{
		int num = this.itemRow;
		int maxRow_Horizontal = this.MaxRow_Horizontal;
		int maxRow_Horizontal2 = this.MaxRow_Horizontal;
		this.itemRow = maxRow_Horizontal2;
		GUIControllerPageMenuPopupGridNavigator.GetGrid grid = this._grid;
		int num2 = this.itemColumn;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		GUIControllerPageMenuPopupGridNavigator.GetGrid grid2 = this._grid;
		IntPtr invoke_impl2 = grid2.invoke_impl;
		IntPtr method_code2 = grid2.method_code;
		IntPtr method2 = grid2.method;
		this.itemColumn = num2;
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00013844 File Offset: 0x00011A44
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (0600061C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerPageMenuPopupGridNavigator::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_009B:
	stloc:bool(var_20_AB, callgetter:bool(GUIPageIconGrouping::get_LeftSideGrouping, callgetter:GUIPageIconGrouping(GUIPageContentController::get_ParentGrouping, ldfld:GUIPageContentController(GUIControllerPageMenuPopupGridNavigator::_controller, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))))
	stloc:GetGrid(var_21_B3, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_22_BC, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_21_B3)))
	stloc:native int(var_23_C5, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_21_B3)))
	stloc:native int(var_24_CE, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_21_B3)))
	stloc:GetGrid(var_25_D6, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:int32(var_26_DE, ldfld:int32(GUIControllerPageMenuPopupGridNavigator::itemColumn, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_27_E7, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_25_D6)))
	stloc:native int(var_28_F0, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_25_D6)))
	stloc:native int(var_29_F9, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_25_D6)))
	stloc:GetGrid(var_30_101, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:int32(var_31_109, ldfld:int32(GUIControllerPageMenuPopupGridNavigator::itemColumn, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_32_112, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_30_101)))
	stloc:native int(var_33_11B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_30_101)))
	stloc:native int(var_34_124, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_30_101)))
	stloc:GetGrid(var_35_12C, ldfld:GetGrid(GUIControllerPageMenuPopupGridNavigator::_grid, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:int32(var_36_134, ldfld:int32(GUIControllerPageMenuPopupGridNavigator::itemRow, ldloc:GUIControllerPageMenuPopupGridNavigator(this)))
	stloc:native int(var_37_13D, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_35_12C)))
	stloc:native int(var_38_146, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_35_12C)))
	stloc:native int(var_39_14F, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_35_12C)))
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

	// Token: 0x040004C9 RID: 1225
	private readonly GUIControllerPageMenuPopupGridNavigator.GetGrid _grid;

	// Token: 0x040004CA RID: 1226
	private readonly GUIControllerPageMenuPopupGridNavigator.GetCollectionCount _collectionCount;

	// Token: 0x040004CB RID: 1227
	private readonly GUIControllerPageMenuPopupGridNavigator.GetItemScale _itemScale;

	// Token: 0x040004CC RID: 1228
	private readonly GUIPageContentController _controller;

	// Token: 0x040004CD RID: 1229
	public int itemRow;

	// Token: 0x040004CE RID: 1230
	public int itemColumn;

	// Token: 0x020000E8 RID: 232
	public sealed class GetGrid : MulticastDelegate
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x000139A4 File Offset: 0x00011BA4
		public GetGrid(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000139F8 File Offset: 0x00011BF8
		public ItemGrid_Layout Invoke()
		{
			/*
An exception occurred when decompiling this method (0600061E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ItemGrid_Layout GUIControllerPageMenuPopupGridNavigator/GetGrid::Invoke()

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

		// Token: 0x0600061F RID: 1567 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000021DB File Offset: 0x000003DB
		public ItemGrid_Layout EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x020000E9 RID: 233
	public sealed class GetCollectionCount : MulticastDelegate
	{
		// Token: 0x06000621 RID: 1569 RVA: 0x00013A1C File Offset: 0x00011C1C
		public GetCollectionCount(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00013A70 File Offset: 0x00011C70
		public int Invoke()
		{
			/*
An exception occurred when decompiling this method (06000622)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerPageMenuPopupGridNavigator/GetCollectionCount::Invoke()

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

		// Token: 0x06000623 RID: 1571 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x000021DB File Offset: 0x000003DB
		public int EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x020000EA RID: 234
	public sealed class GetItemScale : MulticastDelegate
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x00013A94 File Offset: 0x00011C94
		public GetItemScale(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00013AD8 File Offset: 0x00011CD8
		public float Invoke()
		{
			/*
An exception occurred when decompiling this method (06000626)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerPageMenuPopupGridNavigator/GetItemScale::Invoke()

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

		// Token: 0x06000627 RID: 1575 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000021DB File Offset: 0x000003DB
		public float EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
