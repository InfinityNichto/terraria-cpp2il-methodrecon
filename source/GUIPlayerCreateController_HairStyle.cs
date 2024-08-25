using System;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000F1 RID: 241
public class GUIPlayerCreateController_HairStyle : GUIControllerItem
{
	// Token: 0x06000657 RID: 1623 RVA: 0x00014898 File Offset: 0x00012A98
	public GUIPlayerCreateController_HairStyle(GUIPlayerCreateController controller)
	{
		this._controller = controller;
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x000148BC File Offset: 0x00012ABC
	public void Activate()
	{
		int num = 1;
		if (num == 0)
		{
		}
		int hair = Main.PendingPlayer.hair;
		this.itemRow = num;
		this.UpdateScroll();
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x000148E8 File Offset: 0x00012AE8
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x000148F8 File Offset: 0x00012AF8
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (0600065A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIPlayerCreateController_HairStyle::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIPlayerCreateController_HairStyle::itemRow, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stfld:int32(GUIPlayerCreateController_HairStyle::itemRow, ldloc:GUIPlayerCreateController_HairStyle(this), ldloc:int32(var_0_06))
	call:void(GUIPlayerCreateController_HairStyle::UpdateScroll, ldloc:GUIPlayerCreateController_HairStyle(this))
	stloc:int32(var_1_1A, ldfld:int32(GUIPlayerCreateController_HairStyle::itemRow, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stloc:int32(var_2_21, ldfld:int32(GUIPlayerCreateController_HairStyle::maxRowIndex, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stfld:int32(GUIPlayerCreateController_HairStyle::itemRow, ldloc:GUIPlayerCreateController_HairStyle(this), ldloc:int32(var_1_1A))
	stloc:int32(var_3_2F, ldfld:int32(GUIPlayerCreateController_HairStyle::itemColumn, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stloc:int32(var_4_36, ldfld:int32(GUIPlayerCreateController_HairStyle::maxRowColumn, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stfld:int32(GUIPlayerCreateController_HairStyle::itemColumn, ldloc:GUIPlayerCreateController_HairStyle(this), ldloc:int32(var_4_36))
	stloc:int32(var_5_46, ldfld:int32(GUIPlayerCreateController_HairStyle::itemColumn, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stloc:int32(var_6_4E, ldfld:int32(GUIPlayerCreateController_HairStyle::maxRowIndex, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stloc:int32(var_7_56, ldfld:int32(GUIPlayerCreateController_HairStyle::itemRow, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stloc:int32(var_8_5E, ldfld:int32(GUIPlayerCreateController_HairStyle::maxRowColumn, ldloc:GUIPlayerCreateController_HairStyle(this)))
	call:void(GUIPlayerCreateController_Tabs::Activate, ldfld:GUIPlayerCreateController_Tabs(GUIPlayerCreateController::Tabs, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_HairStyle::_controller, ldloc:GUIPlayerCreateController_HairStyle(this))))
	stloc:GUIPlayerCreateController(var_9_76, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_HairStyle::_controller, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stloc:int32(var_10_7E, ldfld:int32(GUIPlayerCreateController_HairStyle::itemColumn, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stloc:GUIPlayerCreateController_Tabs(var_11_87, ldfld:GUIPlayerCreateController_Tabs(GUIPlayerCreateController::Tabs, ldloc:GUIPlayerCreateController(var_9_76)))
	stfld:ItemSelection(GUIPlayerCreateController_Tabs::HighlightedTab, ldloc:GUIPlayerCreateController_Tabs(var_11_87), ldloc:GUIPlayerCreateController[exp:ItemSelection](var_9_76))
	stloc:GUIPlayerCreateController(var_12_99, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(var_11_87)))
	stloc:int32(var_13_9C, ldc.i4:int32(2))
	stloc:GUIPlayerCreateController_MainButtons(var_14_A5, ldfld:GUIPlayerCreateController_MainButtons(GUIPlayerCreateController::Buttons, ldloc:GUIPlayerCreateController(var_12_99)))
	stfld:int32(GUIPlayerCreateController_MainButtons::element, ldloc:GUIPlayerCreateController_MainButtons(var_14_A5), ldloc:int32(var_13_9C))
	stloc:int32(var_15_B1, ldc.i4:int32(1))
	stfld:int32(GUIPlayerCreateController_MainButtons::element, ldloc:GUIPlayerCreateController_MainButtons(var_14_A5), ldloc:int32(var_15_B1))
	stloc:GUIPlayerCreateController_MainButtons(var_16_C3, ldfld:GUIPlayerCreateController_MainButtons(GUIPlayerCreateController::Buttons, ldloc:GUIPlayerCreateController(var_12_99)))
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

	// Token: 0x0600065B RID: 1627 RVA: 0x000149CC File Offset: 0x00012BCC
	public void UpdateScroll()
	{
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x0600065C RID: 1628 RVA: 0x000149E0 File Offset: 0x00012BE0
	public int currentScrollOffset
	{
		get
		{
			if (!true)
			{
				return;
			}
		}
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x000149F4 File Offset: 0x00012BF4
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (0600065D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIPlayerCreateController_HairStyle::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_3_0B, ldfld:int32(GUIPlayerCreateController_HairStyle::itemRow, ldloc:GUIPlayerCreateController_HairStyle(this)))
	stloc:int32(var_4_12, ldfld:int32(GUIPlayerCreateController_HairStyle::itemColumn, ldloc:GUIPlayerCreateController_HairStyle(this)))
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

	// Token: 0x040004E7 RID: 1255
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x040004E8 RID: 1256
	public int maxRowIndex = 21;

	// Token: 0x040004E9 RID: 1257
	public int maxRowColumn;

	// Token: 0x040004EA RID: 1258
	public int itemRow;

	// Token: 0x040004EB RID: 1259
	public int itemColumn;
}
