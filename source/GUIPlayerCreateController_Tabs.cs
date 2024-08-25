using System;
using Microsoft.Xna.Framework;

// Token: 0x020000F5 RID: 245
public class GUIPlayerCreateController_Tabs : GUIControllerItem
{
	// Token: 0x06000672 RID: 1650 RVA: 0x00014D08 File Offset: 0x00012F08
	public GUIPlayerCreateController_Tabs(GUIPlayerCreateController controller)
	{
		this._controller = controller;
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00014D24 File Offset: 0x00012F24
	public void Activate()
	{
		GUIPlayerCreateMenu.ItemSelection highlightedTab = this.HighlightedTab;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00014D38 File Offset: 0x00012F38
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00014D48 File Offset: 0x00012F48
	public GUIControllerItem NavigateIntoCurrentPage(bool fromTabSwitch = false)
	{
		/*
An exception occurred when decompiling this method (06000675)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIPlayerCreateController_Tabs::NavigateIntoCurrentPage(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(GUIPlayerCreateController_Gender::Activate, ldfld:GUIPlayerCreateController_Gender(GUIPlayerCreateController::GenderPage, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:GUIPlayerCreateController(var_0_16, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this)))
	stloc:GUIPlayerCreateController_ItemColour(var_1_22, ldfld:GUIPlayerCreateController_ItemColour(GUIPlayerCreateController::EyeColour, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:GUIPlayerCreateController_ItemColour(var_2_2E, ldfld:GUIPlayerCreateController_ItemColour(GUIPlayerCreateController::HairColour, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	call:void(GUIPlayerCreateController_Info::Activate, ldfld:GUIPlayerCreateController_Info(GUIPlayerCreateController::InfoPage, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:GUIPlayerCreateController(var_3_45, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this)))
	stloc:GUIPlayerCreateController_ItemColour(var_4_51, ldfld:GUIPlayerCreateController_ItemColour(GUIPlayerCreateController::SkinColour, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:GUIPlayerCreateController_HairStyle(var_5_5E, ldfld:GUIPlayerCreateController_HairStyle(GUIPlayerCreateController::HairStlyePage, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	call:void(GUIPlayerCreateController_HairStyle::Activate, ldloc:GUIPlayerCreateController_HairStyle(var_5_5E))
	stloc:GUIPlayerCreateController_ItemColour(var_6_72, ldfld:GUIPlayerCreateController_ItemColour(GUIPlayerCreateController::ShirtColour, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:GUIPlayerCreateController_ItemColour(var_7_7F, ldfld:GUIPlayerCreateController_ItemColour(GUIPlayerCreateController::UndershirtColour, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:GUIPlayerCreateController_ItemColour(var_8_8C, ldfld:GUIPlayerCreateController_ItemColour(GUIPlayerCreateController::PantsColour, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:GUIPlayerCreateController_ItemColour(var_9_99, ldfld:GUIPlayerCreateController_ItemColour(GUIPlayerCreateController::ShoesColour, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:ItemSelection(var_10_A1, ldfld:ItemSelection(GUIPlayerCreateController_Tabs::HighlightedTab, ldloc:GUIPlayerCreateController_Tabs(this)))
	stfld:int32(GUIPlayerCreateController_HairStyle::itemColumn, ldloc:GUIPlayerCreateController_HairStyle(var_5_5E), ldloc:ItemSelection[exp:int32](var_10_A1))
	stfld:int32(GUIPlayerCreateController_HairStyle::itemRow, ldloc:GUIPlayerCreateController_HairStyle(var_5_5E), ldloc:int32(var_11))
	call:void(GUIPlayerCreateController_HairStyle::UpdateScroll, ldfld:GUIPlayerCreateController_HairStyle(GUIPlayerCreateController::HairStlyePage, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this))))
	stloc:GUIPlayerCreateController(var_12_CB, ldfld:GUIPlayerCreateController(GUIPlayerCreateController_Tabs::_controller, ldloc:GUIPlayerCreateController_Tabs(this)))
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

	// Token: 0x06000676 RID: 1654 RVA: 0x00014E24 File Offset: 0x00013024
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		long num = 0L;
		return this.NavigateIntoCurrentPage(num != 0L);
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00014E40 File Offset: 0x00013040
	public Rectangle GetSelectedItemRegion()
	{
		GUIPlayerCreateMenu.ItemSelection highlightedTab = this.HighlightedTab;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x040004F2 RID: 1266
	private readonly GUIPlayerCreateController _controller;

	// Token: 0x040004F3 RID: 1267
	public GUIPlayerCreateMenu.ItemSelection HighlightedTab;
}
