using System;
using Microsoft.Xna.Framework;

// Token: 0x020000F3 RID: 243
public class GUIPlayerCreateController_ItemColour : GUIControllerItem
{
	// Token: 0x06000667 RID: 1639 RVA: 0x00014B10 File Offset: 0x00012D10
	public GUIPlayerCreateController_ItemColour(GUIPlayerCreateController controller)
	{
		this._controller = controller;
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00014B2C File Offset: 0x00012D2C
	public void Activate()
	{
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00014B3C File Offset: 0x00012D3C
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00014B4C File Offset: 0x00012D4C
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (0600066A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIPlayerCreateController_ItemColour::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIPlayerCreateController_ItemColour::selectionIndex, ldloc:GUIPlayerCreateController_ItemColour(this)))
	call:void(GUIPlayerCreateController_Tabs::Activate, ldfld:GUIPlayerCreateController_Tabs(GUIPlayerCreateController::Tabs, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_ItemColour::_controller, ldloc:GUIPlayerCreateController_ItemColour(this))))
	stloc:GUIPlayerCreateController_Tabs(var_1_22, ldfld:GUIPlayerCreateController_Tabs(GUIPlayerCreateController::Tabs, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_ItemColour::_controller, ldloc:GUIPlayerCreateController_ItemColour(this))))
	stloc:ItemSelection(var_2_29, ldfld:ItemSelection(GUIPlayerCreateController_Tabs::HighlightedTab, ldloc:GUIPlayerCreateController_Tabs(var_1_22)))
	stloc:GUIPlayerCreateController_MainButtons(var_3_35, ldfld:GUIPlayerCreateController_MainButtons(GUIPlayerCreateController::Buttons, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(var_1_22))))
	stloc:int32(var_4_37, ldc.i4:int32(2))
	stfld:int32(GUIPlayerCreateController_MainButtons::element, ldloc:GUIPlayerCreateController_MainButtons(var_3_35), ldloc:int32(var_4_37))
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

	// Token: 0x0600066B RID: 1643 RVA: 0x00014B9C File Offset: 0x00012D9C
	public Rectangle GetSelectedItemRegion()
	{
		int num = this.selectionIndex;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x040004EE RID: 1262
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x040004EF RID: 1263
	public int selectionIndex;
}
