using System;

// Token: 0x0200007E RID: 126
public class GUIControllerSliderEntry : GUIControllerMappingEntryBase
{
	// Token: 0x060002E0 RID: 736 RVA: 0x00009960 File Offset: 0x00007B60
	public GUIControllerSliderEntry(GUISettingID id)
		: base(id)
	{
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00009974 File Offset: 0x00007B74
	public override void Draw()
	{
		GUISliderSetting worker = this.Worker;
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00009988 File Offset: 0x00007B88
	public override float GetElementHeight()
	{
		/*
An exception occurred when decompiling this method (060002E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerSliderEntry::GetElementHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUISliderSetting(var_0_06, ldfld:GUISliderSetting(GUIControllerSliderEntry::Worker, ldloc:GUIControllerSliderEntry(this)))
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

	// Token: 0x060002E3 RID: 739 RVA: 0x0000999C File Offset: 0x00007B9C
	public override void DrawOverlay()
	{
		GUISliderSetting worker = this.Worker;
	}

	// Token: 0x04000325 RID: 805
	private GUISliderSetting Worker;
}
