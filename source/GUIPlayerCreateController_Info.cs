using System;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000F2 RID: 242
public class GUIPlayerCreateController_Info : GUIControllerItem
{
	// Token: 0x0600065E RID: 1630 RVA: 0x00014A14 File Offset: 0x00012C14
	public GUIPlayerCreateController_Info(GUIPlayerCreateController controller)
	{
		this._controller = controller;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00014A30 File Offset: 0x00012C30
	public void Activate()
	{
		byte difficulty = Main.PendingPlayer.difficulty;
		this.element = (int)difficulty;
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00014A54 File Offset: 0x00012C54
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00014A64 File Offset: 0x00012C64
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (06000661)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIPlayerCreateController_Info::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIPlayerCreateController_MainButtons(var_1_15, ldfld:GUIPlayerCreateController_MainButtons(GUIPlayerCreateController::Buttons, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Info::_controller, ldloc:GUIPlayerCreateController_Info(this))))
	call:void(GUIPlayerCreateController_Tabs::Activate, ldfld:GUIPlayerCreateController_Tabs(GUIPlayerCreateController::Tabs, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_MainButtons::_controller, ldloc:GUIPlayerCreateController_MainButtons(var_1_15))))
	stfld:ItemSelection(GUIPlayerCreateController_Tabs::HighlightedTab, ldfld:GUIPlayerCreateController_Tabs(GUIPlayerCreateController::Tabs, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_MainButtons::_controller, ldloc:GUIPlayerCreateController_MainButtons(var_1_15))), ldc.i4:ItemSelection(1))
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

	// Token: 0x06000662 RID: 1634 RVA: 0x00014AA8 File Offset: 0x00012CA8
	public void ActivateOptions(int selectedOption)
	{
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00014AB8 File Offset: 0x00012CB8
	public void DeactivateOptions()
	{
		this.element = 1;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00014ACC File Offset: 0x00012CCC
	public void ActivateName()
	{
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00014ADC File Offset: 0x00012CDC
	public void DeactivateName()
	{
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00014AEC File Offset: 0x00012CEC
	public Rectangle GetSelectedItemRegion()
	{
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x040004EC RID: 1260
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x040004ED RID: 1261
	public int element;
}
