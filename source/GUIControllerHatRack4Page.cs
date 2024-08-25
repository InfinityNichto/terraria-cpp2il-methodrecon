using System;
using Microsoft.Xna.Framework;

// Token: 0x020000C9 RID: 201
public class GUIControllerHatRack4Page : GUIControllerHatRack
{
	// Token: 0x060004E4 RID: 1252 RVA: 0x0000F45C File Offset: 0x0000D65C
	public override void Activate()
	{
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x0000F46C File Offset: 0x0000D66C
	public override int GetNavigationOutDirs()
	{
		/*
An exception occurred when decompiling this method (060004E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerHatRack4Page::GetNavigationOutDirs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:bool(var_3_35, callgetter:bool(GUIPageIconGrouping::get_LeftSideGrouping, callgetter:GUIPageIconGrouping(GUIPageContentController::get_ParentGrouping, ldloc:GUIControllerHatRack4Page[exp:GUIPageContentController](this))))
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

	// Token: 0x060004E6 RID: 1254 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		GUIControllerItem guicontrollerItem;
		do
		{
			base.LoadPageAnchor();
			if (base.ParentGrouping != null)
			{
				bool leftSideGrouping = base.ParentGrouping.LeftSideGrouping;
			}
			int itemColumn = this.itemColumn;
			GUIControllerPageGroup menuController = base.ParentGrouping.MenuController;
			int itemRow = this.itemRow;
			menuController.MenuRow = itemRow;
			GUIControllerPageGroup menuController2 = base.ParentGrouping.MenuController;
			int itemColumn2 = this.itemColumn;
			bool leftSideGrouping2 = base.ParentGrouping.LeftSideGrouping;
			GUIPageIconGrouping parentGrouping = base.ParentGrouping;
			int itemRow2 = this.itemRow;
			guicontrollerItem = parentGrouping.NavigateRight(itemRow2);
		}
		while (guicontrollerItem != null);
		return guicontrollerItem;
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (060004E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerHatRack4Page::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0031:
	stloc:int32(var_8_37, ldfld:int32(GUIControllerHatRack::itemRow, ldloc:GUIControllerHatRack4Page[exp:GUIControllerHatRack](this)))
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

	// Token: 0x060004E9 RID: 1257 RVA: 0x0000F5FC File Offset: 0x0000D7FC
	public GUIControllerHatRack4Page()
	{
	}
}
