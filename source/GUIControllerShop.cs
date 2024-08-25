using System;
using Microsoft.Xna.Framework;

// Token: 0x020000DC RID: 220
public class GUIControllerShop : GUIPageContentController
{
	// Token: 0x060005B2 RID: 1458 RVA: 0x00011008 File Offset: 0x0000F208
	public GUIControllerShop()
	{
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0001101C File Offset: 0x0000F21C
	public override void Activate()
	{
		this.itemRow = 4;
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00011030 File Offset: 0x0000F230
	public virtual bool IsInMenu()
	{
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00011040 File Offset: 0x0000F240
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		int num = this.itemRow;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0001107C File Offset: 0x0000F27C
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (060005B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerShop::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!0(var_0_08, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_3_10, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_4_16, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:!0(var_5_1D, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:int32(var_7_25, ldfld:int32(GUIControllerShop::itemColumn, ldloc:GUIControllerShop(this)))
	stloc:!0(var_8_2C, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
	stloc:int32(var_9_34, ldfld:int32(GUIControllerShop::itemRow, ldloc:GUIControllerShop(this)))
	stloc:!0(var_10_3B, callgetter:!0(PageControllerLayoutDefinition`1::get_Instance))
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

	// Token: 0x040004B4 RID: 1204
	public int itemRow;

	// Token: 0x040004B5 RID: 1205
	public int itemColumn;
}
