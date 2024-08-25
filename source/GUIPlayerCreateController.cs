using System;
using Microsoft.Xna.Framework;

// Token: 0x020000EF RID: 239
public class GUIPlayerCreateController : GUIControllerItem
{
	// Token: 0x0600064A RID: 1610 RVA: 0x00014708 File Offset: 0x00012908
	public GUIPlayerCreateController()
	{
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x0001471C File Offset: 0x0001291C
	public void Activate()
	{
		GUIControllerItem guicontrollerItem = this.Tabs.NavigateIntoCurrentPage(true);
		this._activeItem = guicontrollerItem;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00014740 File Offset: 0x00012940
	public void ActivateRandomise()
	{
		GUIPlayerCreateController_MainButtons buttons = this.Buttons;
		buttons.element = 1;
		this._activeItem = buttons;
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00014764 File Offset: 0x00012964
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00014774 File Offset: 0x00012974
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return this._activeItem;
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00014790 File Offset: 0x00012990
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (0600064F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIPlayerCreateController::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIControllerItem(var_0_06, ldfld:GUIControllerItem(GUIPlayerCreateController::_activeItem, ldloc:GUIPlayerCreateController(this)))
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

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000650 RID: 1616 RVA: 0x000147A4 File Offset: 0x000129A4
	public GUIControllerItem CurrentItem
	{
		get
		{
			return this._activeItem;
		}
	}

	// Token: 0x040004D7 RID: 1239
	private GUIControllerItem _activeItem;

	// Token: 0x040004D8 RID: 1240
	public readonly GUIPlayerCreateController_MainButtons Buttons;

	// Token: 0x040004D9 RID: 1241
	public readonly GUIPlayerCreateController_Tabs Tabs;

	// Token: 0x040004DA RID: 1242
	public readonly GUIPlayerCreateController_Info InfoPage;

	// Token: 0x040004DB RID: 1243
	public readonly GUIPlayerCreateController_Gender GenderPage;

	// Token: 0x040004DC RID: 1244
	public readonly GUIPlayerCreateController_HairStyle HairStlyePage;

	// Token: 0x040004DD RID: 1245
	public readonly GUIPlayerCreateController_ItemColour HairColour;

	// Token: 0x040004DE RID: 1246
	public readonly GUIPlayerCreateController_ItemColour EyeColour;

	// Token: 0x040004DF RID: 1247
	public readonly GUIPlayerCreateController_ItemColour SkinColour;

	// Token: 0x040004E0 RID: 1248
	public readonly GUIPlayerCreateController_ItemColour ShirtColour;

	// Token: 0x040004E1 RID: 1249
	public readonly GUIPlayerCreateController_ItemColour UndershirtColour;

	// Token: 0x040004E2 RID: 1250
	public readonly GUIPlayerCreateController_ItemColour PantsColour;

	// Token: 0x040004E3 RID: 1251
	public readonly GUIPlayerCreateController_ItemColour ShoesColour;
}
