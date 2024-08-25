using System;
using Controller;
using Microsoft.Xna.Framework;

// Token: 0x020000B9 RID: 185
public class GUIControllerCoins4Page : GUIControllerCoins
{
	// Token: 0x0600046A RID: 1130 RVA: 0x0000E110 File Offset: 0x0000C310
	public override void NavigateFromInventoryRow(int row)
	{
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x0000E128 File Offset: 0x0000C328
	public override int GetNavigationOutDirs()
	{
		/*
An exception occurred when decompiling this method (0600046B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerCoins4Page::GetNavigationOutDirs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerCoins::itemRow, ldloc:GUIControllerCoins4Page[exp:GUIControllerCoins](this)))
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

	// Token: 0x0600046C RID: 1132 RVA: 0x0000E13C File Offset: 0x0000C33C
	public override int GetInventoryRow()
	{
		/*
An exception occurred when decompiling this method (0600046C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerCoins4Page::GetInventoryRow()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerCoins::itemRow, ldloc:GUIControllerCoins4Page[exp:GUIControllerCoins](this)))
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

	// Token: 0x0600046D RID: 1133 RVA: 0x0000E150 File Offset: 0x0000C350
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		GUIControllerItem guicontrollerItem;
		do
		{
			base.LoadPageAnchor();
			int itemRow = this.itemRow;
			int itemRow2 = this.itemRow;
			GUIControllerAmmo guicontrollerAmmo;
			guicontrollerAmmo.itemRow = itemRow2;
			GUIControllerInventory guicontrollerInventory;
			if (itemRow == 0)
			{
				int itemRow3 = this.itemRow;
				guicontrollerInventory.itemRow = itemRow3;
				int itemRow4 = this.itemRow;
			}
			guicontrollerInventory.itemRow = this;
			int num = 9;
			GUIControllerInventory guicontrollerInventory2;
			guicontrollerInventory2.itemColumn = num;
			int itemRow5 = this.itemRow;
			GUIPageIconGrouping parentGrouping = base.ParentGrouping;
			int num2 = 11;
			guicontrollerItem = parentGrouping.NavigateDown(num2);
		}
		while (guicontrollerItem != null);
		return guicontrollerItem;
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
	public override Rectangle GetSelectedItemRegion()
	{
		base.LoadPageAnchor();
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
		if (3 == 0)
		{
		}
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x0000E224 File Offset: 0x0000C424
	public GUIControllerCoins4Page()
		: base(GUIPageIcons.Category.Inventory)
	{
	}
}
