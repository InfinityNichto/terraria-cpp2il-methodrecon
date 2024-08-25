using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x020000E1 RID: 225
public class GUIControllerDynamicGridNavigator
{
	// Token: 0x060005D6 RID: 1494 RVA: 0x000113EC File Offset: 0x0000F5EC
	public GUIControllerDynamicGridNavigator(GUIPageContentController controller, GUIControllerDynamicGridNavigator.GetGrid grid, GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount, GUIControllerDynamicGridNavigator.GetItemScale itemScale, GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset, GUIControllerDynamicGridNavigator.SetScrollOffset setScrollOffset, GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount, GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount)
	{
		this._setScrollOffset = setScrollOffset;
		this._controller = controller;
		this._grid = grid;
		this._collectionCount = collectionCount;
		this._itemScale = itemScale;
		this._getScrollOffset = getScrollOffset;
		this._menuItemCount = menuItemCount;
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00011434 File Offset: 0x0000F634
	private DraggableItemGrid_Layout GridLayout
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005D7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling DraggableItemGrid_Layout GUIControllerDynamicGridNavigator::get_GridLayout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_0_06, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x060005D8 RID: 1496 RVA: 0x000021DB File Offset: 0x000003DB
	private int itemCount
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001145C File Offset: 0x0000F65C
	private float itemScale
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005D9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerDynamicGridNavigator::get_itemScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetItemScale(var_0_06, ldfld:GetItemScale(GUIControllerDynamicGridNavigator::_itemScale, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x060005DA RID: 1498 RVA: 0x00011484 File Offset: 0x0000F684
	// (set) Token: 0x060005DB RID: 1499 RVA: 0x000114AC File Offset: 0x0000F6AC
	private float GridScrollOffset
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerDynamicGridNavigator::get_GridScrollOffset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetScrollOffset(var_0_06, ldfld:GetScrollOffset(GUIControllerDynamicGridNavigator::_getScrollOffset, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetScrollOffset[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetScrollOffset[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetScrollOffset[exp:Delegate](var_0_06)))
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
		set
		{
			GUIControllerDynamicGridNavigator.SetScrollOffset setScrollOffset = this._setScrollOffset;
			IntPtr invoke_impl = setScrollOffset.invoke_impl;
			IntPtr method_code = setScrollOffset.method_code;
			IntPtr method = setScrollOffset.method;
		}
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x000114D8 File Offset: 0x0000F6D8
	public void DisableScrollUntilChange()
	{
		GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount = this._collectionCount;
		this.scrollDisabledUntilChange = true;
		IntPtr invoke_impl = collectionCount.invoke_impl;
		IntPtr method = collectionCount.method;
		this.itemCountAtDisableScroll = this;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00011508 File Offset: 0x0000F708
	public void NextItem()
	{
		bool leftSideController = this.LeftSideController;
		GUIControllerDynamicGridNavigator.GetGrid grid = this._grid;
		int num = this.itemRow;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount = this._collectionCount;
		int num2 = this.itemColumn;
		IntPtr invoke_impl2 = collectionCount.invoke_impl;
		IntPtr method_code2 = collectionCount.method_code;
		IntPtr method2 = collectionCount.method;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0001161C File Offset: 0x0000F81C
	public void PreviousItem()
	{
		bool leftSideController = this.LeftSideController;
		GUIControllerDynamicGridNavigator.GetGrid grid = this._grid;
		int num = this.itemRow;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		int num2 = this.itemColumn;
		GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount = this._collectionCount;
		IntPtr invoke_impl2 = collectionCount.invoke_impl;
		IntPtr method_code2 = collectionCount.method_code;
		IntPtr method2 = collectionCount.method;
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x060005DF RID: 1503 RVA: 0x00011704 File Offset: 0x0000F904
	private int MenuItemCount
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_MenuItemCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerDynamicGridNavigator::_menuItemCount, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001172C File Offset: 0x0000F92C
	private int DisplayItemCount
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005E0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_DisplayItemCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerDynamicGridNavigator::_displayItemCount, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x060005E1 RID: 1505 RVA: 0x00011754 File Offset: 0x0000F954
	public bool isSelectedItem(int itemIndex)
	{
		/*
An exception occurred when decompiling this method (060005E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerDynamicGridNavigator::isSelectedItem(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_0_06, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_5_2B, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_6_34, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_7_3D, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:int32(var_8_45, ldfld:int32(GUIControllerDynamicGridNavigator::itemRow, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:int32(var_9_4D, ldfld:int32(GUIControllerDynamicGridNavigator::itemColumn, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x060005E2 RID: 1506 RVA: 0x000117B4 File Offset: 0x0000F9B4
	public void Activate(int itemIndex = -1)
	{
		GUIControllerDynamicGridNavigator.GetGrid grid = this._grid;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		GUIControllerDynamicGridNavigator.GetGrid grid2 = this._grid;
		IntPtr method_code2 = grid2.method_code;
		IntPtr method2 = grid2.method;
		this.itemColumn = grid;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x000118EC File Offset: 0x0000FAEC
	public GUIControllerItem Navigate(Microsoft.Xna.Framework.Vector2 navigationVector)
	{
		bool leftSideController = this.LeftSideController;
		if (this.scrollDisabledUntilChange)
		{
		}
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001190C File Offset: 0x0000FB0C
	private int MaxRow_Horizontal
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_MaxRow_Horizontal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerDynamicGridNavigator::_collectionCount, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_5_2B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_6_34, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_7_3D, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:GetGrid(var_8_45, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001197C File Offset: 0x0000FB7C
	private int MaxRowColumn_Horizontal
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_MaxRowColumn_Horizontal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:GetGrid(var_12_6F, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_13_78, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_12_6F)))
	stloc:native int(var_14_81, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_12_6F)))
	stloc:native int(var_15_8A, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_12_6F)))
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

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00011A14 File Offset: 0x0000FC14
	private int MaxRow_Vertical
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005E6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_MaxRow_Vertical()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerDynamicGridNavigator::_collectionCount, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_5_2B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_6_34, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_7_3D, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:GetCollectionCount(var_8_45, ldfld:GetCollectionCount(GUIControllerDynamicGridNavigator::_collectionCount, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_9_4E, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_8_45)))
	stloc:native int(var_10_57, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_8_45)))
	stloc:native int(var_11_60, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_8_45)))
	stloc:GetGrid(var_12_68, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_13_71, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:native int(var_14_7A, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:native int(var_15_83, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_12_68)))
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

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00011AA8 File Offset: 0x0000FCA8
	private int MaxRowColumn_Vertical
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_MaxRowColumn_Vertical()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerDynamicGridNavigator::_collectionCount, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_5_2B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_6_34, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_7_3D, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:GetCollectionCount(var_8_45, ldfld:GetCollectionCount(GUIControllerDynamicGridNavigator::_collectionCount, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_9_4E, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_8_45)))
	stloc:native int(var_10_57, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_8_45)))
	stloc:native int(var_11_60, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_8_45)))
	stloc:GetGrid(var_12_68, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_13_71, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:native int(var_14_7A, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:native int(var_15_83, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_12_68)))
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

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00011B3C File Offset: 0x0000FD3C
	private int MenuColumn
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_MenuColumn()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_1_06, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_2_0D, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_1_06)))
	stloc:native int(var_3_14, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_1_06)))
	stloc:native int(var_4_1B, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_1_06)))
	stloc:GetGrid(var_5_23, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_6_2C, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_5_23)))
	stloc:native int(var_7_35, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_5_23)))
	stloc:native int(var_8_3E, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_5_23)))
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

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00011B88 File Offset: 0x0000FD88
	private bool LeftSideController
	{
		get
		{
			GUIPageContentController controller = this._controller;
			return controller == null || controller.ParentGrouping == null || this._controller.ParentGrouping.LeftSideGrouping;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060005EA RID: 1514 RVA: 0x00011BBC File Offset: 0x0000FDBC
	private int MaxScrollOffset_Horizontal
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_MaxScrollOffset_Horizontal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetCollectionCount(var_0_06, ldfld:GetCollectionCount(GUIControllerDynamicGridNavigator::_collectionCount, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetCollectionCount[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_5_2B, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_6_34, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:native int(var_7_3D, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_4_22)))
	stloc:GetGrid(var_8_45, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_9_4E, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_8_45)))
	stloc:native int(var_10_57, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_8_45)))
	stloc:native int(var_11_60, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_8_45)))
	stloc:GetGrid(var_12_68, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_13_71, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:native int(var_14_7A, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:native int(var_15_83, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_12_68)))
	stloc:GetGrid(var_16_8B, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060005EB RID: 1515 RVA: 0x00011C70 File Offset: 0x0000FE70
	private int MaxDisplayRow_Horizontal
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005EB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator::get_MaxDisplayRow_Horizontal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GetGrid(var_0_06, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method_code, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:native int(var_3_1B, ldfld:native int(Delegate::method, ldloc:GetGrid[exp:Delegate](var_0_06)))
	stloc:GetGrid(var_4_22, ldfld:GetGrid(GUIControllerDynamicGridNavigator::_grid, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x060005EC RID: 1516 RVA: 0x00011CBC File Offset: 0x0000FEBC
	public void RefreshScrollOffset()
	{
		int num = 1;
		int maxScrollOffset_Horizontal = this.MaxScrollOffset_Horizontal;
		if (num == 0)
		{
		}
		GUIControllerDynamicGridNavigator.GetItemScale itemScale = this._itemScale;
		IntPtr invoke_impl = itemScale.invoke_impl;
		IntPtr method_code = itemScale.method_code;
		IntPtr method = itemScale.method;
		if (itemScale == null)
		{
		}
		GUIControllerDynamicGridNavigator.GetGrid grid = this._grid;
		IntPtr invoke_impl2 = grid.invoke_impl;
		IntPtr method_code2 = grid.method_code;
		IntPtr method2 = grid.method;
		GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset = this._getScrollOffset;
		IntPtr method_code3 = getScrollOffset.method_code;
		IntPtr invoke_impl3 = getScrollOffset.invoke_impl;
		IntPtr method3 = getScrollOffset.method;
		int num2 = this.scrollOffset;
		GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset2 = this._getScrollOffset;
		this.scrollOffset = num2;
		IntPtr invoke_impl4 = getScrollOffset2.invoke_impl;
		IntPtr method_code4 = getScrollOffset2.method_code;
		IntPtr method4 = getScrollOffset2.method;
		GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset3 = this._getScrollOffset;
		int num3 = this.scrollOffset;
		IntPtr invoke_impl5 = getScrollOffset3.invoke_impl;
		IntPtr method_code5 = getScrollOffset3.method_code;
		IntPtr method5 = getScrollOffset3.method;
		int num4 = 32640;
		this.scrollOffset = num4;
		int num5 = this.scrollOffset;
		int maxScrollOffset_Horizontal2 = this.MaxScrollOffset_Horizontal;
		int maxScrollOffset_Horizontal3 = this.MaxScrollOffset_Horizontal;
		this.scrollOffset = maxScrollOffset_Horizontal3;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00011E74 File Offset: 0x00010074
	protected void UpdateScroll()
	{
		int num3;
		if (this.scrollDisabledUntilChange)
		{
			GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount = this._collectionCount;
			IntPtr invoke_impl = collectionCount.invoke_impl;
			IntPtr method_code = collectionCount.method_code;
			IntPtr method = collectionCount.method;
			if (this.itemCountAtDisableScroll == 0)
			{
			}
			GUIControllerDynamicGridNavigator.GetItemScale itemScale = this._itemScale;
			IntPtr invoke_impl2 = itemScale.invoke_impl;
			IntPtr method_code2 = itemScale.method_code;
			IntPtr method2 = itemScale.method;
			if (itemScale == null)
			{
			}
			GUIControllerDynamicGridNavigator.GetGrid grid = this._grid;
			IntPtr invoke_impl3 = grid.invoke_impl;
			IntPtr method_code3 = grid.method_code;
			IntPtr method3 = grid.method;
			GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset = this._getScrollOffset;
			IntPtr method_code4 = getScrollOffset.method_code;
			IntPtr invoke_impl4 = getScrollOffset.invoke_impl;
			IntPtr method4 = getScrollOffset.method;
			int num = this.scrollOffset;
			GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset2 = this._getScrollOffset;
			this.scrollOffset = num;
			IntPtr invoke_impl5 = getScrollOffset2.invoke_impl;
			IntPtr method_code5 = getScrollOffset2.method_code;
			IntPtr method5 = getScrollOffset2.method;
			GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset3 = this._getScrollOffset;
			int num2 = this.scrollOffset;
			IntPtr invoke_impl6 = getScrollOffset3.invoke_impl;
			IntPtr method_code6 = getScrollOffset3.method_code;
			IntPtr method6 = getScrollOffset3.method;
			num3 = 32640;
			this.scrollOffset = num3;
			return;
		}
		int maxScrollOffset_Horizontal = this.MaxScrollOffset_Horizontal;
		if (num3 == 0)
		{
		}
		GUIControllerDynamicGridNavigator.GetItemScale itemScale2 = this._itemScale;
		IntPtr invoke_impl7 = itemScale2.invoke_impl;
		IntPtr method_code7 = itemScale2.method_code;
		IntPtr method7 = itemScale2.method;
		if (itemScale2 == null)
		{
		}
		GUIControllerDynamicGridNavigator.GetGrid grid2 = this._grid;
		IntPtr invoke_impl8 = grid2.invoke_impl;
		IntPtr method_code8 = grid2.method_code;
		IntPtr method8 = grid2.method;
		GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset4 = this._getScrollOffset;
		IntPtr method_code9 = getScrollOffset4.method_code;
		IntPtr invoke_impl9 = getScrollOffset4.invoke_impl;
		IntPtr method9 = getScrollOffset4.method;
		int num4 = this.scrollOffset;
		GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset5 = this._getScrollOffset;
		this.scrollOffset = num4;
		IntPtr invoke_impl10 = getScrollOffset5.invoke_impl;
		IntPtr method_code10 = getScrollOffset5.method_code;
		IntPtr method10 = getScrollOffset5.method;
		GUIControllerDynamicGridNavigator.GetScrollOffset getScrollOffset6 = this._getScrollOffset;
		int num5 = this.scrollOffset;
		IntPtr invoke_impl11 = getScrollOffset6.invoke_impl;
		IntPtr method_code11 = getScrollOffset6.method_code;
		IntPtr method11 = getScrollOffset6.method;
		int num6 = 32640;
		this.scrollOffset = num6;
		int num7 = this.scrollOffset;
		int maxScrollOffset_Horizontal2 = this.MaxScrollOffset_Horizontal;
		int maxScrollOffset_Horizontal3 = this.MaxScrollOffset_Horizontal;
		this.scrollOffset = maxScrollOffset_Horizontal3;
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060005EE RID: 1518 RVA: 0x0001220C File Offset: 0x0001040C
	private bool HasMenu
	{
		get
		{
			GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
			IntPtr invoke_impl = menuItemCount.invoke_impl;
			IntPtr method_code = menuItemCount.method_code;
			IntPtr method = menuItemCount.method;
			return true;
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001225C File Offset: 0x0001045C
	public bool InMenu
	{
		get
		{
			/*
An exception occurred when decompiling this method (060005EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean GUIControllerDynamicGridNavigator::get_InMenu()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerDynamicGridNavigator::itemColumn, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:int32(var_1_0D, callgetter:int32(GUIControllerDynamicGridNavigator::get_MenuColumn, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x060005F0 RID: 1520 RVA: 0x00012278 File Offset: 0x00010478
	private void ClampMenu(bool preferUp = true)
	{
		GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
		int num = this.menuRow;
		IntPtr invoke_impl = menuItemCount.invoke_impl;
		IntPtr method_code = menuItemCount.method_code;
		IntPtr method = menuItemCount.method;
		GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount = this._displayItemCount;
		int num2 = this.menuRow;
		IntPtr invoke_impl2 = displayItemCount.invoke_impl;
		IntPtr method_code2 = displayItemCount.method_code;
		IntPtr method2 = displayItemCount.method;
		GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount2 = this._displayItemCount;
		IntPtr invoke_impl3 = displayItemCount2.invoke_impl;
		IntPtr method_code3 = displayItemCount2.method_code;
		IntPtr method3 = displayItemCount2.method;
		if (method_code3 != 0)
		{
			GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount3 = this._displayItemCount;
			IntPtr invoke_impl4 = displayItemCount3.invoke_impl;
			IntPtr method_code4 = displayItemCount3.method_code;
			IntPtr method4 = displayItemCount3.method;
			return;
		}
		GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount2 = this._menuItemCount;
		IntPtr invoke_impl5 = menuItemCount2.invoke_impl;
		IntPtr method_code5 = menuItemCount2.method_code;
		IntPtr method5 = menuItemCount2.method;
		this.menuRow = menuItemCount2;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00012350 File Offset: 0x00010550
	private GUIControllerItem NavigateMenuOutOfGrid()
	{
		/*
An exception occurred when decompiling this method (060005F1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerDynamicGridNavigator::NavigateMenuOutOfGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIControllerPageGroup(var_1_15, callgetter:GUIControllerPageGroup(GUIPageIconGrouping::get_MenuController, callgetter:GUIPageIconGrouping(GUIPageContentController::get_ParentGrouping, ldloc:GUIPageContentController(var_0_06))))
	stloc:int32(var_2_1C, ldfld:int32(GUIControllerDynamicGridNavigator::itemRow, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:int32(var_3_23, ldfld:int32(GUIControllerDynamicGridNavigator::scrollOffset, ldloc:GUIControllerDynamicGridNavigator(this)))
	stfld:int32(GUIControllerPageGroup::MenuRow, ldloc:GUIControllerPageGroup(var_1_15), ldloc:int32(var_2_1C))
	stloc:GUIControllerPageGroup(var_4_3B, callgetter:GUIControllerPageGroup(GUIPageIconGrouping::get_MenuController, callgetter:GUIPageIconGrouping(GUIPageContentController::get_ParentGrouping, ldfld:GUIPageContentController(GUIControllerDynamicGridNavigator::_controller, ldloc:GUIControllerDynamicGridNavigator(this)))))
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

	// Token: 0x060005F2 RID: 1522 RVA: 0x0001239C File Offset: 0x0001059C
	private GUIControllerItem NavigateUpOutOfGrid()
	{
		/*
An exception occurred when decompiling this method (060005F2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerDynamicGridNavigator::NavigateUpOutOfGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:GUIPageContentController(var_3_27, ldfld:GUIPageContentController(GUIControllerDynamicGridNavigator::_controller, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x060005F3 RID: 1523 RVA: 0x000123D0 File Offset: 0x000105D0
	private GUIControllerItem NavigateDownOutOfGrid()
	{
		/*
An exception occurred when decompiling this method (060005F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerDynamicGridNavigator::NavigateDownOutOfGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:GUIPageContentController(var_2_19, ldfld:GUIPageContentController(GUIControllerDynamicGridNavigator::_controller, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x060005F4 RID: 1524 RVA: 0x000123F8 File Offset: 0x000105F8
	private GUIControllerItem NavigateInnerOutOfGrid()
	{
		/*
An exception occurred when decompiling this method (060005F4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerDynamicGridNavigator::NavigateInnerOutOfGrid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00E2:
	stloc:GUIPageContentController(var_22_E8, ldfld:GUIPageContentController(GUIControllerDynamicGridNavigator::_controller, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x060005F5 RID: 1525 RVA: 0x000124F0 File Offset: 0x000106F0
	public int GetNavigationOutDirs()
	{
		if (this._controller != null)
		{
			GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
			IntPtr invoke_impl = menuItemCount.invoke_impl;
			IntPtr method_code = menuItemCount.method_code;
			IntPtr method = menuItemCount.method;
			GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount = this._displayItemCount;
			IntPtr invoke_impl2 = displayItemCount.invoke_impl;
			IntPtr method_code2 = displayItemCount.method_code;
			IntPtr method2 = displayItemCount.method;
			int num = this.itemColumn;
			int menuColumn = this.MenuColumn;
			bool leftSideController = this.LeftSideController;
			GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount2 = this._menuItemCount;
			int num2 = this.menuRow;
			IntPtr invoke_impl3 = menuItemCount2.invoke_impl;
			IntPtr method_code3 = menuItemCount2.method_code;
			IntPtr method3 = menuItemCount2.method;
			GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount2 = this._displayItemCount;
			IntPtr method_code4 = displayItemCount2.method_code;
			IntPtr invoke_impl4 = displayItemCount2.invoke_impl;
			IntPtr method4 = displayItemCount2.method;
			int num3 = this.menuRow;
		}
		int num4 = this.itemRow;
		int num5 = this.itemColumn;
		int maxRowColumn_Horizontal = this.MaxRowColumn_Horizontal;
		int num6 = this.itemRow;
		int maxRow_Horizontal = this.MaxRow_Horizontal;
		int num7 = this.itemColumn;
		int maxRowColumn_Horizontal2 = this.MaxRowColumn_Horizontal;
		int num8 = this.itemRow;
		return this.MaxRow_Horizontal;
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00012744 File Offset: 0x00010944
	private GUIControllerItem NavigateHorizontal(Microsoft.Xna.Framework.Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060005F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerDynamicGridNavigator::NavigateHorizontal(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0251:
	stloc:GUIPageContentController(var_58_257, ldfld:GUIPageContentController(GUIControllerDynamicGridNavigator::_controller, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:GUIPageContentController(var_59_25F, ldfld:GUIPageContentController(GUIControllerDynamicGridNavigator::_controller, ldloc:GUIControllerDynamicGridNavigator(this)))
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

	// Token: 0x060005F7 RID: 1527 RVA: 0x000129B4 File Offset: 0x00010BB4
	private GUIControllerItem NavigateVertical(Microsoft.Xna.Framework.Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060005F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerDynamicGridNavigator::NavigateVertical(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_03A6:
	stloc:GUIPageContentController(var_97_3AC, ldfld:GUIPageContentController(GUIControllerDynamicGridNavigator::_controller, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:GUIPageContentController(var_98_3B4, ldfld:GUIPageContentController(GUIControllerDynamicGridNavigator::_controller, ldloc:GUIControllerDynamicGridNavigator(this)))
	stloc:int32(var_99_3BC, ldfld:int32(GUIControllerDynamicGridNavigator::itemColumn, ldloc:GUIControllerDynamicGridNavigator(this)))
	stfld:int32(GUIControllerDynamicGridNavigator::itemColumn, ldloc:GUIControllerDynamicGridNavigator(this), ldloc:int32(var_99_3BC))
	call:void(Mouse::UpdateUICursorPoint)
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

	// Token: 0x060005F8 RID: 1528 RVA: 0x00012D90 File Offset: 0x00010F90
	protected void ClampPosition()
	{
		GUIControllerDynamicGridNavigator.GetCollectionCount collectionCount = this._collectionCount;
		IntPtr invoke_impl = collectionCount.invoke_impl;
		IntPtr method_code = collectionCount.method_code;
		IntPtr method = collectionCount.method;
		if (method_code == 0)
		{
			GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
			IntPtr invoke_impl2 = menuItemCount.invoke_impl;
			IntPtr method_code2 = menuItemCount.method_code;
			IntPtr method2 = menuItemCount.method;
			GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount = this._displayItemCount;
			IntPtr invoke_impl3 = displayItemCount.invoke_impl;
			IntPtr method_code3 = displayItemCount.method_code;
			IntPtr method3 = displayItemCount.method;
			int menuColumn = this.MenuColumn;
			this.itemColumn = menuColumn;
		}
		int num = this.itemColumn;
		int menuColumn2 = this.MenuColumn;
		int num2 = 1;
		this.ClampMenu(num2 != 0);
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00012F2C File Offset: 0x0001112C
	public Rectangle GetSelectedItemRegion()
	{
		int num = 1;
		this.ClampPosition();
		if (num == 0)
		{
		}
		GUIControllerDynamicGridNavigator.GetItemScale itemScale = this._itemScale;
		IntPtr invoke_impl = itemScale.invoke_impl;
		IntPtr method_code = itemScale.method_code;
		IntPtr method = itemScale.method;
		if (itemScale == null)
		{
		}
		int num2 = this.scrollOffset;
		int num3 = this.itemRow;
		bool flag = this.inMenu;
		int menuColumn = this.MenuColumn;
		int num4 = this.menuRow;
		GUIControllerDynamicGridNavigator.GetGrid grid = this._grid;
		IntPtr invoke_impl2 = grid.invoke_impl;
		IntPtr method_code2 = grid.method_code;
		IntPtr method2 = grid.method;
		GUIControllerDynamicGridNavigator.GetGrid grid2 = this._grid;
		IntPtr invoke_impl3 = grid2.invoke_impl;
		IntPtr method_code3 = grid2.method_code;
		IntPtr method3 = grid2.method;
		Debug.Log("Cursor outside visible");
		return "Cursor outside visible";
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00012FF4 File Offset: 0x000111F4
	public void NavigateInto(int column, int row)
	{
		GUIControllerDynamicGridNavigator.GetGrid grid = this._grid;
		IntPtr invoke_impl = grid.invoke_impl;
		IntPtr method_code = grid.method_code;
		IntPtr method = grid.method;
		GUIControllerDynamicGridNavigator.GetCollectionCount menuItemCount = this._menuItemCount;
		IntPtr invoke_impl2 = menuItemCount.invoke_impl;
		IntPtr method_code2 = menuItemCount.method_code;
		IntPtr method2 = menuItemCount.method;
		GUIControllerDynamicGridNavigator.GetCollectionCount displayItemCount = this._displayItemCount;
		IntPtr invoke_impl3 = displayItemCount.invoke_impl;
		IntPtr method_code3 = displayItemCount.method_code;
		IntPtr method3 = displayItemCount.method;
		int menuColumn = this.MenuColumn;
		int num = this.scrollOffset;
		this.itemRow = num;
		this.inMenu = invoke_impl3 != 0;
		this.ClampPosition();
	}

	// Token: 0x040004BA RID: 1210
	private readonly GUIControllerDynamicGridNavigator.GetGrid _grid;

	// Token: 0x040004BB RID: 1211
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _collectionCount;

	// Token: 0x040004BC RID: 1212
	private readonly GUIControllerDynamicGridNavigator.GetItemScale _itemScale;

	// Token: 0x040004BD RID: 1213
	private readonly GUIControllerDynamicGridNavigator.GetScrollOffset _getScrollOffset;

	// Token: 0x040004BE RID: 1214
	private readonly GUIControllerDynamicGridNavigator.SetScrollOffset _setScrollOffset;

	// Token: 0x040004BF RID: 1215
	private readonly GUIPageContentController _controller;

	// Token: 0x040004C0 RID: 1216
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _displayItemCount;

	// Token: 0x040004C1 RID: 1217
	private readonly GUIControllerDynamicGridNavigator.GetCollectionCount _menuItemCount;

	// Token: 0x040004C2 RID: 1218
	private bool scrollDisabledUntilChange;

	// Token: 0x040004C3 RID: 1219
	private int itemCountAtDisableScroll;

	// Token: 0x040004C4 RID: 1220
	public int itemRow;

	// Token: 0x040004C5 RID: 1221
	public int itemColumn;

	// Token: 0x040004C6 RID: 1222
	public bool inMenu;

	// Token: 0x040004C7 RID: 1223
	public int menuRow;

	// Token: 0x040004C8 RID: 1224
	private int scrollOffset;

	// Token: 0x020000E2 RID: 226
	public sealed class GetGrid : MulticastDelegate
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x0001308C File Offset: 0x0001128C
		public GetGrid(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000130E0 File Offset: 0x000112E0
		public DraggableItemGrid_Layout Invoke()
		{
			/*
An exception occurred when decompiling this method (060005FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling DraggableItemGrid_Layout GUIControllerDynamicGridNavigator/GetGrid::Invoke()

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

		// Token: 0x060005FD RID: 1533 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000021DB File Offset: 0x000003DB
		public DraggableItemGrid_Layout EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x020000E3 RID: 227
	public sealed class GetCollectionCount : MulticastDelegate
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x00013104 File Offset: 0x00011304
		public GetCollectionCount(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00013158 File Offset: 0x00011358
		public int Invoke()
		{
			/*
An exception occurred when decompiling this method (06000600)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDynamicGridNavigator/GetCollectionCount::Invoke()

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

		// Token: 0x06000601 RID: 1537 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x000021DB File Offset: 0x000003DB
		public int EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x020000E4 RID: 228
	public sealed class GetItemScale : MulticastDelegate
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x0001317C File Offset: 0x0001137C
		public GetItemScale(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000131D0 File Offset: 0x000113D0
		public float Invoke()
		{
			/*
An exception occurred when decompiling this method (06000604)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerDynamicGridNavigator/GetItemScale::Invoke()

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

		// Token: 0x06000605 RID: 1541 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000021DB File Offset: 0x000003DB
		public float EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x020000E5 RID: 229
	public sealed class GetScrollOffset : MulticastDelegate
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x000131F4 File Offset: 0x000113F4
		public GetScrollOffset(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00013248 File Offset: 0x00011448
		public float Invoke()
		{
			/*
An exception occurred when decompiling this method (06000608)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerDynamicGridNavigator/GetScrollOffset::Invoke()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:GetScrollOffset[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GetScrollOffset[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:GetScrollOffset[exp:Delegate](this)))
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

		// Token: 0x06000609 RID: 1545 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000021DB File Offset: 0x000003DB
		public float EndInvoke(IAsyncResult result)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x020000E6 RID: 230
	public sealed class SetScrollOffset : MulticastDelegate
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x0001326C File Offset: 0x0001146C
		public SetScrollOffset(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000132C0 File Offset: 0x000114C0
		public void Invoke(float scrollOffset)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(float scrollOffset, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000132E4 File Offset: 0x000114E4
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
