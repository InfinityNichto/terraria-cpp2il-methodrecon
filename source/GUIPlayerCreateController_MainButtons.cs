using System;
using Microsoft.Xna.Framework;

// Token: 0x020000F4 RID: 244
public class GUIPlayerCreateController_MainButtons : GUIControllerItem
{
	// Token: 0x0600066C RID: 1644 RVA: 0x00014BB4 File Offset: 0x00012DB4
	public GUIPlayerCreateController_MainButtons(GUIPlayerCreateController controller)
	{
		this._controller = controller;
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00014BD0 File Offset: 0x00012DD0
	public void Activate()
	{
		this.element = 2;
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00014BE4 File Offset: 0x00012DE4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00014BF4 File Offset: 0x00012DF4
	public GUIControllerItem NavigateIntoCurrentPage()
	{
		/*
An exception occurred when decompiling this method (0600066F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIPlayerCreateController_MainButtons::NavigateIntoCurrentPage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00B7:
	stloc:GUIPlayerCreateController_Gender(var_14_C2, ldfld:GUIPlayerCreateController_Gender(GUIPlayerCreateController::GenderPage, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_MainButtons::_controller, ldloc:GUIPlayerCreateController_MainButtons(this))))
	stloc:int32(var_15_C6, ldc.i4:int32(9))
	stfld:int32(GUIPlayerCreateController_Gender::selectionIndex, ldloc:GUIPlayerCreateController_Gender(var_14_C2), ldloc:int32(var_15_C6))
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

	// Token: 0x06000670 RID: 1648 RVA: 0x00014CD4 File Offset: 0x00012ED4
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return this.NavigateIntoCurrentPage();
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00014CF0 File Offset: 0x00012EF0
	public Rectangle GetSelectedItemRegion()
	{
		int num = this.element;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x040004F0 RID: 1264
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x040004F1 RID: 1265
	public int element;
}
