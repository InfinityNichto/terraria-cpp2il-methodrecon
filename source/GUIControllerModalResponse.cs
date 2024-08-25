using System;
using Microsoft.Xna.Framework;

// Token: 0x02000096 RID: 150
public class GUIControllerModalResponse : GUIControllerItem
{
	// Token: 0x06000399 RID: 921 RVA: 0x0000BF20 File Offset: 0x0000A120
	public void Activate()
	{
	}

	// Token: 0x0600039A RID: 922 RVA: 0x0000BF30 File Offset: 0x0000A130
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (0600039A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerModalResponse::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:Controls(GUIControllerModalResponse::selectedControl, ldloc:GUIControllerModalResponse(this), ldc.i4:Controls(1))
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

	// Token: 0x0600039B RID: 923 RVA: 0x0000BF44 File Offset: 0x0000A144
	public Rectangle GetSelectedItemRegion()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		Rectangle rectangle2;
		return rectangle2;
	}

	// Token: 0x0600039C RID: 924 RVA: 0x0000BF58 File Offset: 0x0000A158
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0000BF68 File Offset: 0x0000A168
	public GUIControllerModalResponse()
	{
	}

	// Token: 0x04000382 RID: 898
	public GUIControllerModalResponse.Controls selectedControl;

	// Token: 0x02000097 RID: 151
	public enum Controls
	{
		// Token: 0x04000384 RID: 900
		Cancel,
		// Token: 0x04000385 RID: 901
		Confirm
	}
}
