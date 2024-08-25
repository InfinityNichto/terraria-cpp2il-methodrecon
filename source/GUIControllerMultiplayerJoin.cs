using System;
using Microsoft.Xna.Framework;

// Token: 0x02000099 RID: 153
public class GUIControllerMultiplayerJoin : GUIControllerItem
{
	// Token: 0x060003A5 RID: 933 RVA: 0x0000C01C File Offset: 0x0000A21C
	public void Activate()
	{
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x0000C02C File Offset: 0x0000A22C
	public int GetNavigationOutDirs()
	{
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0000C03C File Offset: 0x0000A23C
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060003A7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerMultiplayerJoin::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(GUIControllerMultiplayerJoin::selectionIndex, ldloc:GUIControllerMultiplayerJoin(this)))
	stloc:int32(var_1_0D, ldfld:int32(GUIControllerMultiplayerJoin::selectionIndex, ldloc:GUIControllerMultiplayerJoin(this)))
	stloc:int32(var_2_14, ldfld:int32(GUIControllerMultiplayerJoin::selectionIndex, ldloc:GUIControllerMultiplayerJoin(this)))
	stloc:int32(var_3_1B, ldfld:int32(GUIControllerMultiplayerJoin::selectionIndex, ldloc:GUIControllerMultiplayerJoin(this)))
	stloc:int32(var_4_1D, ldc.i4:int32(2))
	stfld:int32(GUIControllerMultiplayerJoin::selectionIndex, ldloc:GUIControllerMultiplayerJoin(this), ldloc:int32(var_4_1D))
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

	// Token: 0x060003A8 RID: 936 RVA: 0x0000C070 File Offset: 0x0000A270
	public void ActivateServerIP()
	{
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0000C080 File Offset: 0x0000A280
	public void DeactivateServerIP()
	{
	}

	// Token: 0x060003AA RID: 938 RVA: 0x0000C090 File Offset: 0x0000A290
	public void ActivateServerPort()
	{
		this.serverIPActive = true;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
	public void DeactivateServerPort()
	{
	}

	// Token: 0x060003AC RID: 940 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
	public Rectangle GetSelectedItemRegion()
	{
		int num = this.selectionIndex;
		Rectangle rectangle;
		return rectangle;
	}

	// Token: 0x060003AD RID: 941 RVA: 0x0000C0CC File Offset: 0x0000A2CC
	public GUIControllerMultiplayerJoin()
	{
	}

	// Token: 0x04000388 RID: 904
	private bool serverIPActive;

	// Token: 0x04000389 RID: 905
	private bool serverPortActive;

	// Token: 0x0400038A RID: 906
	public int selectionIndex;
}
