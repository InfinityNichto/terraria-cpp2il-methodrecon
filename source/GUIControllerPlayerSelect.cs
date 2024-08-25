using System;
using Microsoft.Xna.Framework;

// Token: 0x020000A1 RID: 161
public class GUIControllerPlayerSelect : GUIControllerItem
{
	// Token: 0x060003D2 RID: 978 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
	public void Activate()
	{
		this.selectedControl = 4;
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
	private void UpdateScroll()
	{
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060003D5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerPlayerSelect::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:int32(var_1_0B, ldc.i4:int32(1))
	stfld:int32(GUIControllerPlayerSelect::selectedControl, ldloc:GUIControllerPlayerSelect(this), ldloc:int32(var_1_0B))
	stloc:int32(var_2_14, ldc.i4:int32(5))
	stfld:int32(GUIControllerPlayerSelect::selectedControl, ldloc:GUIControllerPlayerSelect(this), ldloc:int32(var_2_14))
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

	// Token: 0x060003D6 RID: 982 RVA: 0x0000C8FC File Offset: 0x0000AAFC
	public Rectangle GetSelectedItemRegion()
	{
		int num = this.selectedControl;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x0000C914 File Offset: 0x0000AB14
	public GUIControllerPlayerSelect()
	{
	}

	// Token: 0x040003B6 RID: 950
	public int selectedControl;

	// Token: 0x020000A2 RID: 162
	public enum Controls
	{
		// Token: 0x040003B8 RID: 952
		Back,
		// Token: 0x040003B9 RID: 953
		Delete,
		// Token: 0x040003BA RID: 954
		Favourite,
		// Token: 0x040003BB RID: 955
		EditName,
		// Token: 0x040003BC RID: 956
		Play,
		// Token: 0x040003BD RID: 957
		New
	}
}
