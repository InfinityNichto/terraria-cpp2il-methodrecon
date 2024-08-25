using System;
using Microsoft.Xna.Framework;

// Token: 0x020000B3 RID: 179
public class GUIControllerHardwarePulldown : GUIControllerMappingEntryBase
{
	// Token: 0x0600043E RID: 1086 RVA: 0x0000DB14 File Offset: 0x0000BD14
	public GUIControllerHardwarePulldown(GUISettingID id)
		: base(id)
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x0000DB28 File Offset: 0x0000BD28
	public override void Draw()
	{
		GUIPulldownSetting worker = this.Worker;
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0000DB3C File Offset: 0x0000BD3C
	public override float GetElementHeight()
	{
		/*
An exception occurred when decompiling this method (06000440)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single GUIControllerHardwarePulldown::GetElementHeight()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GUIPulldownSetting(var_0_06, ldfld:GUIPulldownSetting(GUIControllerHardwarePulldown::Worker, ldloc:GUIControllerHardwarePulldown(this)))
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

	// Token: 0x06000441 RID: 1089 RVA: 0x0000DB50 File Offset: 0x0000BD50
	public override void DrawOverlay()
	{
		GUIPulldownSetting worker = this.Worker;
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x0000DB64 File Offset: 0x0000BD64
	private void ActivateOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset)
	{
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x0000DB74 File Offset: 0x0000BD74
	private void DeactivateOverlay()
	{
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x0000DB84 File Offset: 0x0000BD84
	private void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion)
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x0000DB94 File Offset: 0x0000BD94
	public int GetNumberOfOptions()
	{
		return this.Worker.GetNumberOfOptions();
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x0000DBAC File Offset: 0x0000BDAC
	public void CloseOptions()
	{
		this.Worker.CloseOptions();
	}

	// Token: 0x04000438 RID: 1080
	private GUIPulldownSetting Worker;
}
