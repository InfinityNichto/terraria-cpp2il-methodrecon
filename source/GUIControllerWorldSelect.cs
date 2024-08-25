using System;
using Microsoft.Xna.Framework;

// Token: 0x020000AA RID: 170
public class GUIControllerWorldSelect : GUIControllerItem
{
	// Token: 0x06000400 RID: 1024 RVA: 0x0000D138 File Offset: 0x0000B338
	public void Activate()
	{
		this.selectedControl = 5;
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x0000D14C File Offset: 0x0000B34C
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x0000D15C File Offset: 0x0000B35C
	private void UpdateScroll()
	{
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x0000D16C File Offset: 0x0000B36C
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (06000403)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerWorldSelect::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:int32(var_1_0B, ldc.i4:int32(1))
	stfld:int32(GUIControllerWorldSelect::selectedControl, ldloc:GUIControllerWorldSelect(this), ldloc:int32(var_1_0B))
	stloc:int32(var_2_14, ldc.i4:int32(6))
	stfld:int32(GUIControllerWorldSelect::selectedControl, ldloc:GUIControllerWorldSelect(this), ldloc:int32(var_2_14))
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

	// Token: 0x06000404 RID: 1028 RVA: 0x0000D194 File Offset: 0x0000B394
	public Rectangle GetSelectedItemRegion()
	{
		int num = this.selectedControl;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x0000D1AC File Offset: 0x0000B3AC
	public GUIControllerWorldSelect()
	{
	}

	// Token: 0x040003DA RID: 986
	public int selectedControl;

	// Token: 0x020000AB RID: 171
	public enum Controls
	{
		// Token: 0x040003DC RID: 988
		Back,
		// Token: 0x040003DD RID: 989
		Delete,
		// Token: 0x040003DE RID: 990
		Favourite,
		// Token: 0x040003DF RID: 991
		Rename,
		// Token: 0x040003E0 RID: 992
		SeedDisplay,
		// Token: 0x040003E1 RID: 993
		Play,
		// Token: 0x040003E2 RID: 994
		New
	}
}
