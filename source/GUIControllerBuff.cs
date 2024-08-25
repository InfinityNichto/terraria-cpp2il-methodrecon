using System;
using Microsoft.Xna.Framework;

// Token: 0x02000089 RID: 137
public class GUIControllerBuff : GUIControllerItem
{
	// Token: 0x06000356 RID: 854 RVA: 0x0000AF84 File Offset: 0x00009184
	public void Activate()
	{
	}

	// Token: 0x06000357 RID: 855 RVA: 0x0000AF94 File Offset: 0x00009194
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x0000AFA4 File Offset: 0x000091A4
	private void Clamp()
	{
	}

	// Token: 0x06000359 RID: 857 RVA: 0x0000AFBC File Offset: 0x000091BC
	public void NavigateNext()
	{
		this.Clamp();
		int num = this.selectedItem;
		this.selectedItem = num;
		this.selectedItem = num;
		this.Clamp();
	}

	// Token: 0x0600035A RID: 858 RVA: 0x0000AFEC File Offset: 0x000091EC
	public void NavigatePrevious()
	{
		this.Clamp();
		int num = this.selectedItem;
		this.selectedItem = num;
		this.selectedItem = num;
		this.Clamp();
	}

	// Token: 0x0600035B RID: 859 RVA: 0x0000B01C File Offset: 0x0000921C
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (0600035B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerBuff::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(GUIControllerBuff::NavigatePrevious, ldloc:GUIControllerBuff(this))
	call:void(GUIControllerBuff::NavigateNext, ldloc:GUIControllerBuff(this))
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

	// Token: 0x0600035C RID: 860 RVA: 0x0000B034 File Offset: 0x00009234
	public int GetSelectedItem()
	{
		return this.selectedItem;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x0000B048 File Offset: 0x00009248
	public Rectangle GetSelectedItemRegion()
	{
		/*
An exception occurred when decompiling this method (0600035D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle GUIControllerBuff::GetSelectedItemRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0051:
	stloc:int32(var_11_57, ldfld:int32(GUIControllerBuff::selectedItem, ldloc:GUIControllerBuff(this)))
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

	// Token: 0x0600035E RID: 862 RVA: 0x0000B0B0 File Offset: 0x000092B0
	public GUIControllerBuff()
	{
	}

	// Token: 0x04000350 RID: 848
	private int selectedItem;
}
