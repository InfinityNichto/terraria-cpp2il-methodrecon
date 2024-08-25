using System;
using Microsoft.Xna.Framework;

// Token: 0x0200007D RID: 125
public class GUIControllerPulldownEntry : GUIControllerMappingEntryBase
{
	// Token: 0x060002D8 RID: 728 RVA: 0x000098C8 File Offset: 0x00007AC8
	public GUIControllerPulldownEntry(GUISettingID id)
		: base(id)
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x000098DC File Offset: 0x00007ADC
	public override void Draw()
	{
		GUIPulldownSetting worker = this.Worker;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x000098F0 File Offset: 0x00007AF0
	public override float GetElementHeight()
	{
		/*
An exception occurred when decompiling this method (060002DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerPulldownEntry::GetElementHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIPulldownSetting(var_0_06, ldfld:GUIPulldownSetting(GUIControllerPulldownEntry::Worker, ldloc:GUIControllerPulldownEntry(this)))
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

	// Token: 0x060002DB RID: 731 RVA: 0x00009904 File Offset: 0x00007B04
	public override void DrawOverlay()
	{
		GUIPulldownSetting worker = this.Worker;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00009918 File Offset: 0x00007B18
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00009928 File Offset: 0x00007B28
	private void DeactivateOverlay()
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00009938 File Offset: 0x00007B38
	private void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00009948 File Offset: 0x00007B48
	public int GetNumberOfOptions()
	{
		return this.Worker.GetNumberOfOptions();
	}

	// Token: 0x04000324 RID: 804
	private GUIPulldownSetting Worker;
}
