using System;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000F0 RID: 240
public class GUIPlayerCreateController_Gender : GUIControllerItem
{
	// Token: 0x06000651 RID: 1617 RVA: 0x000147B8 File Offset: 0x000129B8
	public GUIPlayerCreateController_Gender(GUIPlayerCreateController controller)
	{
		this._controller = controller;
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x000147D4 File Offset: 0x000129D4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x000147E4 File Offset: 0x000129E4
	public void Activate()
	{
		if (!true)
		{
		}
		int skinVariant = Main.PendingPlayer.skinVariant;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00014804 File Offset: 0x00012A04
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (06000654)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIPlayerCreateController_Gender::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIPlayerCreateController_Gender::selectionIndex, ldloc:GUIPlayerCreateController_Gender(this)))
	call:void(GUIPlayerCreateController_Tabs::Activate, ldfld:GUIPlayerCreateController_Tabs(GUIPlayerCreateController::Tabs, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Gender::_controller, ldloc:GUIPlayerCreateController_Gender(this))))
	stloc:GUIPlayerCreateController_Tabs(var_1_22, ldfld:GUIPlayerCreateController_Tabs(GUIPlayerCreateController::Tabs, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Gender::_controller, ldloc:GUIPlayerCreateController_Gender(this))))
	stloc:ItemSelection(var_2_29, ldfld:ItemSelection(GUIPlayerCreateController_Tabs::HighlightedTab, ldloc:GUIPlayerCreateController_Tabs(var_1_22)))
	stloc:ItemSelection(var_3_30, ldfld:ItemSelection(GUIPlayerCreateController_Tabs::HighlightedTab, ldloc:GUIPlayerCreateController_Tabs(var_1_22)))
	stloc:ItemSelection(var_4_37, ldfld:ItemSelection(GUIPlayerCreateController_Tabs::HighlightedTab, ldloc:GUIPlayerCreateController_Tabs(var_1_22)))
	stloc:GUIPlayerCreateController_MainButtons(var_5_44, ldfld:GUIPlayerCreateController_MainButtons(GUIPlayerCreateController::Buttons, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(var_1_22))))
	stloc:int32(var_6_47, ldc.i4:int32(2))
	stfld:int32(GUIPlayerCreateController_MainButtons::element, ldloc:GUIPlayerCreateController_MainButtons(var_5_44), ldloc:int32(var_6_47))
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

	// Token: 0x06000655 RID: 1621 RVA: 0x00014864 File Offset: 0x00012A64
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (06000655)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIPlayerCreateController_Gender::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIPlayerCreateController_Gender::selectionIndex, ldloc:GUIPlayerCreateController_Gender(this)))
	stloc:int32(var_2_0D, ldfld:int32(GUIPlayerCreateController_Gender::selectionIndex, ldloc:GUIPlayerCreateController_Gender(this)))
	stloc:int32(var_4_14, ldfld:int32(GUIPlayerCreateController_Gender::selectionIndex, ldloc:GUIPlayerCreateController_Gender(this)))
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

	// Token: 0x06000656 RID: 1622 RVA: 0x00014888 File Offset: 0x00012A88
	// Note: this type is marked as 'beforefieldinit'.
	static GUIPlayerCreateController_Gender()
	{
	}

	// Token: 0x040004E4 RID: 1252
	private static int[] actualStyleOrder;

	// Token: 0x040004E5 RID: 1253
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x040004E6 RID: 1254
	public int selectionIndex;
}
