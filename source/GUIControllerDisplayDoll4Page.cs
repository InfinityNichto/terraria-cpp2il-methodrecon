using System;
using Microsoft.Xna.Framework;

// Token: 0x020000C1 RID: 193
public class GUIControllerDisplayDoll4Page : GUIControllerDisplayDoll
{
	// Token: 0x060004B6 RID: 1206 RVA: 0x0000E984 File Offset: 0x0000CB84
	public override void Activate()
	{
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x0000E994 File Offset: 0x0000CB94
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x0000E9AC File Offset: 0x0000CBAC
	public override int GetNavigationOutDirs()
	{
		/*
An exception occurred when decompiling this method (060004B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 GUIControllerDisplayDoll4Page::GetNavigationOutDirs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:bool(var_3_35, callgetter:bool(GUIPageIconGrouping::get_LeftSideGrouping, callgetter:GUIPageIconGrouping(GUIPageContentController::get_ParentGrouping, ldloc:GUIControllerDisplayDoll4Page[exp:GUIPageContentController](this))))
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

	// Token: 0x060004B9 RID: 1209 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
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
			this.itemColumn = itemColumn;
			int itemColumn2 = this.itemColumn;
			bool leftSideGrouping2 = base.ParentGrouping.LeftSideGrouping;
			GUIPageIconGrouping parentGrouping = base.ParentGrouping;
			int itemRow = this.itemRow;
			guicontrollerItem = parentGrouping.NavigateRight(itemRow);
		}
		while (guicontrollerItem != null);
		return guicontrollerItem;
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x0000EAEC File Offset: 0x0000CCEC
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (060004BA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerDisplayDoll4Page::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003B:
	stloc:int32(var_10_41, ldfld:int32(GUIControllerDisplayDoll::itemRow, ldloc:GUIControllerDisplayDoll4Page[exp:GUIControllerDisplayDoll](this)))
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

	// Token: 0x060004BB RID: 1211 RVA: 0x0000EB3C File Offset: 0x0000CD3C
	public GUIControllerDisplayDoll4Page()
		: base(GUIPageIcons.Category.DisplayDoll)
	{
	}
}
