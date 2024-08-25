using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

// Token: 0x02000098 RID: 152
public class GUIControllerMultiplayerHost : GUIControllerItem
{
	// Token: 0x0600039E RID: 926 RVA: 0x0000BF7C File Offset: 0x0000A17C
	public void Activate()
	{
	}

	// Token: 0x0600039F RID: 927 RVA: 0x000021DB File Offset: 0x000003DB
	public int GetNavigationOutDirs()
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x0000BF8C File Offset: 0x0000A18C
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060003A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerMultiplayerHost::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerMultiplayerHost::selectionIndex, ldloc:GUIControllerMultiplayerHost(this)))
	stloc:int32(var_1_0D, ldfld:int32(GUIControllerMultiplayerHost::selectionIndex, ldloc:GUIControllerMultiplayerHost(this)))
	stloc:int32(var_2_14, ldfld:int32(GUIControllerMultiplayerHost::selectionIndex, ldloc:GUIControllerMultiplayerHost(this)))
	stloc:int32(var_3_1B, ldfld:int32(GUIControllerMultiplayerHost::selectionIndex, ldloc:GUIControllerMultiplayerHost(this)))
	stloc:int32(var_4_1D, ldc.i4:int32(2))
	stfld:int32(GUIControllerMultiplayerHost::selectionIndex, ldloc:GUIControllerMultiplayerHost(this), ldloc:int32(var_4_1D))
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

	// Token: 0x060003A1 RID: 929 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
	public void ActivateServerPassword()
	{
		this.serverPasswordActive = true;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
	public void DeactivateServerPassword()
	{
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
	public Rectangle GetSelectedItemRegion()
	{
		int num = 1;
		this.selectionIndex = num;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x0000C008 File Offset: 0x0000A208
	public GUIControllerMultiplayerHost()
	{
	}

	// Token: 0x04000386 RID: 902
	private bool serverPasswordActive;

	// Token: 0x04000387 RID: 903
	public int selectionIndex;
}
