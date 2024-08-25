using System;
using Microsoft.Xna.Framework;

// Token: 0x020000C0 RID: 192
public class GUIControllerDisplayDoll : GUIPageContentController
{
	// Token: 0x060004B1 RID: 1201 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
	public GUIControllerDisplayDoll()
		: base(GUIPageIcons.Category.DisplayDoll)
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
	public override void Activate()
	{
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
	public override void NavigateInto(int column, int row)
	{
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		int num = this.itemColumn;
		this.itemColumn = num;
		int num2 = this.itemColumn;
		int num3 = this.itemRow;
		int num4 = 2;
		this.itemRow = num4;
		int num5 = this.itemRow;
		int num6 = this.itemRow;
		int num7 = this.itemRow;
		GUIControllerItem guicontrollerItem;
		return guicontrollerItem;
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x0000E93C File Offset: 0x0000CB3C
	public override Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (060004B5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerDisplayDoll::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0031:
	stloc:int32(var_9_37, ldfld:int32(GUIControllerDisplayDoll::itemRow, ldloc:GUIControllerDisplayDoll(this)))
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

	// Token: 0x04000449 RID: 1097
	public int itemRow;

	// Token: 0x0400044A RID: 1098
	public int itemColumn;
}
