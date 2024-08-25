using System;
using Controller;
using Microsoft.Xna.Framework;

// Token: 0x020000B8 RID: 184
public class GUIControllerCoins : GUIPageContentController
{
	// Token: 0x06000464 RID: 1124 RVA: 0x0000E048 File Offset: 0x0000C248
	public GUIControllerCoins()
		: base(GUIPageIcons.Category.Inventory)
	{
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x0000E05C File Offset: 0x0000C25C
	public override void Activate()
	{
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x0000E06C File Offset: 0x0000C26C
	public virtual void NavigateFromInventoryRow(int row)
	{
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x0000E07C File Offset: 0x0000C27C
	public virtual int GetInventoryRow()
	{
		/*
An exception occurred when decompiling this method (06000467)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerCoins::GetInventoryRow()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerCoins::itemRow, ldloc:GUIControllerCoins(this)))
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

	// Token: 0x06000468 RID: 1128 RVA: 0x0000E090 File Offset: 0x0000C290
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		GUIControllerInventory guicontrollerInventory;
		guicontrollerInventory.itemRow = this;
		int num = 9;
		GUIControllerInventory guicontrollerInventory2;
		guicontrollerInventory2.itemColumn = num;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x0000E0CC File Offset: 0x0000C2CC
	public override Rectangle GetSelectedItemRegion()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		!0 instance = PageControllerLayoutDefinition.Instance;
		!0 instance2 = PageControllerLayoutDefinition.Instance;
		!0 instance3 = PageControllerLayoutDefinition.Instance;
		!0 instance4 = PageControllerLayoutDefinition.Instance;
		!0 instance5 = PageControllerLayoutDefinition.Instance;
		!0 instance6 = PageControllerLayoutDefinition.Instance;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x0400043E RID: 1086
	public int itemRow;
}
